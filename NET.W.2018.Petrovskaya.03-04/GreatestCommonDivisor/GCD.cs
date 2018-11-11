using System;
using System.Diagnostics;

namespace GreatestCommonDivisor
{
     /// <summary>
     /// Class contains methods to find GDC.
     /// </summary>
     public class GCD
     {
          private delegate int GDCMethod(int a, int b);

          #region Euclidean methods

          public static int GetGDCEuclidean(int num1, int num2, out TimeSpan time)
          {
               GDCMethod method = FindGCDEuclidean;
               return FindGDC(out time, method, new int[] { num1, num2 });
          }

          public static int GetGDCEuclidean(int num1, int num2, int num3, out TimeSpan time)
          {
               GDCMethod method = FindGCDEuclidean;
               return FindGDC(out time, method, new int[] { num1, num2, num3 });
          }

          public static int GetGDCEuclidean(out TimeSpan time, params int[] numbers)
          {
               GDCMethod method = FindGCDEuclidean;
               return FindGDC(out time, method, numbers);
          }
          #endregion

          #region Binary Euclidean methods

          public static int GetGDCBinaryEuclidean(int num1, int num2, out TimeSpan time)
          {
               GDCMethod method = FindGCDBinaryEuclidean;
               return FindGDC(out time, method, new int[] { num1, num2 });
          }

          public static int GetGDCBinaryEuclidean(int num1, int num2, int num3, out TimeSpan time)
          {
               GDCMethod method = FindGCDBinaryEuclidean;
               return FindGDC(out time, method, new int[] { num1, num2, num3 });
          }

          public static int GetGDCBinaryEuclidean(out TimeSpan time, params int[] numbers)
          {
               GDCMethod method = FindGCDBinaryEuclidean;
               return FindGDC(out time, method, numbers);
          }
          #endregion

          /// <summary>
          /// Universal method for GDC searching.
          /// </summary>
          /// <param name="time">
          /// Elapsed time to complete searching.
          /// </param>
          /// <param name="method">
          /// Searching algorithm.
          /// </param>
          /// <param name="numbers">
          /// Elements.
          /// </param>
          /// <returns>
          /// GDC
          /// </returns>
          private static int FindGDC(out TimeSpan time, GDCMethod method, params int[] numbers)
          {
               int result;
               Stopwatch stopwatch = new Stopwatch();
               stopwatch.Start();
               if (numbers.Length <= 1)
               {
                    throw new ArgumentException("The number of numbers is not enough.");
               }

               result = method(numbers[0], numbers[1]);
               for (int i = 2; i < numbers.Length && result != 1; i++)
               {
                    result = method(result, numbers[i]);
               }

               stopwatch.Stop();
               time = stopwatch.Elapsed;
               return result;
          }

          /// <summary>
          /// Find GDC for two numbers by Euclidean algorithm.
          /// </summary>
          /// <param name="a">
          /// First element.
          /// </param>
          /// <param name="b">
          /// Second element.
          /// </param>
          /// <returns>
          /// GDC
          /// </returns>
          private static int FindGCDEuclidean(int a, int b)
          {
               a = Math.Abs(a);
               b = Math.Abs(b);
               if (a == 0)
               {
                    return b;
               }

               if (b == 0)
               {
                    return a;
               }

               if (a > b)
               {
                    return FindGCDEuclidean(a % b, b);
               }
               else
               {
                    return FindGCDEuclidean(a, b % a);
               }
          }

          /// <summary>
          /// Find GDC for two numbers by Binary Euclidean algorithm (Stein's algorithm).
          /// </summary>
          /// <param name="a">
          /// First element.
          /// </param>
          /// <param name="b">
          /// Second element.
          /// </param>
          /// <returns>
          /// GDC
          /// </returns>
          private static int FindGCDBinaryEuclidean(int a, int b)
          {
               if (a == 0)
               {
                    return Math.Abs(b);
               }

               if (b == 0)
               {
                    return Math.Abs(a);
               }

               a = Math.Abs(a);
               b = Math.Abs(b);
               if (a == 1 || b == 1)
               {
                    return 1;
               }

               if (a == b)
               {
                    return a;
               }

               if ((~a & 1) == 1)
               {
                    // a and b are both even
                    if ((~b & 1) == 1)
                    {
                         return 2 * FindGCDBinaryEuclidean(a >> 1, b >> 1);
                    }
                    else
                    {
                         return FindGCDBinaryEuclidean(a >> 1, b);
                    }
               }

               // a is odd, b is even     
               if ((~b & 1) == 1)
               {
                    return FindGCDBinaryEuclidean(a, b >> 1);
               }

               // a and b are both odd     
               if (a > b)
               {
                    return FindGCDBinaryEuclidean((a - b) >> 1, b);
               }
               else
               {
                    return FindGCDBinaryEuclidean(a, (b - a) >> 1);
               }
          }
     }
}
