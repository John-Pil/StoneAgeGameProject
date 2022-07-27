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
    public partial class UseToolsForm : Form {
        public int usedIdx = 0; // will be accessed after form is closed to determine which tool was used
        private (int val, bool used)[] tools;
        public UseToolsForm((int val, bool used)[] tools) {
            InitializeComponent();
            this.tools = tools;
            // initalize tool values
            lblValue1.Text = tools[0].val.ToString(); 
            lblValue2.Text = tools[1].val.ToString();
            lblValue3.Text = tools[2].val.ToString();
        }

        private void pbToolClick(object sender, EventArgs e) {
            PictureBox pb = sender as PictureBox;
            if (pb.Name == pbTool1.Name) 
                usedIdx = 1;
            else if (pb.Name == pbTool2.Name)
                usedIdx = 2;
            // can't use tools that have already been used
            // we should also have some graphical indication that the tool has been used (to do!!)
            if (tools[usedIdx].used) {
                MessageBox.Show("This tool has already been used!");
                usedIdx = 0; 
                return; 
            }
            this.Close();
        }
    }
}
