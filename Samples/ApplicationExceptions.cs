using System;
using System.Collections.Generic;
using System.Text;

namespace Samples
{
    //creating own Exception Class
    public class DivideByOddNoException:ApplicationException
    {
        public override string Message
        {
            get
            {
                return "Attempted to use Odd number";
            }
        }
    }
    class ApplicationExceptions
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter element 1:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("enter element 2:");
            int y = int.Parse(Console.ReadLine());
            if(y%2==1)
            {
                //throw new ApplicationException("The Element should be even number");
                throw new DivideByOddNoException();
            }
            int z = x / y;
            Console.WriteLine("the result is:" + z);
            Console.WriteLine("Program Executed Successfully");
        }
    }
}
