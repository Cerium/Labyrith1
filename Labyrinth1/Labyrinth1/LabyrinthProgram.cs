﻿using System;
using System.Linq;

namespace Labyrinth
{
    public class LabyrinthProgram
    {
        static Playfield playfield = new Playfield();
        static Message message = new Message();
        static Scoreboard scores;
        static int moves = 0;

        static void newGame()
        {
            message.intro();
            playfield.reset();
            message.nl();
            playfield.print();
            moves = 0;
        }

        static void Main(string[] args)
        {
            newGame();
            scores = new Scoreboard();
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
                        newGame();
                        break;
                    case "L":

                        if (!playfield.move(Direction.Left))
                        {
                            message.invalid();
                        }
                        else
                        {
                            moves++;
                            playfield.print();
                        }

                        break;
                    case "U":

                        if (!playfield.move(Direction.Up))
                        {
                            message.invalid();
                        }
                        else
                        {
                            moves++;
                            playfield.print();
                        }

                        break;
                    case "R":

                        if (!playfield.move(Direction.Right))
                        {
                            message.invalid();
                        }
                        else
                        {
                            moves++;
                            playfield.print();
                        }

                        break;
                    case "D":

                        if (!playfield.move(Direction.Down))
                        {
                            message.invalid();
                        }
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
                    newGame();
                }

                message.move();
            }

            Console.Write("Good Bye!");
            Console.ReadKey();
        }
    }
}
