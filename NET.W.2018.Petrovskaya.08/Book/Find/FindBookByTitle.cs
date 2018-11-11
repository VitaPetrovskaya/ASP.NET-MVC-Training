using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
     public class FindBookByTitle : IFindBookBy
     {
          private string title;
          private List<Book> listOfBooks;

          public FindBookByTitle(string input_title)
          {
               title = input_title;
          }

          /// <summary>
          /// Search book in list by input title.
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
                    if (bookInList.Title == title)
                    {
                         return bookInList;
                    }
               }

               return null;
          }
     }
}