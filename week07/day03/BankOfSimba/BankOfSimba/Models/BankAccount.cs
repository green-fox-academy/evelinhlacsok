using System;
namespace BankOfSimba.Models
{
    public class BankAccount
    {
        public string Name { get; set; }
        public string Balance { get; set; }
        public AnimalType AnimalType { get; set; }
        public bool IsKing { get; set; }

        public BankAccount()
        {

        }
        public BankAccount(string name, string balance, AnimalType animalType, bool isKing)
        {
            Name = name;
            Balance = balance + "0.00" + " Zebra";
            AnimalType = AnimalType;
            IsKing = isKing;
        }
    }
}
