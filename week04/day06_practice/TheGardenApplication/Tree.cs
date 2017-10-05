using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGardenApplication
{
    public class Tree : Plant
    {
        public Tree(string color)
        {
            this.waterNeed = 10;
            //
            this.type = "Tree";
            this.color = color;
        }

        public override void Water(double waterAmount)
        {
            currentWaterAmount += waterAmount * 0.4;
        }
    }
}