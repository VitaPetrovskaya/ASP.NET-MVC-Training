using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
     /// <summary>
     /// Comparer for Points.
     /// </summary>
     public class ComparePoints : IComparer<Point>
     {
          /// <summary>
          /// Compare by length between point and (0,0).
          /// </summary>
          /// <param name="first"></param>
          /// <param name="second"></param>
          /// <returns></returns>
          public int Compare(Point first, Point second)
          {
               double count = Math.Sqrt((first.X * first.X) + (first.Y * first.Y)) - Math.Sqrt((second.X * second.X) + (second.Y * second.Y));
               if (count < 0)
               {
                    return -1;
               }

               if (count > 0)
               {
                    return 1;
               }

               return 0;
          }
     }
}
