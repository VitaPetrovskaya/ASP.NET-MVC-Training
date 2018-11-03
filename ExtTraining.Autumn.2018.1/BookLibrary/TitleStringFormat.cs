using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
     public class TitleStringFormat: IStringFormat
     {
          public string PresentToString(Book book)
          {
               return "Book record:" + book.Title;
          }
     }
}
