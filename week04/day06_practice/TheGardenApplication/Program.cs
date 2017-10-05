using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGardenApplication
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Garden myGarden = new Garden();
            Plant flower1 = new Flowers("yellow");
            myGarden.ListOfPlants.Add(flower1);
            Plant flower2 = new Flowers("blue");
            myGarden.ListOfPlants.Add(flower2);

            Tree tree1 = new Tree("purple");
            myGarden.ListOfPlants.Add(tree1);
            Tree tree2 = new Tree("orange");
            myGarden.ListOfPlants.Add(tree2);
        }
    }
}