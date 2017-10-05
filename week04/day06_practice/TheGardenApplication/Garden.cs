using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TheGardenApplication
{
    public class Garden
    {
        private List<Plant> listOfPlants = new List<Plant>();
        private double wateringAmount;
       
        public List<Plant> ListOfPlants
        {
            get
            {
                return listOfPlants; 
            }
            set
            {
                listOfPlants = value;
            }
        }

        public double WateringAmount
        {
            get
            {
                return wateringAmount;
            }
            set
            {
                wateringAmount = value;
            }
        }
    }
}