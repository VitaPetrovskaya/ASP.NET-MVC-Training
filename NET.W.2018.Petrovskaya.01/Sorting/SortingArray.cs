using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
     /// <summary>
     /// Class contains methods for sorting single arrays.
     /// </summary>
     public class SortingArray
     {
          /// <summary>
          /// User method for quick sorting (divide input array into two parts) .
          /// </summary>
          /// <param name="array">
          /// Array for sorting.
          /// </param>
          public static void QuickSort(ref int[] array)
          {
               if (array == null)
                    throw new ArgumentException(null);
               if (array.Length <= 0)
                    throw new ArgumentException(nameof(array));
               QuickSort(ref array, 0, array.Length - 1);
          }

          /// <summary>
          /// User method for merge sorting (using buffer) .
          /// </summary>
          /// <param name="array">
          /// Array for sorting.
          /// </param>
          public static void MergeSort(ref int[] array)
          {
               if (array == null)
                    throw new ArgumentException(null);
               if (array.Length <= 0)
                    throw new ArgumentException(nameof(array));
               MergeSort(ref array, 0, array.Length - 1);
          }

          private static void QuickSort(ref int[] array, int first, int last)
          {
               int p = array[(last - first) / 2 + first];
               int temp;
               int i = first, j = last;
               while (i <= j)
               {
                    while (array[i] < p && i <= last)
                         ++i;
                    while (array[j] > p && j >= first)
                         --j;
                    if (i <= j)
                    {
                         temp = array[i];
                         array[i] = array[j];
                         array[j] = temp;
                         ++i; --j;
                    }
               }
               if (j > first) QuickSort(ref array, first, j);
               if (i < last) QuickSort(ref array, i, last);
          }

          private static void MergeSort(ref int[] array, int first, int last)
          {
               if (last <= first)
                    return;
               int mid = first + (last - first) / 2;
               MergeSort(ref array, first, mid);
               MergeSort(ref array, mid + 1, last);
               int[] buf = new int[array.Length];
               for (int k = first; k <= last; k++)
                    buf[k] = array[k];
               int i = first, j = mid + 1;
               for (int k = first; k <= last; k++)
               {
                    if (i > mid)
                    {
                         array[k] = buf[j];
                         j++;
                    }
                    else 
                         if (j > last)
                         {
                              array[k] = buf[i];
                              i++;
                         }
                         else 
                              if (buf[j] < buf[i])
                              {
                                   array[k] = buf[j];
                                   j++;
                              }
                              else
                              {
                                   array[k] = buf[i];
                                   i++;
                              }
               }
          }
     }
}