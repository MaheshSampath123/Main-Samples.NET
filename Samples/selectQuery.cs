using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Samples
{
    public class EmployeeBasicInfo
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Salary { get; set; }
    }
    public class Employee
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
        class selectQuery
        {
            static void Main(string[] args)
            {
                //Query Syntax
                IEnumerable<EmployeeBasicInfo> selectQuery = (from emp in Employee.GetEmployees()
                                                              select new EmployeeBasicInfo()
                                                              {
                                                                  FirstName = emp.FirstName,
                                                                  LastName = emp.LastName,
                                                                  Salary = emp.Salary
                                                              });

                foreach (var emp in selectQuery)
                {
                    Console.WriteLine($" Name : {emp.FirstName} {emp.LastName} Salary : {emp.Salary} ");
                }
                //Method Syntax
                List<EmployeeBasicInfo> selectMethod = Employee.GetEmployees().
                                              Select(emp => new EmployeeBasicInfo()
                                              {
                                                  FirstName = emp.FirstName,
                                                  LastName = emp.LastName,
                                                  Salary = emp.Salary
                                              }).ToList();
                foreach (var emp in selectMethod)
                {
                    Console.WriteLine($" Name : {emp.FirstName} {emp.LastName} Salary : {emp.Salary} ");
                }
                Console.ReadKey();

            }
        }
    }
}
