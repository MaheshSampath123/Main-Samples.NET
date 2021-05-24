using System;
using System.Collections.Generic;
using System.Text;

namespace MainClass
{
    class @foreach
    {
        public void foreach1()
        {
            string[] names = new string[] { "Sampath", "Mahesh", "Goteti" };
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
