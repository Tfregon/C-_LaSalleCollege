using System.Data;
using System.Net;
using System.Security.Cryptography;
using System.Windows.Forms;
using The_Game_Management_System.Classes;

namespace The_Game_Management_System
{
    public partial class Form1 : Form
    {
        GameManager gm = new GameManager();
        ManagerUser um = new ManagerUser();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Game game = new Game();
            game.GameId = game.GameId = Convert.ToInt32(textBoxGameId.Text);
            game.TitleName = textBoxTitle.Text;
            game.TypeOfGame = textBoxTypeOfGame.Text;
            game.ReleaseYear = dateTimePickerReleaseDate.Value;
            //game.GameType = textBoxGameType.Text;

            gm.addGame(game);
            gm.GamesDict.Add(game.TitleName, game.TypeOfGame);

            loadData();
            clearText();
        }

        private void loadData()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Title");
            dt.Columns.Add("Type Of Game");
            dt.Columns.Add("Release Year");

            foreach (Game game in gm.GamesList)
            {
                dt.Rows.Add(game.GameId, game.TitleName, game.TypeOfGame, game.ReleaseYear);
            }

            dataGridView1.DataSource = dt;
        }


        private void clearText()
        {
            textBoxTitle.Clear();
            textBoxTypeOfGame.Clear();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int selectedId = Convert.ToInt32(textBoxGameId.Text);
            foreach (Game game in gm.GamesList)
            {
                if (game.GameId == selectedId)
                {
                    gm.GamesList.Remove(game);
                    break;
                }
                else
                {
                    MessageBox.Show("There is not that Game Id!");
                }
            }
            Game newGame = new Game();
            newGame.GameId = Convert.ToInt32(textBoxGameId.Text);
            newGame.TitleName = textBoxTitle.Text;
            newGame.TypeOfGame = textBoxTypeOfGame.Text;
            newGame.ReleaseYear = dateTimePickerReleaseDate.Value;
            //game.GameType = textBoxGameType.Text;

            gm.addGame(newGame);

            loadData();
            clearText();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int selectedId = Convert.ToInt32(textBoxGameId.Text);
            foreach (Game game in gm.GamesList)
            {
                if (game.GameId == selectedId)
                {
                    gm.removeGame(game);
                    break;
                }
                else
                {
                    MessageBox.Show("There is not that Game Id!");
                }
            }
            loadData();
            clearText();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string title = textBoxTitleSearch.Text;
            string typeOfGameSearch = textBoxTypeOfGameSearch.Text;
            DataTable dtSearch = new DataTable();
            dtSearch.Columns.Add("Id");
            dtSearch.Columns.Add("Title");
            dtSearch.Columns.Add("Type Of Game");
            dtSearch.Columns.Add("Release Year");

            foreach (var game in gm.GamesDict)
            {
                if (game.Key.Contains(title) && game.Value.Contains(typeOfGameSearch))
                {
                    dtSearch.Rows.Add(game.Key, game.Value);
                }
            }

            dataGridViewSearch.DataSource = dtSearch;
            loadData();
            clearText();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonRegisterUser_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;

            foreach(Game game in gm.GamesList)
            {
                checkedListBoxGameInUser.Items.Add(game.TitleName);
            }
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            UserRegister user = new UserRegister();
            user.UserId = Convert.ToInt32(textBoxIdUser.Text);
            user.Name = textBoxUserName.Text;
            user.Genre = checkedListBoxGenreUser.Text;
            foreach (var game in gm.GamesList)
            {
                if(game.TitleName == checkedListBoxGameInUser.Text)
                {
                    user.Game = game;
                } 
            }

            DataTable dtUser = new DataTable();
            dtUser.Columns.Add("User Name");
            dtUser.Columns.Add("Title");
            
            foreach (UserRegister itemUser in um.UserGamesList)
            {
                dtUser.Rows.Add(itemUser);
            }

            dataGridView1.DataSource = dtUser;
        }

        private void buttonDelUser_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    } //Mrs I am stoping here Because I have another final exam.
}
