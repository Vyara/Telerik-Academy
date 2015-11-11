namespace AllAreasOfPassableCells
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// *We are given a matrix of passable and non-passable cells.
    /// Write a recursive program for finding all areas of passable cells in the matrix.
    /// </summary>
    public class Startup
    {
        private const int NumberOfRowsAndCols = 10;

        private static readonly int[][] Paths =
      {
                new[] { 1, 0 },
                new[] { -1, 0 },
                new[] { 0, 1 },
                new[] { 0, -1 },
            };

        public static void Main()
        {
            var labirynth = new bool[NumberOfRowsAndCols, NumberOfRowsAndCols];
            FillLabirynth(labirynth);

            Console.WriteLine(FindLongestPath(labirynth));
        }

        public static string FindLongestPath(bool[,] labirynth)
        {
            var output = new StringBuilder();
            output.AppendLine("Longest Path: ");
            output.AppendLine(new string('-', 100));
            var visited = new bool[labirynth.GetLength(0), labirynth.GetLength(1)];
            var maxCount = 0;

            for (int row = 0; row < labirynth.GetLength(0); row++)
            {
                for (int col = 0; col < labirynth.GetLength(1); col++)
                {
                    if (!visited[row, col] && !labirynth[row, col])
                    {
                        var currentCount = 0;

                        var path = new List<string>();
                        CountAdjacentCells(labirynth, visited, row, col, path, ref currentCount);
                        output.Append(string.Join(", ", path)).AppendLine();

                        if (currentCount > maxCount)
                        {
                            maxCount = currentCount;
                        }
                    }
                }
            }

            return output.ToString().Trim();
        }

        public static void FillLabirynth(bool[,] labirynth)
        {
            labirynth[0, 3] = true;
            labirynth[1, 3] = true;
            labirynth[2, 3] = true;

            for (int col = 0; col <= 3; col++)
            {
                labirynth[3, col] = true;
            }

            for (int col = 0; col < labirynth.GetLength(1); col++)
            {
                labirynth[7, col] = true;
            }
        }

        private static void CountAdjacentCells(bool[,] labirynth, bool[,] visited, int row, int col, List<string> cells, ref int count)
        {
            if (!IsInRange(row, col, labirynth.GetLength(0), labirynth.GetLength(1)))
            {
                return;
            }

            if (visited[row, col])
            {
                return;
            }

            if (labirynth[row, col])
            {
                return;
            }

            ++count;
            visited[row, col] = true;
            cells.Add(string.Format("({0} {1})", row, col));

            foreach (var direction in Paths)
            {
                CountAdjacentCells(labirynth, visited, row + direction[0], col + direction[1], cells, ref count);
            }
        }

        private static bool IsInRange(int row, int col, int rows, int cols)
        {
            var rowIsInRange = row >= 0 && row < rows;
            var colIsInRange = col >= 0 && col < cols;

            return rowIsInRange && colIsInRange;
        }
    }
}