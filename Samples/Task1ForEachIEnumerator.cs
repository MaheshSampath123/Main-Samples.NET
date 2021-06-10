using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;

namespace Samples
{
    class Employee1
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
        public double Salary { get; set; }
    }
    class Organization:IEnumerable
    {
        List<Employee1> Emps = new List<Employee1>();
        public void Add(Employee1 Emp)
        {
            Emps.Add(Emp);
        }
        public int Count
        {
            get { return Emps.Count; }
        }
        public Employee1 this [int index]
        {
            get
            {
                return Emps[index];
            }
        }
        public IEnumerator GetEnumerator()
        {
            return new OrganizationEnumerator(this);
        }
    }
    class OrganizationEnumerator : IEnumerator
    {
        Organization OrgColl;
        int CurrentIndex;
        Employee1 CurrentEmp;
        public OrganizationEnumerator(Organization obj)
        {
            OrgColl = obj;
            CurrentIndex = -1;
        }
        public object Current
        {
            get
            {
                return CurrentEmp;
            }
        }
        public bool MoveNext()
        {
            if (++CurrentIndex >= OrgColl.Count)
                return false;
            else
                CurrentEmp = OrgColl[CurrentIndex];
            return true;
        }
        public void Reset()
        {

        }
    }

    class Task1ForEachIEnumerator
    {
        
        static void Main(string[] args)
        {
            Organization Employees = new Organization();
            Employees.Add(new Employee1 { Id = 101, Name = "John", Job = "Manager", Salary = 25000.00 });
            Employees.Add(new Employee1 { Id = 102, Name = "Mark", Job = "Analyst", Salary = 20000.00 });
            Employees.Add(new Employee1 { Id = 103, Name = "Steve", Job = "Developer", Salary = 15000.00 });
            Employees.Add(new Employee1 { Id = 104, Name = "Joy", Job = "SalesMan", Salary = 10000.00 });
           
            foreach (Employee1 Emp in Employees)
                Console.WriteLine(Emp.Id + " " + Emp.Name + " " + Emp.Job + " " + Emp.Salary);
            Console.ReadLine();

        }
    }
}
 