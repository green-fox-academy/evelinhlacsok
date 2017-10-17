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

        public bool IsThirsty()
        {
            return waterAmount < waterNeed;
        }

    }
}
