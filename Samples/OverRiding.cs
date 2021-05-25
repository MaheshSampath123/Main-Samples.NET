using System;
using System.Collections.Generic;
using System.Text;

namespace Samples
{
    class LoadingParent
    {
        public void show()
        {
            Console.WriteLine("parent show method is called");
        }
        public virtual void test()  //Overridable
        {
            Console.WriteLine("parent test method is called");
        }
    }
    class LoadingChild : LoadingParent
    {
        public void show(int i) ///OverLoading the same method
        {
            Console.WriteLine("child show method is called");
        }
        public override void test() ///overriding
        {
            Console.WriteLine("child test method is called");
        }
    }
    class OverRiding
    {
        static void Main(string[] args)
        {
            LoadingChild c = new LoadingChild();
            c.show();
            c.show(10);
            c.test();
            Console.ReadLine();
        }
    }
}
