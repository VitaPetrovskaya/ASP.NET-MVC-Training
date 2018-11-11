using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdatingPreviousTasks
{
     /// <summary>
     /// Interface for book description.
     /// </summary>
     public interface IStringFormat
     {
          string PresentToString(Book book);
     }
}
