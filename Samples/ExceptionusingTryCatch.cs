using System;
using System.Collections.Generic;
using System.Text;

namespace Samples
{
    class ExceptionusingTryCatch
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("enter element 1:");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("enter element 2:");
                int y = int.Parse(Console.ReadLine());
                int z = x / y;
                Console.WriteLine("the result is:" + z);
            }
           /* catch(DivideByZeroException var)
            {
                Console.WriteLine(var.Message);
            }
            catch(FormatException var1)
            {
                Console.WriteLine(var1.Message);
            }*/
           catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Program Executed Successfully");
        }
    }
}
