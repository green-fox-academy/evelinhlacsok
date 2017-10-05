using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden2
{
    class Garden
    {
        List<Plant> plants = new List<Plant>();
        
        public void Add(Plant plant)  //polimorfizmus
        {
            plants.Add(plant);
        }

        public void ThirstyChecker()
        {
            foreach (var plant in plants)
            {
                Console.WriteLine("The {0} {1} {2}", plant.color, plant.type, plant.IsThirsty());
            }
        }

        public void Watering(double waterPortion)
        {
            Console.WriteLine("Watering with " + waterPortion);
            double waterPerPlant = waterPortion / plants.Count;
            foreach (var plant in plants)
            {
                plant.waterAmount += waterPerPlant * plant.waterAbsorb;
            }

        }
    }
}
