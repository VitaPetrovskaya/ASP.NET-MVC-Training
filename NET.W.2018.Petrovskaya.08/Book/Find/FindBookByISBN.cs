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

          public FindBookByISBN(string input_isbn)
          {
               ISBN = input_isbn;
          }

          public Book FindBookByTag(List<Book> books)
          {
               listOfBooks = books;
               foreach (Book bookInList in listOfBooks)
                    if (bookInList.ISBN == ISBN)
                         return bookInList;
               return null;
          }
     }
}
