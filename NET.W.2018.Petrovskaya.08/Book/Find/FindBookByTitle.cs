using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
     class FindBookByTitle: IFindBookBy
     {
          public string title;
          public List<Book> listOfBooks;

          public FindBookByTitle(string input_title, List<Book> books)
          {
               title = input_title;
               listOfBooks = books;
          }

          public Book FindBookByTag()
          {
               foreach (Book bookInList in listOfBooks)
                    if (bookInList.Title == title)
                         return bookInList;
               return null;
          }
     }
}
