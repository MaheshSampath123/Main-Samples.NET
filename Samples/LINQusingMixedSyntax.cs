using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Linq;

namespace Samples
{
    class LINQusingMixedSyntax
    {
        static void Main(string[] args)
        {
            
            List<int> lst = new List<int>() { 10, 20, 30, 40, 50, 60, 70 };//DataSource
            var MixedSyntax = (from obj in lst where obj > 25 select obj).Sum();//MixedSyntax
            Console.WriteLine(MixedSyntax);
            Console.ReadLine();
           

        }
    }
}
