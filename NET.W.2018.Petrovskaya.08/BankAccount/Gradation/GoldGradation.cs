using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
     /// <summary>
     /// Gold gradation of account in bank.
     /// </summary>
     public class GoldGradation : IAccountGradation
     {
          public GoldGradation()
          {
               BalanceCost = 2;
               PuttingCost = 2;
          }

          public int BalanceCost { get; set; }

          public int PuttingCost { get; set; }

          public string GetGradation()
          {
               return "Gold";
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
               return (int)money * PuttingCost;
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
               return (int)money * BalanceCost;
          }
     }
}
