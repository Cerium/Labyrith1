using System;

namespace Labyrinth
{
    public static class Message
    {
        public static string PrintInvalidMoveMessage()
        {
            string message = " Invalid move!";
            return message;
        }

        public static string PrintDirectionsMessage()
        {
            string message = "Enter your move (L=left, R=right, U=up, D=down): ";
            return message;
        }

        public static string PrintIntro()
        {
            string message = "Welcome to \"Labyrinth\" game. Please try to escape. Use 'top' to view the top scoreboard, 'restart' to start a new game and 'exit' to quit the game.";
            return message;

        }

        public static string PrintNewLine()
        {
            string newLine = string.Empty;
            return newLine;
        }

        public static string PrintWinningMessage(int moves)
        {
            string message = "Congratulations! You escaped in " + moves + " moves.\nPlease enter your name for the top scoreboard: ";
            return message;
        }

        public static string PrintInstructionsMessage()
        {
            string message = "You are playing \"Labyrinth\" game. Please try to escape. Use 'top' to view the top scoreboard, 'restart' to start a new game and 'exit' to quit the game.";
            return message;
        }
    }
}