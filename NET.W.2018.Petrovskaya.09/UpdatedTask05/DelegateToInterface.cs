using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
     /// <summary>
     /// Adapts work with the delegate to work with the interface.
     /// </summary>
     public class DelegateToInterface : IComparer<int[]>
     {
          private Func<int[], int[], int> comparer;

          /// <summary>
          /// Constructor takes a delegate-parameter of comparison.
          /// </summary>
          /// <param name="compareMethod"></param>
          public DelegateToInterface(Func<int[], int[], int> compareMethod)
          {
               comparer = compareMethod;
          }

          public int Compare(int[] arr1, int[] arr2)
          {
               return comparer(arr1, arr2);
          }
     }
}
