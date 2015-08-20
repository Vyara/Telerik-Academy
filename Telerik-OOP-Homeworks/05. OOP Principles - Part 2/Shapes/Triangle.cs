namespace Shapes
{

    public class Triangle : Shape
    {
        //fields

        //constructors
        public Triangle(double width, double height)
            : base(width, height)
        {

        }

        //properties

        //methods
        public override double CalculateSurface()
        {
            return (this.Width * this.Height) / 2.0;
        }

    }
}
