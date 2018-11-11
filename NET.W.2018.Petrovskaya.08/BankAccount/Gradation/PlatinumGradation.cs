using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
     /// <summary>
     /// Platinum gradation of account in bank.
     /// </summary>
     public class PlatinumGradation : IAccountGradation
     {
          public PlatinumGradation()
          {
               BalanceCost = 5;
               PuttingCost = 5;
          }

          public int BalanceCost { get; set; }

          public int PuttingCost { get; set; }

          public string GetGradation()
          {
               return "Platinum";
          }

          /// <summary>
          /// Count bonuses when user puts money.
          /// </summary>
          /// <param name="money">
          /// Output money.
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
