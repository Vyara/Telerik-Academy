namespace MineSweeper
{
    using System;
    using System.Collections.Generic;

    public class Engine
    {
        public static void Main()
        {
            const int MovesForWin = 35;
            string command = string.Empty;
            char[,] field = CreatePlayField();
            char[,] mines = PlaceMines();
            int counter = 0;
            bool doesExplode = false;
            var players = new List<Player>(6);
            int row = 0;
            int column = 0;
            bool displayGameInstructions = true;
            bool isGameWon = false;

            do
            {
                if (displayGameInstructions)
                {
                    Console.WriteLine("Let's play \"Minesweeper\"! Try to locate all the fileds without mines on them!");
                    Console.WriteLine("Enter \"top\" to display the rankings, \"restart\" for a new game, or \"exit\" to leave the game");
                    RenderPlayField(field);
                    displayGameInstructions = false;
                }

                Console.Write("Please enter a row and a column: ");
                command = Console.ReadLine().Trim();
                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                    int.TryParse(command[2].ToString(), out column) &&
                        row <= field.GetLength(0) && column <= field.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        GetRanking(players);
                        break;
                    case "restart":
                        field = CreatePlayField();
                        mines = PlaceMines();
                        RenderPlayField(field);
                        doesExplode = false;
                        displayGameInstructions = false;
                        break;
                    case "exit":
                        Console.WriteLine("See you!");
                        break;
                    case "turn":
                        if (mines[row, column] != '*')
                        {
                            if (mines[row, column] == '-')
                            {
                                MakeMove(field, mines, row, column);
                                counter++;
                            }

                            if (MovesForWin == counter)
                            {
                                isGameWon = true;
                            }
                            else
                            {
                                RenderPlayField(field);
                            }
                        }
                        else
                        {
                            doesExplode = true;
                        }

                        break;
                    default:
                        Console.WriteLine("Invalid command!");
                        break;
                }

                if (doesExplode)
                {
                    RenderPlayField(mines);
                    Console.Write("Score: {0} points. " + "Please enter nickname: ", counter);
                    string nickname = Console.ReadLine();
                    Player newPlayer = new Player(nickname, counter);
                    if (players.Count < 5)
                    {
                        players.Add(newPlayer);
                    }
                    else
                    {
                        for (int i = 0; i < players.Count; i++)
                        {
                            if (players[i].Points < newPlayer.Points)
                            {
                                players.Insert(i, newPlayer);
                                players.RemoveAt(players.Count - 1);
                                break;
                            }
                        }
                    }

                    players.Sort((Player firstPlayer, Player secondPlayer) => secondPlayer.Name.CompareTo(firstPlayer.Name));
                    players.Sort((Player firstPlayer, Player secondPlayer) => secondPlayer.Points.CompareTo(firstPlayer.Points));
                    GetRanking(players);

                    field = CreatePlayField();
                    mines = PlaceMines();
                    counter = 0;
                    doesExplode = false;
                    displayGameInstructions = true;
                }

                if (isGameWon)
                {
                    Console.WriteLine("Good Work! You located all the 35 safe fields!");
                    RenderPlayField(mines);
                    Console.WriteLine("Please enter your name: ");
                    string name = Console.ReadLine();
                    var player = new Player(name, counter);
                    players.Add(player);
                    GetRanking(players);
                    field = CreatePlayField();
                    mines = PlaceMines();
                    counter = 0;
                    isGameWon = false;
                    displayGameInstructions = true;
                }
            }
            while (command != "exit");
            Console.WriteLine("Hope you enjoyed the game!");
            Console.WriteLine("Thank you for playing!");
            Console.Read();
        }

        private static void GetRanking(List<Player> players)
        {
            Console.WriteLine("Players:");
            if (players.Count > 0)
            {
                for (int i = 0; i < players.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} kutii", i + 1, players[i].Name, players[i].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("The Rankings are empty!");
            }
        }

        private static void MakeMove(char[,] field, char[,] mines, int row, int column)
        {
            char minesCounter = CountAdjacentMines(mines, row, column);
            mines[row, column] = minesCounter;
            field[row, column] = minesCounter;
        }

        private static void RenderPlayField(char[,] board)
        {
            int rows = board.GetLength(0);
            int columns = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < rows; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreatePlayField()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];
            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        private static char[,] PlaceMines()
        {
            int rows = 5;
            int columns = 10;
            char[,] playFiled = new char[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    playFiled[i, j] = '-';
                }
            }

            var randomNumbers = new List<int>();
            while (randomNumbers.Count < 15)
            {
                var random = new Random();
                var number = random.Next(50);
                if (!randomNumbers.Contains(number))
                {
                    randomNumbers.Add(number);
                }
            }

            foreach (int number in randomNumbers)
            {
                int column = number / columns;
                int row = number % columns;
                if (row == 0 && number != 0)
                {
                    column--;
                    row = column;
                }
                else
                {
                    row++;
                }

                playFiled[column, row - 1] = '*';
            }

            return playFiled;
        }

        private static void RevealAllMines(char[,] field)
        {
            int column = field.GetLength(0);
            int row = field.GetLength(1);

            for (int i = 0; i < column; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    if (field[i, j] != '*')
                    {
                        char minesCounter = CountAdjacentMines(field, i, j);
                        field[i, j] = minesCounter;
                    }
                }
            }
        }

        private static char CountAdjacentMines(char[,] field, int row, int column)
        {
            int minesCounter = 0;
            int rows = field.GetLength(0);
            int columns = field.GetLength(1);

            if (row - 1 >= 0)
            {
                if (field[row - 1, column] == '*')
                {
                    minesCounter++;
                }
            }

            if (row + 1 < rows)
            {
                if (field[row + 1, column] == '*')
                {
                    minesCounter++;
                }
            }

            if (column - 1 >= 0)
            {
                if (field[row, column - 1] == '*')
                {
                    minesCounter++;
                }
            }

            if (column + 1 < columns)
            {
                if (field[row, column + 1] == '*')
                {
                    minesCounter++;
                }
            }

            if ((row - 1 >= 0) && (column - 1 >= 0))
            {
                if (field[row - 1, column - 1] == '*')
                {
                    minesCounter++;
                }
            }

            if ((row - 1 >= 0) && (column + 1 < columns))
            {
                if (field[row - 1, column + 1] == '*')
                {
                    minesCounter++;
                }
            }

            if ((row + 1 < rows) && (column - 1 >= 0))
            {
                if (field[row + 1, column - 1] == '*')
                {
                    minesCounter++;
                }
            }

            if ((row + 1 < rows) && (column + 1 < columns))
            {
                if (field[row + 1, column + 1] == '*')
                {
                    minesCounter++;
                }
            }

            return char.Parse(minesCounter.ToString());
        }
    }
}
