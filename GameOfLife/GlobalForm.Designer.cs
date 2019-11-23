namespace GameOfLife
{
    partial class GlobalForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.WidthLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.WidthInput = new System.Windows.Forms.TextBox();
            this.HeightInput = new System.Windows.Forms.TextBox();
            this.NumberOfRandomElementsLabel = new System.Windows.Forms.Label();
            this.RandomElementsNumberInput = new System.Windows.Forms.TextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.PauseButton = new System.Windows.Forms.Button();
            this.boardPictureBox = new System.Windows.Forms.PictureBox();
            this.GodModeLabel = new System.Windows.Forms.Label();
            this.IntervalLabel = new System.Windows.Forms.Label();
            this.IntervalInput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.boardPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(57, 19);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(35, 13);
            this.WidthLabel.TabIndex = 0;
            this.WidthLabel.Text = "Width";
            this.WidthLabel.UseMnemonic = false;
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(57, 60);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(38, 13);
            this.HeightLabel.TabIndex = 1;
            this.HeightLabel.Text = "Height";
            // 
            // WidthInput
            // 
            this.WidthInput.Location = new System.Drawing.Point(27, 35);
            this.WidthInput.Name = "WidthInput";
            this.WidthInput.Size = new System.Drawing.Size(100, 20);
            this.WidthInput.TabIndex = 2;
            // 
            // HeightInput
            // 
            this.HeightInput.Location = new System.Drawing.Point(27, 76);
            this.HeightInput.Name = "HeightInput";
            this.HeightInput.Size = new System.Drawing.Size(100, 20);
            this.HeightInput.TabIndex = 3;
            // 
            // NumberOfRandomElementsLabel
            // 
            this.NumberOfRandomElementsLabel.AutoSize = true;
            this.NumberOfRandomElementsLabel.Location = new System.Drawing.Point(10, 99);
            this.NumberOfRandomElementsLabel.Name = "NumberOfRandomElementsLabel";
            this.NumberOfRandomElementsLabel.Size = new System.Drawing.Size(139, 13);
            this.NumberOfRandomElementsLabel.TabIndex = 4;
            this.NumberOfRandomElementsLabel.Text = "Number of random elements";
            // 
            // RandomElementsNumberInput
            // 
            this.RandomElementsNumberInput.Location = new System.Drawing.Point(27, 115);
            this.RandomElementsNumberInput.Name = "RandomElementsNumberInput";
            this.RandomElementsNumberInput.Size = new System.Drawing.Size(100, 20);
            this.RandomElementsNumberInput.TabIndex = 5;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(27, 189);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(100, 23);
            this.StartButton.TabIndex = 6;
            this.StartButton.Text = "Start new";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // PauseButton
            // 
            this.PauseButton.Enabled = false;
            this.PauseButton.Location = new System.Drawing.Point(27, 228);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(100, 23);
            this.PauseButton.TabIndex = 7;
            this.PauseButton.Text = "Pause";
            this.PauseButton.UseVisualStyleBackColor = true;
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // boardPictureBox
            // 
            this.boardPictureBox.Location = new System.Drawing.Point(225, 3);
            this.boardPictureBox.Name = "boardPictureBox";
            this.boardPictureBox.Size = new System.Drawing.Size(656, 637);
            this.boardPictureBox.TabIndex = 8;
            this.boardPictureBox.TabStop = false;
            this.boardPictureBox.Click += new System.EventHandler(this.boardPictureBox_Click);
            // 
            // GodModeLabel
            // 
            this.GodModeLabel.AutoSize = true;
            this.GodModeLabel.Location = new System.Drawing.Point(24, 265);
            this.GodModeLabel.Name = "GodModeLabel";
            this.GodModeLabel.Size = new System.Drawing.Size(108, 13);
            this.GodModeLabel.TabIndex = 9;
            this.GodModeLabel.Text = "You are in God Mode";
            this.GodModeLabel.Visible = false;
            // 
            // IntervalLabel
            // 
            this.IntervalLabel.AutoSize = true;
            this.IntervalLabel.Location = new System.Drawing.Point(47, 141);
            this.IntervalLabel.Name = "IntervalLabel";
            this.IntervalLabel.Size = new System.Drawing.Size(64, 13);
            this.IntervalLabel.TabIndex = 10;
            this.IntervalLabel.Text = "Interval (ms)";
            // 
            // IntervalInput
            // 
            this.IntervalInput.Location = new System.Drawing.Point(27, 157);
            this.IntervalInput.Name = "IntervalInput";
            this.IntervalInput.Size = new System.Drawing.Size(100, 20);
            this.IntervalInput.TabIndex = 11;
            this.IntervalInput.Text = "250";
            // 
            // GlobalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 643);
            this.Controls.Add(this.IntervalInput);
            this.Controls.Add(this.IntervalLabel);
            this.Controls.Add(this.GodModeLabel);
            this.Controls.Add(this.boardPictureBox);
            this.Controls.Add(this.PauseButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.RandomElementsNumberInput);
            this.Controls.Add(this.NumberOfRandomElementsLabel);
            this.Controls.Add(this.HeightInput);
            this.Controls.Add(this.WidthInput);
            this.Controls.Add(this.HeightLabel);
            this.Controls.Add(this.WidthLabel);
            this.Name = "GlobalForm";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.boardPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.TextBox WidthInput;
        private System.Windows.Forms.TextBox HeightInput;
        private System.Windows.Forms.Label NumberOfRandomElementsLabel;
        private System.Windows.Forms.TextBox RandomElementsNumberInput;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button PauseButton;
        private System.Windows.Forms.PictureBox boardPictureBox;
        private System.Windows.Forms.Label GodModeLabel;
        private System.Windows.Forms.Label IntervalLabel;
        private System.Windows.Forms.TextBox IntervalInput;
    }
}

