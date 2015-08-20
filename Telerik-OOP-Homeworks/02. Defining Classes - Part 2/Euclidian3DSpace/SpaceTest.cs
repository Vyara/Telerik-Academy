namespace Euclidian3DSpace
{
    using System;
    using System.Globalization;
    using System.Threading;

    class SpaceTest
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.WriteLine("Creating Points");
            Console.WriteLine(new string('-', 30));
            
            var firstPoint = new Point3D(2.3, 5, 0);
            Console.WriteLine("First point: {0}", firstPoint);
            
            var zeroPoint = Point3D.ZeroPoint;
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Zero point: {0}", zeroPoint);

            var distance = PointsDistance.CalculateDistance(firstPoint, zeroPoint);
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Distance between the points: {0:F2} ", distance);

            var path = new Path();
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Creating path.");

            path.AddPoint(firstPoint);
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Adding first point.");

            path.AddPoint(zeroPoint);
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Adding zero point.");

            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Path: {0}", path.ToString());

            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Total points in path: {0}", path.Count);

            path.RemovePoint(zeroPoint);
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Removing zero point.");

            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Path: {0}", path.ToString());

            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Total points in path: {0}", path.Count);

            path.Clear();
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Clearing path.");

            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Total points in path: {0}", path.Count);

            path.AddPoint(firstPoint);
            path.AddPoint(zeroPoint);
            PathStorage.SavePath(path, "input");
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Saving path in a text file.");

            PathStorage.LoadPath("input");
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Loading path from a text file.");

            
        }
    }
}
