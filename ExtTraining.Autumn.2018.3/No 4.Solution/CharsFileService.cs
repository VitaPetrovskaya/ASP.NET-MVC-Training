using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No4.Solution
{
     /// <summary>
     /// Contains properties and methods for files with random chars.
     /// </summary>
     public class CharsFileService : IFileService
     {
          public string WorkingDirectory
          {
               get { return "Files with random chars"; }
               set { }
          }

          public string FileExtension
          {
               get { return ".txt"; }
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
               var generatedString = this.RandomString(contentLength);
               var bytes = Encoding.Unicode.GetBytes(generatedString);
               return bytes;
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

          /// <summary>
          /// Method for generating chars.
          /// </summary>
          /// <param name="Size">
          /// Number of chars in output string.
          /// </param>
          /// <returns>
          /// Generating string.
          /// </returns>
          private string RandomString(int size)
          {
               var random = new Random();
               const string Input = "abcdefghijklmnopqrstuvwxyz0123456789";
               var chars = Enumerable.Range(0, size).Select(x => Input[random.Next(0, Input.Length)]);
               return new string(chars.ToArray());
          }
     }
}
