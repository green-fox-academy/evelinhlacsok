using System;
namespace BankOfSimba.Models
{
    public class BankAccount
    {
        public string Name { get; set; }
        public double Balance { get; set; }
        public AnimalType AnimalType { get; set; }

        public BankAccount()
        {

        }
        public BankAccount(string name, double balance, AnimalType animalType)
        {
            Name = name;
            Balance = balance;
            AnimalType = AnimalType;
        }
    }
}
