namespace TheGardenApplication
{
    public class Plant
    {
        protected string color;
        public bool needsWater;
        public double waterNeed;
        public double waterAmount;

        public void Watering()
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