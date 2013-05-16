using System;

namespace Labyrinth
{
    public class Player
    {
        public const int PlayerRow = 3;
        public const int PlayerCol = 3;
        private Position position;

        private string name = string.Empty;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int points = 0;
        public int Points
        {
            get { return points; }
            set { points = value; }
        }

        public Player()
        {
            this.position = new Position(PlayerRow, PlayerCol);     
        }

        public Player(Position position)
        {
            this.GetPosition = position;
        }

        public Position GetPosition
        {
            get
            {
                return new Position(this.position.Row, this.position.Col);
            }

            private set
            {
                if (value.Row < 0 || value.Row >= Playfield.PlayfieldRows ||
                    value.Col < 0 || value.Col >= Playfield.PlayfieldCols)
                {
                    throw new ArgumentOutOfRangeException("Player Position", "Player must be inside the playfield!");
                }

                this.position = new Position(value.Row, value.Col);
            }
        }
        
        public void RestartDefaultPosition()
        {
            this.position = new Position(PlayerRow, PlayerCol);
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
                    this.position.Col -= 1;
                    break;
                case Direction.Up:
                    this.position.Row -= 1;
                    break;
                case Direction.Right:
                    this.position.Col += 1;
                    break;
                case Direction.Down:
                    this.position.Row += 1;
                    break;             
            }

            this.Points++;
        }

        public override string ToString()
        {
            return string.Format("{0} -> {1}", this.Name, this.Points);
        }
    }
}
