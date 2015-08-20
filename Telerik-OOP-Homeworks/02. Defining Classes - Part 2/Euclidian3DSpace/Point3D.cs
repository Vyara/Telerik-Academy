//Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space.
//Implement the ToString() to enable printing a 3D point.

namespace Euclidian3DSpace
{
    using System.Text;
    public struct Point3D
    {
        //fields
        private static readonly Point3D zeroPoint;

        //constructors
        static Point3D()
        {
            zeroPoint = new Point3D(0, 0, 0);
        }

        public Point3D(double x, double y, double z)
            :this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }


        //properties
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        //property to return the zero point
        public static Point3D ZeroPoint { get { return zeroPoint; } }


        //methods
        public override string ToString()
        {
            StringBuilder point = new StringBuilder();

            point.AppendFormat("{{{0}, {1}, {2}}}", this.X, this.Y, this.Z);

            return point.ToString();
        }
    }
}
