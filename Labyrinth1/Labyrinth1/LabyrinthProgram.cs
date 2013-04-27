﻿using System;
using System.Linq;

namespace Labyrinth
{
    public class LabyrinthProgram
    {
        readonly static Playfield playfield = new Playfield();
        readonly static Message message = new Message();
        private static Scoreboard scores;
        private static Player player = new Player();

        public static void NewGame()
        {
            message.IntroOfLabyrinthGame();
            playfield.reset();
            message.NewLine();
            playfield.print();
            player = new Player();
        }

        public static void Main(string[] args)
        {
            NewGame();
            scores = new Scoreboard();
            message.PrintAlloudMoves();
            string input = Console.ReadLine();
            while (input != "exit")
            {
                switch (input)
                {
                    case "top":
                        Console.WriteLine(scores.Show(Configuration.FILE_NAME));
                        break;
                    case "restart":
                        NewGame();
                        break;
                    case "L":
                        if (!playfield.move(Direction.Left))
                        {
                            message.PrintInvalidMoveMessage();
                        }
                        else
                        {
                            player.Points++;
                            playfield.print();
                        }
                        break;
                    case "U":
                        if (!playfield.move(Direction.Up))
                        {
                            message.PrintInvalidMoveMessage();
                        }
                        else
                        {
                            player.Points++;
                            playfield.print();
                        }
                        break;
                    case "R":
                        if (!playfield.move(Direction.Right))
                        {
                            message.PrintInvalidMoveMessage();
                        }
                        else
                        {
                            player.Points++;
                            playfield.print();
                        }
                        break;
                    case "D":
                        if (!playfield.move(Direction.Down))
                        {
                            message.PrintInvalidMoveMessage();
                        }
                        else
                        {
                            player.Points++;
                            playfield.print();
                        }
                        break;
                    default:
                        {
                            message.PrintInvalidMoveMessage();
                            break;
                        }
                }

                if (playfield.isWinning())
                {
                    message.PrintWonMessage(player.Points);
                    player.Name = Console.ReadLine();
                    scores.Add(Configuration.FILE_NAME, player);
                    message.NewLine();
                    NewGame();
                }

                message.PrintAlloudMoves();
            }

            Console.Write("Good Bye!");
            Console.ReadKey();
        }
    }
}
