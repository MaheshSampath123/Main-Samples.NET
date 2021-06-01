using System;
using System.Collections.Generic;
using System.Text;

namespace Samples
{
    class SortedListCollection
    {
        static void Main(string[] args)
        {
            //Create a new sorted list
            SortedList<int, string> slst = new SortedList<int, string>();
            slst.Add(1, "mahesh");
            slst.Add(4, "sampath");
            slst.Add(2, "madhu");
            slst.Add(3, "veerababu");
            slst.Add(5, "Satya");
            // Remove element with key 2
            slst.Remove(2);
            // Remove element at index position 2
            slst.RemoveAt(2);
            Console.WriteLine("*********Access Sorted List Elements********");
            Console.WriteLine();
            foreach (KeyValuePair<int, string> item in slst)
            {
                Console.WriteLine("Key = {0}, Value = {1}", item.Key, item.Value);
            }
            Console.ReadLine();
        }
    }
}
