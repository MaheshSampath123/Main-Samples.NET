using System;
using System.Collections.Generic;
using System.Text;

namespace Samples
{
    class Class1
    {
        public void test1()
        {
            Console.WriteLine("Method 1");
        }
        public void test2()
        {
            Console.WriteLine("Method 2");
        }

    }
    class InheritenceClass:Class1
    {
        static void Main(string[] args)
        {
            Class1 n = new Class1();
            n.test1();
            n.test2();
        }
    }
}
