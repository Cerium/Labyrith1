namespace Labyrinth
{
    public struct Position
    {
        public int Row { get; set; }
        public int Col { get; set; }

        //public Position() : this()
        //{
        //    this.Row = 3;
        //    this.Col = 3;
        //}

        public Position(int row, int col)
            : this()
        {
            this.Row = row;
            this.Col = col;
        }

        public bool move(Direction direction)
        {
            if (HasWon())
            {
                return false;
            }

            switch (direction)
            {
                case Direction.Left:
                    this.Row -= 1;
                    break;
                case Direction.Up:
                    this.Col -= 1;
                    break;
                case Direction.Right:
                    this.Row += 1;
                    break;
                case Direction.Down:
                    this.Col += 1;
                    break;
                default:
                    return false;
            }

            return true;
        }

        public bool HasWon()
        {
            bool resault;
            resault = false;
            if (Row == 0 || Row == 6 || Col == 0 || Col == 6)
            {
                resault = true;
            }

            return resault;
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