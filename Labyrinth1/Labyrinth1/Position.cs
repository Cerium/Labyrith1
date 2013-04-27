﻿namespace Labyrinth
{
    public struct Position
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Position(int x, int y)
            : this()
        {
            this.X = x;
            this.Y = y;
        }

        public bool IsWinning(int fieldSize)
        {
            if (X == 0 || X == fieldSize - 1 || Y == 0 || Y == fieldSize - 1)
            {
                return true;
            }
            return false;
        }
    }
}