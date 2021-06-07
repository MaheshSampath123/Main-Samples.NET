using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Samples
{
    class SingleThreading
    {
        public void Test1()
        {
            for(int i=1;i<=100;i++)
            {
                Console.WriteLine("Test-1:"+" "+i);
            }
        }
        public void Test2()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i == 50)
                {
                    Console.WriteLine("Stop");
                    Thread.Sleep(5000);
                    Console.WriteLine("again start");
                }
                else
                    Console.WriteLine("Test-2" + " " + i);
            }
        }
        public void Test3()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("Test-3"+" "+i);
            }
        }
        static void Main(string[] args)
        {
            SingleThreading s = new SingleThreading();
            s.Test1();
            s.Test2();
            s.Test3();
            Console.ReadLine();
        }
    }
}
