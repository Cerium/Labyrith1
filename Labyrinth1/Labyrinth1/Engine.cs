﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labyrinth
{
    public class Engine
    {
        private const int MovesStartAmount = 0;
        private ObjectRenderer renderer;
        private Player player;
        private Playfield playfield;
        private Scoreboard scoreboard;

        public Engine(ObjectRenderer renderer, Player player, Playfield playfield, Scoreboard scoreboard)
        {
            this.renderer = renderer;
            this.player = player;
            this.playfield = playfield;
            this.scoreboard = scoreboard;
        }

        public void Run()
        {
            int moves = MovesStartAmount;
            String input = "";
            this.player.RestartDefaultPosition();
            this.playfield.CreateLabyrinth();
            this.renderer.Render(this.playfield, this.player);
            Message.PrintDirectionsMessage();
            while ((input = Console.ReadLine()) != "exit")
            {
                //uncomment;
                //int[,] labyrinthImage = playfield.GetImage();
                switch (input)
                {
                    case "top":
                        this.scoreboard.pokazvane();
                        break;
                    case "restart":
                        //newGame();
                        this.Run();
                        break;
                    case "L":

                        if (this.playfield.Labyrinth[this.player.GetPosition.Row, this.player.GetPosition.Col - 1] == 0)
                        {
                            moves++;
                            this.player.Move(Direction.Left);
                        }
                        else
                        {
                            Message.PrintInvalidMoveMessage();
                        }

                        break;
                    case "U":

                        if (this.playfield.Labyrinth[this.player.GetPosition.Row - 1, this.player.GetPosition.Col] == 0)
                        {
                            moves++;
                            this.player.Move(Direction.Up);
                        }
                        else
                        {
                            Message.PrintInvalidMoveMessage();
                        }

                        break;
                    case "R":

                        if (this.playfield.Labyrinth[this.player.GetPosition.Row, this.player.GetPosition.Col + 1] == 0)
                        {
                            moves++;
                            this.player.Move(Direction.Right);
                        }
                        else
                        {
                            Message.PrintInvalidMoveMessage();
                        }

                        break;
                    case "D":

                        if (this.playfield.Labyrinth[this.player.GetPosition.Row + 1, this.player.GetPosition.Col] == 0)
                        {
                            moves++;
                            this.player.Move(Direction.Down);
                        }
                        else
                        {
                            Message.PrintInvalidMoveMessage();
                        }

                        break;
                    default:
                        {
                            Message.PrintInvalidMoveMessage();
                            break;
                        }
                }


                if (this.player.HasWon())
                {
                    renderer.Render(this.playfield, this.player);
                    Message.PrintWinningMessage(moves);
                    string name = Console.ReadLine();
                    try
                    {
                        this.scoreboard.add(name, moves);
                    }
                    finally
                    {
                    }

                    Message.PintNewLine();
                    this.Run();
                }
                renderer.Render(this.playfield, this.player);
                Message.PrintDirectionsMessage();
            }
        }
    }
}