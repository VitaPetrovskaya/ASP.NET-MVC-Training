using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No4.Solution
{
     /// <summary>
     /// Includes items that are different for different files.
     /// </summary>
     public interface IFileService
     {
          string WorkingDirectory { get; set; }

          string FileExtension { get; set; }

          byte[] GenerateFileContent(int contentLength);

          void WriteBytesToFile(string fileName, byte[] content);
     }
}
