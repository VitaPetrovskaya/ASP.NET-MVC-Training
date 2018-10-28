using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
     class BaseGradation: IAccountGradation
     {
          public int BalanceCost { get; set; }
          public int PuttingCost { get; set; }

          public BaseGradation()
          {
               BalanceCost = 1;
               PuttingCost = 1;
          }

          public string GetGradation()
          {
               return "Base";
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
