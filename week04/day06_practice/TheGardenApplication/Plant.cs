using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGardenApplication
{
    public class Plant
    {
        protected string color;
        // protected static string[] colors = new string[]{"yellow", "blue", "purple", "orange"};
        protected double currentWaterAmount;
        protected double waterNeed;
        protected string type;

        public double WaterNeed
        {
            get
            {
                return waterNeed;
            }
        }

        public string Type
        {
            get
            {
                return type;
            }
        }

        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }

        public double CurrentWaterAmount
        {
            get
            {
                return currentWaterAmount;
            }
            set
            {
                currentWaterAmount = value;
            }
        }

        public virtual void Water(double waterAmount)
        {
            currentWaterAmount += waterAmount;
        }
        
    }
}
