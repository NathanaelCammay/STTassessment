using System;
using System.IO;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using System.Text;

namespace PackageLibrary
{
    public class Packer
    {
        private static string? inputResult;

        public static string Pack(string absoluteFilePath)
        {

            if (absoluteFilePath == null)
            {
                throw new ArgumentNullException(nameof(absoluteFilePath));  // throw exception in event that file object is null
            }

            if (File.Exists(absoluteFilePath))
            {
                // Open the stream and read it back.
                using (FileStream fs = File.OpenRead(absoluteFilePath))
                {
                    byte[] b = new byte[1024];
                    var temp = new UTF8Encoding(true);  // UTF8Encoding object

                    while (fs.Read(b, 0, b.Length) > 0)
                    {
                         inputResult = temp.GetString(b);
                    }

                    if (inputResult == null)
                    {
                        throw new APIException("File was not read");
                    }
                    return inputResult;
                }
            }
            else
            {
                throw new APIException("File not found, check file path and configuration");
            }

            
        }
    }
}