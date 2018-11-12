using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
     public class Roulette
     {
          private int currentNumber;
          private string[] arrayOfNumberMeaning = new string[] { "zero", "red", "black", "red", "black", "red", "black", "red", "black", "red", "black", "black", "red", "black", "red", "black", "red", "black", "red", "red", "black", "red", "black", "red", "black", "red", "black", "red", "black", "black", "red", "black", "red", "black", "red", "black", "red" };

          /// <summary>
          /// Type of added in event methods.
          /// </summary>
          /// <param name="sender"></param>
          /// <param name="e"></param>
          public delegate void NewSpinEventHandler(object sender, ResultEventArgs e);

          public event NewSpinEventHandler NewSpin, ResultRed, ResultBlack, ResultEven, ResultOdd, ResultSmall, ResultBig;

          /// <summary>
          /// Spin roulette and random number.
          /// </summary>
          /// <returns></returns>
          public int SpinTheRoulette()
          {
               int result;
               Random rand = new Random();
               result = rand.Next(0, 36);
               currentNumber = result;
               if (result == 0)
               {
                    return 0;
               }

               OnNewSpin(this, new ResultEventArgs(result, arrayOfNumberMeaning));
               CheckColor(this, new ResultEventArgs(result, arrayOfNumberMeaning));
               CheckEvenOdd(this, new ResultEventArgs(result, arrayOfNumberMeaning));
               CheckSmallBig(this, new ResultEventArgs(result, arrayOfNumberMeaning));
               return result;
          }

          private void OnNewSpin(object sender, ResultEventArgs e)
          {
               NewSpin?.Invoke(sender, e);
          }

          private void CheckColor(object sender, ResultEventArgs e)
          {
               if (e.Color == "red")
               {
                    ResultRed?.Invoke(sender, e);
               }
               else
               {
                    ResultBlack?.Invoke(sender, e);
               }
          }

          private void CheckEvenOdd(object sender, ResultEventArgs e)
          {
               if (e.Color == "even")
               {
                    ResultEven?.Invoke(sender, e);
               }
               else
               {
                    ResultOdd?.Invoke(sender, e);
               }
          }

          private void CheckSmallBig(object sender, ResultEventArgs e)
          {
               if (e.Color == "small")
               {
                    ResultSmall?.Invoke(sender, e);
               }
               else
               {
                    ResultBig?.Invoke(sender, e);
               }
          }
     }
}
