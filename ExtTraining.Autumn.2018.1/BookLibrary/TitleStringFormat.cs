using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
     /// <summary>
     /// Present info about book in form: "Book record: Title"
     /// </summary>
     public class TitleStringFormat : IStringFormat
     {
          public string PresentToString(Book book)
          {
               return "Book record:" + book.Title;
          }
     }
}
