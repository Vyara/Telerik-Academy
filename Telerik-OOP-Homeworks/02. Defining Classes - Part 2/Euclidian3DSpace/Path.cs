//Create a class Path to hold a sequence of points in the 3D space.

namespace Euclidian3DSpace
{
    using System;
    using System.Collections.Generic;

    public class Path
    {
        //constructor
        public Path()
        {
            this.PointsSequence = new List<Point3D>();
        }

        //properties
        public List<Point3D> PointsSequence { get; private set; }

        public int Count { get { return this.PointsSequence.Count; } }

        //path indexer
        public Point3D this[int index]
        {
            get
            {
                if (index >= 0 && index < PointsSequence.Count)
                {
                    return this.PointsSequence[index];
                }

                else
                {
                    throw new ArgumentException("Index is out of range.");
                }
            }

            set
            {
                if (index >= 0 && index < PointsSequence.Count)
                {
                    this.PointsSequence[index] = value;
                }

                else
                {
                    throw new ArgumentException("Index is out of range.");
                }

            }
        }


        //methods
        public void AddPoint(Point3D point)
        {
            this.PointsSequence.Add(point);
        }

        public void AddPoints(params Point3D[] points)
        {
            this.PointsSequence.AddRange(points);
        }

        public void RemovePoint(Point3D point)
        {
            this.PointsSequence.Remove(point);
        }

        public void Clear()
        {
            this.PointsSequence.Clear();
        }

        //overriding ToString()
        public override string ToString()
        {
            return string.Join("-", this.PointsSequence);
        }

    }
}
