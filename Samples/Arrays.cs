using System;
using System.Collections.Generic;
using System.Text;

namespace MainClass
{
    class Arrays
    {
        static void Main(string[] args)
        {
            int[] array = new int[5] { 1, 4, 2, 3, 5 };
            Console.WriteLine("---Initial Array Elements---");
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
            Array.Sort(array);
            Console.WriteLine("---Elements After Sort---");
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
            Array.Reverse(array);
            Console.WriteLine("---Elements After Reverse---");
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Press Enter Key to Exit..");
            Console.ReadLine();
        }
    }
}
