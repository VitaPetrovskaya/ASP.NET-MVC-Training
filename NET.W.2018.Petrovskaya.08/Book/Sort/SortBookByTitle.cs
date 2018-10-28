using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
     class SortBooksByTitle: ISortBooksBy
     {
          public List<Book> listOfBooks;

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
