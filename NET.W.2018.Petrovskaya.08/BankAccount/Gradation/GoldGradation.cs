using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
     class GoldGradation: IAccountGradation
     {
          public int BalanceCost { get; set; }
          public int PuttingCost { get; set; }

          public GoldGradation()
          {
               BalanceCost = 2;
               PuttingCost = 2;
          }

          public string GetGradation()
          {
               return "Gold";
          }

          public int PutMoney(double money)
          {
               return (int)money * PuttingCost;
          }

          public int TakeMoney(double money)
          {
               return (int)money * BalanceCost;
          }
     }
}
