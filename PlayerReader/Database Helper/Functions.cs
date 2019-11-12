using System;
using System.Collections.Generic;
using System.Text;

namespace PlayerReader
{
    class Functions
    {
        internal static Dictionary<string, Players> AddAPlayer(Dictionary<string, Players> players)
        {
            Console.WriteLine("What is the player's name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is the player's jersey number?");
            int number = 0;
            while (number == 0)
            {
                if (int.TryParse(Console.ReadLine(), out number))
                {
                    if (number > 99 || number < 1)
                    {
                        Console.WriteLine("This is not valid, this must be a number between 1-99");
                        number = 0;
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("This is not valid, this must be a number between 1-99");
                    number = 0;
                    continue;
                }
            }
            Console.WriteLine("What sport does the player play?");
            string sport = Console.ReadLine();
            Console.WriteLine("What position does the player play?");
            string position = Console.ReadLine();
            
            players.Add(name, new Players(name, number, position, sport));
            return players;
        }
        internal static Dictionary<string, Players> DeleteAPlayer(Dictionary<string, Players> players)
        {
            Console.WriteLine("What is the player's name that you would like to delete?");
            string name = Console.ReadLine();
            players.Remove(name);

            return players;
        }


    }
}
