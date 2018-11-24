using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
     /// <summary>
     /// Comparer for strings.
     /// </summary>
     public class CompareStringsByLength : IComparer<string>
     {
          /// <summary>
          /// Compare by length.
          /// </summary>
          /// <param name="first"></param>
          /// <param name="second"></param>
          /// <returns></returns>
          public int Compare(string first, string second)
          {
               if (first == null)
               {
                    if (second == null)
                    {
                         return 0;
                    }

                    return -2;
               }

               if (second == null)
               {
                    return -2;
               }

               if (first.Length - second.Length < 0)
               {
                    return -1;
               }

               if (first.Length - second.Length > 0)
               {
                    return 1;
               }

               return 0;
          }
     }
}
