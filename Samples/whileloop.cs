using System;
using System.Collections.Generic;
using System.Text;

namespace MainClass
{
    class whileloop
    { 
        public void whileloops()
        {
            int i = 1;
            
            while(i<=5)
            {
                Console.WriteLine("*"+" ");
                i++;
            }
        }
        static void Main(string[] args)
        {
            whileloop n = new whileloop();
            n.whileloops();
        }
    }
}
