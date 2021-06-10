using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;

namespace Samples
{
    class LINQoperators
    {
        static void Main(string[] args)
        {
            List<int> lst = new List<int>() { 10, 20, 30, 45, 60, 70, 77 };
            //List<dynamic> lst = new List<dynamic>() { 10, 20.0,"name",true };
            //var sam = from obj in lst
            //                  select obj;
            //Stack<string> lst = new Stack<string>();
            //lst.Push("sampath");
            //lst.Push("madhu");
            //lst.Push("veeru");
            //lst.Push("mahesh");
            //var sam = from obj in lst
            //          where obj.Length<6
            //          select obj;
            // var sam = lst.All(obj=>obj>5);
            // var sam = lst.Any(obj => obj > 70);
            var sam = lst.Contains(23);
            Console.WriteLine(sam);
            //foreach(var i in sam)
            //{
            //    Console.WriteLine(i);
            //}
            Console.ReadLine();
        }
        
    }
}
