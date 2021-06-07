using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Samples
{
    class MultiThreading
    {
        public static  void Test4()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("Test-1:" + " " + i);
            }
        }
        public static void Test5()
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
        public static void Test6()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("Test-3" + " " + i);
            }
        }
        static void Main(string[] args)
        {
            
            Thread t1 = new Thread(Test4);
            Thread t2 = new Thread(Test5);
            Thread t3 = new Thread(Test6);
            t2.Priority = ThreadPriority.Highest;
            t1.Start();
            t2.Start();
            t3.Start();
            Console.ReadLine();
        }
    }
}
