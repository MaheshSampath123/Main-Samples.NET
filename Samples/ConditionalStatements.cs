using System;
using System.Collections.Generic;
using System.Text;

namespace MainClass
{
    class ConditionalStatements
    {
        int a = 5;
        public void @if()
        {
            if(a<10)
                Console.WriteLine("A values is less than 10");
        }
        public void @ifelse()
        {
            if(a<10)
                Console.WriteLine("A is smaller than 10");
            else
            
                Console.WriteLine("A is Bigger than 10");
        }
        public void @ifelseif()
        {
            if(a<5)
                Console.WriteLine("A is less than 5");
            else if(a>5)
                Console.WriteLine("A is greater than 5");
            else if(a>10)
                Console.WriteLine("A is Large Greater than 10");
            else
                Console.WriteLine("A==5");
        }
        public void @nestedif()
        {
            if(a>2)
                if(a<4)
                    Console.WriteLine("A is 3");
                else
                    Console.WriteLine("A is More than 4");
            else
                Console.WriteLine("A is lessthan 2");
        }
        static void Main(string[] args)
        {
            ConditionalStatements n = new ConditionalStatements();
            n.@if();
           

        }
    }
}
