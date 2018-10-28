using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
     class FindBookByISBN : IFindBookBy
     {
          public string ISBN;
          public List<Book> listOfBooks;

          public FindBookByISBN(string isbn, List<Book> books)
          {
               ISBN = isbn;
               listOfBooks = books;
          }

          public Book FindBookByTag()
          {
               foreach (Book bookInList in listOfBooks)
                    if (bookInList.ISBN == ISBN)
                         return bookInList;
               return null;
          }
     }
}
