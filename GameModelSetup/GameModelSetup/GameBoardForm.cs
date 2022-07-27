using IsaiahsPartOfProject;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GameModelSetup
{
    public partial class Game_Board : Form
    {

        private GameClass game;
        private int phase = 0, round = 0, playerTurn = 0;
        public string placementRegion="";
        public bool placementDone=false;
        
        
        public Game_Board(List<PlayerClass> players)
        {
            InitializeComponent();
            game = new GameClass(players);
            Load_Player(game.currentPlayer.number);
            
        }

        

        private void CheckWorkers()
        {
            for(int i=0;i<game.getPlayers();i++)
            {
                if(Players.players[i].workersAvail==0)
                {
                    placementDone = true;
                }
                else
                {
                    placementDone = false;
                    break;
                }
            }
        }

        private void btnEndTurn_Click(object sender, EventArgs e)
        {
            CheckWorkers();
            
            playerTurn++;
            placementRegion = "";

            if (game.currentPlayer.score >= 100) 
            {
                Hide();
                //WinningForm winForm = new WinningForm(game.currentPlayer.name);
                //winForm.Show();
                Close();
            }

            if (playerTurn % game.getPlayers() == 0) 
            {
                playerTurn = 0;
                if (phase == 2)
                {
                    phase = 0;
                    round++;
                }
                else if(placementDone==true)
                {
                    phase++;
                }
            }

            game.changeCurrentPlayer(playerTurn, round);
            
            if (phase == 0)
            {
                PlacementPhase();
                

            }
            else if (phase == 1)
            {
                ResolutionPhase();
                phase++;
                Load_Player(game.currentPlayer.number);
            }
            else 
            {
                FoodPhase();
                Load_Player(game.currentPlayer.number);
            }

        }
        private void reloadGameBoard()
        {
            Load_Player(game.currentPlayer.number);
            player1SleepButton.BackColor = SystemColors.Control;
            player2SleepButton.BackColor = SystemColors.Control;
            player3SleepButton.BackColor = SystemColors.Control;
            player4SleepButton.BackColor = SystemColors.Control;
            req1Button.BackColor = SystemColors.Control;
            req2Button.BackColor = SystemColors.Control;
            req3Button.BackColor = SystemColors.Control;
            req4Button.BackColor = SystemColors.Control;
            req5Button.BackColor = SystemColors.Control;
            req6Button.BackColor = SystemColors.Control;
            req7Button.BackColor = SystemColors.Control;
            des1Button.BackColor = SystemColors.Control;
            des2Button.BackColor = SystemColors.Control;
            des3Button.BackColor = SystemColors.Control;
            des4Button.BackColor = SystemColors.Control;
            des5Button.BackColor = SystemColors.Control;
            des6Button.BackColor = SystemColors.Control;
            des7Button.BackColor = SystemColors.Control;
            imp1Button.BackColor = SystemColors.Control;
            imp2Button.BackColor = SystemColors.Control;
            imp3Button.BackColor = SystemColors.Control;
            imp4Button.BackColor = SystemColors.Control;
            imp5Button.BackColor = SystemColors.Control;
            imp6Button.BackColor = SystemColors.Control;
            imp7Button.BackColor = SystemColors.Control;
            tes1Button.BackColor = SystemColors.Control;
            tes2Button.BackColor = SystemColors.Control;
            tes3Button.BackColor = SystemColors.Control;
            tes4Button.BackColor = SystemColors.Control;
            tes5Button.BackColor = SystemColors.Control;
            tes6Button.BackColor = SystemColors.Control;
            tes7Button.BackColor = SystemColors.Control;
            hrButton.BackColor = SystemColors.Control;
            rubberDuckyButton.BackColor = SystemColors.Control;
            sleepingPodButton.BackColor = SystemColors.Control;

        }
        
        /// <summary>
        /// Allows users to select a tool to use. Should be called by whatever event we want to use to use tools, probably a button. 
        /// </summary>
        private void UseTools() {
            UseToolsForm fatForm = new UseToolsForm(game.currentPlayer.tools);
            fatForm.ShowDialog();
            int idx = fatForm.usedIdx;
            game.currentPlayer.tools[idx].used = true;

            // we can now use the value of this tool to do whatever we want

            //placeholder to show function
            MessageBox.Show("Used tool with value: " + game.currentPlayer.tools[idx].value);
        }

        #region Phases

        private void PlacementPhase() 
        {
            Load_Player(game.currentPlayer.number);
        }
        private void Load_Player(int num)
        {
            sleepFoodTextBox.Text = Players.players[num].food.ToString();
            requirementsWoodTextBox.Text = Players.players[num].wood.ToString();
            designClayTextBox.Text = Players.players[num].clay.ToString();
            implementationStoneTextBox.Text = Players.players[num].stone.ToString();
            testingGoldTextBox.Text = Players.players[num].gold.ToString();
            tool1TextBox.Text = Players.players[num].tools[0].ToString();
            tool2TextBox.Text = Players.players[num].tools[1].ToString();
            tool3TextBox.Text = Players.players[num].tools[2].ToString();
            tbPlayerName.Text = "Player " + Players.players[num].name + "'s turn";
            String holder = (Players.players[game.currentPlayer.number].workersAvail).ToString(); unusedPersonnelTextBox.Text = holder;

            placementRegion = "";
            placementDone = false;
            Player0Textbox.Text = Players.players[0].name + "'s Score: " + Players.players[0].score;
            Player0Textbox.ForeColor = Players.players[0].color;

            if (Players.numPlayers > 1)
            {
                Player1Textbox.Text = Players.players[1].name + "'s Score: " + Players.players[1].score;
                Player1Textbox.ForeColor = Players.players[1].color;
            }
            if (Players.numPlayers > 2)
            {
                Player2Textbox.Text = Players.players[2].name + "'s Score: " + Players.players[2].score;
                Player2Textbox.ForeColor = Players.players[2].color;
            }
            if (Players.numPlayers > 3)
            {
                Player3Textbox.Text = Players.players[3].name + "'s Score: " + Players.players[3].score;
                Player3Textbox.ForeColor = Players.players[3].color;
            }
        }

        private void PlaceWorkers(object sender, EventArgs e) {
            Button btn = (Button)sender; // button that the user pressed, we don't know or care what it is 
            string region = "";
            int workerCost = 1;

            // set region name from button name 
            if (char.IsDigit(btn.Name[3])) { // if normal resource 
                region = btn.Name.Substring(0, 3);
                region = char.ToUpper(region[0]) + region.Substring(1); // capitalize first letter of this region to match existing code
            }
            else if (btn.Name == "hrButton") {
                region = "HR";
                workerCost = 2;
            }
            else if (btn.Name == "sleepingPodButton") {
                region = "sleepingPod";
            }
            else if (btn.Name == "rubberDuckyButton") {
                region = "rubberDucky";
            }
            else if (btn.Name.Contains("SleepButton")) {
                region = "Sleep" + btn.Name[6]; // gets number of player 
            }

            // don't let users place workers on spots they already occupy 
            if (btn.BackColor == Players.players[game.currentPlayer.number].color) {
                MessageBox.Show("Oi matey there's already a dude there.");
                return;
            }

            // don't allow users to overwrite other workers -- that would be bad 
            if (btn.BackColor != SystemColors.Control) {
                MessageBox.Show("Theft is bad and this game does not allow murder (:");
                return;
            }

            if (placementRegion == "" || placementRegion == region) {
                placementRegion = region; // might be sometimes be unnecessary, but i promise that this is far from the most
                                          // pressing performance issue. hmu when we start using this game to model fluid simulations 
                if (Players.players[game.currentPlayer.number].workersAvail >= workerCost) {
                    btn.BackColor = (Players.players[game.currentPlayer.number].color);
                    Players.players[game.currentPlayer.number].workersAvail -= workerCost;
                    String holder = (Players.players[game.currentPlayer.number].workersAvail).ToString(); 
                    unusedPersonnelTextBox.Text = holder;

                    switch (region) {
                        case "HR":
                            Players.players[game.currentPlayer.number].workersOnHR += workerCost;
                            break;
                        case "sleepingPod":
                            Players.players[game.currentPlayer.number].workersOnSleepPod += workerCost;
                            break;
                        case "rubberDucky":
                            Players.players[game.currentPlayer.number].workersOnRubberDuck += workerCost;
                            break;
                        case "Des":
                            Players.players[game.currentPlayer.number].workersOnDes += workerCost;
                            break;
                        case "Imp":
                            Players.players[game.currentPlayer.number].workersOnImp += workerCost;
                            break;
                        case "Tes":
                            Players.players[game.currentPlayer.number].workersOnTes += workerCost;
                            break;
                        case "Req":
                            Players.players[game.currentPlayer.number].workersOnReq += workerCost;
                            break;
                    }

                    if (region.StartsWith("Sleep"))
                        Players.players[game.currentPlayer.number].workersOnSleep += workerCost;
                }
                else {
                    MessageBox.Show("You have already placed all your workers. Hit END TURN button.");
                }
            }
            else {
                if (region.StartsWith("Sleep")) {
                    MessageBox.Show("Only one sleeping pod can be selected per turn");
                    return;
                }
                MessageBox.Show("You cannot place workers in 2 regions during a turn");
            }
        }

        private void ProjCompletButton_Click(object sender, EventArgs e)
        {

        }

        private void CustCollabButton_Click(object sender, EventArgs e)
        {

        }

        private void playerCards_onClick(object sender, EventArgs e)
        {
            if (!Players.players[game.currentPlayer.number].checkBuildingCard() && !Players.players[game.currentPlayer.number].checkCivCard())
            {
                MessageBox.Show("You currently have no cards.");
            }
            else
            {
                MessageBox.Show("Civ Cards:  " + Players.players[game.currentPlayer.number].countCivCards() + "  Building Cards:  " +
                    Players.players[game.currentPlayer.number].countBuildingCards());
            }
        }

        private void availableCards_onClick(object sender, EventArgs e)
        {
            CardDisplayForm cdf = new CardDisplayForm(game);
            cdf.ShowDialog();
        }

        private void ResolutionPhase() 
        {
            MessageBox.Show("The dice will now be rolled to gain resources");
            int sleep = 0, requirements = 0, design = 0, implementation = 0, testing = 0;
            int diceTotal=0;
            Random r = new Random();
            for(int i=0;i<game.getPlayers();i++)
            {
                diceTotal = 0;
                for (int a=1;a<Players.players[i].workersOnSleep;a++)
                {
                    diceTotal += r.Next(1, 7);
                }

                if (Players.players[i].workersOnSleep > 0) {
                    RollsForm f = new RollsForm(Players.players[i], "sleep", diceTotal, 2);
                    f.ShowDialog();
                    sleep = f.result; 
                }

                diceTotal = 0;

                for (int a = 1; a < Players.players[i].workersOnReq; a++)
                {
                    diceTotal += r.Next(1, 7);
                }                

                if (Players.players[i].workersOnReq > 0) {
                    RollsForm f = new RollsForm(Players.players[i], "requirements", diceTotal, 2);
                    f.ShowDialog();
                    requirements = f.result;
                }

                diceTotal = 0;
                for (int a = 1; a < Players.players[i].workersOnDes; a++)
                {
                    diceTotal += r.Next(1, 7);
                }
                
                if (Players.players[i].workersOnDes > 0) {
                    RollsForm f = new RollsForm(Players.players[i], "design", diceTotal, 3);
                    f.ShowDialog();
                    design = f.result; 
                }

                diceTotal = 0;
                for (int a = 1; a < Players.players[i].workersOnImp; a++)
                {
                    diceTotal += r.Next(1, 7);
                }

                if (Players.players[i].workersOnImp > 0) {
                    RollsForm f = new RollsForm(Players.players[i], "implementation", diceTotal, 4);
                    f.ShowDialog();
                    implementation = f.result; 
                }

                diceTotal = 0;
                for (int a = 1; a < Players.players[i].workersOnTes; a++)
                {
                    diceTotal += r.Next(1, 7);
                }

                if (Players.players[i].workersOnTes > 0) {
                    RollsForm f = new RollsForm(Players.players[i], "testing", diceTotal, 6);
                    f.ShowDialog();
                    testing = f.result;
                }

                Players.players[i].AddResources(sleep, requirements, design, implementation, testing);
                if(Players.players[i].workersOnHR>0)
                {
                    Players.players[i].workers += 1;
                    Players.players[i].workersAvail += 1;
                }
                if (Players.players[i].workersOnSleepPod > 0)
                {
                    Players.players[i].incrementAgriculture();
                }
                if (Players.players[i].workersOnRubberDuck > 0)
                {
                    Players.players[i].AddTool();
                }
                // reset things so the things do the right things 
                Players.players[i].workersAvail = Players.players[i].workers;
                Players.players[i].workersOnDes = 0; 
                Players.players[i].workersOnHR = 0; 
                Players.players[i].workersOnImp = 0; 
                Players.players[i].workersOnReq = 0; 
                Players.players[i].workersOnRubberDuck = 0; 
                Players.players[i].workersOnSleep = 0; 
                Players.players[i].workersOnSleepPod = 0; 
                Players.players[i].workersOnTes = 0;
                Players.players[i].tools[0].used = false;
                Players.players[i].tools[1].used = false;
                Players.players[i].tools[2].used = false;
            }
        }

        /// <summary>
        /// Simulates last phase of a round where food is added based on agriculture level
        /// and then calculated to see if the workers are able to eat.
        /// </summary>
        private void FoodPhase() 
        {
            for(int i=0;i<game.getPlayers();i++)
            {
                Players.players[i].AddFood(game.currentPlayer.agriLevel);
                int unfedWorkers = game.currentPlayer.DeductFood();

                if (unfedWorkers != 0)
                {
                    if (MessageBox.Show("There are " + unfedWorkers + " unfed workers. Use resources instead?", "Unfed Workers", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        ResourceSelectionForm foodSelector = new ResourceSelectionForm(game.currentPlayer.wood, game.currentPlayer.stone, game.currentPlayer.clay, game.currentPlayer.gold, unfedWorkers);
                        foodSelector.ShowDialog();
                        if (foodSelector.DialogResult == DialogResult.OK)
                        {
                            game.currentPlayer.DeductResources(foodSelector.wood, foodSelector.stone, foodSelector.clay, foodSelector.gold);
                        }
                        else
                        {
                            game.currentPlayer.score -= 10;
                        }
                    }
                    else
                    {
                        game.currentPlayer.score -= 10;
                    }
                }
            }
            
            reloadGameBoard();
        }

        #endregion
    }
}
