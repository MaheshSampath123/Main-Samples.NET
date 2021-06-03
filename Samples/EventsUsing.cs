using System;
using System.Collections.Generic;
using System.Text;

namespace Samples
{
    class EventsUsing
    {
        static void Main(string[] args)
        {
            AddTwoNumbers a = new AddTwoNumbers();
            //Event gets binded with delegates
            a.ev_OddNumber += new AddTwoNumbers.dg_OddNumber(EventMessage);
            a.Add();
            Console.Read();
        }
        //Delegates calls this method when event raised.  
        static void EventMessage()
        {
            Console.WriteLine("********Event Executed : This is Odd Number**********");
        }
    }
    class AddTwoNumbers
    {
        public delegate void dg_OddNumber(); //Declared Delegate     
        public event dg_OddNumber ev_OddNumber; //Declared Events

        public void Add()
        {
            // int result;
            //result = 5 + 5;
            int result = int.Parse(Console.ReadLine());
            Console.WriteLine(result.ToString());
            //Check if result is odd number then raise event
            if ((result % 2 != 0) && (ev_OddNumber != null))
            {
                ev_OddNumber(); //Raised Event
            }
            else
            {
                Console.WriteLine("Even Number ");
            }
        }
    }
}
