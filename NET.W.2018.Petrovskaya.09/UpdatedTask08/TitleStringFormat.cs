using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdatingPreviousTasks
{
     public class TitleStringFormat : IStringFormat
     {
          public string PresentToString(Book book)
          {
               return string.Format("Book record: {0}", book.Title);
          }
     }
}
