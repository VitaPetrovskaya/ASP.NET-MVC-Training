﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
     /// <summary>
     /// Interface to count bonuses for different accounts.
     /// </summary>
     public interface IAccountGradation
     {
          int BalanceCost { get; set; }

          int PuttingCost { get; set; }

          string GetGradation();

          int PutMoney(double money);

          int TakeMoney(double money);
     }
}
