using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
     /// <summary>
     /// Interface to show info about book.
     /// </summary>
     public interface IStringFormat
     {
          string PresentToString(Book book);
     }
}
