using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsaiahsPartOfProject
{
   
    public class BuildingCardClass
    {
        public string type { get; private set; }
        public int score, woodCost, clayCost, stoneCost, goldCost, wildMin, wildMax, wildPaid, reqDifferentResources;
    
	
		public BuildingCardClass(int sc, int wood, int clay, int stone, int gold, int wMin, int wMax, int wPaid, int difReq)
		{
			score = sc;
			woodCost = wood;
			clayCost = clay;
			stoneCost = stone;
			goldCost = gold;
			wildMin = wMin;
			wildMax = wMax;
			wildPaid = wPaid;
			reqDifferentResources = difReq;
		}
	
		public int CalculateScore()
		{
			if(score != 0)
				return score;
			else
				return wildPaid * reqDifferentResources;
		}
	
		public void PrintInfo()
		{
			Console.WriteLine("Score:  " + score + "  Wood:  " + woodCost + "  Clay:  " + clayCost + " Stone:  " + stoneCost + 
				"  Gold:  " + goldCost + "  Min:  " + wildMin + "  Max:  " + wildMax + "  Paid:  " + wildPaid +  "  Different:  " 
				+ reqDifferentResources);
		}
	}
}
