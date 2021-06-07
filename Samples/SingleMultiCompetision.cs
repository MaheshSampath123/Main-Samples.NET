using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Diagnostics;

namespace Samples
{
   
        class singleThread
        {
            public static void Test1()
            {
                for (int i = 1; i <= 100; i++)
                {
                    Console.WriteLine("Test-1:" + " " + i);
                }
            }
            public static void Test2()
            {
                for (int i = 1; i <= 100; i++)
                {
                    Console.WriteLine("Test-2" + " " + i);
                }
            }
            public static void Test3()
            {
                for (int i = 1; i <= 100; i++)
                {
                    Console.WriteLine("Test-3" + " " + i);
                }
            }
          
        }
    class SingleMultiCompetision
    {
        public static void Test4()
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
            Stopwatch sw1 = new Stopwatch();
            sw1.Start();
            SingleThreading s = new SingleThreading();
            s.Test1();
            s.Test2();
            s.Test3();
            sw1.Stop();
            

            Stopwatch sw2 = new Stopwatch();
            sw2.Start();
            Thread t1 = new Thread(Test4);
            Thread t2 = new Thread(Test5);
            Thread t3 = new Thread(Test6);
            t1.Start();
            t2.Start();
            t3.Start();
            sw2.Stop();
            Console.WriteLine("Time Taken single Threading:" + sw1.ElapsedMilliseconds);
            Console.WriteLine("Time Taken MultiThreading:"+sw2.ElapsedMilliseconds);
            Console.ReadLine();
        }
    
    }
}



