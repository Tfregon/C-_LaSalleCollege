using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Game_Management_System.Classes
{
    public class ManagerUser
    {
        private List<UserRegister> userGamesList = new List<UserRegister>();
        private Dictionary<int, UserRegister > userGamesDict = new Dictionary<int, UserRegister>();
        public ManagerUser() { }

        public ManagerUser(List<UserRegister> userGamesList, Dictionary<int, UserRegister> userGamesDict)
        {
            this.userGamesList = userGamesList;
            this.userGamesDict = userGamesDict;
        }

        public List<UserRegister> UserGamesList { get => userGamesList; set => userGamesList = value; }
        public Dictionary<int, UserRegister> UserGamesDict { get => userGamesDict; set => userGamesDict = value; }

        public void addGame(UserRegister user)
        {
            userGamesList.Add(user);
        }

        public void removeGame(UserRegister user)
        {
            userGamesList.Remove(user);
        }
    }
}
