using System;
using System.Collections.Generic;
using System.Text;

namespace MainClass
{
    class Constructor
    {
        int a;
        int b;
        static void Main(string[] args)
        {
            Constructor n = new Constructor();
            Console.WriteLine(n.a + " " +n.b);
        }
    }
}
