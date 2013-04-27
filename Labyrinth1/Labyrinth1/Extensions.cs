﻿namespace Labyrinth
{
    public static class Extensions
    {
        public static bool IsValidPosition(this Position source)
        {
            if (source.X <= 6 && source.X >= 0 && source.Y >= 0 && source.Y <= 6)
            {
                return true;
            }
            return false;
        }
    }
}