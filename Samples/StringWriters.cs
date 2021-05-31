using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Samples
{
    class StringWriters
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            StringWriter sw = new StringWriter(sb);
             sw.Write(10);
             sw.Write(20);
             sw.Write(30);
             sw.Write(40);
             sw.Write(50);
            sw.Write("sampath");
            sw.Write("mahesh");
            sw.Flush();
            sw.Close();
            StringReader sr = new StringReader(sb.ToString());
            Console.WriteLine(sr.ReadLine());



        }
    }
}
