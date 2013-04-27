﻿namespace Labyrinth
{
    public class Position
    {
        public const int DefaultStartPositionX = 3;
        public const int DefaultStartPositionY = 3;

        public int X { get; set; }
        public int Y { get; set; }

        public Position()
        {
            this.X = DefaultStartPositionX;
            this.Y = DefaultStartPositionY;
        }
        public Position(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public bool move(Direction direction)
        {
            if (isWinning()) return false;
            switch (direction)
            {
                case Direction.Left:
                    this.X -= 1;
                    break;
                case Direction.Up:
                    this.Y -= 1;
                    break;
                case Direction.Right:
                    this.X += 1;
                    break;
                case Direction.Down:
                    this.Y += 1;
                    break;
                default:
                    return false;
            }
            return true;
        }
        public bool isWinning()
        {
            bool resault;
            resault = false;
            if (X == 0 || X == 6 || Y == 0 || Y == 6)
                resault = true;
            return resault;
        }



        public bool isValidPosition()
        {



            if (X <= 6 && X >= 0 && Y >= 0 && Y <= 6) return true;
            else return false;
        }

        public void makeStarting()
        {
            this.X = 3;
            this.Y = 3;
        }
    }
}