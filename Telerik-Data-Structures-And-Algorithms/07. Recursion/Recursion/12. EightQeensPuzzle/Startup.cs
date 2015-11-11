namespace EightQeensPuzzle
{
    using System;

    /// <summary>
    /// *Write a recursive program to solve the "8 Queens Puzzle" with backtracking.
    /// </summary>
    public class Startup
    {
        public static void Main()
        {
            var board = new Board(8);
            Console.WriteLine(board.FindQueensSolutions());
        }
    }
}
