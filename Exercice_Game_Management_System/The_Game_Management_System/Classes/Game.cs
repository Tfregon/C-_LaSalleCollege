using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace The_Game_Management_System.Classes
{
    public class Game
    {
        private int gameId;
        private string titleName;
        private DateTime releaseYear;
        private float price;
        private Enum gameType; // solo ou multi
        private string typeOfGame; // adventure 

        public Game() { }

        public Game(int gameId, string titleName, DateTime releaseYear, float price, Enum gameType, string typeOfGame)
        {
            this.gameId = gameId;
            this.titleName = titleName;
            this.releaseYear = releaseYear;
            this.price = price;
            this.gameType = gameType;
            this.typeOfGame = typeOfGame;
        }

        public int GameId { get => gameId; set => gameId = value; }
        public string TitleName { get => titleName; set => titleName = value; }
        public DateTime ReleaseYear { get => releaseYear; set => releaseYear = value; }
        public float Price { get => price; set => price = value; }
        public Enum GameType { get => gameType; set => gameType = value; }
        public string TypeOfGame { get => typeOfGame; set => typeOfGame = value; }
    }
}
