using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
     public class ArraySortingDelegateToInteface
     {
          #region User interface methods
          public static void BubbleSortOfSumRows(ref int[][] arr)
          {
               Func<int[], int[], int> param = CompareBySum;
               BubbleSort(ref arr, param);
          }
          
          public static void BubbleSortOfMaxElem(ref int[][] arr)
          {
               Func<int[], int[], int> param = CompareByMax;
               BubbleSort(ref arr, param);
          }
          
          public static void BubbleSortOfMinElem(ref int[][] arr)
          {
               Func<int[], int[], int> param = CompareByMin;
               BubbleSort(ref arr, param);
          }
          #endregion

          /// <summary>
          /// Method for sorting. Call method with interface parameter.
          /// </summary>
          /// <param name="arr">
          /// Input jagged array.
          /// </param>
          /// <param name="param">
          /// Delegate - parameter of comparison rows for sorting.
          /// </param>
          private static void BubbleSort(ref int[][] arr, Func<int[], int[], int> param)
          {
               if (ReferenceEquals(param, null))
               {
                    throw new ArgumentNullException(nameof(param));
               }

               BubbleSort(ref arr, new DelegateToInterface(param));
          }

          /// <summary>
          /// Sort jagged array using class implementing interface.
          /// </summary>
          /// <param name="arr">
          /// Input jagged array.
          /// </param>
          /// <param name="param">
          /// Object for comparison.
          /// </param>
          private static void BubbleSort(ref int[][] arr, IComparer<int[]> param)
          {
               if (arr == null)
               {
                    throw new ArgumentException(null);
               }

               if (arr.Length <= 0)
               {
                    throw new ArgumentException(nameof(arr));
               }

               for (int i = 0; i < arr.Length; i++)
               {
                    for (int j = 0; j < arr.Length - 1 - i; j++)
                    {
                         if (param.Compare(arr[j], arr[j + 1]) == 1)
                         {
                              Swap(ref arr[j], ref arr[j + 1]);
                         }
                    }
               }
          }

          #region Methods of comparison
          private static int CompareBySum(int[] arr1, int[] arr2)
          {
               int sum1 = 0, sum2 = 0;
               for (int i = 0; i < arr1.Length; i++)
               {
                    sum1 += arr1[i];
               }

               for (int i = 0; i < arr2.Length; i++)
               {
                    sum2 += arr2[i];
               }

               if (sum1 == sum2)
               {
                    return 0;
               }

               if (sum1 < sum2)
               {
                    return -1;
               }

               return 1;
          }
          
          private static int CompareByMax(int[] arr1, int[] arr2)
          {
               int max1 = arr1[0], max2 = arr2[0];
               for (int i = 1; i < arr1.Length; i++)
               {
                    if (max1 < arr1[i])
                    {
                         max1 = arr1[i];
                    }
               }

               for (int i = 1; i < arr2.Length; i++)
               {
                    if (max2 < arr2[i])
                    {
                         max2 = arr2[i];
                    }
               }

               if (max1 == max2)
               {
                    return 0;
               }

               if (max1 < max2)
               {
                    return -1;
               }

               return 1;
          }
          
          private static int CompareByMin(int[] arr1, int[] arr2)
          {
               int min1 = arr1[0], min2 = arr1[0];
               for (int i = 1; i < arr1.Length; i++)
               {
                    if (min1 > arr1[i])
                    {
                         min1 = arr1[i];
                    }
               }

               for (int i = 1; i < arr2.Length; i++)
               {
                    if (min2 > arr2[i])
                    {
                         min2 = arr2[i];
                    }
               }
               
               if (min1 == min2)
               {
                    return 0;
               }

               if (min1 < min2)
               {
                    return -1;
               }

               return 1;
          }
          #endregion

          /// <summary>
          /// Swap rows in jagged array.
          /// </summary>
          /// <param name="firstArg"></param>
          /// <param name="secondArg"></param>
          private static void Swap(ref int[] firstArg, ref int[] secondArg)
          {
               int[] temp = firstArg;
               firstArg = secondArg;
               secondArg = temp;
          }
     }
}
