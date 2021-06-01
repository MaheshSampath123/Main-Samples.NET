using System;
using System.Collections.Generic;
using System.Text;

namespace Samples
{
    public class GenericClass1<T>
    {
        public T msg;
        public void GenericMethod(T name,T location)
        {
            Console.WriteLine(msg);
            Console.WriteLine("Name:"+name);
            Console.WriteLine("Location:"+location);
        }
    }
    class GenericsSample
    {
        static void Main(string[] args)
        {
            GenericClass1<string> n = new GenericClass1<string>();
            n.msg=("Welcome to Cognine");
            n.GenericMethod("sampath", "Hyderabad");
          /*  GenericClass1<int> n1 = new GenericClass1<int>();
            n1.msg = 100;
            n1.GenericMethod(10, 20); */

            Console.ReadLine();

        }
    }
}
