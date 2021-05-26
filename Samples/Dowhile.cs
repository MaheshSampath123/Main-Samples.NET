using System;
using System.Collections.Generic;
using System.Text;

namespace MainClass
{
    class Dowhile
    {
       public void Dowhile1()
        {
            int i = 1;
            do
            {
                Console.WriteLine("*" + " ");
                i++;
            } while (i <= 5);
        }
        static void Main(string[] args)
        {
            Dowhile n = new Dowhile();
            n.Dowhile1();
        }
    }
}
