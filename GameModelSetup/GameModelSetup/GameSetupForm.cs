using IsaiahsPartOfProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameModelSetup
{
    public partial class Players : Form
    {
        public static List<PlayerClass> players = new List<PlayerClass>();
        public static int numPlayers = 2;

        public Players()
        {
            InitializeComponent();
        }

        private void Players2_Click(object sender, EventArgs e)
        {
            numPlayers = 2;
            PlayerClass player1 = new PlayerClass();
            PlayerClass player2 = new PlayerClass();
            players.Add(player1);
            players.Add(player2);
            PlayerInfo playersInfoForm = new PlayerInfo();
            this.Hide();
            playersInfoForm.ShowDialog();
            //this.Close();
        }

        private void Players3_Click(object sender, EventArgs e)
        {
            numPlayers = 3;
            PlayerClass player1 = new PlayerClass();
            PlayerClass player2 = new PlayerClass();
            PlayerClass player3 = new PlayerClass();
            players.Add(player1);
            players.Add(player2);
            players.Add(player3);
            PlayerInfo playersInfoForm = new PlayerInfo();
            this.Hide();
            playersInfoForm.ShowDialog();
            //this.Close();
        }

        private void Players4_Click(object sender, EventArgs e)
        {
            numPlayers = 4;
            PlayerClass player1 = new PlayerClass();
            PlayerClass player2 = new PlayerClass();
            PlayerClass player3 = new PlayerClass();
            PlayerClass player4 = new PlayerClass();
            players.Add(player1);
            players.Add(player2);
            players.Add(player3);
            players.Add(player4);
            PlayerInfo playersInfoForm = new PlayerInfo();
            this.Hide();
            playersInfoForm.ShowDialog();
            //this.Close();
        }
    }
}
