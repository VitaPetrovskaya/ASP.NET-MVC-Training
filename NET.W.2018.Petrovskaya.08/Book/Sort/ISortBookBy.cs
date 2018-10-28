﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
     public interface ISortBooksBy
     {
          IEnumerable<Book> SortBooksByTag(List<Book> books);
     }
}
