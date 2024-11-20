using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Final_Mood_Fodd_Tracker
{
    public partial class Start : Form
    {
        public static string userName;
        
        public Start()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            userName = textBoxNicknameUser.Text;
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }
    }
}
