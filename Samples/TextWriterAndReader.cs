using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace Samples
{
    class TextWriterAndReader
    {
        static void Main(string[] args)
        {
            string fpath = @"D:\Test1223.txt";
            // Check file if exists
          /*  if (File.Exists(fpath))
            {
                File.Delete(fpath);
            }*/
            // Create the file
              using (TextWriter wr = File.CreateText(fpath))
              {
                  wr.WriteLine("Hi");
                  wr.WriteLine("\r\nWelcome to Tutlane");
                  wr.WriteLine("\r\nTextWriter Example");
              }
            using (TextReader n = File.OpenText(fpath))
            {
                Console.WriteLine(n.ReadToEnd());
            }
            Console.ReadLine();

        }

       
    }
}
