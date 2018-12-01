using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URLToXML
{
     public class FileService
     {
          public static IEnumerable<URL> ExtractURLFromFile(string filePath)
          {
               IEnumerable<string> lines = File.ReadLines(filePath);
               List<URL> listOfURL = new List<URL>();

               foreach (string line in lines)
               {
                    if (Uri.IsWellFormedUriString(line, UriKind.RelativeOrAbsolute))
                    {
                         Uri uri = new Uri(line);
                         listOfURL.Add(new URL(uri.Host, URLConverter.TransformSegments(uri.Segments), URLConverter.TransformParameters(uri.Query)));
                    }
               }

               return listOfURL;
          } 
     }
}
