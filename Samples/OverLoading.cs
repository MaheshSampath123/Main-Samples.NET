using System;
using System.Collections.Generic;
using System.Text;

namespace Samples
{
    class LoadParent
    {
        public void show()
        {
            Console.WriteLine("parent show method is called");
        }
        public void test()
        {
            Console.WriteLine("parent test method is called");
        }
    }
    class LoadChild:LoadParent
    {
        public void show(int i) ///OverLoading the same method
        {
            Console.WriteLine("child show method is called");
        }
    }
    class OverLoading
    {
        static void Main(string[] args)
        {
            LoadChild c = new LoadChild();
            c.show();
            c.show(10);
            c.test();
            Console.ReadLine();
        }
    }
}
