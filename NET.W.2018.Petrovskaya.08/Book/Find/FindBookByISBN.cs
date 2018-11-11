using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
     public class FindBookByISBN : IFindBookBy
     {
          private string isbn;
          private List<Book> listOfBooks;

          public FindBookByISBN(string input_isbn)
          {
               isbn = input_isbn;
          }

          /// <summary>
          /// Search book in list by input ISBN
          /// </summary>
          /// <param name="books">
          /// List of books.
          /// </param>
          /// <returns>
          /// Necessary book.
          /// </returns>
          public Book FindBookByTag(List<Book> books)
          {
               listOfBooks = books;
               foreach (Book bookInList in listOfBooks)
               {
                    if (bookInList.ISBN == isbn)
                    {
                         return bookInList;
                    }
               }

               return null;
          }
     }
}
