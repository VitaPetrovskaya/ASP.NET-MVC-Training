using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
     /// <summary>
     /// Class contains info about result of spin roulette.
     /// </summary>
     public class ResultEventArgs : EventArgs
     {
          private string color, even_odd, small_big;
          private int number;

          public ResultEventArgs(int result, string[] arrayOfColor)
          {
               this.number = result;
               this.even_odd = (result % 2 == 0) ? "even" : "odd";
               this.color = arrayOfColor[this.number];
               this.small_big = (result < 19) ? "small" : "big";
          }

          public int Number
          {
               get { return this.number; }
               private set { }
          }

          public string Color
          {
               get { return this.color; }
               private set { }
          }

          public string Even_odd
          {
               get { return this.even_odd; }
               private set { }
          }

          public string Small_big
          {
               get { return this.small_big; }
               private set { }
          }
     }
}
