﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace URLToXML
{
     /// <summary>
     /// Contains static methods to transform data of URL.
     /// </summary>
     public class URLConverter
     {
          /// <summary>
          /// Converts info about URL in XML element.
          /// </summary>
          /// <param name="url"></param>
          /// <returns></returns>
          public static XElement ConvertURLToXML(URL url)
          {
               XElement xmlElement = new XElement("urlAdress");
               XElement host = new XElement("host", new XAttribute("name", url.GetHostName()));
               xmlElement.Add(host);
               if (url.GetSegments() != null)
               {
                    XElement uri = new XElement("uri");
                    foreach (var item in url.GetSegments())
                    {
                         uri.Add(new XElement("segment", item));
                    }

                    xmlElement.Add(uri);
               }

               if (url.GetParameters() != null)
               {
                    XElement parameters = new XElement("parameters");
                    foreach (var item in url.GetParameters())
                    {
                         parameters.Add(new XElement("parametr", new XAttribute("value", item.Value), new XAttribute("key", item.Key)));
                    }

                    xmlElement.Add(parameters);
               }

               return xmlElement;
          }

          /// <summary>
          /// Transforms sequence of strings in correct form of URL segments.
          /// </summary>
          /// <param name="segments">
          /// Input strings with segments.
          /// </param>
          /// <returns>
          /// Correct segments.
          /// </returns>
          public static List<string> TransformSegments(IEnumerable<string> segments)
          {
               List<string> result = new List<string>();
               string temp;
               if (ReferenceEquals(segments, null))
               {
                    throw new ArgumentNullException(nameof(segments));
               }

               if (segments.Count() == 0)
               {
                    return null;
               }

               foreach (string item in segments)
               {
                    temp = item.Replace("/", string.Empty);
                    if (temp != string.Empty)
                    {
                         result.Add(temp);
                    }
               }

               return result;
          }

          /// <summary>
          /// Find parameters in string.
          /// </summary>
          /// <param name="parameters">
          /// String with parameters.
          /// </param>
          /// <returns>
          /// List of parameters.
          /// </returns>
          public static List<Parameter> TransformParameters(string parameters)
          {
               List<Parameter> result = new List<Parameter>();
               if (ReferenceEquals(parameters, null))
               {
                    throw new ArgumentNullException(nameof(parameters));
               }

               if (parameters == string.Empty)
               {
                    return null;
               }

               parameters = parameters.Replace("?", string.Empty);
               string[] arrayOfParameters = parameters.Split('&');
               string[] temp;
               foreach (string item in arrayOfParameters)
               {
                    temp = item.Split('=');
                    result.Add(new Parameter(temp[0], temp[1]));
               }

               return result;
          }
     }
}
