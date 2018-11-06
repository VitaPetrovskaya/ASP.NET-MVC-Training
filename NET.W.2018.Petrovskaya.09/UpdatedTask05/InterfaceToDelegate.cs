using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
     /// <summary>
     /// Adapts work with the interface to work with the delegate.
     /// </summary>
     public class InterfaceToDelegate
     {
          private Func<int[], int[], int> compareDelegate;

          /// <summary>
          /// Constructor takes an object-parameter of comparison.
          /// </summary>
          /// <param name="compareMethod"></param>
          public InterfaceToDelegate(IComparer<int[]> compareMethod)
          {
               compareDelegate = compareMethod.Compare;
          }

          public Func<int[], int[], int> Delegate
          {
               get { return compareDelegate; }
               private set { }
          }
     }
}
