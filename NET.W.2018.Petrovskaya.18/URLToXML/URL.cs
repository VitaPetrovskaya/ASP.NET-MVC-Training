using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URLToXML
{
     /// <summary>
     /// Contains info about URL.
     /// </summary>
     public class URL
     {
          private string hostName;
          private List<string> segments;
          private List<Parameter> parameters;

          /// <summary>
          /// Constructor initializes private fields.
          /// </summary>
          /// <param name="hostName"></param>
          /// <param name="segments"></param>
          /// <param name="parameters"></param>
          public URL(string hostName, List<string> segments, List<Parameter> parameters)
          {
               this.hostName = hostName;
               this.segments = segments;
               this.parameters = parameters;
          }

          /// <summary>
          /// Returns host name.
          /// </summary>
          /// <returns></returns>
          public string GetHostName()
          {
               return hostName;
          }

          /// <summary>
          /// Returns list of segments.
          /// </summary>
          /// <returns></returns>
          public List<string> GetSegments()
          {
               return segments;
          }

          /// <summary>
          /// Returns list of parameters.
          /// </summary>
          /// <returns></returns>
          public List<Parameter> GetParameters()
          {
               return parameters;
          }
     }
}
