using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bot0
{
    internal class Players
    {
        string[] players;
        string[] turns;
        public bool remind(string player)
        {
            foreach (string i in players)
                if (i == player)
                    return true;
            return false;
        }
        public void new_ones(string player1, string player2)
        {
            players = new string[]{player1, player2};
        }
    }
}
