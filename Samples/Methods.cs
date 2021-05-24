using System;
using System.Collections.Generic;
using System.Text;

namespace MainClass
{
    class Methods
    {
        public void Passbyvalue()   ///pass by value here
        {
            int x = 10;
            Console.WriteLine("Variable Value Before Calling the Method: {0}", x);
            Multiplication(x);
            Console.WriteLine("Variable Value After Calling the Method: {0}", x);
            Console.WriteLine("Press Enter Key to Exit..");
            Console.ReadLine();
        }
        public void Multiplication(int a)
        {
            a *= a;
            Console.WriteLine("Variable Value Inside the Method: {0}", a);
        }
        public void passbyreference() ///pass by reference here
        {
            int x = 10;
            Console.WriteLine("Variable Value Before Calling the Method: {0}", x);
            Multiplication1(ref x);
            Console.WriteLine("Variable Value After Calling the Method: {0}", x);
            Console.WriteLine("Press Enter Key to Exit..");
            Console.ReadLine();
        }
        public void Multiplication1(ref int a)
        {
            a *= a;
            Console.WriteLine("Variable Value Inside the Method: {0}", a);
        }
        public void outputparameter()  ///output parameters start here
        {
            int x;
            Multiplication2(out x);
            Console.WriteLine("Variable Value: {0}", x);
            Console.WriteLine("Press Enter Key to Exit..");
            Console.ReadLine();
        }
        public  void Multiplication2(out int a)
        {
            a = 10;
            a *= a;
        }
        public void paramsmethod() ///paramsmethod starting here
        {
            ParamsMethod(1, 2, 3, 4, 5, 6);
        }
        public void ParamsMethod(params int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + (i < arr.Length - 1 ? ", " : ""));
            }
            Console.WriteLine();
            Console.WriteLine("\nPress Enter Key to Exit..");
            Console.ReadLine();
        }
    }
}
