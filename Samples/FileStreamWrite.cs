using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Samples
{
    class FileStreamWrite
    {
        static void Main(string[] args)
        {
            string fpath = @"D:\Test.txt";
            // Delete file if exists
            if (File.Exists(fpath))
            {
                File.Delete(fpath);
            }
            // Create the file
            using (FileStream fs = File.Create(fpath))
            {
                AddTexttoFile(fs, "Hi");
                AddTexttoFile(fs, "\r\nWelcome to Programming");
                AddTexttoFile(fs, "\r\nFileStream Example");
            }
        }
        private static void AddTexttoFile(FileStream fs, string value)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(value);
            fs.Write(info, 0, info.Length);
        }
    }
}

