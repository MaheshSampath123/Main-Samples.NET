using System;
using System.Collections.Generic;
using System.Text;

namespace MainClass
{
    class StringFormatting
    {
        public void Interpolated()
        {
            Console.WriteLine($@"Testing \n 1 2 {5-3}
                               new lin");
        }
        public void EscapingQoutes()
        {
            Console.WriteLine(@"""I Don't Think so,""he said.");
        }
        public void nonverbatim()
        {
            Console.WriteLine("c:\temp\newfile.txt");
        }
        public void stringrev()
        {
            string s = "hello all";
            char[] a = s.ToCharArray();
            System.Array.Reverse(a);
            string r = new string(a);
            Console.WriteLine(r);
        }
        public void check()
        {
            string s = "sample";
            string s1 = "\n";
            bool result,result1;
            result = string.IsNullOrEmpty(s);
            result1 = string.IsNullOrWhiteSpace(s1);
            Console.WriteLine(result+" "+result1);
            Console.ReadLine();
        }
        public void trim()
        {
            string s = "   Hello World   ";
            string s1 = "{(Hi*!";
            Console.WriteLine(s.Trim());
            Console.WriteLine(s1.TrimStart('{','('));
            Console.WriteLine(s1.TrimEnd('*','!'));
            Console.ReadLine();
        }
        public void convertion()
        {
            int a = 15;
            Console.WriteLine(Convert.ToString(a,2));
        }
       
    }
}
