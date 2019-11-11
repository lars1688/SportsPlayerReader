using System;
using System.Collections.Generic;
using System.Text;

namespace PlayerReader
{
    class Players
    {
        public string PlayerName { get; private set; }

        public uint PlayerNumber { get; private set; }
        public string PlayerPosition { get; private set; }
        public string PlayerSport { get; private set; }

        public Players(string playerName, uint playerNumber, string playerPosition, string playerSport)
        {
            this.PlayerName = playerName;
            this.PlayerNumber = playerNumber;
            this.PlayerPosition = playerPosition;
            this.PlayerSport = playerSport;
        }

        public override string ToString()
        {
            string retString = PlayerName + " is number " + PlayerNumber.ToString() + " and plays " + PlayerSport + " at position " + PlayerPosition;
            return retString;
        }

    }
}
