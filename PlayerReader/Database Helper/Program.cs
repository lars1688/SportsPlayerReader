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
            Dictionary<string, Players> players = new Dictionary<string, Players>();

            foreach (string playerLine in playerFile)
            {
                string name = playerLine.ToString().Split(',')[0];
                int number = Convert.ToUInt16(playerLine.ToString().Split(',')[1]);
                string position = playerLine.ToString().Split(',')[2];
                string sport = playerLine.ToString().Split(',')[3];

                players.Add(name, new Players (name, number, position, sport));
            }

            Console.WriteLine("These are the players on file:");
            foreach (Players player in players.Values)
            {
                Console.WriteLine(player.ToString());
            }

            int options = 0;
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Add a player to file");
            options++;
            Console.WriteLine("2. Delete a player from file");
            options++;

            int x = 0;
            while (x == 0)
            {
                if (int.TryParse(Console.ReadLine(), out x))
                {
                    if(x > options || x < 1)
                    {
                        Console.WriteLine("This is not valid, the valid options are 1-2");
                        x = 0;
                        continue;
                    }                    
                }
                else
                {
                    Console.WriteLine("This is not valid, the valid options are 1-2");
                    x = 0;
                    continue;
                }
            }

            switch (x)
            {
                case 1:
                    players = Functions.AddAPlayer(players);
                    break;
                case 2:
                    players = Functions.DeleteAPlayer(players);
                    break;
            }

            Console.WriteLine("These are the players on file:");
            foreach (Players player in players.Values)
            {
                Console.WriteLine(player.ToString());
            }

            Console.ReadKey();
        }
        
    }
}
