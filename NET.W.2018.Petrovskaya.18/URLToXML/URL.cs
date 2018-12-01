using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URLToXML
{
     public class URL
     {
          private string hostName;
          private List<string> segments;
          private List<Parameter> parameters;

          public URL(string hostName, List<string> segments, List<Parameter> parameters)
          {
               this.hostName = hostName;
               this.segments = segments;
               this.parameters = parameters;
          }

          public string GetHostName()
          {
               return hostName;
          }

          public List<string> GetSegments()
          {
               return segments;
          }

          public List<Parameter> GetParameters()
          {
               return parameters;
          }
     }
}
