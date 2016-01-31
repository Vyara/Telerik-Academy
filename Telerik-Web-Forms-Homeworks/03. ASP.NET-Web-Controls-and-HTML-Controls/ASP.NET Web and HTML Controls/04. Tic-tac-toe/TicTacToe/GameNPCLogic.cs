namespace TicTacToe
{
    using System;
    using System.Linq;

    public class GameNPCLogic
    {
        private int FromMatrixToIndex(int row, int col)
        {
            return (row * 3) + col;
        }

        public Movement GetBestMove(char[] board, int boardSize, int CurrentPlayer, int alpha, int beta, GameLogic logic)
        {
            Movement BestMove = null;
            int iPossibleMoves = board.Count(b => b == '-');

            Random rand = new Random();
            int i = rand.Next(boardSize);
            int j = rand.Next(boardSize);

            while (iPossibleMoves > 0)
            {
                do
                {
                    if (i < boardSize - 1)
                    {
                        i++;
                    }
                    else if (j < boardSize - 1)
                    {
                        i = 0; j++;
                    }
                    else
                    {
                        i = 0; j = 0;
                    }
                }
                while (board[FromMatrixToIndex(i, j)] != '-');

                Movement NewMove = new Movement(i, j);
                iPossibleMoves--;

                char[] NewBoard = (new string(board)).ToCharArray();

                NewBoard[FromMatrixToIndex(NewMove.iRow, NewMove.iCol)] = 'O';
                var result = logic.GetResult(NewBoard);

                if (result == GameResult.NotFinished)
                {
                    Movement tempMove = GetBestMove(NewBoard, 3, -CurrentPlayer, alpha, beta, logic);
                    NewMove.iRank = tempMove.iRank;
                }
                else
                {
                    if (result == GameResult.NotFinished)
                    {
                        NewMove.iRank = 0;
                    }
                    else
                    {
                        if (result == GameResult.WonByO)
                        {
                            NewMove.iRank = -1;
                        }
                        else
                        {
                            if (result == GameResult.WonByX)
                            {
                                NewMove.iRank = 1;
                            }
                        }
                    }
                }

                if (BestMove == null ||
                    (CurrentPlayer == 1 && NewMove.iRank < BestMove.iRank) ||
                    (CurrentPlayer == -1 && NewMove.iRank > BestMove.iRank))
                {
                    BestMove = NewMove;
                }

                if (CurrentPlayer == 1 && BestMove.iRank < beta)
                {
                    beta = BestMove.iRank;
                }

                if (CurrentPlayer == -1 && BestMove.iRank > alpha)
                {
                    alpha = BestMove.iRank;
                }

                if (alpha > beta)
                {
                    iPossibleMoves = 0;
                }
            }

            return BestMove;
        }
    }
}