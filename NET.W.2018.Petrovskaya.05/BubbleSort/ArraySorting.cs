using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
     /// <summary>
     /// Class contains array sorting methods.
     /// </summary>
     class ArraySorting
     {
          enum TypeOfSort
          {
               increase,
               decrease
          }

          enum ParamOfSort
          {
               sum,
               maxElem,
               minElem
          }
          #region Sorting by sums
          public static void BubbleSortOfSumRowsInc(ref int[][] arr)
          {
               BubleSortBySum(ref arr, TypeOfSort.increase, ParamOfSort.sum);
          }
          
          public static void BubbleSortOfSumRowsDec(ref int[][] arr)
          {
               BubleSortBySum(ref arr, TypeOfSort.decrease, ParamOfSort.sum);
          }
          #endregion

          #region Sorting by max element
          public static void BubbleSortOfMaxElemInc(ref int[][] arr)
          {
               BubleSortBySum(ref arr, TypeOfSort.increase, ParamOfSort.maxElem);
          }

          public static void BubbleSortOfMaxElemDec(ref int[][] arr)
          {
               BubleSortBySum(ref arr, TypeOfSort.decrease, ParamOfSort.maxElem);
          }
          #endregion

          #region Sorting by min element
          public static void BubbleSortOfMinElemInc(ref int[][] arr)
          {
               BubleSortBySum(ref arr, TypeOfSort.increase, ParamOfSort.minElem);
          }

          public static void BubbleSortOfMinElemDec(ref int[][] arr)
          {
               BubleSortBySum(ref arr, TypeOfSort.decrease, ParamOfSort.minElem);
          }
          #endregion
          
          /// <summary>
          /// Buble sorting jagged array.
          /// </summary>
          /// <param name="arr">
          /// Jagged array for sorting.
          /// </param>
          /// <param name="type">
          /// Increase or decrease.
          /// </param>
          /// <param name="param">
          /// By sums or max elements or min elements.
          /// </param>
          private static void BubleSortBySum(ref int[][] arr, TypeOfSort type, ParamOfSort param)
          {
               for (int i = 0; i < arr.Length; i++)
               {
                    for (int j = 0; j < arr.Length - 1 - i; j++)
                    {
                         switch (param)
                         {
                              case ParamOfSort.sum:
                                   {
                                        if (type == TypeOfSort.increase && Sum(arr[j]) > Sum(arr[j + 1]))
                                             Swap(ref arr[j], ref arr[j + 1]);
                                        if (type == TypeOfSort.decrease && Sum(arr[j]) < Sum(arr[j + 1]))
                                             Swap(ref arr[j], ref arr[j + 1]);
                                        break;
                                   }
                              case ParamOfSort.maxElem:
                                   {
                                        if (type == TypeOfSort.increase && Max(arr[j]) > Max(arr[j + 1]))
                                             Swap(ref arr[j], ref arr[j + 1]);
                                        if (type == TypeOfSort.decrease && Max(arr[j]) < Max(arr[j + 1]))
                                             Swap(ref arr[j], ref arr[j + 1]);
                                        break;
                                   }
                              case ParamOfSort.minElem:
                                   {
                                        if (type == TypeOfSort.increase && Min(arr[j]) > Min(arr[j + 1]))
                                             Swap(ref arr[j], ref arr[j + 1]);
                                        if (type == TypeOfSort.decrease && Min(arr[j]) < Min(arr[j + 1]))
                                             Swap(ref arr[j], ref arr[j + 1]);
                                        break;
                                   }
                         }
                    }
               }
          }

          /// <summary>
          /// Find sum of elements in row.
          /// </summary>
          /// <param name="arr">
          /// Row of jagged array.
          /// </param>
          /// <returns>
          /// Sum of elements.
          /// </returns>
          private static int Sum(int[] arr)
          {
               int result = 0;
               for (int i = 0; i < arr.Length; i++)
               {
                    result += arr[i];
               }
               return result;
          }

          /// <summary>
          /// Find max element in row.
          /// </summary>
          /// <param name="arr">
          /// Row of jagged array.
          /// </param>
          /// <returns>
          /// Max element.
          /// </returns>
          private static int Max(int[] arr)
          {
               int result = arr[0];
               for (int i = 1; i < arr.Length; i++)
               {
                    if (result < arr[i])
                         result = arr[i];
               }
               return result;
          }

          /// <summary>
          /// Find min element in row.
          /// </summary>
          /// <param name="arr">
          /// Row of jagged array.
          /// </param>
          /// <returns>
          /// Min element.
          /// </returns>
          private static int Min(int[] arr)
          {
               int result = arr[0];
               for (int i = 1; i < arr.Length; i++)
               {
                    if (result > arr[i])
                         result = arr[i];
               }
               return result;
          }

          /// <summary>
          /// Swap rows in jagged array.
          /// </summary>
          /// <param name="firstArg"></param>
          /// <param name="secondArg"></param>
          public static void Swap(ref int[] firstArg, ref int[] secondArg)
          {
               int[] temp = firstArg;
               firstArg = secondArg;
               secondArg = temp;
          }
     }
}
