using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGardenApplication
{
    public class Flowers : Plant
    {
        public Flowers(string color)
        {
            this.waterNeed = 5;
           // this.type = "Flower";
            this.color = color;
        }

        public override void Water(double WaterAmount)
        {
            currentWaterAmount += WaterAmount * 0.75;
        }
    }
}