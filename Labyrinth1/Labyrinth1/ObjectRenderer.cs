using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labyrinth
{
    public class ObjectRenderer
    {
        public void print(Playfield playfield, Player player)
        {
            for (int temp2 = 0; temp2 < 7; temp2++)
            {

                for (int temp1 = 0; temp1 < 7; temp1++)
                {
                    if (player.GetPosition.Row == temp1 && player.GetPosition.Col == temp2)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        if (playfield.Labyrinth[temp1, temp2] == 0)
                        {
                            Console.Write("-");
                        }
                        else
                        {
                            if (playfield.Labyrinth[temp1, temp2] == 1)
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
