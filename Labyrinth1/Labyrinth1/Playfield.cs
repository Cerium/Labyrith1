﻿using System;

namespace Labyrinth
{
    public class Playfield
    {
        private readonly int[,] labyrinth;
        Position player;

        public Playfield(int fieldSize)
        {
            labyrinth = new int[fieldSize,fieldSize];
        }

        bool isValidPosition(Position position)
        {
            return labyrinth[position.X, position.Y] == 0 && position.IsValidPosition();
        }

        bool isValidMove(Player player, Direction direction)
        {
            //if (isWinning()) return false;

            //Position newPosition = new Position(player.Position.X, player.Position.Y);

            //player.Move(direction);

            return true;// isValidPosition(newPosition);
        }

        bool isBlankPosition(Position position)
        {
            return labyrinth[position.X, position.Y] == -1;
        }

        bool isBlankMove(Player player, Direction direction)
        {
            Position newPosition = new Position(player.Position.X, player.Position.Y);
            //player.Move(direction);
            bool isBlankPos = isBlankPosition(newPosition);

            return isBlankPos;
        }

        public void RenderGameField(Player player)
        {
            for (int temp2 = 0; temp2 < 7; temp2++)
            {
                for (int temp1 = 0; temp1 < 7; temp1++)
                {
                    if (player.Position.X == temp1 && player.Position.Y == temp2)
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
                        }
                    }
                }
                Console.WriteLine();
            }
        }
        public void CreateGameField()
        {
            int gameFieldLenght = labyrinth.GetLength(0);

            for (int i = 0; i < gameFieldLenght; i++)
            {
                for (int j = 0; j < gameFieldLenght; j++)
                {
                    labyrinth[i, j] = -1;
                }
            }

            labyrinth[gameFieldLenght / 2, gameFieldLenght / 2] = 0;

            Direction currentDirection = Direction.Blank;            
            Position currentPosition = new Position(gameFieldLenght / 2, gameFieldLenght / 2);
            Random directionGenerator = new Random();
            //while (!isWinning())
            //{
            //    do
            //    {
            //        int nextDirection = directionGenerator.Next() % 4;
            //        currentDirection = (Direction)(nextDirection);
            //    } while (!isBlankMove(currentPosition, currentDirection));

            //    move(currentDirection);
            //    labyrinth[currentPosition.X, currentPosition.Y] = 0;
            //}
            for (int i = 0; i < gameFieldLenght; i++)
            {
                for (int j = 0; j < gameFieldLenght; j++)
                {
                    if (labyrinth[i, j] == -1)
                    {
                        int randomNumber = directionGenerator.Next();
                        if (randomNumber % 3 == 0) labyrinth[i, j] = 0;
                        else labyrinth[i, j] = 1;
                    }
                }
            }
        }

        
       
       


       
    }
}