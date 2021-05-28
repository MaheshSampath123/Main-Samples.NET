using System;
using System.Collections.Generic;
using System.Text;

namespace Samples
{
    class Nullable
    {
        static void Main(string[] args)
        {
            int? x = null;
            if (x.HasValue)
            {
                Console.WriteLine("x = {0}", x.Value);
            }
            else
            {
                Console.WriteLine("Value is Empty");
            }
            Console.ReadLine();
        }
    }
}
