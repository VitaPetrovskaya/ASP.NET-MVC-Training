using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
     class SortBooksByYear: ISortBooksBy
     {
          public List<Book> listOfBooks;

          public SortBooksByYear(List<Book> books)
          {
               listOfBooks = books;
          }

          public List<Book> SortBooksByTag()
          {
               var sortedBooks = from b in listOfBooks
                                 orderby b.Year
                                 select b;
               return (List<Book>)sortedBooks;
          }
     }
}
