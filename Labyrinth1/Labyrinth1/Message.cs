using System;

namespace Labyrinth
{
    public static class Message
    {
        public static void PrintInvalidMoveMessage()
        {
            Console.WriteLine(" Invalid move!");
        }

        public static void PrintDirectionsMessage()
        {
            Console.Write("Enter your move (L=left, R=right, U=up, D=down): ");
        }

        public static void PrintIntro()
        {
            Console.WriteLine("Welcome to \"Labyrinth\" game. Please try to escape. Use 'top' to view the top scoreboard, 'restart' to start a new game and 'exit' to quit the game.");
        }

        public static void PrintNewLine()
        {
            Console.WriteLine();
        }

        public static void PrintWinningMessage(int moves)
        {
            Console.Write("Congratulations! You escaped in {0} moves.\nPlease enter your name for the top scoreboard: ", moves);
        }

        public static void PrintInstructionsMessage()
        {
            Console.WriteLine("You are playing \"Labyrinth\" game. Please try to escape. Use 'top' to view the top scoreboard, 'restart' to start a new game and 'exit' to quit the game.");
        }
    }
}