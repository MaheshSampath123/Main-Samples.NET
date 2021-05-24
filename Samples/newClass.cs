using System;
using System.Collections.Generic;
using System.Text;

namespace MainClass
{
    class classA
    {
        public void getdata()
        {
            Console.WriteLine("method1");
        }
    }
    class newClass:classA
    {
        static void Main(string[] args)
        {
            newClass n = new newClass();
            n.getdata();
            Console.ReadLine();
        }
    }
}
