using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace The_Game_Management_System.Classes
{
    public class Enum
    {
        string gameType;

        public Enum() { }

        public Enum(string gameType)
        {
            this.gameType = gameType;
        }

        public string GameType { get => gameType; set => gameType = value; }
    }
}
