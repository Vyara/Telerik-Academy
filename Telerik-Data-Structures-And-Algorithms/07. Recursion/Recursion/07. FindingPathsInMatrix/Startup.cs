namespace FindingPathsInMatrix
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// We are given a matrix of passable and non-passable cells.
    ///  Write a recursive program for finding all paths between two cells in the matrix.
    /// </summary>
    public static class Startup
    {
        private const int Empty = 0;
        private const int Visited = 1;

        private static readonly int[] FirstPath = new int[] { 0, 0, -1, 0 };
        private static readonly int[] SecondPath = new int[] { 0, 0, 0, -1 };
        private static readonly int[] ThirdPath = new int[] { 0, 0, -1, 0 };
        private static readonly int[] FourthPath = new int[] { -1, 0, 0, 0 };

        private static readonly PathVector[] Paths =
        {
            new PathVector()
            {
                X = 0,
                Y = 1
            },
            new PathVector()
            {
                X = 0,
                Y = -1
            },

            new PathVector()
            {
                X = 1,
                Y = 0
            },

            new PathVector()
            {
                X = -1,
                Y = 1
            }
        };

        public static void Main()
        {
            var labyrinth = new[,] { { 0, 0, -1, 0 }, { 0, 0, 0, -1 }, { 0, 0, -1, 0 }, { -1, 0, 0, 0 } };

            var result = new List<LinkedList<PathVector>>();
            result.FindPaths(
                new PathVector()
                {
                    X = 3,
                    Y = 3
                },
              new PathVector()
              {
                  X = 0,
                  Y = 0
              },
                new LinkedList<PathVector>(),
                labyrinth);

            Console.WriteLine("All paths in the labyrinth: ");
            Console.WriteLine("[{0}]", string.Join(", ", FirstPath));
            Console.WriteLine("[{0}]", string.Join(", ", SecondPath));
            Console.WriteLine("[{0}]", string.Join(", ", ThirdPath));
            Console.WriteLine("[{0}]", string.Join(", ", FourthPath));

            Console.WriteLine(new string('-', 30));

            foreach (var path in result)
            {
                Console.WriteLine(string.Join("| ", path));
            }
        }

        public static void FindPaths(this List<LinkedList<PathVector>> allPaths, PathVector endPoint, PathVector position, LinkedList<PathVector> pathVectors, int[,] labyrinth)
        {
            if (labyrinth[position.Y, position.X] != Empty)
            {
                return;
            }

            labyrinth[position.Y, position.X] = Visited;
            pathVectors.AddLast((PathVector)position.Clone());

            if (position.CompareTo(endPoint) == 0)
            {
                allPaths.Add(new LinkedList<PathVector>(pathVectors));
            }
            else
            {
                foreach (var path in Paths)
                {
                    if (IsPathInRange(
                        position.Y + path.Y,
                        position.X + path.X,
                        labyrinth.GetLength(0),
                        labyrinth.GetLength(1)))
                    {
                        allPaths.FindPaths(
                            endPoint,
                            new PathVector()
                            {
                                Y = position.Y + path.Y,
                                X = position.X + path.X
                            },
                            pathVectors,
                            labyrinth);
                    }
                }
            }

            pathVectors.RemoveLast();
            labyrinth[position.Y, position.X] = Empty;
        }

        private static bool IsPathInRange(int y, int x, int rows, int cols)
        {
            var rowIsInRange = y >= 0 && y < rows;
            var colIsInRange = x >= 0 && x < cols;

            return rowIsInRange && colIsInRange;
        }
    }
}
