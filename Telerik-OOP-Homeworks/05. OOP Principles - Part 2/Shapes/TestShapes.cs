//Problem 1. Shapes

//Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height.
//Define two new classes Triangle and Rectangle that implement the virtual method and return the surface of the figure (height * width for rectangle and height * width/2 for triangle).
//Define class Square and suitable constructor so that at initialization height must be kept equal to width and implement the CalculateSurface() method.
//Write a program that tests the behaviour of the CalculateSurface() method for different shapes (Square, Rectangle, Triangle) stored in an array.

namespace Shapes
{
    using System;

    class TestShapes
    {
        static void Main()
        {
            //creates a Triangle and calculates surface
            var triangle = new Triangle(3.2, 4.5);
            var triangleSurface = triangle.CalculateSurface();

            //creates a Rectangle and calculates surface
            var rectangle = new Rectangle(4, 12.3);
            var rectangleSurface = rectangle.CalculateSurface();

            //creates a Square and calculates surface
            var square = new Square(5);
            var squareSurface = square.CalculateSurface();

            //prints shapes and surfaces
            PrintShape(triangle);
            Console.WriteLine("Surface of the triangle is: {0}", triangleSurface);
            Console.WriteLine(new string('-', 30));
            Console.WriteLine();

            PrintShape(rectangle);
            Console.WriteLine("Surface of the rectangle is: {0}", rectangleSurface);
            Console.WriteLine(new string('-', 30));
            Console.WriteLine();

            PrintShape(square);
            Console.WriteLine("Surface of the square is: {0}", squareSurface);
            Console.WriteLine(new string('-', 30));
        }

        //method for printing shape 
        public static void PrintShape(Shape shape)
        {
            if (shape is Square)
            {
                Console.WriteLine("Square with side {0}.", shape.Width);
            }

            else
            {
                Console.WriteLine("{0} with width {1} and height {2}.", shape.GetType().Name, shape.Width, shape.Height);
            }

        }
    }
}
