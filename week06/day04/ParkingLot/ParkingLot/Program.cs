using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a Car class with 2 enum properties
            //enum of car types
            //The types of these cars or vehicles is up to you
            //enum of colors
            //Create 256 Vehicles randomly and put them into a List
            //Count and Print the number of same vehicles for each type
            //Count and Print the number of same vehicles for each color
            //Print the most frequently occurring vehicle

            Random random = new Random();
            int carNumber = 256;
            List<Car> carList = new List<Car>();
            int randomTypeMax = Enum.GetValues(typeof(Type)).Length;
            int randomColorMax = Enum.GetValues(typeof(Color)).Length;


            for (int i = 1; i <= carNumber; i++)
            {
                // int randomTypeCar = random.Next(randomTypeMax);
                // int randomColorCar = random.Next(randomColorMax);
                 carList.Add(new Car((Type)random.Next(randomTypeMax), (Color)random.Next(randomColorMax)));
            }

            foreach (var car in carList)
            {
                 Console.WriteLine(car.Type.ToString() + " "+ car.Color.ToString());
            }
            Console.WriteLine();
            FindSameTypeCars(carList);
            Console.ReadLine();
        }

        private static void FindSameTypeCars(List<Car> carList)
        {
            var sameTypeHonda = from honda in carList
                                      where honda.Type == Type.Honda
                                      select honda;

            var sameTypeToyota = from toyota in carList
                                       where toyota.Type == Type.Toyota
                                       select toyota;

            var sameTypeVolvo = from volvo in carList
                                      where volvo.Type == Type.Volvo
                                      select volvo;

            var sameTypeAudi = from audi in carList
                                     where audi.Type == Type.Audi
                                     select audi;
           
            Console.WriteLine("Number of Honda: {0}, number of Toyota: {1}, number of Volvo: {2}, number of Audi: {3}",
                    sameTypeHonda.Count(), sameTypeToyota.Count(), sameTypeVolvo.Count(), sameTypeAudi.Count());
            
        }
    }
}
