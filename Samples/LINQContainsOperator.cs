using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Samples
{
    class LINQContainsOperator
    {
        static void Main(string[] args)
        {
            int[] IntArray = { 11, 22, 33, 44, 55 };
            //Using Method Syntax
            var IsExistsMS = IntArray.Contains(33);
            //Using Query Syntax
            var IsExistsQS = (from num in IntArray
                              select num).Contains(33);
            Console.WriteLine(IsExistsMS);
            Console.ReadKey();
        }
    }
}
