using System;
using System.Collections.Generic;
using System.Text;

namespace MainClass
{
    class Dictionaries1
    {
        public void Dict()
        {
            //Create a new dictionary
            Dictionary<int, string> dct = new Dictionary<int, string>();
            dct.Add(1, "Mahesh");
            dct.Add(4, "Sampath");
            dct.Add(2, "Madhu");
            dct.Add(3, "VeeruBabu");
            // Access value with key (not index)
            string val1 = dct[2];
            string val2 = dct[3];
            string val3 = dct[4];
            Console.WriteLine("******Access Elements with Keys*****");
            Console.WriteLine("Value at Key '2': " + val1);
            Console.WriteLine("Value at Key '3': " + val2);
            Console.WriteLine("Value at Key '4': " + val3);
            Console.WriteLine("*********Access Elements with Foreach Loop********");
            foreach (KeyValuePair<int, string> item in dct)
            {
                Console.WriteLine("Key = {0}, Value = {1}", item.Key, item.Value);
            }
            Console.WriteLine("*********Dictionary Keys********");
            foreach (var item in dct.Keys)
            {
                Console.WriteLine("Key = {0}", item);
            }
            Console.WriteLine("*********Dictionary Values********");
            foreach (var item in dct.Values)
            {
                Console.WriteLine("Value = {0}", item);
            }
            Console.ReadLine();
        }
        class Dictionaries
        {
            static void Main(string[] args)
            {
                Dictionaries1 n = new Dictionaries1();
                n.Dict();
            }
        }
    }
}
