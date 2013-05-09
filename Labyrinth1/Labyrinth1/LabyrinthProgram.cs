using System;
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
            message.PrintIntro();
            playfield.reset();
            message.PintNewLine();
            playfield.print();
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
                            message.PrintInvalidMoveMessage();
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
                            message.PrintInvalidMoveMessage();
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
                            message.PrintInvalidMoveMessage();
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
                            message.PrintInvalidMoveMessage();
                        }
                        else
                        {
                            moves++;
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

                message.PrintDirectionsMessage();
            }

            Console.Write("Good Bye!");
            Console.ReadKey();
        }
    }
}
