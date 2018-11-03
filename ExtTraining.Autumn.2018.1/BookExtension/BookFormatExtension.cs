using BookLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookExtension
{
    public static class BookFormatExtension
    {
          public static string GetСentury(this Book book)
          {
               int result = (Convert.ToInt32(book.Year) / 100) + ((Convert.ToInt32(book.Year) % 100 == 0) ? 0 : 1);
               return result.ToString();
          }
    }
}
