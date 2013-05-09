using System;

namespace Labyrinth
{
    public class Player
    {
        public const int PlayerRow = 3;
        public const int PlayerCol = 3;
        private Position position;

        public Player()
        {
            this.position.Row = PlayerRow;
            this.position.Col = PlayerCol;
        }

        public Player(Position position)
        {
            this.GetPosition = position;
        }

        public Position GetPosition
        {
            get
            {
                return new Position(position.Row, position.Col);
            }
            private set
            {
                if (value.Row < 0 || value.Row >= Playfield.PlayfieldRows ||
                    value.Col < 0 || value.Col >= Playfield.PlayfieldCols)
                {
                    throw new ArgumentOutOfRangeException("Player must be inside the playfield!");
                }

                this.position = new Position(value.Row, value.Col);
            }
        }

        public bool HasWon()
        {
            bool resault;
            resault = false;
            if (this.GetPosition.Row == 0 || this.GetPosition.Row == 6 ||
                this.GetPosition.Col == 0 || this.GetPosition.Col == 6)
            {
                resault = true;
            }

            return resault;
        }

        public void Move(Direction direction)
        {
            switch (direction)
            {
                case Direction.Left:
                    this.position.Row -= 1;
                    break;
                case Direction.Up:
                    this.position.Col -= 1;
                    break;
                case Direction.Right:
                    this.position.Row += 1;
                    break;
                case Direction.Down:
                    this.position.Col += 1;
                    break;             
            }
        }
    }
}
