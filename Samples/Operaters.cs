using System;
using System.Collections.Generic;
using System.Text;

namespace MainClass
{
    class Operaters
    {
        public void ArithmeticOperation()
        {
            int a = 10;
            int b = 20;
            Console.WriteLine(a+b);
            Console.WriteLine(a-b);
            Console.WriteLine(a*b);
            Console.WriteLine(a%b);
            Console.WriteLine(a/b);
            Console.ReadLine();

        }
        public void RelationalOperator()
        {
            int a = 10;
            int b = 20;
            Console.WriteLine(a<b);
            Console.WriteLine(a>b);
            Console.WriteLine(a==b);
            Console.WriteLine(a<=b);
            Console.WriteLine(a>=b);
            Console.ReadLine();
        }
        public void LogicalOperator()
        {
            int a = 20;
            int b = 30;
            Console.WriteLine((a<b)&&(a<50));
            Console.WriteLine((a>b)||(a>10));
            Console.WriteLine(a!=b);
            Console.ReadLine();
        }
    }
}
