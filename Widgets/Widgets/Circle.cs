﻿namespace Widgets.Widgets
{
    public class Circle : Widget
    {
        private int diameter;
        public Circle(int xPosition, int yPosition, int diameter) : base(xPosition, yPosition)
        {
            this.Diameter = diameter;
        }

        public int Diameter
        {
            get { return diameter; }
            set
            {
                ArgumentOutOfRangeException.ThrowIfNegative(value, nameof(value));
                diameter = value;
            }
        }
    }
}