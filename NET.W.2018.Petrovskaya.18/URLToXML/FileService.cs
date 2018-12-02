using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace URLToXML
{
     /// <summary>
     /// Contains method to extracting data from file.
     /// </summary>
     public class FileService
     {
          /// <summary>
          /// Saves string mismatch to expected type.
          /// </summary>
          private static Logger logger;

          /// <summary>
          /// Extracts URLs from file.
          /// </summary>
          /// <param name="filePath">
          /// Path to file.
          /// </param>
          /// <returns>
          /// Enumerated URL sequence.
          /// </returns>
          public static IEnumerable<URL> ExtractURLFromFile(string filePath)
          {
               logger = LogManager.GetCurrentClassLogger();
               IEnumerable<string> lines = File.ReadLines(filePath);
               List<URL> listOfURL = new List<URL>();

               if (filePath == null)
               {
                    logger.Error("Specified file path is null.");
               }

               foreach (string line in lines)
               {
                    try
                    {
                         Uri uri = new Uri(line);
                         listOfURL.Add(new URL(uri.Host, URLConverter.TransformSegments(uri.Segments), URLConverter.TransformParameters(uri.Query)));
                    }
                    catch
                    {
                         logger.Error(line + " can not be processed.");
                    }
               }

               return listOfURL;
          } 
     }
}
