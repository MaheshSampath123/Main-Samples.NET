using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Samples
{
   
    class AssignmentForeach
    {
        public static void sampathforeach<T>(T a)
        {
            dynamic x = a;
            // Console.WriteLine(a.GetType().FullName);
            IEnumerator n = ((IEnumerable)x).GetEnumerator();

            do
            {
                if (n.MoveNext())
                {
                    Console.WriteLine(n.Current.ToString());
                }
                else
                    break;
            } while(true);
           
            
        }
        static void Main(string[] args)
        {
             ArrayList lst = new ArrayList() { 10, 20, 30.0, 40, true, 60, 70, "sampath" };
           // List<int> lst = new List<int>() { 1, 2, 3, 4, 5 };
            /*sampathforeach(var i in lst)
            {
                Console.WriteLine(i);
            }*/
            sampathforeach<ArrayList>(lst);
           
        }
    }
}
