using System;
using System.Collections.Generic;

namespace Garden3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Garden myGarden = new Garden();
            Flower flower1 = new Flower("yellow");
            myGarden.PlantAdder(flower1);
            Flower flower2 = new Flower("green");
            myGarden.PlantAdder(flower2);
            Tree tree1 = new Tree("grey");
            myGarden.PlantAdder(tree1);
            Tree tree2 = new Tree("pink");
            myGarden.PlantAdder(tree2);
            
            myGarden.ThristyCheck();
            Console.WriteLine();

            myGarden.Watering(40);
            myGarden.ThristyCheck();
            Console.WriteLine();
            
            myGarden.Watering(70);
            myGarden.ThristyCheck();
            Console.WriteLine();
            
        }
    }
}