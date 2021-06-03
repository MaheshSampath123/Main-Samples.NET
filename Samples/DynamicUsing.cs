using System;
using System.Collections.Generic;
using System.Text;

namespace Samples
{
    class DynamicUsing
    {
        static void Main(string[] args)
        {
            int a1 = 10;
            Console.WriteLine(a1.Factorial());
            object a = 10;
            object b = "sampath";
           
            var c = 10;
            var d = "mahesh";
            Console.WriteLine(c+d);
            dynamic e = 10;
            dynamic f = "veeru";
            Console.WriteLine(e+f);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);




            /* int a = 10;
             object b = true;
             Console.WriteLine(a.GetType());
             Console.WriteLine(b.GetType()); */
            //  object n1 = Console.ReadLine();
            // Console.WriteLine(n1.GetType());
            Console.ReadLine();
        }
    }
}
