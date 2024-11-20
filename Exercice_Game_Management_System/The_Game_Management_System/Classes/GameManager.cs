using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Game_Management_System.Classes;

namespace The_Game_Management_System.Classes
{
    public class GameManager
    {
        private List<Game> gamesList = new List<Game>();
        private Dictionary<string, string> gamesDict = new Dictionary<string, string>();

        public List<Game> GamesList { get => gamesList; set => gamesList = value; }
        public Dictionary<string, string> GamesDict { get => gamesDict; set => gamesDict = value; }

        public GameManager() { }

        public GameManager(List<Game> gamesList, Dictionary<string, string> gamesDict)
        {
            this.gamesList = gamesList;
            this.gamesDict = gamesDict;
        }

        public void addGame(Game game)
        { 
            gamesList.Add(game);
        }

        public void removeGame(Game game) 
        {
            gamesList.Remove(game);
        }

        public  List<UserRegister> getAllGames() 
        {
            return gamesList;
        }
    }
}
