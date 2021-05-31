using System;
using System.Collections.Generic;
using System.Text;

namespace Samples
{
    class Exceptions
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter element 1:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("enter element 2:");
            int y = int.Parse(Console.ReadLine());
            int z = x / y;
            Console.WriteLine("the result is:"+z);
            Console.WriteLine("Program Executed Successfully");
        }
    }
}
