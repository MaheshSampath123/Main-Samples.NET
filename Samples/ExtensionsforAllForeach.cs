using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Samples
{
    class ExtensionsforAllForeach
    {
        static void Main(string[] args)
        {
            List<dynamic> lst = new List<dynamic>() { 10, 11.23, "sampath", false };
            lst.SampathForeach();
            ArrayList lst1 = new ArrayList() { 10, 20.40, "sampath", true };
            lst1.SampathForeach();
            Stack<dynamic> st = new Stack<dynamic>();
            st.Push(10);
            st.Push("cognine");
            st.Push(true);
            st.Push(20.36);
            st.SampathForeach();
            Queue<dynamic> qe = new Queue<dynamic>();
            qe.Enqueue(100);
            qe.Enqueue("cognine");
            qe.Enqueue("company");
            qe.Enqueue(203.45);
            qe.Enqueue(false);
            qe.SampathForeach();
            string sname = "sampath";
            sname.SampathForeach();
            

        }
    }
    public static class ExttensionHelper3
    {
        public static void SampathForeach(this List<dynamic> str1)
        {
            foreach (dynamic i in str1)
            {
                Console.WriteLine(i);
            }
        }
        public static void SampathForeach(this ArrayList str1)
        {
            foreach (dynamic i in str1)
            {
                Console.WriteLine(i);
            }
        }
        public static void SampathForeach(this Stack<dynamic> str1)
        {
            foreach (dynamic i in str1)
            {
                Console.WriteLine(i);
            }
        }
        public static void SampathForeach(this Queue<dynamic> str1)
        {
            foreach (dynamic i in str1)
            {
                Console.WriteLine(i);
            }
        }
        public static void SampathForeach(this string str1)
        {
            foreach (dynamic i in str1)
            {
                Console.WriteLine(i);
            }
        }
    }
}
