using System;
namespace DependencyInjectionWorkshop.Models
{
    public class Counter
    {
        public int Number { get; set; } = 1;
        public string Name { get; set; } = "Rozi";

        public void Raise()
        {
            Number++;
        }
    }
}
