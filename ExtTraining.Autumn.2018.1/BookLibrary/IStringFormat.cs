﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
     public interface IStringFormat
     {
          string PresentToString(Book book);
     }
}
