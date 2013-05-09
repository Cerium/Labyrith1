using System;

namespace Labyrinth
{
    public class Playfield
    {
        public const int PlayfieldRows = 7;
        public const int PlayfieldCols = 7;
        private int[,] labyrinth;

        //playfield constructor
        public Playfield()
        {
            this.labyrinth = new int[PlayfieldRows, PlayfieldCols];
        }

        //should create class Player
        Position player;

        //think it is not neccessery
        public bool isWinning()
        {
            return player.HasWon();
        }

        public bool move(Direction direction)
        {
            if (isValidMove(player, direction))
                player.move(direction);
            else return false;
            return true;
        }

        bool isValidPosition(Position position)
        {
            return labyrinth[position.Row, position.Col] == 0 && position.isValidPosition();
        }

        bool isValidMove(Position position, Direction direction)
        {
            if (position.HasWon())
            {
                return false;
            }

            Position newPosition = new Position(position.Row, position.Col);
            newPosition.move(direction);
            return isValidPosition(newPosition);
        }

        bool isBlankPosition(Position position)
        {
            return labyrinth[position.Row, position.Col] == -1;
        }

        bool isBlankMove(Position position, Direction direction)
        {
            Position newPosition = new Position(position.Row, position.Col);
            newPosition.move(direction);
            return isBlankPosition(newPosition);
        }

        // should create class Renderer and put this method there
        public void print()
        {
            for (int temp2 = 0; temp2 < 7; temp2++)
            {

                for (int temp1 = 0; temp1 < 7; temp1++)
                {
                    if (player.Row == temp1 && player.Col == temp2)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        if (labyrinth[temp1, temp2] == 0)
                        {
                            Console.Write("-");
                        }
                        else
                        {
                            if (labyrinth[temp1, temp2] == 1)
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

        public void CreatePlayfield()
        {
            Player player = new Player();
            //player = new Position();//shouldn't be here
            for (int i = 0; i < PlayfieldRows; i++)
            {
                for (int j = 0; j < PlayfieldCols; j++)
                {
                    labyrinth[i, j] = -1;
                }
            }

            labyrinth[PlayfieldRows / 2, PlayfieldCols / 2] = 0;
            Direction d = Direction.Blank;
            Random random = new Random();
            Position tempPos2 = new Position();
            while (!tempPos2.HasWon())
            {
                do
                {
                    int randomNumber = random.Next() % 4;
                    d = (Direction)(randomNumber);
                } while (!isBlankMove(tempPos2, d));

                tempPos2.move(d);
                labyrinth[tempPos2.Row, tempPos2.Col] = 0;
            }

            for (int i = 0; i < PlayfieldRows; i++)
            {
                for (int j = 0; j < PlayfieldCols; j++)
                {
                    if (labyrinth[i, j] == -1)
                    {
                        int randomNumber = random.Next();
                        if (randomNumber % 3 == 0) labyrinth[i, j] = 0;
                        else labyrinth[i, j] = 1;
                    }
                }
            }
        }
    }
}