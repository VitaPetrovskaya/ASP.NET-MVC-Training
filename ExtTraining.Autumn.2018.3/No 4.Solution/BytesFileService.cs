using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No4.Solution
{
     /// <summary>
     /// Contains properties and methods for files with random bytes.
     /// </summary>
     public class BytesFileService : IFileService
     {
          public string WorkingDirectory
          {
               get { return "Files with random bytes"; }
               set { }
          }

          public string FileExtension
          {
               get { return ".bytes"; }
               set { }
          }

          /// <summary>
          /// Method for generating content file.
          /// </summary>
          /// <param name="contentLength">
          /// Length of content.
          /// </param>
          /// <returns>
          /// Array of random bytes.
          /// </returns>
          public byte[] GenerateFileContent(int contentLength)
          {
               var random = new Random();
               var fileContent = new byte[contentLength];
               random.NextBytes(fileContent);
               return fileContent;
          }

          /// <summary>
          /// File creation and filling.
          /// </summary>
          /// <param name="fileName"></param>
          /// <param name="content"></param>
          public void WriteBytesToFile(string fileName, byte[] content)
          {
               if (!Directory.Exists(WorkingDirectory))
               {
                    Directory.CreateDirectory(WorkingDirectory);
               }

               File.WriteAllBytes($"{WorkingDirectory}//{fileName}", content);
          }
     }
}
