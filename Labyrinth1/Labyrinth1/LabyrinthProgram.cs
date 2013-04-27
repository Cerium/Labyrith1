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
            message.intro();
            playfield.reset();
            message.nl();
            playfield.print();
            moves = 0;
        }

        public static void Main(string[] args)
        {

            NewGame();
            scores=new Scoreboard();
            String input = "";
            message.move();
            while ((input = Console.ReadLine()) != "exit")
            {
                switch (input)
                {
                    case "top":
                        scores.pokazvane();
                        break;
                    case "restart":
                        NewGame();
                        break;
                    case "L":

                        if (!playfield.move(Direction.Left)) message.invalid();
                        else
                        {
                            moves++;
                            playfield.print();
                        }
                        
                        break;
                    case "U":

                        if (!playfield.move(Direction.Up)) message.invalid();
                        else
                        {
                            moves++;
                            playfield.print();
                        }
                        
                        break;
                    case "R":

                        if (!playfield.move(Direction.Right)) message.invalid();
                        else
                        {
                            moves++;
                            playfield.print();
                        }
                        
                        break;
                    case "D":

                        if (!playfield.move(Direction.Down)) message.invalid();
                        else
                        {
                            moves++;
                            playfield.print();
                        }
                        
                        break;
                    default:
                        {
                            message.invalid(); 
                            break;
                        }

                }
                if (playfield.isWinning())
                {
                    message.win(moves);
                    string name = Console.ReadLine();
                    try
                    {
                        scores.add(name, moves);
                    }
                    finally
                    {                        
                       
                    };
                    message.nl();
                    NewGame();
                }
                message.move();
            }
            Console.Write("Good Bye!");
            Console.ReadKey();
        }
    }
}
