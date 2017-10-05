using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden2
{
    class Flower : Plant
    {
        public Flower(string color)
        {
            this.color = color;
            waterNeed = 5;
            waterAbsorb = 0.75;
            type = "flower";
        }

        
    }
}
