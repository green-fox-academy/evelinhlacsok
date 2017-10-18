using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exercise10___Foxes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a Fox class with 3 properties(name, type, color) Fill a list with at least 5 foxes, 
            //it's up to you how you name/create them! Write a LINQ Expression to find the foxes with green color!
            //Write a LINQ Expression to find the foxes with green color and pallida type!

            List<Fox> foxList = new List<Fox>();
            foxList.Add(new Fox("Rebi", "arctic", "white"));
            foxList.Add(new Fox("Iren", "forest", "green"));
            foxList.Add(new Fox("Rozi", "pallida", "green"));
            foxList.Add(new Fox("Aron", "arabian", "red"));
            foxList.Add(new Fox("Abel", "kitfox", "grey"));

            foreach (var fox in foxList)
            {
                Console.WriteLine(fox.Name + " " + fox.Type + " " + fox.Color);
            }
           
            Console.WriteLine();
            FindGreenFoxWithQuery(foxList);

            Console.WriteLine();
            FindPallidaFoxWithQuery(foxList);

            Console.WriteLine();
            FindGreenFoxWithLambda(foxList);

            Console.WriteLine();
            FindPallidaFoxWithLambda(foxList);

            Console.ReadLine();
        }

        public static void FindGreenFoxWithQuery(List<Fox> greenfox)
        {
            var greenfoxWithQuery = from fox in greenfox
                                    where fox.Color == "green"
                                    select fox;

            foreach (var fox in greenfoxWithQuery)
            {
                Console.WriteLine("The green foxes are called: {0}", fox.Name);
            }
        }

        public static void FindPallidaFoxWithQuery(List<Fox> pallidafox)
        {
            var pallidafoxWithQuery = from fox in pallidafox
                                      where fox.Color == "green" && fox.Type == "pallida"
                                      select fox;

            foreach (var fox in pallidafoxWithQuery)
            {
                Console.WriteLine("The green and pallida foxes are called: {0}", fox.Name);
            }
        }

        public static void FindGreenFoxWithLambda(List<Fox> greenfox)
        {
            var greenFoxWithLambda = greenfox.Where(x => x.Color == "green").Select(x => x).ToList();

            foreach (var fox in greenFoxWithLambda)
            {
                Console.WriteLine("The green foxes are called: {0}", fox.Name);
            }
        }

        public static void FindPallidaFoxWithLambda(List<Fox> pallidafox)
        {
            var pallidaFoxWithLambda = pallidafox.Where(x => x.Color == "green" && x.Type == "pallida").Select(x => x).ToList();

            foreach (var fox in pallidaFoxWithLambda)
            {
                Console.WriteLine("The green and pallida foxes are called: {0}", fox.Name);
            }
        }
    }
}
