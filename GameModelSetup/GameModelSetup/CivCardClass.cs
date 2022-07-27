using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsaiahsPartOfProject
{
    public class CivCardClass
    {
        public string type { get; private set; }
        public int needRoll, addFood, addWood, addClay, addStone, addGold, addAgriLevel, addTools;
    
	
		public CivCardClass(int roll, int food, int wood, int clay, int stone, int gold, int agriLevel, int tools)
		{
			needRoll = roll;
			addFood = food;
			addWood = wood;
			addClay = clay;
			addStone = stone;
			addGold = gold;
			addAgriLevel = agriLevel;
			addTools = tools;
		}
		
		
	
		public void PrintInfo()
		{
			Console.WriteLine("Need Roll:  " + needRoll + "  Food:  " + addFood + "  Wood:  " + addWood + " Clay:  " + addClay + 
				"  Stone:  " + addStone + "  Gold:  " + addGold + "  Agriculture:  " + addAgriLevel + "  Tools:  " + addTools);
		}
	}
}
