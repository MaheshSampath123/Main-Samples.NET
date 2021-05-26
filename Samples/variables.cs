using System;
using System.Collections.Generic;
using System.Text;

namespace MainClass
{
    class variables
    {
        static int b = 20;
        readonly int d = 40;
        public void variable()
        {
            int a = 10;
            const int c = 30;
            Console.WriteLine(a+" "+b+" "+c+" "+d);
            
        }
        static void Main(string[] args)
        {
            variables n = new variables();
            n.variable();
        }
    }
}
