using System;

namespace Labyrinth
{
    public class Playfield
    {
        public const int PlayfieldRows = 7;
        public const int PlayfieldCols = 7;
        private int[,] labyrinth;
        
        public Playfield()
        {
            this.labyrinth = new int[PlayfieldRows, PlayfieldCols];
        }
        
        public int[,] Labyrinth
        {
            get
            {
                return this.labyrinth;
            }
        }      
     
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
            Player bot = new Player();            
            for (int i = 0; i < PlayfieldRows; i++)
            {
                for (int j = 0; j < PlayfieldCols; j++)
                {
                    labyrinth[i, j] = -1;
                }
            }
            
            labyrinth[bot.GetPosition.Row, bot.GetPosition.Col] = 0;
            Direction direction = Direction.Blank;
            Random randomGenerator = new Random();            
            while (!bot.HasWon())
            {
                do
                {
                    int randomNumber = randomGenerator.Next() % 4;
                    direction = (Direction)(randomNumber);
                } while (!IsVisitedPosition(bot, direction));

                bot.Move(direction);
                labyrinth[bot.GetPosition.Row, bot.GetPosition.Col] = 0;
            }

            for (int i = 0; i < PlayfieldRows; i++)
            {
                for (int j = 0; j < PlayfieldCols; j++)
                {
                    if (labyrinth[i, j] == -1)
                    {
                        int randomNumber = randomGenerator.Next();
                        if (randomNumber % 3 == 0) labyrinth[i, j] = 0;
                        else labyrinth[i, j] = 1;
                    }
                }
            }
        }
    }
}