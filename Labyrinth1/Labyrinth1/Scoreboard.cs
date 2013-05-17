using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;

namespace Labyrinth
{
    public class Scoreboard
    {
        public string Show(string fileName)
        {
            var players = new List<Player>();
            ReadScores(fileName, players);

            var sb = new StringBuilder();
            var count = 0;
            players.ForEach(p =>
            {
                sb.AppendFormat("{0}: {1}" + Environment.NewLine, ++count, p.ToString());
            });

            return sb.ToString();
        }

        public void Add(string fileName, Player player)
        {
            var players = new List<Player>();
            ReadScores(fileName, players);

            players.Add(new Player(new Position(Configuration.GameFieldSize / 2, Configuration.GameFieldSize / 2))
            {
                Name = player.Name,
                Points = player.Points
            });

            CreateFile(fileName, players);
        }

        private static void CreateFile(string fileName, IEnumerable<Player> players)
        {
            using (var writer = new StreamWriter(fileName, false))
            {
                players.OrderBy(p => p.Points).Take(5).ToList().ForEach(p =>
                    {
                        writer.WriteLine(p.ToString());
                    });
            }
        }

        private static void ReadScores(string fileName, ICollection<Player> players)
        {
            if (!File.Exists(fileName))
            {
                CreateFile(fileName, players);
            }

            using (var reader = new StreamReader(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var nameAndPoints = line.Split();
                    players.Add(new Player(new Position(Configuration.GameFieldSize / 2, Configuration.GameFieldSize / 2))
                    {
                        Name = nameAndPoints[0],
                        Points = Int32.Parse(nameAndPoints[2])
                    });
                }
            }
        }
    }
}