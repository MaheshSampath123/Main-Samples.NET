using System;
using System.Collections.Generic;
using System.Text;

namespace MainClass
{
    public enum Days
    {
        Monday=1, Tuesday=11, Wednesday=21, Thursday=31, Friday=41
    }
    class @enum
    { 
        public static Days MeetingDate { get; set; } = Days.Monday;
        public void use()
        { 
        Console.WriteLine(MeetingDate);
            MeetingDate=Days.Tuesday;


            Console.WriteLine(MeetingDate);
        }

    }
}
