using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;

namespace Samples
{
    class LINQselectProjectionOperator
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Salary { get; set; }
        public static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee {ID = 101, FirstName = "Preety", LastName = "Tiwary", Salary = 60000 },
                new Employee {ID = 102, FirstName = "Priyanka", LastName = "Dewangan", Salary = 70000 },
                new Employee {ID = 103, FirstName = "Hina", LastName = "Sharma", Salary = 80000 },
                new Employee {ID = 104, FirstName = "Anurag", LastName = "Mohanty", Salary = 90000 },
                new Employee {ID = 105, FirstName = "Sambit", LastName = "Satapathy", Salary = 100000 },
                new Employee {ID = 106, FirstName = "Sushanta", LastName = "Jena", Salary = 160000 }
            };
            return employees;
        }
        static void Main(string[] args)
        {
            //var sam = from obj in LINQselectProjectionOperator.GetEmployees()
            //         where obj.FirstName.StartsWith("Pr")
            //         select obj;
            var sam = from obj in LINQselectProjectionOperator.GetEmployees()
                      where obj.FirstName.StartsWith("Pri")
                      select obj.FirstName;
            foreach(var i in sam)
            {
                // Console.WriteLine(i.ID+" "+i.FirstName+" "+i.LastName+" "+i.Salary);
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
