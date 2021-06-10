using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Samples
{
    class LINQoperatorsAllAny
    {
        
            static void Main(string[] args)
            {
                int[] IntArray = { 11, 22, 33, 44, 55 };
            // var Result = IntArray.All(x => x > 10);
            var Result = (from num in IntArray
                            select num).Any();
            Console.WriteLine("Is All Numbers are greater than 10 : " + Result);
                Console.ReadKey();
            }
        
    }
}
