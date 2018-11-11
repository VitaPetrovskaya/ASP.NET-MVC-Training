using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
     public class SortBooksByTitle : ISortBooksBy
     {
          private List<Book> listOfBooks;

          /// <summary>
          /// Sort books by title in alphabet order.
          /// </summary>
          /// <param name="books"></param>
          /// <returns></returns>
          public IEnumerable<Book> SortBooksByTag(List<Book> books)
          {
               listOfBooks = books;
               var sortedBooks = from b in listOfBooks
                                 orderby b.Title
                                 select b;
               return sortedBooks;
          }
     }
}
