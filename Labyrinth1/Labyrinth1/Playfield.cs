﻿using System;

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

        //labyrinth property
        public int[,] Labyrinth
        {
            get
            {
                return this.labyrinth;
            }
        }
        //should create class Player
        //Position player;

        //think it is not neccessery
        //public bool isWinning()
        //{
        //    return player.HasWon();
        //}

        //uncomment;

        //public bool Move(Direction direction)
        //{
        //    if (isValidMove(player, direction))
        //        player.Move(direction);
        //    else return false;
        //    return true;
        //}

        bool isValidPosition(Position position)
        {
            return labyrinth[position.Row, position.Col] == 0 && position.isValidPosition();
        }

        //uncomment;

        //bool isValidMove(Position position, Direction direction)
        //{
        //    if (position.HasWon())
        //    {
        //        return false;
        //    }

        //    Position newPosition = new Position(position.Row, position.Col);
        //    newPosition.Move(direction);
        //    return isValidPosition(newPosition);
        //}

        //uncomment;

        //bool isBlankPosition(Position position)
        //{
        //    return labyrinth[position.Row, position.Col] == -1;
        //}

        private bool IsVisitedPosition(Player player, Direction direction)
        {
            Position pos = new Position(player.GetPosition.Row, player.GetPosition.Col);
            Player bot = new Player(pos);
            bot.Move(direction);
            if (labyrinth[bot.GetPosition.Row, bot.GetPosition.Col] == -1)
            {
                return true;
            }

            return false;
        }

        // should create class Renderer and put this method there
        //public void print()
        //{
        //    for (int temp2 = 0; temp2 < 7; temp2++)
        //    {

        //        for (int temp1 = 0; temp1 < 7; temp1++)
        //        {
        //            if (player.Row == temp1 && player.Col == temp2)
        //            {
        //                Console.Write("*");
        //            }
        //            else
        //            {
        //                if (labyrinth[temp1, temp2] == 0)
        //                {
        //                    Console.Write("-");
        //                }
        //                else
        //                {
        //                    if (labyrinth[temp1, temp2] == 1)
        //                    {
        //                        Console.Write("X");
        //                    }
        //                    else
        //                    {
        //                        Console.Write("+");
        //                    }
        //                }
        //            }
        //        }

        //        Console.WriteLine();
        //    }
        //}

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

            //create way out
            labyrinth[player.GetPosition.Row, player.GetPosition.Col] = 0;
            Direction direction = Direction.Blank;
            Random random = new Random();
            //Position tempPos2 = new Position();
            while (!player.HasWon())
            {
                do
                {
                    int randomNumber = random.Next() % 4;
                    direction = (Direction)(randomNumber);
                } while (!IsVisitedPosition(player, direction));

                player.Move(direction);
                labyrinth[player.GetPosition.Row, player.GetPosition.Col] = 0;
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