using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace GameOfLife
{
    public partial class GlobalForm : Form
    {
        private Timer Timer { get; set; }
        private Grid Grid { get; set; }
        private int GlobalWidth { get; set; }
        private int GlobalHeight { get; set; }
        private List<GamePixel> ActualView { get; set; }

        public GlobalForm()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            var width = int.Parse(WidthInput.Text);
            var height = int.Parse(HeightInput.Text);
            var randomElementsNumber = int.Parse(RandomElementsNumberInput.Text);
            var interval = int.Parse(IntervalInput.Text);
            var gridValidator = new GridValidator();
            if (!gridValidator.Validate(width, height, randomElementsNumber, interval)) return;
            PauseButton.Enabled = true;
            Grid = null;
            Timer?.Dispose();
            GlobalWidth = width;
            GlobalHeight = height;
            Grid = new Grid(width, height, randomElementsNumber);
            PauseButton.Text = "Pause";
            Timer = new Timer {Interval = interval };
            Timer.Tick += (localSender, locale) => Simulation();
            Timer.Start();    
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            var pause = PauseButton.Text;
            switch (pause)
            {
                case "Pause":
                    PauseButton.Text = "Continue";
                    GodModeLabel.Visible = true;
                    Timer.Stop();
                    break;
                case "Continue":
                    PauseButton.Text = "Pause";
                    Timer.Start();
                    GodModeLabel.Visible = false;
                    break;
                default:
                    throw new ArgumentException("There are only two states");
            }
        }

        private void Draw(List<GamePixel> elementsToDraw, int width, int height)
        {

            var screen = Screen.FromControl(this);
            var workingArea = screen.WorkingArea;

            var workingWidth = workingArea.Height - 40;
            var workingHeight = workingWidth;

            var elementWidth = workingWidth / width;
            var elementHeight = workingHeight / height;

            var bitmap = new Bitmap(workingWidth, workingHeight);
            boardPictureBox.Width = workingWidth;
            boardPictureBox.Height = workingHeight;

            foreach (var gamePixel in elementsToDraw)
            {
                using (var graphics = Graphics.FromImage(bitmap))
                {
                    graphics.FillRectangle(Brushes.Black, new Rectangle(gamePixel.X * elementWidth, gamePixel.Y * elementHeight, elementWidth, elementHeight));
                }
            }          
            boardPictureBox.Image = bitmap;
        }

        private void Simulation()
        {
            ActualView = Grid.GetUsedPixels();
            Draw(ActualView, GlobalWidth, GlobalHeight);
            Grid.MakeNewGeneration(new ConwayRules());

        }

        private void boardPictureBox_Click(object sender, EventArgs e)
        {
            var me = (MouseEventArgs)e;
            var x = me.X;
            var y = me.Y;
            var screen = Screen.FromControl(this);
            var workingArea = screen.WorkingArea;

            var workingWidth = workingArea.Height - 40;
            var workingHeight = workingWidth;

            var elementWidth = workingWidth / GlobalWidth;
            var elementHeight = workingHeight / GlobalHeight;

            var finalX = x / elementWidth;
            var finalY = y / elementHeight;

            var pixel = Grid.ChangeOnePixelColor(finalX, finalY);
            if (pixel.IsAlive())
            {
                ActualView.Add(new GamePixel(finalX, finalY, true));
            }
            else
            {
                var element = ActualView.First(u => u.X == pixel.X && u.Y == pixel.Y);
                ActualView.Remove(element);
            }

            Draw(ActualView, GlobalWidth, GlobalHeight);
        }
    }
}
