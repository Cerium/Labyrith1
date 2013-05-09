namespace Labyrinth
{
    public struct Position
    {
        public int Row { get; set; }
        public int Col { get; set; }

        public Position(int row, int col)
            : this()
        {
            this.Row = row;
            this.Col = col;
        }
               
        public bool isValidPosition()
        {
            if (Row <= 6 && Row >= 0 && Col >= 0 && Col <= 6)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void makeStarting()
        {
            this.Row = 3;
            this.Col = 3;
        }
    }
}