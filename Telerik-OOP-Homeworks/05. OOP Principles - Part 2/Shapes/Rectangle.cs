namespace Shapes
{

    public class Rectangle : Shape
    {
        //fields

        //constructors
        public Rectangle(double width, double height)
            : base(width, height)
        {

        }

        //properties

        //methods
        public override double CalculateSurface()
        {
            return this.Width * this.Height;
        }

    }
}
