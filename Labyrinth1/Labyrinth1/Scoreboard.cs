﻿using System;
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
            int count = 0;
            players.ForEach(p =>
                {
                    sb.AppendFormat("{0}: {1} -> {2}" + Environment.NewLine, ++count, p.Name, p.Points);
                });
           
            return sb.ToString();
        }
        
        public void Add(string fileName, Player player)
        {
            var players = new List<Player>();

            ReadScores(fileName, players);

            players.Add(new Player()
            {
                Name = player.Name,
                Points = player.Points
            });

            using (var writer = new StreamWriter(fileName))
            {
                players.OrderBy(p => p.Points).Take(5).ToList().ForEach(p =>
                    {
                        writer.WriteLine("{0} {1}", p.Name, p.Points);
                    });
            }
        }

        private static void ReadScores(string fileName, List<Player> players)
        {
            using (var reader = new StreamReader(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var nameAndPoints = line.Split();
                    players.Add(new Player()
                        {
                            Name = nameAndPoints[0],
                            Points = Int32.Parse(nameAndPoints[1])
                        });
                }
            }
        }
    }
}