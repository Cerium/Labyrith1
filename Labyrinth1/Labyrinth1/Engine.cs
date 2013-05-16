using System;

namespace Labyrinth
{
    public class Engine
    {
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
            Message.PrintIntro();
            string input;
            this.player.RestartDefaultPosition();
            this.playfield.CreateLabyrinth();            
            this.renderer.Render(this.playfield, this.player);
            Message.PrintDirectionsMessage();
            while ((input = Console.ReadLine()) != "exit")
            {
                string userInput = input.ToUpper();
                switch (userInput)
                {
                    case "TOP":
                        Console.WriteLine(this.scoreboard.Show(Configuration.FileName));
                        break;
                    case "RESTART":                        
                        this.Run();
                        break;
                    case "L":
                        if (this.playfield.Labyrinth[this.player.GetPosition.Row, this.player.GetPosition.Col - 1] == 0)
                        {
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
                    Message.PrintWinningMessage(this.player.Points);

                    player.Name = Console.ReadLine();
                    this.scoreboard.Add(Configuration.FileName, player);
                    this.player.Points = 0;

                    Message.PrintNewLine();                    
                    this.Run();
                }
                
                renderer.Render(this.playfield, this.player);
                Message.PrintDirectionsMessage();
            }
        }
    }
}
