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

        public bool isWinning()
        {
            return player.isWinning();
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
            return labyrinth[position.X, position.Y] == 0 && position.isValidPosition();
        }

        bool isValidMove(Position position, Direction direction)
        {
            if (position.isWinning()) return false;

            Position newPosition = new Position(position.X, position.Y);

            newPosition.move(direction);

            return isValidPosition(newPosition);
        }

        bool isBlankPosition(Position position)
        {
            return labyrinth[position.X, position.Y] == -1;
        }
        bool isBlankMove(Position position, Direction direction)
        {
            Position newPosition = new Position(position.X, position.Y);
            newPosition.move(direction);
            bool isBlankPos = isBlankPosition(newPosition);

            return isBlankPos;
        }


        public void RenderGameField()
        {
            for (int temp2 = 0; temp2 < 7; temp2++)
            {
                for (int temp1 = 0; temp1 < 7; temp1++)
                {
                    if (player.X == temp1 && player.Y == temp2)
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
            player = new Position();

            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    labyrinth[i, j] = -1;
                }
            }

            labyrinth[Position.DefaultStartPositionX, Position.DefaultStartPositionY] = 0;
            Direction currentDirection = Direction.Blank;            
            Position currentPosition = new Position();
            Random directionGenerator = new Random();
            while (!currentPosition.isWinning())
            {
                do
                {
                    int nextDirection = directionGenerator.Next() % 4;
                    currentDirection = (Direction)(nextDirection);
                } while (!isBlankMove(currentPosition, currentDirection));

                currentPosition.move(currentDirection);
                labyrinth[currentPosition.X, currentPosition.Y] = 0;
            }
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
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