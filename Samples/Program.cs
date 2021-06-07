using System;
using System.Collections.Generic;
using System.Collections;

namespace Samples
{
    class Program
    {
        public static void sampathforeach<T>(T a)
        {
            dynamic x = a;
            // Console.WriteLine(a.GetType().FullName);
            IEnumerator n = ((IEnumerable)x).GetEnumerator();
            while (n.MoveNext())
            {
                Console.WriteLine(n.Current.ToString());
            }

            static void Main(string[] args)
            {
                Stack<int> stac = new Stack<int>();
                stac.Push(10);
                stac.Push(20);
                stac.Push(30);
                stac.Push(40);
                stac.Push(50);
                stac.Pop();
                sampathforeach<Stack<int>>(stac);
            }
        }
    }
}

