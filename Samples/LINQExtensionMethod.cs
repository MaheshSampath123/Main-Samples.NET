using System;
using System.Collections.Generic;
using System.Text;

namespace Samples
{
    class LINQExtensionMethod
    {
        static void Main(string[] args)
        {
            string sentence = "Welcome to Cognine Company";
            int WordCount = sentence.GetWordCount();
            Console.WriteLine(WordCount);


        }
    }
    public static class ExtensionHelper1
    { 
        public static int GetWordCount(this string str)
        {
            if (!string.IsNullOrEmpty(str))
                return str.Split(' ').Length;
            return 0;
        }
    }
  
}
