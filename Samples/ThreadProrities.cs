using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Samples
{
    class ThreadProrities
    {
        static long count1, count2;
        public static void IncrementCount1()
        {
            while (true)
                count1 += 1;
        }
        public static void IncrementCount2()
        {
            while (true)
                count2 += 1;
        }
        static void Main(string[] args)
        {
            try
            {
                Thread t1 = new Thread(IncrementCount1);
            Thread t2 = new Thread(IncrementCount2);
            t1.Priority = ThreadPriority.Lowest;
            t2.Priority = ThreadPriority.Highest;
            t1.Start();
            t2.Start();
            Console.WriteLine("main thread going to sleep");
            Thread.Sleep(1000);
            Console.WriteLine("main thread woke up");
           
                t1.Abort();
                t2.Abort();
                t1.Join();
                t2.Join();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
            finally
            {
                Console.WriteLine("count1:" + count1);
                Console.WriteLine("count2:" + count2);
                Console.ReadLine();
            }

        }
    }
}
