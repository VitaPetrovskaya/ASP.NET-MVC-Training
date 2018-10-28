using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
     class PlatinumGradation: IAccountGradation
     {
          public int BalanceCost { get; set; }
          public int PuttingCost { get; set; }

          public PlatinumGradation()
          {
               BalanceCost = 5;
               PuttingCost = 5;
          }

          public string GetGradation()
          {
               return "Platinum";
          }

          public int PutMoney(double money)
          {
               return (int)(money * 0.5) * PuttingCost;
          }

          public int TakeMoney(double money)
          {
               return (int)(money * 0.5) * BalanceCost;
          }
     }
}
