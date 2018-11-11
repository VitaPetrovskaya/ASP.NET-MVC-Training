using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
     public class Program
     {
          /// <summary>
          /// Test account methods.
          /// </summary>
          /// <param name="args"></param>
          public static void Main(string[] args)
          {
               Account newAccount1 = new Account("Vita", "Petrovskaya", new BaseGradation());
               newAccount1.PutMoney(12.90);
               Console.WriteLine(newAccount1.Bonus);
               newAccount1.PutMoney(50.10);
               newAccount1.TakeMoney(10.30);
               Console.WriteLine(newAccount1.Amount);
               Account newAccount2 = new Account(newAccount1.Number, "Vita", "Petrovskaya", newAccount1.Amount, newAccount1.Bonus, new GoldGradation());
               newAccount2.PutMoney(11);
               Account newAccount3 = newAccount2.CreateNewAccount(new PlatinumGradation());
               Console.WriteLine(newAccount3.Bonus);
               newAccount3.CloseAccount();
               Console.ReadLine();
          }
     }
}
