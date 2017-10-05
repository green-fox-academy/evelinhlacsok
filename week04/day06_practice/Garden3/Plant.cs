using System;

namespace Garden3
{
    public class Plant
    {
        public string color;
        public string type;
        public double waterNeed;
        public double waterAbsorb;
        public double waterAmount;

        public string IsThirsty()
        {
            if (waterAmount < waterNeed)
            {
                return "needs water";
            }
            return "does not need water";
        }
    }
}