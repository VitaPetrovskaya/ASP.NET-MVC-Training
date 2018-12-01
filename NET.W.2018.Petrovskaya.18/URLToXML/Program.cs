using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URLToXML
{
     public class Program
     {
          public static void Main(string[] args)
          {
               string source = @"source.txt";
               string storage = @"storage.txt";
               Converter.URLToXML(FileService.ExtractURLFromFile(source), storage);
               Console.ReadLine();
          }
     }
}
