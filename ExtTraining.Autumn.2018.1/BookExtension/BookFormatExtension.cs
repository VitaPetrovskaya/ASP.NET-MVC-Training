using System;
using BookLibrary;

namespace BookExtension
{
     /// <summary>
     /// Contain extension method for Book.
     /// </summary>
     public static class BookFormatExtension
     {
          /// <summary>
          /// Extension method for type Book.
          /// </summary>
          /// <param name="book">
          /// Input book.
          /// </param>
          /// <returns>
          /// Century when book was published.
          /// </returns>
          public static string GetСentury(this Book book)
          {
               int result = (Convert.ToInt32(book.Year) / 100) + ((Convert.ToInt32(book.Year) % 100 == 0) ? 0 : 1);
               return result.ToString();
          }
     }
}
