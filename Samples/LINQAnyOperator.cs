using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace Samples
{
    class LINQAnyOperator
    {
        static void Main(string[] args)
        {
            string[] stringArray = { "James", "Sachin", "Sourav", "Pam", "Sara" };
            //Method Syntax
            var ResultMS = stringArray.Any(name => name.Length > 7);
            //Query Syntax
            var ResultQS = (from name in stringArray
                            select name).Any(name => name.Length > 5);
            Console.WriteLine("Is Any name with length  greater than 5 Characters : " + ResultMS);
            Console.ReadKey();
        }
    }
}
