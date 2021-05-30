using System;
using System.Collections.Generic;
using System.Text;

namespace Samples
{
    interface IName
    {
        void GetName(string x);
    }
    interface ILocation
    {
        void GetLocation(string x);
    }
    interface IAge
    {
        void GetAge(int x);
    }
    class User1 : IName, ILocation, IAge
    {
        public void GetName(string a)
        {
            Console.WriteLine("Name: {0}", a);
        }
        public void GetLocation(string a)
        {
            Console.WriteLine("Location: {0}", a);
        }
        public void GetAge(int a)
        {
            Console.WriteLine("Age: {0}", a);
        }
    }
    class InheritanceusingInterface
    {
        static void Main(string[] args)
        {
            User1 u = new User1();
            u.GetName("Suresh Dasari");
            u.GetLocation("Hyderabad");
            u.GetAge(32);
            Console.WriteLine("\nPress Enter Key to Exit..");
            Console.ReadLine();
        }
    }
}
