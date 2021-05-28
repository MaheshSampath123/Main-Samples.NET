using System;
using System.Collections.Generic;
using System.Text;

namespace Samples
{
    abstract class AbstractParent
    {
        public void add(int x,int y)
        {
            Console.WriteLine(x+y);
        }
        public void sub(int x,int y)
        {
            Console.WriteLine(x-y);
        }
        public abstract void mul(int x, int y);
        public abstract void div(int x, int y);
    }
    class Child:AbstractParent
    {
        public override void mul(int x, int y)
        {
            Console.WriteLine(x*y);
        }
        public override void div(int x, int y)
        {
            Console.WriteLine(x/y);
        }
        static void Main(string[] args)
        {
            Child n = new Child();
            n.add(150, 45);
            n.sub(40, 20);
            n.mul(10, 20);
            n.div(20, 10);
            Console.ReadLine();
        }
    }
}
