using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdatingPreviousTasks
{
     public class FullStringFormat : IStringFormat
     {
          public string PresentToString(Book book)
          {
               return string.Format("Book record: {0}, {1}, {2}, {3}, {4}, {5}, {6}", book.ISBN, book.Author, book.Title, book.Publisher, book.Year, book.NumOfPages, book.Price);
          }
     }
}
