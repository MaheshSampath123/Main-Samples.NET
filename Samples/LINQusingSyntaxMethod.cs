using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Samples
{
    class LINQusingSyntaxMethod
    {
        static void Main(string[] args)
        {
            //DataSource
            List<int> lst = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Linq Query using Query Syntax
            var QuerySyntax = from obj in lst
                              where obj > 5
                              select obj;
            //Execution
            foreach(var i in QuerySyntax)
            {
                Console.Write(i+" ");
            }
            Console.ReadLine();
        }
    }
}
