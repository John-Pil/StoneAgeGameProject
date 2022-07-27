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
    public partial class PlayerInfo : Form
    {
        
        public static int currentPlayer = 1;
        Button colorUsed = null;

        public PlayerInfo()
        {
            InitializeComponent();
        }

        private void Color1_Click(object sender, EventArgs e)
        {
            SetColors(Color1.BackColor);
            colorUsed = Color1;
        }

        private void Color2_Click(object sender, EventArgs e)
        {
            SetColors(Color2.BackColor);
            colorUsed = Color1;
        }

        private void Color3_Click(object sender, EventArgs e)
        {
            SetColors(Color3.BackColor);
            colorUsed = Color1;
        }

        private void Color4_Click(object sender, EventArgs e)
        {
            SetColors(Color4.BackColor);
            colorUsed = Color1;
        }

        private void Color5_Click(object sender, EventArgs e)
        {
            SetColors(Color5.BackColor);
            colorUsed = Color1;
        }

        private void Color6_Click(object sender, EventArgs e)
        {
            SetColors(Color6.BackColor);
            colorUsed = Color1;
        }

        private void Color7_Click(object sender, EventArgs e)
        {
            SetColors(Color7.BackColor);
            colorUsed = Color1;
        }

        private void Color8_Click(object sender, EventArgs e)
        {
            SetColors(Color8.BackColor);
            colorUsed = Color1;
        }

        private void Color9_Click(object sender, EventArgs e)
        {
            SetColors(Color9.BackColor);
            colorUsed = Color1;
        }

        private void SetColors(Color color)
        {
            int player = 0;
            switch (PlayerNumber.Text)
            {
                case "Player 1":
                    player = 0;
                    break;
                case "Player 2":
                    player = 1;
                    break;
                case "Player 3":
                    player = 2;
                    break;
                case "Player 4":
                    player = 3;
                    break;

            }
            Players.players[player].name = PlayerNameText.Text;
            Players.players[player].color = color;
            Players.players[player].number = player;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            colorUsed.Enabled = false; 
            if(currentPlayer == Players.numPlayers)
            {
                Game_Board gameBoard = new Game_Board(Players.players);
                this.Hide();
                gameBoard.ShowDialog();
                
                this.Close();
                
            }
            else
            {
                currentPlayer++;
                PlayerNumber.Text = "Player " + currentPlayer;
                PlayerNameText.Clear();
            }
        }        
    }
}
