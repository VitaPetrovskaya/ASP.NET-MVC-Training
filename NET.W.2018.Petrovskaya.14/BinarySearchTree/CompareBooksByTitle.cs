using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
     /// <summary>
     /// Comparer for Book.
     /// </summary>
     public class CompareBooksByTitle : IComparer<Book.Book>
     {
          /// <summary>
          /// Compare by title.
          /// </summary>
          /// <param name="first"></param>
          /// <param name="second"></param>
          /// <returns></returns>
          public int Compare(Book.Book first, Book.Book second)
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

               if (first.Title.CompareTo(second.Title) < 0)
               {
                    return -1;
               }

               if (first.Title.CompareTo(second.Title) > 0)
               {
                    return 1;
               }

               return 0;
          }
     }
}
