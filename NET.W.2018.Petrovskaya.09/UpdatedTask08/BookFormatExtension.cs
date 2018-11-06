using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdatingPreviousTasks
{
     public static class BookFormatExtension
     {
          /// <summary>
          /// Present info about the book in the form of a description.
          /// </summary>
          /// <param name="book">
          /// Current book.
          /// </param>
          /// <returns>
          /// String with description.
          /// </returns>
          public static string GetBookDescription(this Book book)
          {
               if (ReferenceEquals(book, null))
               {
                    throw new ArgumentNullException();
               }

               string result = string.Format("Книга {0} автор {1}. Издательством {2} она была напечатана в {3}. Всего {4} страниц.", book.Title, book.Author, book.Publisher, book.Year, book.NumOfPages);
               return result;
          }
     }
}
