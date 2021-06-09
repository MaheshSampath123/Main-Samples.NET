using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Samples
{
   
    class AssignmentForeach
    {
        public string FirstName { get; set; }
        public static void sampathforeach<T>(T a) 
        {
            //Converting Generic type to Dynamic Type
            dynamic change = a;              
            //IEnumerator is an interface that will iterate the data in a particular manner
           //GetEnumerator is a method of IEnumerabl. So, converting Dynamic DataType to IEnumerable
           //Returned in IEnumerator var n
           var n = ((IEnumerable)change).GetEnumerator(); //To use GetEnumerator

            do
            {
                //MoveNext is a Method of IEnumerator which will provide Boolean type if there is a Value it will return true else it will return false.
                if (n.MoveNext())
                {
                    //Current is also a Method of IEnumerator which will Provide that Particular Current value
                    
                    Console.WriteLine(n.Current);
                }
                else
                    break;
            } while (true);
        }
        static void Main(string[] args)
        {
            

            //List<dynamic> lst1 = new List<dynamic>() { 10, 2.3, "madhu", false };
            //lst1.SampathForeach();
            //Queue<dynamic> de = new Queue<dynamic>();
            //de.Enqueue(10);
            //de.Enqueue("sampath");
            //de.Enqueue(true);
            //de.SampathForeach();
             ArrayList lst = new ArrayList() { 10, 20, 30.0, 40, true, 60, 70, "sampath" };//ArrayList created
            // List<int> lst = new List<int>() { 1, 2, 3, 4, 5 };//List created
            
            /* Stack<dynamic> st = new Stack<dynamic>(); //stack created
             st.Push(10);
             st.Push("sampath");
             st.Push(20.30);    
             st.Push(true);
             st.Push(500);
             st.Pop(); */
          /*  Queue<dynamic> qe = new Queue<dynamic>(); //Queue Created
            qe.Enqueue(10);
            qe.Enqueue("sampath");
            qe.Enqueue(true);
            qe.Enqueue(20.90);
            qe.Enqueue(30);
            qe.Dequeue(); */
             sampathforeach<ArrayList>(lst);//Calling Method Here 
            // sampathforeach<List<int>>(lst);
            
            // sampathforeach<Stack<dynamic>>(st);
           // sampathforeach<Queue<dynamic>>(qe);
           
        }
    }
}
