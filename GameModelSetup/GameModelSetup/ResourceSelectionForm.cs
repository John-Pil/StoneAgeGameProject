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
    public partial class ResourceSelectionForm : Form
    {
        //values of the counters 
        public int wood = 0, stone = 0, clay = 0, gold = 0;

        //passed conditions for the form
        public int typesRequired, totalRequired;

        //bools to determine if a resource type is being used
        bool woodUsed, stoneUsed, clayUsed, goldUsed; 

        public ResourceSelectionForm(int maxWood, int maxStone, int maxClay, int maxGold, int totalRequired, int typesRequired = 0)
        {
            InitializeComponent();
            this.totalRequired = totalRequired;
            this.typesRequired = typesRequired;
            woodCounter.Maximum = maxWood;
            stoneCounter.Maximum = maxStone;
            clayCounter.Maximum = maxClay;
            goldCounter.Maximum = maxGold;
        }

        private void AccButton_Click(object sender, EventArgs e)
        {
            wood = (int)woodCounter.Value;
            stone = (int)stoneCounter.Value;
            clay = (int)clayCounter.Value;
            gold = (int)goldCounter.Value;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void EndButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }


        private void woodCounter_ValueChanged(object sender, EventArgs e) 
        {
            if (woodCounter.Value > 0)
            {
                woodUsed = true;
            }
            else 
            {
                woodUsed = false;
            }
            counterValueChanged();
        }
        private void stoneCounter_ValueChanged(object sender, EventArgs e)
        {
            if (stoneCounter.Value > 0)
            {
                stoneUsed = true;
            }
            else
            {
                stoneUsed = false;
            }
            counterValueChanged();
        }
        private void clayCounter_ValueChanged(object sender, EventArgs e)
        {
            if (clayCounter.Value > 0)
            {
                clayUsed = true;
            }
            else
            {
                clayUsed = false;
            }
            counterValueChanged();
        }
        private void goldCounter_ValueChanged(object sender, EventArgs e)
        {
            if (goldCounter.Value > 0)
            {
                goldUsed = true;
            }
            else
            {
                goldUsed = false;
            }
            counterValueChanged();
        }

        private void counterValueChanged()
        {
            //check to see if the required number of resource types are used
            //if so prevent the unused resources from being used
            //otherwise reenable all counters to allow selection
            if (typesRequired != 0) 
            {
                int currentTypes = 0;
                if (woodUsed) 
                    typesRequired++;
                if (stoneUsed)
                    typesRequired++;
                if (clayUsed)
                    typesRequired++;
                if (goldUsed)
                    typesRequired++;

                if (currentTypes == typesRequired)
                {
                    woodCounter.Enabled = woodUsed;
                    stoneCounter.Enabled = stoneUsed;
                    clayCounter.Enabled = clayUsed;
                    goldCounter.Enabled = goldUsed;
                }
                else 
                {
                    woodCounter.Enabled = true;
                    stoneCounter.Enabled = true;
                    clayCounter.Enabled = true;
                    goldCounter.Enabled = true;
                }
            }

            //if the required number of resources have been selected
            //allow the user to submit the form otherwise don't allow submission
            if (totalRequired == (woodCounter.Value + stoneCounter.Value + clayCounter.Value + goldCounter.Value))
            {
                AccButton.Enabled = true;
            }
            else 
            {
                AccButton.Enabled = false;
            }

        }
    }
}
