using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab_7
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Salary { get; set; }

        public Employee(string firstName, string lastName, int salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salary = salary;
        }

        public override string ToString()
        {
            return String.Format("Fitst Name: {0}. Last Name: {1}. Salary: {2}", FirstName, LastName, Salary);
        }
    }

    class Company
    {
        public List<Employee> Employees { get; set; }

        public void RecruitEmployee(string fisrtName, string lastName, int salary)
        {
            Employees.Add(new Employee(fisrtName, lastName, salary));
        }

        public void RecruitEmployee(Employee employee)
        {
            Employees.Add(employee);
        }

        public void FireEmployee(string fisrtName, string lastName)
        {
            var employee = Employees.Find(e => e.FirstName.Equals(fisrtName) && e.LastName.Equals(lastName));
            if (employee != null)
            {
                Employees.Remove(employee);
            }

        }

        public string PrintEmployeesList()
        {
            return Employees.Aggregate("", (current, item) => current + item.ToString() + "\n");
        }

        public int GetAverageSalary()
        {
            return Employees.Sum(e => e.Salary) / Employees.Count;
        }
    }
}
