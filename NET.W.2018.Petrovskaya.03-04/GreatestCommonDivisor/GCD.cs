using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace GreatestCommonDivisor
{
     class GCD
     {
          // find GDC for two numbers by Euclidean algorithm
          private static int FindGCDEuclidean(int a, int b)
          {
               a = Math.Abs(a);
               b = Math.Abs(b);
               if (a == 0)
                    return b;
               if (b == 0)
                    return a;
               if (a > b)
                    return FindGCDEuclidean(a % b, b);
               else
                    return FindGCDEuclidean(a, b % a);
          }

          // find GDC for two numbers by Binary Euclidean algorithm (Stein's algorithm)
          private static int FindGCDBinaryEuclidean(int a, int b)
          {
               if (a == 0)
                    return Math.Abs(b);
               if (b == 0)
                    return Math.Abs(a);
               a = Math.Abs(a);
               b = Math.Abs(b);
               if (a == 1 || b == 1)
                    return 1;
               if (a == b)
                    return a;
               if ((~a & 1) == 1)
                    if ((~b & 1) == 1) //a and b are both even
                         return 2 * FindGCDBinaryEuclidean(a >> 1, b >> 1);
                    else //a is even, b is odd
                         return FindGCDBinaryEuclidean(a >> 1, b);
               if ((~b & 1) == 1) //a is odd, b is even
                    return FindGCDBinaryEuclidean(a, b >> 1);
               if (a > b)  //a and b are both odd
                    return FindGCDBinaryEuclidean((a - b) >> 1, b);
               else
                    return FindGCDBinaryEuclidean(a, (b - a) >> 1);
          }

          #region Euclidean methods

          public static int GetGDCEuclidean(int num1, int num2, out TimeSpan time)
          {
               int result;
               Stopwatch stopwatch = new Stopwatch(); // create new stopwatch
               stopwatch.Start(); // begin timing
               result = FindGCDEuclidean(num1, num2);
               stopwatch.Stop(); // stop timing
               time = stopwatch.Elapsed;
               return result;
          }

          public static int GetGDCEuclidean(int num1, int num2, int num3, out TimeSpan time)
          {
               int result;
               Stopwatch stopwatch = new Stopwatch();
               stopwatch.Start();
               result = FindGCDEuclidean(FindGCDEuclidean(num1, num2), num3);
               stopwatch.Stop();
               time = stopwatch.Elapsed;
               return result;
          }

          public static int GetGDCEuclidean(out TimeSpan time, params int[] numbers)
          {
               int result;
               Stopwatch stopwatch = new Stopwatch();
               stopwatch.Start();
               if (numbers.Length <= 1)
                    throw new ArgumentException("The number of numbers is not enough.");
               result = FindGCDEuclidean(numbers[0], numbers[1]);
               for (int i = 2; i < numbers.Length && result != 1; i++)
               {
                    result = FindGCDEuclidean(result, numbers[i]);
               }
               stopwatch.Stop();
               time = stopwatch.Elapsed;
               return result;
          }
          #endregion

          #region Binary Euclidean methods

          public static int GetGDCBinaryEuclidean(int num1, int num2, out TimeSpan time)
          {
               int result;
               Stopwatch stopwatch = new Stopwatch();
               stopwatch.Start();
               result = FindGCDBinaryEuclidean(num1, num2);
               stopwatch.Stop();
               time = stopwatch.Elapsed;
               return result;
          }

          public static int GetGDCBinaryEuclidean(int num1, int num2, int num3, out TimeSpan time)
          {
               int result;
               Stopwatch stopwatch = new Stopwatch();
               stopwatch.Start();
               result = FindGCDBinaryEuclidean(FindGCDEuclidean(num1, num2), num3);
               stopwatch.Stop();
               time = stopwatch.Elapsed;
               return result;
          }

          public static int GetGDCBinaryEuclidean(out TimeSpan time, params int[] numbers)
          {
               int result;
               Stopwatch stopwatch = new Stopwatch();
               stopwatch.Start();
               if (numbers.Length <= 1)
                    throw new ArgumentException("The number of numbers is not enough.");
               result = FindGCDBinaryEuclidean(numbers[0], numbers[1]);
               for (int i = 2; i < numbers.Length && result != 1; i++)
               {
                    result = FindGCDBinaryEuclidean(result, numbers[i]);
               }
               stopwatch.Stop();
               time = stopwatch.Elapsed;
               return result;
          }
          #endregion
     }
}
