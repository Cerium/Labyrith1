using System;

namespace Labyrinth
{
    public class ObjectRenderer
    {
        public void Render(Playfield playfield, Player player)
        {
            for (int row = 0; row < 7; row++)
            {
                for (int col = 0; col < 7; col++)
                {
                    if (player.GetPosition.Row == row && player.GetPosition.Col == col)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        if (playfield.Labyrinth[row, col] == 0)
                        {
                            Console.Write("-");
                        }
                        else
                        {                            
                            Console.Write("X");                                                       
                        }
                    }
                }

                Message.PrintNewLine();
            }
        }
    }
}
