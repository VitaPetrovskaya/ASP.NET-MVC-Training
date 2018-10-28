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

          public FindBookByTitle(string input_title)
          {
               title = input_title;
          }

          public Book FindBookByTag(List<Book> books)
          {
               listOfBooks = books;
               foreach (Book bookInList in listOfBooks)
                    if (bookInList.Title == title)
                         return bookInList;
               return null;
          }
     }
}
