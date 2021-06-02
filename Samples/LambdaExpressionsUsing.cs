using System;
using System.Collections.Generic;
using System.Text;

namespace Samples
{
    public delegate string EveningDelegate(string name);
    class LambdaExpressionsUsing
    {
        static void Main(string[] args)
        {
            EveningDelegate obj = (name) =>
              {
                  return "Hello" + name + "Good Evening";
              };
            //Console.WriteLine(obj.Invoke("sampath"));
            //or
            string str = obj.Invoke("sampath");
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}
