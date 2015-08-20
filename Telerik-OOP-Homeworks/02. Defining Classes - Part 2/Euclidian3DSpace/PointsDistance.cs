//Write a static class with a static method to calculate the distance between two points in the 3D space.

namespace Euclidian3DSpace
{
    using System;

    public static class PointsDistance
    {
        //method for calculating distance
        public static decimal CalculateDistance(Point3D firstPoint, Point3D secondPoint)
        {
            decimal distance = (decimal)Math.Sqrt(((firstPoint.X - secondPoint.X) * (firstPoint.X - secondPoint.X)) + ((firstPoint.Y - secondPoint.Y) * (firstPoint.Y - secondPoint.Y)) + ((firstPoint.Z - secondPoint.Z) * (firstPoint.Z - secondPoint.Z)));

            return distance;
        }
    }
}
