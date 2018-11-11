using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
     /// <summary>
     /// Base gradation of account in bank.
     /// </summary>
     public class BaseGradation : IAccountGradation
     {
          public BaseGradation()
          {
               BalanceCost = 1;
               PuttingCost = 1;
          }

          public int BalanceCost { get; set; }

          public int PuttingCost { get; set; }

          public string GetGradation()
          {
               return "Base";
          }

          /// <summary>
          /// Count bonuses when user puts money.
          /// </summary>
          /// <param name="money">
          /// Input money.
          /// </param>
          /// <returns>
          /// Number of bonuses.
          /// </returns>
          public int PutMoney(double money)
          {
               return (int)(money * 0.5) * PuttingCost;
          }

          /// <summary>
          /// Count bonuses when user takes money.
          /// </summary>
          /// <param name="money">
          /// Output money.
          /// </param>
          /// <returns>
          /// Number of bonuses.
          /// </returns>
          public int TakeMoney(double money)
          {
               return (int)(money * 0.5) * BalanceCost;
          }
     }
}
