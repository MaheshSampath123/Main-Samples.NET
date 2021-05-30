using System;
using System.Collections.Generic;
using System.Text;

namespace Samples
{
   class staticstart
    {
        static staticstart()
        {
            Console.WriteLine("static constructor is executed");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("main method ");
        }
    }
}
