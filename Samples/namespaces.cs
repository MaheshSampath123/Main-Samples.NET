using System;
using System.Collections.Generic;
using System.Text;

namespace MainClass
{
    class namespaces
    {
        public void start()
        {
            Console.WriteLine("hello");
        }
        static void Main(string[] args)
        {
            namespaces n = new namespaces();
            n.start();
        }
    }
}
namespace anotherone
{
    namespace getting
    {
        class using1
        {
            public void sample()
            {
                Console.WriteLine("world");
            }
        }
    }
}