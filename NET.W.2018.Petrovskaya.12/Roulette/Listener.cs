using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
     /// <summary>
     /// Class for player in roulette.
     /// </summary>
     public class Listener
     {
          private int[] currentBetNumbers;
          private string currentBetColor;
          private string currentBetEvenOdd;
          private string currentBetSmallBig;
          private string name;
          private List<DateTime> winnings = new List<DateTime>();

          public Listener(string input_name)
          {
               name = input_name;
          }

          public string Name
          {
               get { return name; }
               set { }
          }

          /// <summary>
          /// List contains time of winning.
          /// </summary>
          public List<DateTime> Winnings
          {
               get { return winnings; }
               set { }
          }

          /// <summary>
          /// User method for making bet on specific number.
          /// </summary>
          /// <param name="roulette">
          /// Current roulette.
          /// </param>
          /// <param name="ps">
          /// Bet numbers.
          /// </param>
          public void MakeBetOnNumbers(Roulette roulette, params int[] ps)
          {
               currentBetNumbers = ps;
               roulette.NewSpin += CheckBetNumber;
          }

          /// <summary>
          /// Reset bet on current numbers.
          /// </summary>
          /// <param name="roulette">
          /// Current roulette.
          /// </param>
          public void ResetBetOnNumbers(Roulette roulette)
          {
               roulette.NewSpin -= CheckBetNumber;
          }

          /// <summary>
          /// User method for making bet on red or black color.
          /// </summary>
          /// <param name="roulette">
          /// Current roulette.
          /// </param>
          /// <param name="color">
          /// Red or black.
          /// </param>
          public void MakeBetOnColor(Roulette roulette, string color)
          {
               currentBetColor = color;
               if (currentBetColor == "red")
               {
                    roulette.ResultRed += FellRed;
               }

               if (currentBetColor == "black")
               {
                    roulette.ResultBlack += FellBlack;
               }
          }

          /// <summary>
          /// Reset bet on current color.
          /// </summary>
          /// <param name="roulette">
          /// Current roulette.
          /// </param>
          public void ResetBetOnColor(Roulette roulette)
          {
               if (currentBetColor == "red")
               {
                    roulette.ResultRed -= FellRed;
               }

               if (currentBetColor == "black")
               {
                    roulette.ResultBlack -= FellBlack;
               }
          }

          /// <summary>
          /// User method for making bet on even or odd values.
          /// </summary>
          /// <param name="roulette">
          /// Current roulette.
          /// </param>
          /// <param name="even_odd">
          /// Even or odd.
          /// </param>
          public void MakeBetOnEvenOdd(Roulette roulette, string even_odd)
          {
               currentBetEvenOdd = even_odd;
               if (currentBetEvenOdd == "even")
               {
                    roulette.ResultRed += FellEven;
               }

               if (currentBetEvenOdd == "odd")
               {
                    roulette.ResultBlack += FellOdd;
               }
          }

          /// <summary>
          /// Reset bet on current even or odd values.
          /// </summary>
          /// <param name="roulette"></param>
          public void ResetBetOnEvenOdd(Roulette roulette)
          {
               if (currentBetEvenOdd == "even")
               {
                    roulette.ResultEven -= FellEven;
               }

               if (currentBetEvenOdd == "odd")
               {
                    roulette.ResultOdd -= FellOdd;
               }
          }

          /// <summary>
          /// User method for making bet on small or big values.
          /// </summary>
          /// <param name="roulette"></param>
          /// <param name="small_big"></param>
          public void MakeBetOnSmallBig(Roulette roulette, string small_big)
          {
               currentBetSmallBig = small_big;
               if (currentBetSmallBig == "small")
               {
                    roulette.ResultSmall += FellSmall;
               }

               if (currentBetSmallBig == "big")
               {
                    roulette.ResultBig += FellBig;
               }
          }

          /// <summary>
          /// Reset bet on current size.
          /// </summary>
          /// <param name="roulette"></param>
          public void ResetBetOnSmallBig(Roulette roulette)
          {
               if (currentBetSmallBig == "small")
               {
                    roulette.ResultSmall -= FellSmall;
               }

               if (currentBetSmallBig == "big")
               {
                    roulette.ResultBig -= FellBig;
               }
          }

          /// <summary>
          /// Check bet numbers and result.
          /// </summary>
          /// <param name="sender"></param>
          /// <param name="eventArgs"></param>
          private void CheckBetNumber(object sender, ResultEventArgs eventArgs)
          {
               foreach (int i in currentBetNumbers)
               {
                    if (eventArgs.Number == i)
                    {
                         winnings.Add(DateTime.Now);
                         return;
                    }
               }
          }

          /// <summary>
          /// If red add time of winning.
          /// </summary>
          /// <param name="sender"></param>
          /// <param name="eventArgs"></param>
          private void FellRed(object sender, ResultEventArgs eventArgs)
          {
               winnings.Add(DateTime.Now);
          }

          /// <summary>
          /// If black add time of winning.
          /// </summary>
          /// <param name="sender"></param>
          /// <param name="eventArgs"></param>
          private void FellBlack(object sender, ResultEventArgs eventArgs)
          {
               winnings.Add(DateTime.Now);
          }

          /// <summary>
          /// If even add time of winning.
          /// </summary>
          /// <param name="sender"></param>
          /// <param name="eventArgs"></param>
          private void FellEven(object sender, ResultEventArgs eventArgs)
          {
               winnings.Add(DateTime.Now);
          }

          /// <summary>
          /// If odd add time of winning.
          /// </summary>
          /// <param name="sender"></param>
          /// <param name="eventArgs"></param>
          private void FellOdd(object sender, ResultEventArgs eventArgs)
          {
               winnings.Add(DateTime.Now);
          }

          /// <summary>
          /// If small add time of winning.
          /// </summary>
          /// <param name="sender"></param>
          /// <param name="eventArgs"></param>
          private void FellSmall(object sender, ResultEventArgs eventArgs)
          {
               winnings.Add(DateTime.Now);
          }

          /// <summary>
          /// If big add time of winning.
          /// </summary>
          /// <param name="sender"></param>
          /// <param name="eventArgs"></param>
          private void FellBig(object sender, ResultEventArgs eventArgs)
          {
               winnings.Add(DateTime.Now);
          }
     }
}
