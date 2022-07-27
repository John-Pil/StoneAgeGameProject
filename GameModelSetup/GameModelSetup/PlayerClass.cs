using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IsaiahsPartOfProject
{
	public class PlayerClass
	{
		public string name;
		public Color color;
		public int number;
		public int wood, stone, clay, gold, food, workers, agriLevel, score;
		public int workersAvail;
		public int workersOnSleep=0;
		public int workersOnReq=0;
		public int workersOnDes=0;
		public int workersOnImp=0;
		public int workersOnTes=0;
		public int workersOnHR=0;
		public int workersOnRubberDuck=0;
		public int workersOnSleepPod=0;
		public (int value, bool used)[] tools; // tuple for tool values and bool tracking whether they have already been used this turn
		List<CivCardClass> civCards;
		List<BuildingCardClass> buildingCards;
		public PlayerClass()
		{
			wood = 0;
			stone = 0;
			clay = 0;
			gold = 0;
			food = 12;
			workers = 5;
			agriLevel = 0;
			score = 0;
			workersAvail = 5;
			civCards = new List<CivCardClass>();
			buildingCards = new List<BuildingCardClass>();
			tools = new (int, bool)[3];
		}
		
		public void incrementAgriculture()
		{
			agriLevel++;
		}

		public void AddTool() {
			// if all tools have value of 4 we cannot add any more
			if (tools[2].value == 4)
				return;
			// if all zeros
			if (tools[0].value == 0) {
				tools[0].value = 1;
				return;
			}
			// increment first tool available
			for (int i = 0; i < 2; i++) {
				if (tools[i].value > tools[i + 1].value) {
					tools[i + 1].value++;
					return;
				}
			}
			// if all tools are the same value, we need to loop back to the start
			tools[0].value++;
		}

		public bool checkCivCard()
        {
			return civCards.Any();
        }

		public bool checkBuildingCard()
        {
			return buildingCards.Any();
        }

		public int countCivCards()
        {
			return civCards.Count();
        }

		public int countBuildingCards()
        {
			return buildingCards.Count();
        }
		/* Works in progress:
		void ReceiveCivCard(CivCardClass card)
		{
			civCards.Add(card);
			if (card.needRoll == 1)
			{
				Random dice = new Random();
				int toAdd = dice.Next(1, 6) + dice.Next(1, 6);
				if(card.addClay == 1)
				{
					int[] diceRolls = new int[need to know what the game class instance is going to be called.getPlayers()];
					for(int count = 0; count < need to know what the game class instance is going to be called.getPlayers(); count++)
						diceRolls[count] = dice.Next(1, 6);
					//Logic for having players pick in turn order and by dice value, new form needed?
				}
				else if(card.addWood == 1)
				{
					AddResources(toAdd/3,0,0,0);
				}
				else if(card.addStone == 1)
				{
					AddResources(0,0,toAdd/5,0);
				}
				else if(card.addGold == 1)
				{
					AddResources(0,0,0,toAdd/6);
				}
			}
			else
			{
				if(card.addFood > 0)
				{
					AddFood(card.addFood);
				}
				else if(card.addLumber > 0)
				{
					AddResources(card.addLumber,0,0,0);
				}
				else if(card.addClay > 0)
				{
					AddResources(0,card.addClay,0,0);
				}
				else if(card.addStone > 0)
				{
					AddResources(0,0,card.addStone,0);
				}
				else if(card.addGold > 0)
				{
					AddResources(0,0,0,card.addGold);
				}
				else if(card.agriLevel > 0)
				{
					incrementAgriculture();
				}
				else if(card.addTools > 0)
				{
					AddTool();
				}
			}
		}

		void ReceiveBuildingCard(BuildingCardClass card)
		{
			if(card.wildMin == 0)
			{
				UpdateScore(card.score);
				DeductResources(card.wood, card.clay, card.stone, card.gold);
			}
			else
			{
				//different types of requirements to need discuss forms and such at next meeting
			}
		} end works in progress*/

		public void AddResources(int addFood, int addWood, int addClay, int addStone, int addGold)
		{
			food += addFood;
			wood += addWood;
			stone += addStone;
			clay += addClay;
			gold += addGold;
		}

		public bool DeductResources(int subWood, int subClay, int subStone, int subGold)
		{
			if (wood >= subWood && stone >= subStone && clay >= subClay && gold >= subGold)
			{
				wood -= subWood;
				stone -= subStone;
				clay -= subClay;
				gold -= subGold;
				return true;
			}
			else
			{
				return false;
			}
		}

		public void AddFood(int addFood)
		{
			food += addFood;
		}

		/// <summary>
		/// deducts food based on the number of workers
		/// if all workers cannot be fed, feed as many as
		/// possible and return the number of unfed workers
		/// </summary>
		/// <returns>number of unfed workers</returns>
		public int DeductFood()
		{
			if(food >= workers)
			{
				food -= workers;
				return 0;
			}
			else
			{
				int fedWorkers = food;
				food = 0;
				return workers - fedWorkers;
			}
		}
		
		public void UpdateScore(int update)
		{
			score += update;
		}

	}
}
