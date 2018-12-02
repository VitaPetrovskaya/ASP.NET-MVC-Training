using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace URLToXML
{
     public class Converter
     {
          /// <summary>
          /// Convert list of URLs to XML and save result in file.
          /// </summary>
          /// <param name="listOfUrls">
          /// Enumerated URL sequence.
          /// </param>
          /// <param name="storage">
          /// Storage file path.
          /// </param>
          public static void URLToXML(IEnumerable<URL> listOfUrls, string storage)
          {
               XDocument document = new XDocument();
               XElement root = new XElement("urlAddresses");
               foreach (var url in listOfUrls)
               {
                    root.Add(URLConverter.ConvertURLToXML(url));
               }

               document.Add(root);
               document.Save(storage);
          }
     }
}
