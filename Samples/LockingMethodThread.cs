using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Samples
{
    class LockingMethodThread
    {
        public void display()
        {
            lock (this)
            {
                Console.Write("[ C sharp is an");
                Thread.Sleep(5000);
                Console.WriteLine("Object Oriented Language");
            }
        }
        static void Main(string[] args)
        {
            LockingMethodThread L = new LockingMethodThread();
            Thread t1 = new Thread(L.display);
            Thread t2 = new Thread(L.display);
            Thread t3 = new Thread(L.display);
            t1.Start();
            t2.Start();
            t3.Start();
            Console.ReadLine();
        }
    }
}
