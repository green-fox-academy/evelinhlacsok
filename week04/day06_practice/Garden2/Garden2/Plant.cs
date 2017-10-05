using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden2
{
    class Plant 
    {
        public string color;
        public int waterNeed;
        public double waterAbsorb;
        public string type;
        public double waterAmount;

        public string IsThirsty()
        {
            if (waterAmount < waterNeed)
            {
                return "need water";
            }
            else
            {
                return "does not need water";
            }
        }

    }
}
