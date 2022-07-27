using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameModelSetup
{
    class GameFunctions
    {

        public static int rollDice(int numDice)
        {
            int total = 0;
            Random r = new Random();
            for (int i = 0; i < numDice; i++)
            {
                total += r.Next(1, 6);
            }
            return total;

        }
    }
}
