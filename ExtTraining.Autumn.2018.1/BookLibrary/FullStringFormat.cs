﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
     /// <summary>
     /// Present info about book in form: "Book record: Author, Title, Year, Publisher"
     /// </summary>
     public class FullStringFormat : IStringFormat
     {
          public string PresentToString(Book book)
          {
               return "Book record:" + book.Author + ", " + book.Title + ", " + book.Year + ", " + book.PublishingHous;
          }
     }
}
