namespace CheckIfPathsExistInMatrix
{
    using System;

    /// <summary>
    /// Modify the above program to check whether a path exists between two cells without finding all possible paths.
    // Test it over an empty 100 x 100 matrix.
    /// </summary>
    public static class Startup
    {
        private const int NumberOfRowsAndCols = 100;

        private static readonly int[][] Paths =
          {
                new[] { 1, 0 },
                new[] { -1, 0 },
                new[] { 0, 1 },
                new[] { 0, -1 }
            };

        public static void Main()
        {
            var visited = new bool[NumberOfRowsAndCols, NumberOfRowsAndCols];
            new int[NumberOfRowsAndCols, NumberOfRowsAndCols].PathExistsBetween(visited, 0, 0);
            var doesPathExist = visited[99, 99];
            Console.WriteLine("Testing if a Path exists between two cells in an empty 100 x 1000 matrix...");

            Console.WriteLine(new string('-', 80));

            Console.WriteLine("Does path exist? - {0}", doesPathExist ? "Yes" : "No");
        }

        public static void PathExistsBetween(this int[,] labirynth, bool[,] visited, int y, int x)
        {
            if (!IsPathInRange(y, x, labirynth.GetLength(0), labirynth.GetLength(1)))
            {
                return;
            }

            if (visited[y, x])
            {
                return;
            }

            visited[y, x] = true;

            foreach (var direction in Paths)
            {
                labirynth.PathExistsBetween(visited, y + direction[0], x + direction[1]);
            }
        }

        private static bool IsPathInRange(int y, int x, int rows, int cols)
        {
            var rowIsInRange = y >= 0 && y < rows;
            var colIsInRange = x >= 0 && x < cols;

            return rowIsInRange && colIsInRange;
        }
    }
}
