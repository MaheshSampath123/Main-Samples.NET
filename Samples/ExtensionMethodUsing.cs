using System;
using System.Collections.Generic;
using System.Text;

namespace Samples
{
    public static class ExtensionMethodUsing
    {
        static void Main(string[] args)
        {
            //Integer structure Extension
            Console.WriteLine("Enter Number To find Factorial:");
            int i = int.Parse(Console.ReadLine());
            long result = i.Factorial();
            Console.WriteLine("Factorial of {0} is: {1}",i,result);

            //String Sealed Class Extension
            Console.WriteLine("Enter String Value To make ToProper:");
            String str = Console.ReadLine();
            str = str.ToProper();   //ToProper Means making Every Word's First letter To uppercase
            Console.WriteLine(str);

            Console.ReadLine();

        }
       
    }
    public static class staticMethodForExtension
    {
        public static long Factorial(this Int32 x)
        {
            if (x == 1)
                return 1;
            if (x == 2)
                return 2;
            else
                return x * Factorial(x - 1);
        }
        public static string ToProper(this string OldStr)
        {
            if(OldStr.Trim().Length>0)
            {
                string NewStr = null;
                OldStr = OldStr.ToLower();
                string[] sarr = OldStr.Split(' ');//dividing by spaces and adding into array
                foreach (string str in sarr)
                {
                    char[] carr = str.ToCharArray();
                    carr[0] = Char.ToUpper(carr[0]);
                    if (NewStr == null)
                        NewStr = new string(carr);
                    else
                        NewStr += " " + new string(carr);
                }
                return NewStr;
            }
            return OldStr;
        }
    }
}
