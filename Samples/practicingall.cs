using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;

namespace Samples
{
    class practicingall
    {
        static void Main(string[] args)
        {
             List<int> lst = new List<int>() { 1, 2, 3, 4, 6, 8, 89, 9, 100 };
             
            //  var sam = lst.Where(obj => obj > 5).ToList();     //Method syntax 
            //var l = from obj in lst //query syntax
            //        where obj>10
            //        select obj;
            //var say = (from obj in lst  //mixed syntax
            //            where obj > 5
            //            select obj).Sum();
            Console.WriteLine();
            Console.ReadLine();
            
        }
    }
}
