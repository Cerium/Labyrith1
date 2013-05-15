using System;
using System.Linq;

namespace Labyrinth
{
    public class LabyrinthProgram
    {
        static void Main(string[] args)
        {            
            ObjectRenderer renderer = new ObjectRenderer();
            Player player = new Player();
            Playfield playfield = new Playfield();            
            Scoreboard scoreboard = new Scoreboard();
            Engine engine = new Engine(renderer, player, playfield, scoreboard);
            engine.Run();
            Console.Write("Good Bye!");
            Console.ReadKey();
        }
    }
}
