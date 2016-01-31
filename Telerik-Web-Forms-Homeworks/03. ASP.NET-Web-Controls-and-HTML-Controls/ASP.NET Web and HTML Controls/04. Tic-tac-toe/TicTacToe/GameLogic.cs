namespace TicTacToe
{
    using System.Linq;

    public class GameLogic
    {
        public GameResult GetResult(char[] board)
        {
            if (board[0] == board[1] && board[1] == board[2] && board[0] != '-')
            {
                return board[0] == 'X' ? GameResult.WonByX : GameResult.WonByO;
            }

            if (board[3] == board[4] && board[4] == board[5] && board[3] != '-')
            {
                return board[3] == 'X' ? GameResult.WonByX : GameResult.WonByO;
            }

            if (board[6] == board[7] && board[7] == board[8] && board[6] != '-')
            {
                return board[6] == 'X' ? GameResult.WonByX : GameResult.WonByO;
            }

            if (board[0] == board[3] && board[3] == board[6] && board[0] != '-')
            {
                return board[0] == 'X' ? GameResult.WonByX : GameResult.WonByO;
            }

            if (board[1] == board[4] && board[4] == board[7] && board[1] != '-')
            {
                return board[1] == 'X' ? GameResult.WonByX : GameResult.WonByO;
            }

            if (board[2] == board[5] && board[5] == board[8] && board[2] != '-')
            {
                return board[2] == 'X' ? GameResult.WonByX : GameResult.WonByO;
            }

            if (board[0] == board[4] && board[4] == board[8] && board[0] != '-')
            {
                return board[0] == 'X' ? GameResult.WonByX : GameResult.WonByO;
            }

            if (board[2] == board[4] && board[4] == board[6] && board[2] != '-')
            {
                return board[2] == 'X' ? GameResult.WonByX : GameResult.WonByO;
            }

            if (board.Any(b => b == '-'))
            {
                return GameResult.NotFinished;
            }

            return GameResult.Draw;
        }
    }
}