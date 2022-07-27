using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IsaiahsPartOfProject;

namespace GameModelSetup
{
    public partial class CardDisplayForm : Form
    {
        public GameClass game;

        public CardDisplayForm(GameClass passGame)
        {
            game = passGame;
            InitializeComponent();
            this.buildCard1ScoreValue_Label.Text = "Score:  " + game.buildCardsOnBoard[0].score;
            this.buildCard2ScoreValue_Label.Text = "Score:  " + game.buildCardsOnBoard[1].score;
            this.buildCard3ScoreValue_Label.Text = "Score:  " + game.buildCardsOnBoard[2].score;
            this.buildCard4ScoreValue_Label.Text = "Score:  " + game.buildCardsOnBoard[3].score;
            this.buildCard1WoodCost_Label.Text = "Requirement Cost:  " + game.buildCardsOnBoard[0].woodCost;
            this.buildCard2WoodCost_Label.Text = "Requirement Cost:  " + game.buildCardsOnBoard[1].woodCost;
            this.buildCard3WoodCost_Label.Text = "Requirement Cost:  " + game.buildCardsOnBoard[2].woodCost;
            this.buildCard4WoodCost_Label.Text = "Requirement Cost:  " + game.buildCardsOnBoard[3].woodCost;
            this.buildCard1ClayCost_Label.Text = "Design Cost:  " + game.buildCardsOnBoard[0].clayCost;
            this.buildCard2ClayCost_Label.Text = "Design Cost:  " + game.buildCardsOnBoard[1].clayCost;
            this.buildCard3ClayCost_Label.Text = "Design Cost:  " + game.buildCardsOnBoard[2].clayCost;
            this.buildCard4ClayCost_Label.Text = "Design Cost:  " + game.buildCardsOnBoard[3].clayCost;
            this.buildCard1StoneCost_Label.Text = "Testing Cost:  " + game.buildCardsOnBoard[0].stoneCost;
            this.buildCard2StoneCost_Label.Text = "Testing Cost:  " + game.buildCardsOnBoard[1].stoneCost;
            this.buildCard3StoneCost_Label.Text = "Testing Cost:  " + game.buildCardsOnBoard[2].stoneCost;
            this.buildCard4StoneCost_Label.Text = "Testing Cost:  " + game.buildCardsOnBoard[3].stoneCost;
            this.buildCard1GoldCost_Label.Text = "Implementation Cost:  " + game.buildCardsOnBoard[0].goldCost;
            this.buildCard2GoldCost_Label.Text = "Implementation Cost:  " + game.buildCardsOnBoard[1].goldCost;
            this.buildCard3GoldCost_Label.Text = "Implementation Cost:  " + game.buildCardsOnBoard[2].goldCost;
            this.buildCard4GoldCost_Label.Text = "Implementation Cost:  " + game.buildCardsOnBoard[3].goldCost;
            this.buildCard1WildRange_Label.Text = "Wild Range:  " + game.buildCardsOnBoard[0].wildMin + " - " + game.buildCardsOnBoard[0].wildMax;
            this.buildCard2WildRange_Label.Text = "Wild Range:  " + game.buildCardsOnBoard[1].wildMin + " - " + game.buildCardsOnBoard[1].wildMax;
            this.buildCard3WildRange_Label.Text = "Wild Range:  " + game.buildCardsOnBoard[2].wildMin + " - " + game.buildCardsOnBoard[2].wildMax;
            this.buildCard4WildRange_Label.Text = "Wild Range:  " + game.buildCardsOnBoard[3].wildMin + " - " + game.buildCardsOnBoard[3].wildMax;
            this.buildCard1DiffRes_Label.Text = "Different Resources:  " + game.buildCardsOnBoard[0].reqDifferentResources;
            this.buildCard2DiffRes_Label.Text = "Different Resources:  " + game.buildCardsOnBoard[1].reqDifferentResources;
            this.buildCard3DiffRes_Label.Text = "Different Resources:  " + game.buildCardsOnBoard[2].reqDifferentResources;
            this.buildCard4DiffRes_Label.Text = "Different Resources:  " + game.buildCardsOnBoard[3].reqDifferentResources;
            this.civCard1Food_Label.Text = "Sleep:  " + game.civCardsOnBoard[0].addFood;
            this.civCard2Food_Label.Text = "Sleep:  " + game.civCardsOnBoard[1].addFood;
            this.civCard3Food_Label.Text = "Sleep:  " + game.civCardsOnBoard[2].addFood;
            this.civCard4Food_Label.Text = "Sleep:  " + game.civCardsOnBoard[3].addFood;
            this.civCard1Wood_Label.Text = "Requirements:  " + game.civCardsOnBoard[0].addWood;
            this.civCard2Wood_Label.Text = "Requirements:  " + game.civCardsOnBoard[1].addWood;
            this.civCard3Wood_Label.Text = "Requirements:  " + game.civCardsOnBoard[2].addWood;
            this.civCard4Wood_Label.Text = "Requirements:  " + game.civCardsOnBoard[3].addWood;
            this.civCard1Clay_Label.Text = "Design:  " + game.civCardsOnBoard[0].addClay;
            this.civCard2Clay_Label.Text = "Design:  " + game.civCardsOnBoard[1].addClay;
            this.civCard3Clay_Label.Text = "Design:  " + game.civCardsOnBoard[2].addClay;
            this.civCard4Clay_Label.Text = "Design:  " + game.civCardsOnBoard[3].addClay;
            this.civCard1Stone_Label.Text = "Testing:  " + game.civCardsOnBoard[0].addStone;
            this.civCard2Stone_Label.Text = "Testing:  " + game.civCardsOnBoard[1].addStone;
            this.civCard3Stone_Label.Text = "Testing:  " + game.civCardsOnBoard[2].addStone;
            this.civCard4Stone_Label.Text = "Testing:  " + game.civCardsOnBoard[3].addStone;
            this.civCard1Gold_Label.Text = "Implementation:  " + game.civCardsOnBoard[0].addGold;
            this.civCard2Gold_Label.Text = "Implementation:  " + game.civCardsOnBoard[1].addGold;
            this.civCard3Gold_Label.Text = "Implementation:  " + game.civCardsOnBoard[2].addGold;
            this.civCard4Gold_Label.Text = "Implementation:  " + game.civCardsOnBoard[3].addGold;
            this.civCard1Agri_Label.Text = "Sleep:  " + game.civCardsOnBoard[0].addAgriLevel;
            this.civCard2Agri_Label.Text = "Sleep:  " + game.civCardsOnBoard[1].addAgriLevel;
            this.civCard3Agri_Label.Text = "Sleep:  " + game.civCardsOnBoard[2].addAgriLevel;
            this.civCard4Agri_Level.Text = "Sleep:  " + game.civCardsOnBoard[3].addAgriLevel;
            this.civCard1Tool_Label.Text = "Rubber Duckies:  " + game.civCardsOnBoard[0].addTools;
            this.civCard2Tool_Label.Text = "Rubber Duckies:  " + game.civCardsOnBoard[1].addTools;
            this.civCard3Tool_Label.Text = "Rubber Duckies:  " + game.civCardsOnBoard[2].addTools;
            this.civCard4Tool_Label.Text = "Rubber Duckies:  " + game.civCardsOnBoard[3].addTools;
        }

        private void civCard1Select_Button_Click(object sender, EventArgs e)
        {
            if (game.civCardsOnBoard[0].needRoll == 1)
            {
                foreach (PlayerClass player in game.gamePlayers)
                {
                    Random r = new Random();
                    int addFood = 0, addWood = 0, addClay = 0, addStone = 0, addGold = 0;
                    switch (r.Next(1, 6))
                    {
                        case 1:
                            addWood = game.civCardsOnBoard[0].addWood;
                            break;
                        case 2:
                            addClay = game.civCardsOnBoard[0].addClay;
                            break;
                        case 3:
                            addStone = game.civCardsOnBoard[0].addStone;
                            break;
                        case 4:
                            addGold = game.civCardsOnBoard[0].addGold;
                            break;
                        case 5:
                            player.incrementAgriculture();
                            break;
                        case 6:
                            player.AddTool();
                            break;
                        default:

                            break;
                    }
                    player.AddResources(addFood, addWood, addClay, addStone, addGold);
                }
            }
            else if(game.civCardsOnBoard[0].addFood != 0)
            {
                game.currentPlayer.AddResources(game.civCardsOnBoard[0].addFood, 0, 0, 0, 0);
            }
            else if(game.civCardsOnBoard[0].addWood != 0)
            {
                game.currentPlayer.AddResources(0, game.civCardsOnBoard[0].addWood, 0, 0, 0);
            }
            else if(game.civCardsOnBoard[0].addClay != 0)
            {
                game.currentPlayer.AddResources(0, 0, game.civCardsOnBoard[0].addClay, 0, 0);
            }
            else if(game.civCardsOnBoard[0].addStone != 0)
            {
                game.currentPlayer.AddResources(0, 0, 0, game.civCardsOnBoard[0].addStone, 0);
            }
            else if(game.civCardsOnBoard[0].addGold != 0)
            {
                game.currentPlayer.AddResources(0, 0, 0, 0, game.civCardsOnBoard[0].addGold);
            }
            else if(game.civCardsOnBoard[0].addAgriLevel != 0)
            {
                game.currentPlayer.incrementAgriculture();
            }
            else if(game.civCardsOnBoard[0].addTools != 0)
            {
                game.currentPlayer.AddTool();
            }
            game.GivePlayerCivCard(0);
            // transfer info here
            this.Close();
        }

        private void civCard2Select_Button_Click(object sender, EventArgs e)
        {
            if (game.civCardsOnBoard[1].needRoll == 1)
            {
                foreach (PlayerClass player in game.gamePlayers)
                {
                    Random r = new Random();
                    int addFood = 0, addWood = 0, addClay = 0, addStone = 0, addGold = 0;
                    switch (r.Next(1, 6))
                    {
                        case 1:
                            addWood = game.civCardsOnBoard[1].addWood;
                            break;
                        case 2:
                            addClay = game.civCardsOnBoard[1].addClay;
                            break;
                        case 3:
                            addStone = game.civCardsOnBoard[1].addStone;
                            break;
                        case 4:
                            addGold = game.civCardsOnBoard[1].addGold;
                            break;
                        case 5:
                            player.incrementAgriculture();
                            break;
                        case 6:
                            player.AddTool();
                            break;
                        default:

                            break;
                    }
                    player.AddResources(addFood, addWood, addClay, addStone, addGold);
                }
            }
            else if (game.civCardsOnBoard[1].addFood != 0)
            {
                game.currentPlayer.AddResources(game.civCardsOnBoard[1].addFood, 0, 0, 0, 0);
            }
            else if (game.civCardsOnBoard[1].addWood != 0)
            {
                game.currentPlayer.AddResources(0, game.civCardsOnBoard[1].addWood, 0, 0, 0);
            }
            else if (game.civCardsOnBoard[1].addClay != 0)
            {
                game.currentPlayer.AddResources(0, 0, game.civCardsOnBoard[1].addClay, 0, 0);
            }
            else if (game.civCardsOnBoard[1].addStone != 0)
            {
                game.currentPlayer.AddResources(0, 0, 0, game.civCardsOnBoard[1].addStone, 0);
            }
            else if (game.civCardsOnBoard[1].addGold != 0)
            {
                game.currentPlayer.AddResources(0, 0, 0, 0, game.civCardsOnBoard[1].addGold);
            }
            else if (game.civCardsOnBoard[1].addAgriLevel != 0)
            {
                game.currentPlayer.incrementAgriculture();
            }
            else if (game.civCardsOnBoard[1].addTools != 0)
            {
                game.currentPlayer.AddTool();
            }
            game.GivePlayerCivCard(1);
            // transfer info here
            this.Close();
        }

        private void civCard3Select_Button_Click(object sender, EventArgs e)
        {
            if (game.civCardsOnBoard[2].needRoll == 1)
            {
                foreach (PlayerClass player in game.gamePlayers)
                {
                    Random r = new Random();
                    int addFood = 0, addWood = 0, addClay = 0, addStone = 0, addGold = 0;
                    switch (r.Next(1, 6))
                    {
                        case 1:
                            addWood = game.civCardsOnBoard[2].addWood;
                            break;
                        case 2:
                            addClay = game.civCardsOnBoard[2].addClay;
                            break;
                        case 3:
                            addStone = game.civCardsOnBoard[2].addStone;
                            break;
                        case 4:
                            addGold = game.civCardsOnBoard[2].addGold;
                            break;
                        case 5:
                            player.incrementAgriculture();
                            break;
                        case 6:
                            player.AddTool();
                            break;
                        default:

                            break;
                    }
                    player.AddResources(addFood, addWood, addClay, addStone, addGold);
                }
            }
            else if (game.civCardsOnBoard[2].addFood != 0)
            {
                game.currentPlayer.AddResources(game.civCardsOnBoard[2].addFood, 0, 0, 0, 0);
            }
            else if (game.civCardsOnBoard[2].addWood != 0)
            {
                game.currentPlayer.AddResources(0, game.civCardsOnBoard[2].addWood, 0, 0, 0);
            }
            else if (game.civCardsOnBoard[2].addClay != 0)
            {
                game.currentPlayer.AddResources(0, 0, game.civCardsOnBoard[2].addClay, 0, 0);
            }
            else if (game.civCardsOnBoard[2].addStone != 0)
            {
                game.currentPlayer.AddResources(0, 0, 0, game.civCardsOnBoard[2].addStone, 0);
            }
            else if (game.civCardsOnBoard[2].addGold != 0)
            {
                game.currentPlayer.AddResources(0, 0, 0, 0, game.civCardsOnBoard[2].addGold);
            }
            else if (game.civCardsOnBoard[2].addAgriLevel != 0)
            {
                game.currentPlayer.incrementAgriculture();
            }
            else if (game.civCardsOnBoard[2].addTools != 0)
            {
                game.currentPlayer.AddTool();
            }
            game.GivePlayerCivCard(2);
            // transfer info here
            this.Close();
        }

        private void civCard4Select_Button_Click(object sender, EventArgs e)
        {
            if (game.civCardsOnBoard[3].needRoll == 1)
            {
                foreach (PlayerClass player in game.gamePlayers)
                {
                    Random r = new Random();
                    int addFood = 0, addWood = 0, addClay = 0, addStone = 0, addGold = 0;
                    switch (r.Next(1, 6))
                    {
                        case 1:
                            addWood = game.civCardsOnBoard[3].addWood;
                            break;
                        case 2:
                            addClay = game.civCardsOnBoard[3].addClay;
                            break;
                        case 3:
                            addStone = game.civCardsOnBoard[3].addStone;
                            break;
                        case 4:
                            addGold = game.civCardsOnBoard[3].addGold;
                            break;
                        case 5:
                            player.incrementAgriculture();
                            break;
                        case 6:
                            player.AddTool();
                            break;
                        default:

                            break;
                    }
                    player.AddResources(addFood, addWood, addClay, addStone, addGold);
                }
            }
            else if (game.civCardsOnBoard[3].addFood != 0)
            {
                game.currentPlayer.AddResources(game.civCardsOnBoard[3].addFood, 0, 0, 0, 0);
            }
            else if (game.civCardsOnBoard[3].addWood != 0)
            {
                game.currentPlayer.AddResources(0, game.civCardsOnBoard[3].addWood, 0, 0, 0);
            }
            else if (game.civCardsOnBoard[3].addClay != 0)
            {
                game.currentPlayer.AddResources(0, 0, game.civCardsOnBoard[3].addClay, 0, 0);
            }
            else if (game.civCardsOnBoard[3].addStone != 0)
            {
                game.currentPlayer.AddResources(0, 0, 0, game.civCardsOnBoard[3].addStone, 0);
            }
            else if (game.civCardsOnBoard[3].addGold != 0)
            {
                game.currentPlayer.AddResources(0, 0, 0, 0, game.civCardsOnBoard[3].addGold);
            }
            else if (game.civCardsOnBoard[3].addAgriLevel != 0)
            {
                game.currentPlayer.incrementAgriculture();
            }
            else if (game.civCardsOnBoard[3].addTools != 0)
            {
                game.currentPlayer.AddTool();
            }
            game.GivePlayerCivCard(3);
            // transfer info here
            this.Close();
        }

        private void buildCard1Select_Button_Click(object sender, EventArgs e)
        {
            ResourceSelectionForm rsf = new ResourceSelectionForm(game.buildCardsOnBoard[0].woodCost, game.buildCardsOnBoard[0].stoneCost, game.buildCardsOnBoard[0].clayCost,
                game.buildCardsOnBoard[0].goldCost, game.buildCardsOnBoard[0].wildMax, game.buildCardsOnBoard[0].reqDifferentResources);
            game.GivePlayerBuildCard(0);
            this.Close();
        }

        private void buildCard2Select_Button_Click(object sender, EventArgs e)
        {
            ResourceSelectionForm rsf = new ResourceSelectionForm(game.buildCardsOnBoard[1].woodCost, game.buildCardsOnBoard[1].stoneCost, game.buildCardsOnBoard[1].clayCost,
                game.buildCardsOnBoard[1].goldCost, game.buildCardsOnBoard[1].wildMax, game.buildCardsOnBoard[1].reqDifferentResources);
            game.GivePlayerBuildCard(1);
            this.Close();
        }

        private void buildCard3Select_Button_Click(object sender, EventArgs e)
        {
            ResourceSelectionForm rsf = new ResourceSelectionForm(game.buildCardsOnBoard[2].woodCost, game.buildCardsOnBoard[2].stoneCost, game.buildCardsOnBoard[2].clayCost,
                game.buildCardsOnBoard[2].goldCost, game.buildCardsOnBoard[2].wildMax, game.buildCardsOnBoard[2].reqDifferentResources);
            game.GivePlayerBuildCard(2);
            this.Close();
        }

        private void buildCard4Select_Button_Click(object sender, EventArgs e)
        {
            ResourceSelectionForm rsf = new ResourceSelectionForm(game.buildCardsOnBoard[3].woodCost, game.buildCardsOnBoard[3].stoneCost, game.buildCardsOnBoard[3].clayCost,
                game.buildCardsOnBoard[3].goldCost, game.buildCardsOnBoard[3].wildMax, game.buildCardsOnBoard[3].reqDifferentResources);
            game.GivePlayerBuildCard(3);
            this.Close();
        }
    }
}
