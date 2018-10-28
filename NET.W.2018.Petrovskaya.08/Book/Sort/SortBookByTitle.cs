using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
     class SortBookByTitle: ISortBooksBy
     {
          public List<Book> listOfBooks;

          public SortBookByTitle(List<Book> books)
          {
               listOfBooks = books;
          }

          public List<Book> SortBooksByTag()
          {
               var sortedBooks = from b in listOfBooks
                                 orderby b.Title
                                 select b;
               return (List<Book>)sortedBooks;
          }
     }
}
