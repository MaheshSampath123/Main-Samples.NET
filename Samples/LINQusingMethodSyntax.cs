using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Samples
{
    class LINQusingMethodSyntax
    {
        static void Main(string[] args)
        {
            List<string> lst = new List<string>() { "mahesh", "sampath", "madhu", "veeru" };//DataSource
            var MethodSyntax = lst.Where(obj => obj.Length > 5).ToList();//MethodSyntax
            //Execution
            foreach(var i in MethodSyntax)
            {
                Console.WriteLine(i+" ");
            }
            Console.ReadKey();
        }
    }
}
