using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No4.Solution
{
     /// <summary>
     /// Contains method for generating different files using IFileService object.
     /// </summary>
     public class RandomFileGenerator
     {
          /// <summary>
          /// Method creates files and fills them in accordance with the service.
          /// </summary>
          /// <param name="filesCount">
          /// Number of files.
          /// </param>
          /// <param name="contentLength">
          /// Length of file context.
          /// </param>
          public static void GenerateFiles(IFileService service, int filesCount, int contentLength)
          {
               for (var i = 0; i < filesCount; ++i)
               {
                    var generatedFileContent = service.GenerateFileContent(contentLength);
                    var generatedFileName = $"{Guid.NewGuid()}{service.FileExtension}";
                    service.WriteBytesToFile(generatedFileName, generatedFileContent);
               }
          }
     }
}
