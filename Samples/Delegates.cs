using System;
using System.Collections.Generic;
using System.Text;

namespace Samples
{
    public delegate void AddDelegate(int x, int y);
    public delegate string SayDelegate(string str);
    class Delegates
    {
        public void AddNums(int a,int b)
        {
            Console.WriteLine(a+b);
        }
        public static string SayHello(string name)
        {
            return "Hello" + name;
        }
        static void Main(string[] args)
        {
            Delegates p = new Delegates();
            AddDelegate ad = new AddDelegate(p.AddNums);
            ad(100, 100);
            SayDelegate sd = new SayDelegate(Delegates.SayHello);
            string str = sd("World");
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}
