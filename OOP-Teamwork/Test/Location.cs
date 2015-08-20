namespace Test
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Location
    {
        public int Restaurant
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public struct Coordinates
        {
            public int X { get; set; }
            public int Y { get; set; }

            public Coordinates(int x, int y) //constructor 
                : this()
            {
                this.X = x;
                this.Y = y;
            }

            public override string ToString()
            {
                return string.Format("X {0}; Y {1}", X, Y);
            }
        }
    }
}
