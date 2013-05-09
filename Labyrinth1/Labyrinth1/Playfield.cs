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

        //labyrinth property
        public int[,] Labyrinth
        {
            get
            {
                return new int[labyrinth.GetLength(0), labyrinth.GetLength(1)];
            }

            set
            {
                if (value.GetLength(0) != PlayfieldRows || value.GetLength(1) != PlayfieldCols)
                {
                    throw new ArgumentOutOfRangeException("Labyrinth", "Incorrect playfield size!");
                }

                this.labyrinth = new int[value.GetLength(0), value.GetLength(1)];
            }
        }

        public int[,] GetImage()
        {
            int[,] image = new int[PlayfieldRows, PlayfieldCols];
            for (int i = 0; i < PlayfieldRows; i++)
            {
                for (int j = 0; j < PlayfieldCols; j++)
                {
                    image[i, j] = labyrinth[i, j];
                }
            }

            return image;
        }
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
       
        public void CreateLabyrinth()
        {
            Player player = new Player();            
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