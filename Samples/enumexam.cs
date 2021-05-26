using System;
using System.Collections.Generic;
using System.Text;

namespace MainClass
{
    public enum Days
    {
        Monday=1, Tuesday=11, Wednesday=21, Thursday=31, Friday=41
    }
    class enumexam
    { 
        public static Days MeetingDate { get; set; } = Days.Monday;
        static void Main(string[] args)
        { 
         Console.WriteLine(MeetingDate);
         MeetingDate=Days.Tuesday;
         Console.WriteLine(MeetingDate);
        }
    }
}
