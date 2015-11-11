namespace FindingPathsInMatrix
{
    using System;

    public struct PathVector : ICloneable, IComparable<PathVector>
    {
        private int x;
        private int y;

        public int X
        {
            get { return this.x; }

            set { this.x = value; }
        }

        public int Y
        {
            get { return this.y; }

            set { this.y = value; }
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public int CompareTo(PathVector other)
        {
            var result = this.Y.CompareTo(other.Y);
            if (result != 0)
            {
                return result;
            }

            return this.X.CompareTo(other.X);
        }

        public override string ToString()
        {
            return string.Format("({0} {1})", this.Y, this.X);
        }
    }
}
