using System;
using System.Collections.Generic;
using System.Text;

namespace Samples
{
    class User
    {
        private string name;
        private string location;
        public int age;
        public string Location
        {
            get
            {
                return location;
            }
            set
            {
                location = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }
    class Encapsulation
    {
        static void Main(string[] args)
        {
            User n = new User();
            n.Name = "sampath";
            n.Location = "hyderabad";
            n.age = 23;
            Console.WriteLine("Name:"+n.Name);
            Console.WriteLine("Location:"+n.Location);
            Console.WriteLine("Age:"+n.age);
            Console.ReadLine();
        }
    }
}
