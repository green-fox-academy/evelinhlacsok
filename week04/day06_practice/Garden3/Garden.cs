using System;
using System.Collections.Generic;

namespace Garden3
{
    public class Garden : Plant
    {
        List<Plant>plants = new List<Plant>();

        public void PlantAdder(Plant plant)
        {
            plants.Add(plant);
        }

        public void ThristyCheck()
        {
            foreach (var plant in plants)
            {
                Console.WriteLine("The {0} {1} {2}", plant.color, plant.type, plant.IsThirsty());
            }
        }

        public void Watering(double waterPortion)
        {
            Console.WriteLine("watering with " + waterPortion);
            double waterPerPlant = waterPortion / plants.Count;
            foreach (var plant in plants)
            {
                plant.waterAmount += waterPerPlant * plant.waterAbsorb;
            }
        }
    }
}