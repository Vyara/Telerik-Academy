namespace TicTacToe
{
    public class Movement
    {
        public int iCol;
        public int iRow;
        public int iRank;

        public Movement(int col, int row)
        {
            iCol = col;
            iRow = row;
            iRank = 0;
        }
    }
}