using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden2
{
    class Program
    {
        static void Main(string[] args)
        {
            Garden myGarden = new Garden();
            Flower flower1 = new Flower("yellow");
            myGarden.Add(flower1);
            Flower flower2 = new Flower("blue");
            myGarden.Add(flower2);
            Tree tree1 = new Tree("purple");
            myGarden.Add(tree1);
            Tree tree2 = new Tree("orange");
            myGarden.Add(tree2);

            myGarden.ThirstyChecker();
            Console.WriteLine();
            
            myGarden.Watering(40);
            myGarden.ThirstyChecker();
            Console.WriteLine();

            myGarden.Watering(70);
            myGarden.ThirstyChecker();

            Console.ReadLine();
        }
    }
}
