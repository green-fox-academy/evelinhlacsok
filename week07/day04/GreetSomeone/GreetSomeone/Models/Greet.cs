using System;
namespace GreetSomeone.Models
{
    public class Greet
    {
        public string Name { get; set; }
        public Greet()
        {
            Console.WriteLine("hello" + Name);
        }
    }
}
