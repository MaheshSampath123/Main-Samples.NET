using System;
using System.Collections.Generic;
using System.Text;

namespace Samples
{
    class ExceptionusingTryCatchFinally
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
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Program Successfully Executed");
            }
        }
    }
}
