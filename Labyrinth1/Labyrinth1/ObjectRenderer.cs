using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labyrinth
{
    public class ObjectRenderer
    {
        public void Render(Playfield playfield, Player player)
        {
            for (int Row = 0; Row < 7; Row++)
            {

                for (int Col = 0; Col < 7; Col++)
                {
                    if (player.GetPosition.Row == Row && player.GetPosition.Col == Col)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        if (playfield.Labyrinth[Row, Col] == 0)
                        {
                            Console.Write("-");
                        }
                        else
                        {
                            if (playfield.Labyrinth[Row, Col] == 1)
                            {
                                Console.Write("X");
                            }
                            else
                            {
                                Console.Write("+");
                            }
                        }
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
