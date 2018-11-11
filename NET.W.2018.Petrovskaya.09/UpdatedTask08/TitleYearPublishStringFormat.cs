﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdatingPreviousTasks
{
     /// <summary>
     /// Present description of book in format: "Book record: Title, Year, Publisher"
     /// </summary>
     public class TitleYearPublishStringFormat : IStringFormat
     {
          public string PresentToString(Book book)
          {
               return string.Format("Book record: {0}, {1}, {2}", book.Title, book.Year, book.Publisher);
          }
     }
}
