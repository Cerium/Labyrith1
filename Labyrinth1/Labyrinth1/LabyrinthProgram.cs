using System;
using System.Linq;

namespace Labyrinth
{
    public class LabyrinthProgram
    {
        static ObjectRenderer renderer = new ObjectRenderer();
        static Player player = new Player();

        static Playfield playfield = new Playfield();
        static Message message = new Message();
        static Scoreboard scores;
        static int moves = 0;

        static void newGame()
        {
            message.PrintIntro();
            playfield.CreateLabyrinth();
            message.PintNewLine();
            renderer.print(playfield, player);
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

                //switch (input)
                //{
                //    case "top":
                //        scores.pokazvane();
                //        break;
                //    case "restart":
                //        newGame();
                //        break;
                //    case "L":

                //        if (!playfield.Move(Direction.Left))
                //        {
                //            message.PrintInvalidMoveMessage();
                //        }
                //        else
                //        {
                //            moves++;
                //            playfield.print();
                //        }

                //        break;
                //    case "U":

                //        if (!playfield.Move(Direction.Up))
                //        {
                //            message.PrintInvalidMoveMessage();
                //        }
                //        else
                //        {
                //            moves++;
                //            playfield.print();
                //        }

                //        break;
                //    case "R":

                //        if (!playfield.Move(Direction.Right))
                //        {
                //            message.PrintInvalidMoveMessage();
                //        }
                //        else
                //        {
                //            moves++;
                //            playfield.print();
                //        }

                //        break;
                //    case "D":

                //        if (!playfield.Move(Direction.Down))
                //        {
                //            message.PrintInvalidMoveMessage();
                //        }
                //        else
                //        {
                //            moves++;
                //            playfield.print();
                //        }

                //        break;
                //    default:
                //        {
                //            message.PrintInvalidMoveMessage();
                //            break;
                //        }
                //}
                //uncomment;

                //if (playfield.isWinning())
                //{
                //    message.PrintWinningMessage(moves);
                //    string name = Console.ReadLine();
                //    try
                //    {
                //        scores.add(name, moves);
                //    }
                //    finally
                //    {
                //    };

                //    message.PintNewLine();
                //    newGame();
                //}

                message.PrintDirectionsMessage();
            }

            Console.Write("Good Bye!");
            Console.ReadKey();
        }
    }
}
