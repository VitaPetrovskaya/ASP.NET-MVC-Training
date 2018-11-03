using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
     public class AuthorTitleYearStringFormat: IStringFormat
     {
          public string PresentToString(Book book)
          {
               return "Book record:" + book.Author + ", " + book.Title + ", " + book.Year;
          }
     }
}
