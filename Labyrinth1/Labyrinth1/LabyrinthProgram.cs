using System;
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
            message.Intro();
            playfield.reset();
            message.NewLine();
            playfield.print();
            moves = 0;
        }

        public static void Main(string[] args)
        {

            NewGame();
            scores=new Scoreboard();
            String input = "";
            message.Move();
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

                        if (!playfield.move(Direction.Left)) message.Invalid();
                        else
                        {
                            moves++;
                            playfield.print();
                        }
                        
                        break;
                    case "U":

                        if (!playfield.move(Direction.Up)) message.Invalid();
                        else
                        {
                            moves++;
                            playfield.print();
                        }
                        
                        break;
                    case "R":

                        if (!playfield.move(Direction.Right)) message.Invalid();
                        else
                        {
                            moves++;
                            playfield.print();
                        }
                        
                        break;
                    case "D":

                        if (!playfield.move(Direction.Down)) message.Invalid();
                        else
                        {
                            moves++;
                            playfield.print();
                        }
                        
                        break;
                    default:
                        {
                            message.Invalid(); 
                            break;
                        }

                }
                if (playfield.isWinning())
                {
                    message.Win(moves);
                    string name = Console.ReadLine();
                    try
                    {
                        scores.Add(name, moves);
                    }
                    finally
                    {                        
                       
                    };
                    message.NewLine();
                    NewGame();
                }
                message.Move();
            }
            Console.Write("Good Bye!");
            Console.ReadKey();
        }
    }
}
