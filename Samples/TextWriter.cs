using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace Samples
{
    class TextWriter
    {
        static void Main(string[] args)
        {
            string fpath = @"D:\Test.txt";
            // Check file if exists
            if (File.Exists(fpath))
            {
                File.Delete(fpath);
            }
            // Create the file
/*using (TextWriter wr = File.CreateText(fpath))
            {
                wr.WriteLine("Hi");
                wr.WriteLine("\r\nWelcome to Tutlane");
                wr.WriteLine("\r\nTextWriter Example");
            }*/

        }

       
    }
}
