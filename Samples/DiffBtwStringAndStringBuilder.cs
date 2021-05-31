using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace Samples
{
    class DiffBtwStringAndStringBuilder
    {
        static void Main(string[] args)
        {
            string s = " ";
            Stopwatch sw1 = new Stopwatch();
            sw1.Start();
            for(int i=1;i<=100000;i++)
            {
                s = s + i;
            }
            sw1.Stop();

            StringBuilder sb = new StringBuilder();
            Stopwatch sw2 = new Stopwatch();
            sw2.Start();
            for(int i=1;i<=100000;i++)
            {
                sb.Append(i);
            }
            sw2.Stop();
            Console.WriteLine("Time Taken By the String:"+sw1.ElapsedMilliseconds);
            Console.WriteLine("Time Taken By the StringBuilder:"+sw2.ElapsedMilliseconds);
            Console.ReadLine();
        }
    }
}
