using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Samples
{
    class CollectionsusingArrayList
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add(10);
            al.Add(20);
            al.Add(30);
            al.Add(40);
            al.Add(50);
            // Console.WriteLine(al.Capacity);
            al.Insert(2, 25);        //Inserting element in Middle
            //al.Remove(40);           //Deleting element in the Middle
           // al.RemoveAt(3);          //Deleting element with index position
           // al.RemoveRange(1, 3); //it will delete the elements from index point with count elements
            foreach (int i in al)
            {
                Console.WriteLine(i);
            }
            /* al.Reverse();
             foreach(var i in al)
             {
                 Console.WriteLine(i);
             } */
          /*  int[] arr = new int[] { 10, 20, 30, 40 };//Array we can't Delete and can't add element
            foreach(var i in arr)
            {
                Console.WriteLine(i);
            } */
            
        }
    }
}
