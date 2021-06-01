using System;
using System.Collections.Generic;
using System.Text;

namespace Samples
{
    class DictionaryCollections
    {
        static void Main(string[] args)
        {
            Dictionary<string, object> ht = new Dictionary<string, object>();
            ht.Add("Empid", 97);
            ht.Add("Name", "Sampath");
            ht.Add("Role", "Developer");
            ht.Add("salary", 25000);
            ht.Add("Email", "Sampath.Goteti@Cognine.com");
            ht.Add("PhoneNo", "8985727785");
            ht.Add("Location", "Bhimavaram");
            
            foreach(string i in ht.Keys)
            {
                Console.WriteLine(i+":"+ht[i]);
            }
        }
    }
}
