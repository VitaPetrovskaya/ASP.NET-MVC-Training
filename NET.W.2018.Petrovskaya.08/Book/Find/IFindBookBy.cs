using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
     /// <summary>
     /// Interface for searching necessary book.
     /// </summary>
     public interface IFindBookBy
     {
          Book FindBookByTag(List<Book> books);
     }
}
