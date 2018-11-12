using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
     public class Program
     {
          /// <summary>
          /// Test some version of game in roulette.
          /// </summary>
          /// <param name="args"></param>
          public static void Main(string[] args)
          {
               Roulette roul = new Roulette();
               Listener vita = new Listener("Vita");
               vita.MakeBetOnColor(roul, "red");
               Listener person = new Listener("Person");
               person.MakeBetOnColor(roul, "black");
               roul.SpinTheRoulette();
               foreach (DateTime i in vita.Winnings)
               {
                    Console.WriteLine("Vita " + i);
               }

               foreach (DateTime y in person.Winnings)
               {
                    Console.WriteLine("Person " + y);
               }

               Console.ReadLine();
          }
     }
}
