using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Linq;

namespace Samples
{
    class student
    {
        public int StdId { get; set; }
        public string StdName { get; set; }
        public int StdAge { get; set; }

    }

    class IEnumeratorExamples
    {
        static void Main(string[] args)
        {
            List<student> data = new List<student>();
            data.Add(new student { StdId = 101, StdName = "sampath", StdAge = 23 });
            data.Add(new student { StdId = 102, StdName = "madhu", StdAge = 24 });
            data.Add(new student { StdId = 103, StdName = "mahesh", StdAge = 23 });
            data.Add(new student { StdId = 104, StdName = "veeru", StdAge = 24});
            //var z = from i in list<student>
            //       where i.StdAge > 23
            //        select new { StdId = i.StdId, StdName = i.StdName };
            
            foreach(student st in data)
            {
                Console.WriteLine(st.StdId+" "+st.StdName+" "+st.StdAge);

            }
            Console.ReadLine();

        }
    }
}
