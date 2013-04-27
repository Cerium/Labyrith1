﻿using System;

namespace Labyrinth
{
    public class Message
    {
        public void PrintingInvalidMoveMessage()
        {
            Console.WriteLine("* Invalid move!");
        }

        public void PrintingMessageOfAlloudMovements()
        {
            Console.Write("Enter your move (L=left, R=right, U=up, D=down): ");
        }

        public void IntroOfLabyrithGame()
        {
            Console.WriteLine("Welcome to \"Labyrinth\" game. Please try to escape. Use 'top' to view the top scoreboard, 'restart' to start a new game and 'exit' to quit the game.");
        }

        public void PrintingNewLine()
        {
            Console.WriteLine();
        }

        public void WonGameMessage(int moves)
        {
            Console.Write("Congratulations! You escaped in {0} moves.\nPlease enter your name for the top scoreboard: ", moves);
        }

        public void GameInfoMessage()
        {
            Console.WriteLine("You are playing \"Labyrinth\" game. Please try to escape. Use 'top' to view the top scoreboard, 'restart' to start a new game and 'exit' to quit the game.");
        }
    }
}