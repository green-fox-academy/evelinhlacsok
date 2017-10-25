using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankOfSimba.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BankOfSimba.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        [Route("Simba")]
        public IActionResult Index()
        {
            BankAccount bankAccount = new BankAccount("Simba", 2000, AnimalType.Lion, true, true);

            return View(bankAccount);
        }
        [Route("Accounts")]
        public IActionResult ListOfBankAccounts()
        {
            List<BankAccount> bankAccounts = new List<BankAccount>();
            bankAccounts.Add(new BankAccount("Nala", 1000, AnimalType.Tiger, true, true));
            bankAccounts.Add(new BankAccount("Zazu", 500, AnimalType.Bird, false, true));
            bankAccounts.Add(new BankAccount("Zordon", 4000, AnimalType.Tiger, true, false));
            bankAccounts.Add(new BankAccount("Rafiki", 3000, AnimalType.Monkey, false, false));
            bankAccounts.Add(new BankAccount("Mufasa", 8000, AnimalType.Tiger, true, true));

            return View(bankAccounts);
        }
    }
}
