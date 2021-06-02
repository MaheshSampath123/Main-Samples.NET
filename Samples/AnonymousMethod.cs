using System;
using System.Collections.Generic;
using System.Text;

namespace Samples
{
    public delegate string GreetingDelegate(string name);
    class AnonymousMethod
    {
        static void Main(string[] args)
        {
            GreetingDelegate n = delegate (string name)
              {
                  return "hello" + name + "Good Morning";

              };
            // Console.WriteLine(n.Invoke(" sampath "));
            //or
            string str = n.Invoke(" Sampath ");
            Console.WriteLine(str);
            Console.ReadLine();
        }

    }
}
