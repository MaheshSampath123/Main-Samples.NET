using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Samples
{
    class ThreadUsingcs
    {
        static void Main(string[] args)
        {
            Thread t = Thread.CurrentThread;
           
            t.Name = "Main Thread";
            Console.WriteLine("Current Executing Thread is:"+Thread.CurrentThread.Name);
        }
    }
}
