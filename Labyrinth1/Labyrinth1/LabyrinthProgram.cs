using System;
using System.Linq;

namespace Labyrinth
{
    public class LabyrinthProgram
    {
        static ObjectRenderer renderer = new ObjectRenderer();
        static Player player;

        static Playfield playfield;
        static Message message = new Message();
        static Scoreboard scores;
        static int moves = 0;

        static void newGame()
        {
            playfield = new Playfield();
            player = new Player();
            message.PrintIntro();
            playfield.CreateLabyrinth();
            message.PintNewLine();
            renderer.Render(playfield, player);
            moves = 0;
        }

        static void Main(string[] args)
        {
            newGame();
            scores = new Scoreboard();
            String input = "";
            message.PrintDirectionsMessage();
            while ((input = Console.ReadLine()) != "exit")
            {
                //uncomment;
                //int[,] labyrinthImage = playfield.GetImage();
                switch (input)
                {
                    case "top":
                        scores.pokazvane();
                        break;
                    case "restart":
                        newGame();
                        break;
                    case "L":

                        if (playfield.Labyrinth[player.GetPosition.Row, player.GetPosition.Col - 1] == 0)
                        {
                            moves++;
                            player.Move(Direction.Left);                            
                        }
                        else
                        {
                            message.PrintInvalidMoveMessage();
                        }

                        break;
                    case "U":

                        if (playfield.Labyrinth[player.GetPosition.Row - 1, player.GetPosition.Col] == 0)
                        {
                            moves++;
                            player.Move(Direction.Up); 
                        }
                        else
                        {
                            message.PrintInvalidMoveMessage();
                        }

                        break;
                    case "R":

                        if (playfield.Labyrinth[player.GetPosition.Row, player.GetPosition.Col + 1] == 0)
                        {
                            moves++;
                            player.Move(Direction.Right);  
                        }
                        else
                        {
                            message.PrintInvalidMoveMessage();
                        }

                        break;
                    case "D":

                        if (playfield.Labyrinth[player.GetPosition.Row + 1, player.GetPosition.Col] == 0)
                        {
                            moves++;
                            player.Move(Direction.Down);  
                        }
                        else
                        {
                            message.PrintInvalidMoveMessage();
                        }

                        break;
                    default:
                        {
                            message.PrintInvalidMoveMessage();
                            break;
                        }
                }
                

                if (player.HasWon())
                {
                    message.PrintWinningMessage(moves);
                    string name = Console.ReadLine();
                    try
                    {
                        scores.add(name, moves);
                    }
                    finally
                    {
                    };

                    message.PintNewLine();
                    newGame();
                }
                renderer.Render(playfield, player);
                message.PrintDirectionsMessage();
            }

            Console.Write("Good Bye!");
            Console.ReadKey();
        }
    }
}
