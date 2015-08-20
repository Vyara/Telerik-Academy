namespace Shapes
{

    public class Square : Shape
    {
        //fields

        //constructors
        public Square(double side)
            : base(side, side)
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
