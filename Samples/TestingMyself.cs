using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Samples
{
    class TestingMyself
    {
        public TestingMyself()
        {
            Console.WriteLine("Constructor called");
        }
        public static void start()
        {
            int a = 10;int b = 201;
            Console.WriteLine(a+b);
        }
       
        static void Main(string[] args)
        {
            TestingMyself n = new TestingMyself();
            start();
            
            Console.WriteLine("heloo ");
        }
    }
}
