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

namespace GameModelSetup {
    public partial class RollsForm : Form {
        PlayerClass p;
        string res;
        int rollVal;
        int div;
        public int result; 
        public RollsForm(PlayerClass player, string resource, int roll, int divisor) {
            InitializeComponent();
            p = player;
            res = resource;
            rollVal = roll;
            div = divisor;
            lblResults.Text = $"{p.name} rolled {roll} for {roll}/{div} = {roll / div} {res}/s";
            result = roll / div; 
        }

        private void RollsForm_Load(object sender, EventArgs e) {

        }

        private void btnUseTool_Click(object sender, EventArgs e) {
            UseToolsForm f = new UseToolsForm(p.tools);
            f.ShowDialog();
            int idx = f.usedIdx;
            rollVal += p.tools[idx].value;
            result = rollVal / div;
            lblToolUpdate.Text = "+ " + p.tools[idx].value + " from tool = " + result; 
        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.Close(); 
        }
    }
}
