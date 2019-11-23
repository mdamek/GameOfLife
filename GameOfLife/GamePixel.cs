using System;

namespace GameOfLife
{
    public class GamePixel
    {
        private bool Value { get; set; }
        public int X { get; }
        public int Y { get; }

        public GamePixel(int x, int y, bool value = false)
        {
            Value = value;
            X = x;
            Y = y;
        }

        public bool IsAlive()
        {
            return Value;
        }

        public void Revive()
        {
            if (Value) throw new ArgumentException("Pixel already live");
            Value = true;
        }

        public void Kill()
        {
            if (!Value) throw new ArgumentException("Pixel is already dead");
            Value = false;
        }
    }
}
