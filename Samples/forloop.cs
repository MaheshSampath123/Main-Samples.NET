using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace MainClass
{
    class forloop
    {
        public void forloops()
        {
            Stopwatch sw1 = new Stopwatch();
            sw1.Start();
            for (int i=1;i<=5;i++)
            {
                Console.Write(i);
            }
            Console.WriteLine();
            sw1.Stop();
            Console.WriteLine("Time Taken By forloop:"+sw1.ElapsedMilliseconds);
        }
       
        public void forloops1()
        {
            Stopwatch sw2 = new Stopwatch();
            sw2.Start();
            for (int i = 1; i <= 5; i++)
            { 
                for (int j = i;j <= 5; j++)
                {
                    Console.Write("*"+" ");
                }
                Console.WriteLine("\n");
            }
            sw2.Stop();
            Console.WriteLine("Time Taken by the nestedLoop:"+sw2.ElapsedMilliseconds);
        }
        static void Main(string[] args)
        {
            forloop n = new forloop();
            n.forloops();
            n.forloops1();
        }
    }
}