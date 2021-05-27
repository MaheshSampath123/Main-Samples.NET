using System;
using System.Collections.Generic;
using System.Text;

namespace Samples
{

    class class12
    {
        public int age;
        public virtual void GetAge()
        {
            Console.WriteLine("Age:" + age);
        }
    }
    class class123 : class12
    {
        public string name;
        public void GetName()
        {
            Console.WriteLine("Name:" + name);
        }
    }
    class class1234:class123
    {
        public string location;
        public void GetLocation()
        {
            Console.WriteLine("Location:" + location);
        }
    }
    class MultipleInheritence : class1234
    {
        static void Main(string[] args)
        {
            MultipleInheritence n = new MultipleInheritence();
            n.location = "hyderabad";
            class123 c1 = new class123();
            c1.name = "sampath";
            class12 c2 = new class12();
            c2.age = 23;
            c1.GetName();
            c2.GetAge();
            n.GetLocation();
        }
    }
}
