using System;
using System.Collections.Generic;
using System.Text;

namespace MainClass
{
    class SwitchStatement
    {
        public  void switchstate()
        {
            int x = 15;
            switch (x)
            {
                case 10:
                    Console.WriteLine("x value is 10");
                    break;
                case 15:
                    Console.WriteLine("x value is 15");
                    break;
                case 20:
                    Console.WriteLine("x value is 20");
                    break;
                default:
                    Console.WriteLine("Not Known");
                    break;
            }
            static void Main(string[] args)
            {
                SwitchStatement n = new SwitchStatement();
                n.switchstate();
            }
        }
    }
}
