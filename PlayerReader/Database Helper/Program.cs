using System.Data;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
using System.Reflection;

namespace PlayerReader
{
    class Program
    {
        static void Main(string[] args)
        {
            var directory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string path = Path.Combine(directory, "input/PlayerData.csv");
            IEnumerable<string> playerFile = File.ReadAllLines(path).Skip(1);
            List<Players> players = new List<Players>();

            foreach (string playerLine in playerFile)
            {
                string name = playerLine.ToString().Split(',')[0];
                uint number = Convert.ToUInt16(playerLine.ToString().Split(',')[1]);
                string position = playerLine.ToString().Split(',')[2];
                string sport = playerLine.ToString().Split(',')[3];

                players.Add(new Players (name, number, position, sport));
            }

            Console.WriteLine("These are the players on file:");
            foreach (Players player in players)
            {
                Console.WriteLine(player.ToString());
            }

            Console.ReadKey();
        }
        
    }
}
