using System;
using System.Collections.Generic;
using System.Text;

namespace MainClass
{ 
   public class Datatypes
    {
        int a = 10;
        float b = 20.25f;
        char c = 'A';
        string d = "sampath";
        bool e = true;
        double f = 20.5;
        short g = 23;
        long i = 24;
        decimal j = 25;
        static void Main(string[] args)
        {
            Datatypes n = new Datatypes();

            Console.WriteLine(n.a+" "+n.b+" "+n.c +" "+n.d +" "+n.e +" "+n.f +" "+n.g +" "+n.i +" "+n.j);

        }
    }
}
