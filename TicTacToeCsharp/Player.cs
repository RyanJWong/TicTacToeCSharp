using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeCsharp
{
    public class Player
    {
        public string Name { get; set; }
        public int PlayerNumber { get; set; }

        public Player (string name, int number)
        {
            Name = name;
            PlayerNumber = number;
        }
    }
}
