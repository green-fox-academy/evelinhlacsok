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
            Random random = new Random();
            int carNumber = 256;
            List<Car> carList = new List<Car>();

            for (int i = 1; i <= carNumber; i++)
            {
                 carList.Add(new Car(Type.Volvo, Color.Black));
            }



            foreach (var car in carList)
            {
                 Console.WriteLine(carList);
            }
            Console.ReadLine();
        }
    }
}
