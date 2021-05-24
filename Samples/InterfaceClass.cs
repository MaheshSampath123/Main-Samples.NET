using System;
using System.Collections.Generic;
using System.Text;

namespace MainClass
{
    interface InterfaceName
    {
        void GetDetails(string x);
    }
    class InterfaceClass:InterfaceName
    {
        public void GetDetails(string a)
        {
            Console.WriteLine("Name:{0}"+a);
        }
    }
    class InterfaceClass1 : InterfaceName
    {
        public void GetDetails(string a)
        {
            Console.WriteLine("Location:{0}" + a);
        }
    }
   /* class mained
    {
        static void main()
        {
            InterfaceName n = new InterfaceClass();
            n.GetDetails("Sampath");
            InterfaceName n1 = new InterfaceClass1();
            n1.GetDetails("Hyderabad");
            Console.ReadLine();

        }
    }*/

}
