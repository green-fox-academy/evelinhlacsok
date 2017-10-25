using System;
namespace BankOfSimba.Models
{
    public class BankAccount
    {
        public string Name { get; set; }
        public decimal Balance { get; set; }
        public AnimalType AnimalType { get; set; }
        public bool IsKing { get; set; }
        public bool IsGood { get; set; }

        public BankAccount()
        {

        }
        public BankAccount(string name, decimal balance, AnimalType animalType, bool isKing, bool isGood)
        {
            Name = name;
            Balance = balance;
            AnimalType = AnimalType;
            IsKing = isKing;
            IsGood = isGood;
        }
    }
}
