using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Samples
{
    class HashTableUsing
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("Empid", 97);
            ht.Add("Name", "Sampath");
            ht.Add("Role", "Developer");
            ht.Add("salary", 25000);
            ht.Add("Email", "Sampath.Goteti@Cognine.com");
            ht.Add("PhoneNo", "8985727785");
            ht.Add("Location", "Bhimavaram");

           /* Console.WriteLine(ht["Name"]);
            Console.WriteLine(ht["Email"]);
            Console.WriteLine(ht["PhoneNo"]);
            Console.WriteLine(ht["Location"]);  */ 

           foreach(Object i in ht.Keys)
            {
                Console.Write(i.GetHashCode()+":");
                Console.WriteLine(i+":"+ht[i]);
            }
            Console.ReadLine();
            
        }
    }
}
