using GameModelSetup;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsaiahsPartOfProject
{
    public class GameClass
    {
        public List<PlayerClass> gamePlayers = new List<PlayerClass>();
		
		/* Can we remove these two arrays? */
        //CivCardClass[] boardCivCards;
        //BuildingCardClass[] boardBuildCards;
		
        public List<CivCardClass> civCards;
        public List<BuildingCardClass> buildCards;
		public List<CivCardClass> civCardsOnBoard;
		public List<BuildingCardClass> buildCardsOnBoard;
        int wood, clay, stone, gold, food, tools, currentTurn;
        public PlayerClass currentPlayer;
		Random r = new Random(); 

        public GameClass(List<PlayerClass> players)
        {

            gamePlayers = players;
            gamePlayers.TrimExcess();
            currentPlayer = gamePlayers[0];
			
			civCards = new List<CivCardClass>();
			buildCards = new List<BuildingCardClass>();
			LoadCivCards();
			LoadBuildCards();
			
			civCardsOnBoard = new List<CivCardClass>();
			buildCardsOnBoard = new List<BuildingCardClass>();
			LoadCivCardOnBoard();
			LoadBuildCardOnBoard();
			
        }

        public int getPlayers() 
        {
            return gamePlayers.Count;
        }

        /// <summary>
        /// chooses the next player to go in the game by checking the number of players that have taken their turn
        /// and adjusting it by the current round number
        /// i.e round one order is 1,2,3,4 round two order is 2,3,4,1
        /// </summary>
        /// <param name="playerTurn">number of players that have fulfiled their turn in a phase</param>
        /// <param name="round">curren round in the game</param>
        public void changeCurrentPlayer(int playerTurn, int round) 
        {
            currentPlayer = gamePlayers[(playerTurn + round) % gamePlayers.Count];
        }
		
		///Summary:		Loads an populates the CivCards deck from BuildingLoad.txt CSV file
		///Paramater:	None
		///Returns:		None
		private void LoadCivCards()
		{
			string CivCardFileName = "..\\..\\CivCardLoad.txt";
			
			if(File.Exists(CivCardFileName))
			{
				string[] linesOfFile = File.ReadAllLines(CivCardFileName);
			
				foreach(string line in linesOfFile)
				{
					//Console.WriteLine("File line:  " + line);
					string[] valuesOnLine = line.Split(',');
					int[] values = new int[valuesOnLine.Length];
				
					for(int count = 0; count < valuesOnLine.Length; count++)
					{
						values[count] = Int32.Parse(valuesOnLine[count]);
						//Console.WriteLine("Array location:  " + count + "   Value stored:  " + values[count]);
					}
					bool needRoll;
					if (values[0] == 0)
						needRoll = false;
					else
						needRoll = true;

					civCards.Add(new CivCardClass(values[0], values[1], values[2], values[3], values[4], values[5], values[6], values[7]));
				}
			}
			else
				Console.WriteLine("File Not Found");
		}
		
		///Summary:		Loads an populates the BuildCards deck from BuildingLoad.txt CSV file
		///Paramater:	None
		///Returns:		None
		private void LoadBuildCards()
		{
			string BuildingFileName = "..\\..\\BuildingLoad.txt";
			
			if(File.Exists(BuildingFileName))
			{
				string[] linesOfFile = File.ReadAllLines(BuildingFileName);
			
				foreach(string line in linesOfFile)
				{
					//Console.WriteLine("File line:  " + line);
					string[] valuesOnLine = line.Split(',');
					int[] values = new int[valuesOnLine.Length];
				
					for(int count = 0; count < valuesOnLine.Length; count++)
					{
						values[count] = Int32.Parse(valuesOnLine[count]);
						//Console.WriteLine("Array location:  " + count + "   Value stored:  " + values[count]);
					}
				
					
					buildCards.Add(new BuildingCardClass(values[0], values[1], values[2], values[3], values[4], values[5], values[6], values[7], values[8]));
				}
			}
			else
				Console.WriteLine("File Not Found");
		}
		
		///Summary:		Randomly draws cards from the civCard deck according to the number of cards left in the deck
		///Paramater:	None
		///Returns:		One CivCardClass object
		private CivCardClass DrawCivCard()
		{
			int deckSize = civCards.Count;
			CivCardClass tempCard;
			tempCard = civCards[r.Next(0, deckSize - 1)];
			return tempCard;
		}
		
		///Summary:		Randomly draws cards from the buildCard deck according to the number of cards left in the deck
		///Paramater:	None
		///Returns:		One BuildingCardClass object
		private BuildingCardClass DrawBuildCard()
		{
			int deckSize = buildCards.Count;
			Random randomNum = new Random();
			BuildingCardClass buildCard;
			buildCard = buildCards[r.Next(0, deckSize - 1)];
			return buildCard;
		}
		
		///Summary:		Initially populates the civ card tiles on the board(default is 4), after initial population
		///				this method can take any argument to populate the board(should be 1)
		///Paramater:	Default value is 4 for initial load, subsequently should be a 1 to 1 ratio for draws
		///Returns:		Nothing
		private void LoadCivCardOnBoard(int numToLoad = 4)
		{
			for(int count = 0; count < numToLoad; count++)
				civCardsOnBoard.Add(DrawCivCard());
		}
		
		///Summary:  	Initially populates the building card tiles on the board(default is 4), after initial population
		///				this method can take any argument to populate the board(should be 1)
		///Paramater:	Default value is 4 for initial load, subsequently should be a 1 to 1 ratio for draws
		///Returns:		Nothing
		private void LoadBuildCardOnBoard(int numToLoad = 4)
		{
			for(int count = 0; count < numToLoad; count++)
				buildCardsOnBoard.Add(DrawBuildCard());
		}
		
		/// Summary:  	This will return a specified civ card that is on the board that a player wishes to draw.
		/// Paramater:  Takes the integer assigned spot of the card to return
		/// Returns:  	CivCardClass object
		public CivCardClass GivePlayerCivCard(int spotOfCard)
		{
			CivCardClass card;
			card = civCardsOnBoard[spotOfCard];
			LoadCivCardOnBoard(1);
			return card;
		}
		
		/// Summary:  	This will return a specified building card that is on the board that a player wishes to draw.
		/// Paramater:  Takes the integer assigned spot of the card to return
		/// Returns:  	BuildingCardClass object
		public BuildingCardClass GivePlayerBuildCard(int spotOfCard)
		{
			BuildingCardClass card;
			card = buildCardsOnBoard[spotOfCard];
			LoadBuildCardOnBoard(1);
			return card;
		}

    }
}
