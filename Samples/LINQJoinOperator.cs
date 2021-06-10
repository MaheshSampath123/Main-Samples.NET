using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;

namespace Samples
{
    public class Employee2
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int AddressId { get; set; }
        public static List<Employee2> GetAllEmployees()
        {
            return new List<Employee2>()
            {
                new Employee2 { ID = 1, Name = "Preety", AddressId = 1 },
                new Employee2 { ID = 2, Name = "Priyanka", AddressId = 2 },
                new Employee2 { ID = 3, Name = "Anurag", AddressId = 3 },
                new Employee2 { ID = 4, Name = "Pranaya", AddressId = 4 },
                new Employee2 { ID = 5, Name = "Hina", AddressId = 5 },
                new Employee2 { ID = 6, Name = "Sambit", AddressId = 6 },
                new Employee2 { ID = 7, Name = "Happy", AddressId = 7},
                new Employee2 { ID = 8, Name = "Tarun", AddressId = 8 },
                new Employee2 { ID = 9, Name = "Santosh", AddressId = 9 },
                new Employee2 { ID = 10, Name = "Raja", AddressId = 10},
                new Employee2 { ID = 11, Name = "Sudhanshu", AddressId = 11}
            };
        }
    }
    public class Address
    {
        public int ID { get; set; }
        public string AddressLine { get; set; }
        public static List<Address> GetAllAddresses()
        {
            return new List<Address>()
            {
                new Address { ID = 1, AddressLine = "AddressLine1"},
                new Address { ID = 2, AddressLine = "AddressLine2"},
                new Address { ID = 3, AddressLine = "AddressLine3"},
                new Address { ID = 4, AddressLine = "AddressLine4"},
                new Address { ID = 5, AddressLine = "AddressLine5"},
                new Address { ID = 9, AddressLine = "AddressLine9"},
                new Address { ID = 10, AddressLine = "AddressLine10"},
                new Address { ID = 11, AddressLine = "AddressLine11"},
            };
        }
    }
        class LINQJoinOperator
    {
        static void Main(string[] args)
        {
            var JoinUsingMS = Employee2.GetAllEmployees() //Outer Data Source
                           .Join(
                           Address.GetAllAddresses(),  //Inner Data Source
                           employee2 => employee2.AddressId, //Inner Key Selector
                           address => address.ID, //Outer Key selector
                           (employee2, address) => new //Projecting the data into a result set
                           {
                               EmployeeName = employee2.Name,
                               AddressLine = address.AddressLine
                           }).ToList();
            foreach (var employee in JoinUsingMS)
            {
                Console.WriteLine($"Name :{employee.EmployeeName}, Address : {employee.AddressLine}");
            }
            Console.ReadLine();
        }
    }
}
   
