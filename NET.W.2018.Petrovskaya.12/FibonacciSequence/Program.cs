using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSequence
{
     public class Program
     {
          /// <summary>
          /// Test FibonacciSequence class.
          /// </summary>
          /// <param name="args"></param>
          public static void Main(string[] args)
          {
               FibonacciSequence fibonacci = new FibonacciSequence(10);
               foreach (int num in fibonacci)
               {
                    Console.Write(num + " ");
               }

               Console.WriteLine();
               fibonacci.GenerateNewSequence(20);
               foreach (int num in fibonacci)
               {
                    Console.Write(num + " ");
               }

               Console.ReadLine();
          }
     }
}
