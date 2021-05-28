using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Samples
{
    class FileStreamRead
    {
        static void Main(string[] args)
        {
            string fpath = @"D:\Test.txt";
            // Check if file exists
            if (File.Exists(fpath))
            {
                // Open the file and read
                using (FileStream fs = File.OpenRead(fpath))
                {
                    byte[] b = new byte[1024];
                    UTF8Encoding encode = new UTF8Encoding(true);
                    while (fs.Read(b, 0, b.Length) > 0)
                    {
                        Console.WriteLine(encode.GetString(b));
                    }
                }
            }
            Console.ReadLine();
        }
    }

}
