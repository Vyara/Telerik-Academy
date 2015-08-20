namespace Shapes
{
    using System;

    public abstract class Shape
    {
        //fields
        private double width;
        private double height;

        //constructors
        public Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        //properties
        public double Width
        {
            get
            {
                return this.width;
            }

            private set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Width must be larger than zero.");
                }

                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            private set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Height must be larger than zero.");
                }

                this.height = value;
            }
        }

        //methods
        public abstract double CalculateSurface();
    }
}
