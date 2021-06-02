using System;
using System.Collections.Generic;
using System.Text;

namespace Samples
{
    class Program1<T> where T : class
    {
       
        public T msg;
        public void genericMethod(T name, T location)
        {
            Console.WriteLine("{0}", msg);
            Console.WriteLine("name:{0}", name);
            Console.WriteLine("Location:{0}", location);
        }
    }
    class GenericConstraintsusing
    {
        static void Main(string[] args)
        {
            Program1<string> p = new Program1<string>();
            p.msg = ("hiii");
            p.genericMethod("Sampath", "Hyderabad");
            Console.ReadLine();

        }
    }
}