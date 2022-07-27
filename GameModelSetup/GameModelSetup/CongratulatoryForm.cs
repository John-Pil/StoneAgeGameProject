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
    public partial class WinningForm : Form
    {
        public WinningForm(string winner)
        {
            InitializeComponent();
            nameLabel.Text = winner;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            Hide();
            Players setupForm = new Players();
            setupForm.ShowDialog();
            Close();
        }
    }
}
