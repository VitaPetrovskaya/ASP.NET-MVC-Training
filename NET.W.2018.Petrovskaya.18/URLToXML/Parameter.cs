using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URLToXML
{
     public class Parameter
     {
          public Parameter(string value, string key)
          {
               Value = value;
               Key = key;
          }

          public string Value { get; set; }

          public string Key { get; set; }
     }
}
