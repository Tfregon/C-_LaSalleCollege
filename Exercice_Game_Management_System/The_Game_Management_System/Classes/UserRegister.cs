using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Game_Management_System.Classes
{
    public class UserRegister
    {
        private int userId;
        private string name;
        private string genre;
        private Game game;

        public UserRegister() { }

        public UserRegister(int userId, string name, string genre, Game game)
        {
            this.userId = userId;
            this.name = name;
            this.genre = genre;
            this.game = game;
        }

        public int UserId { get => userId; set => userId = value; }
        public string Name { get => name; set => name = value; }
        public string Genre { get => genre; set => genre = value; }
        public Game Game { get => game; set => game = value; }
    }
}
