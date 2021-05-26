using System;
using System.Collections.Generic;
using System.Text;

namespace MainClass
{
    class lists
    {
        public void lst()
        {
            List<int> l = new List<int>();
            l.Add(10);
            l.Add(20);
            l.Add(30);
            l.Add(40);
            l.Add(50);
            foreach(int i in l)
            {
                Console.WriteLine(i);
            }
            
            Console.WriteLine(l.Count);
            Console.WriteLine(l.Capacity);
            Console.ReadLine();
        }
        public void list1()
        {
            // Creating and initializing list
            List<int> lst = new List<int>();
            lst.Add(1);
            lst.Add(8);
            lst.Add(45);
            List<string> lst2 = new List<string>();
            lst2.Add("Hi");
            lst2.Add("Welcome");
            lst2.Add("to");
            lst2.Add("Tutlane");
            Console.WriteLine("List1 Elements Count: " + lst.Count);
            Console.WriteLine("List1 Capacity: " + lst.Capacity);
            Console.WriteLine("*********List1 Elements********");
            // Accessing list elements
            foreach (var item in lst)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("List2 Elements Count: " + lst2.Count);
            Console.WriteLine("List2 Capacity: " + lst2.Capacity);
            Console.WriteLine("*********List2 Elements********");
            foreach (var item in lst2)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
        public void adding()
        {
            // Creating and initializing list
            List<int> lst = new List<int>() { 1, 8, 45, 70 };
            Console.WriteLine("List1 Elements Count: " + lst.Count);
            Console.WriteLine("*********List1 Elements********");
            // Accessing list elements
            foreach (var item in lst)
            {
                Console.WriteLine(item);
            }
            //AddRange method
            List<int> lst2 = new List<int>();
            lst2.AddRange(lst);
            Console.WriteLine("List2 Elements Count: " + lst2.Count);
            Console.WriteLine("*********List2 Elements********");
            foreach (var item in lst2)
            {
                Console.WriteLine(item);
            }
            List<User> users = new List<User>(){
             new User {Id= 1, Name= "Sampath", Location= "Hyderabad"},
             new User {Id = 2, Name = "Madhu", Location = "Hyderabad"}
          };
            users.Add(new User { Id = 3, Name = "Veeru", Location = "Hyderabad" });
            users.Add(new User { Id = 4, Name = "Mahesh", Location = "Hyderabad" });
            Console.WriteLine("List3 Elements Count: " + users.Count);
            Console.WriteLine("*********List3 Elements********");
            foreach (User u in users)
            {
                Console.WriteLine("Id:{0}, Name:{1}, Location:{2}", u.Id, u.Name, u.Location);
            }
            Console.ReadLine();
        }
        public class User
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Location { get; set; }
        }
        static void Main(string[] args)
        {
            lists n = new lists();
            n.lst();
            n.list1();
            n.adding();
        }
    }
}
