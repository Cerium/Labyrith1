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

        public Position GetPosition
        {
            get
            {
                return new Position(position.Row, position.Col);
            }
            private set
            {
                this.position = new Position(value.Row, value.Col);
            }
        }
    }
}
