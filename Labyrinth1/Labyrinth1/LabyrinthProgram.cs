﻿using System;
using System.Linq;

namespace Labyrinth
{
    public class LabyrinthProgram
    {
        readonly static Playfield playfield = new Playfield(Configuration.GAME_FIELD_SIZE);
        readonly static Message message = new Message();
        private static Scoreboard scores;
        private static Player player;

        public static void NewGame()
        {
            message.IntroOfLabyrinthGame();
            playfield.CreateGameField();
            message.NewLine();
            Position playerInitioalPos = new Position(3, 3);
            player = new Player(playerInitioalPos);
            playfield.RenderGameField(player);            
        }

        public static void Main(string[] args)
        {
            NewGame();
            scores = new Scoreboard();
            message.PrintAlloudMoves();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "exit")
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
                        if (!player.Move(Direction.Left, Configuration.GAME_FIELD_SIZE))
                        {
                            message.PrintInvalidMoveMessage();
                        }
                        else
                        {
                            player.Points++;
                            playfield.RenderGameField(player);
                        }
                        break;
                    case "U":
                        if (!player.Move(Direction.Up, Configuration.GAME_FIELD_SIZE))
                        {
                            message.PrintInvalidMoveMessage();
                        }
                        else
                        {
                            player.Points++;
                            playfield.RenderGameField(player);
                        }
                        break;
                    case "R":
                        if (!player.Move(Direction.Right, Configuration.GAME_FIELD_SIZE))
                        {
                            message.PrintInvalidMoveMessage();
                        }
                        else
                        {
                            player.Points++;
                            playfield.RenderGameField(player);
                        }
                        break;
                    case "D":
                        if (!player.Move(Direction.Down, Configuration.GAME_FIELD_SIZE))
                        {
                            message.PrintInvalidMoveMessage();
                        }
                        else
                        {
                            player.Points++;
                            playfield.RenderGameField(player);
                        }
                        break;
                    default:
                        {
                            message.PrintInvalidMoveMessage();
                            break;
                        }
                }

                if (player.Position.IsWinning(Configuration.GAME_FIELD_SIZE))
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
