using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdatingPreviousTasks
{
     /// <summary>
     /// Present description of book in format: "Book record: Author, Title"
     /// </summary>
     public class AuthorTitleStringFormat : IStringFormat
     {
          public string PresentToString(Book book)
          {
               return string.Format("Book record: {0}, {1}", book.Author, book.Title);
          }
     }
}
