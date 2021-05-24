using System;
using System.Collections.Generic;
using System.Text;

namespace MainClass
{
    class forloop
    {
        public void forloops()
        {
            for (int i=1;i<=5;i++)
            {
                Console.WriteLine(i);
            }
        }
        public void forloops1()
        {
            for (int i = 1; i <= 5; i++)
            { 
                for (int j = i;j <= 5; j++)
                {
                    Console.WriteLine("*"+" ");
                }
                Console.WriteLine("\n");
            }
        }
    }
}