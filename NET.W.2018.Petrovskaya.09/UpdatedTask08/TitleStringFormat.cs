using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdatingPreviousTasks
{
     /// <summary>
     /// Present description of book in format: "Book record: Title"
     /// </summary>
     public class TitleStringFormat : IStringFormat
     {
          public string PresentToString(Book book)
          {
               return string.Format("Book record: {0}", book.Title);
          }
     }
}
