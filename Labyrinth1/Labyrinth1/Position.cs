﻿namespace Labyrinth
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
    }
}