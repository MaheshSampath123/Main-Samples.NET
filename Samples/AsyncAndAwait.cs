using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Samples
{
    class AsyncAndAwait
    {
        public async void  display()
        {
            
            Console.WriteLine("helloBoss");
        }
        public void display1()
        {
            Console.WriteLine(1);
        }
        static void Main(string[] args)
        {
            AsyncAndAwait n = new AsyncAndAwait();
            n.display();
        }
    }
}
