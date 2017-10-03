using System;

namespace TheGardenApplication
{
    public class Plant
    {
        protected string color;
        protected static string[] colors = new string[]{"yellow", "blue", "purple", "orange"};
        public bool needsWater;
        public double waterNeed;
        public double waterAmount;

        public void WateringAmount(double water)
        {
            waterAmount += waterNeed * water;
        }

        public void PlantInfo()
        {
            if (needsWater)
            {
                Console.WriteLine("needs some water");
            }
            else
            {
                Console.WriteLine("needs no water");
            }

            if (waterNeed == 0.75)
            {
                Flowers
            }
        }

        public void WaterNeed()
        {
            if (waterNeed == 0)
            {
                Console.WriteLine("needs no more water");
                return;
            }
            waterAmount++;
        }
    }
}