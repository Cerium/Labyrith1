﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labyrinth
{
    public class LabyrinthProgram
    {
        static Playfield playfield = new Playfield();
        static Message message = new Message();
        static Scoreboard scores;
        static int moves = 0;

        public static void NewGame()
        {
            message.IntroOfGameLabyrith();
            playfield.reset();
            message.PrintingNewLine();
            playfield.print();
            moves = 0;
        }

        public static void Main(string[] args)
        {

            NewGame();
            scores=new Scoreboard();
            String input = "";
            message.PrintingMessageOfAlloudMovements();
            while ((input = Console.ReadLine()) != "exit")
            {
                switch (input)
                {
                    case "top":
                        scores.Show();
                        break;
                    case "restart":
                        NewGame();
                        break;
                    case "L":

                        if (!playfield.move(Direction.Left)) message.PrintingInvalidMoveMessage();
                        else
                        {
                            moves++;
                            playfield.print();
                        }
                        
                        break;
                    case "U":

                        if (!playfield.move(Direction.Up)) message.PrintingInvalidMoveMessage();
                        else
                        {
                            moves++;
                            playfield.print();
                        }
                        
                        break;
                    case "R":

                        if (!playfield.move(Direction.Right)) message.PrintingInvalidMoveMessage();
                        else
                        {
                            moves++;
                            playfield.print();
                        }
                        
                        break;
                    case "D":

                        if (!playfield.move(Direction.Down)) message.PrintingInvalidMoveMessage();
                        else
                        {
                            moves++;
                            playfield.print();
                        }
                        
                        break;
                    default:
                        {
                            message.PrintingInvalidMoveMessage(); 
                            break;
                        }

                }
                if (playfield.isWinning())
                {
                    message.WonGameMessage(moves);
                    string name = Console.ReadLine();
                    try
                    {
                        scores.Add(name, moves);
                    }
                    finally
                    {                        
                       
                    };
                    message.PrintingNewLine();
                    NewGame();
                }
                message.PrintingMessageOfAlloudMovements();
            }
            Console.Write("Good Bye!");
            Console.ReadKey();
        }
    }
}
