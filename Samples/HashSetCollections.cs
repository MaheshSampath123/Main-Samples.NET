using System;
using System.Collections.Generic;
using System.Text;

namespace Samples
{
    class HashSetCollections
    {
        static void Main(string[] args)
        {
            //Create a new hashset
            HashSet<int> hset = new HashSet<int>();
            // Add elements to hashset object.
            hset.Add(1);
            hset.Add(2);
            hset.Add(2);
            hset.Add(3);
            hset.Add(3);
            hset.Add(4);
            Console.WriteLine("Number of Elemen in HashSet: {0}", hset.Count);
            Console.WriteLine("*********HashSet Elements********");
            // Accessing elements from hashset.
            foreach (int item in hset)
            {
                Console.WriteLine(item);
            }
            // Creating and initializing hashset
            HashSet<string> hset2 = new HashSet<string> { "welcome", "to", "Cognine", "Cognine" };
            Console.WriteLine("Number of Elemen in HashSet: {0}", hset2.Count);
            Console.WriteLine("*********HashSet2 Elements********");
            // Accessing elements.
            foreach (string item in hset2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Contains Value '2': {0}", hset.Contains(2));
            Console.WriteLine("Contains Value '10': {0}", hset.Contains(10));
            Console.ReadLine();
        }
    }
}
