using System;
using System.Collections.Generic;

namespace EmployeeDirectory
{
    internal class Payroll
    {
        //private fält
        private List<Employee> payroll;

        //Konstruktor
        public Payroll()
        {
            payroll = new List<Employee>();
        }

        //Metoder
        public void AddEmployee(string name, int salary)
        {
            // validate
            payroll.Add(new Employee(name, salary));
        }

        public Employee[] GetEmplyees()
        {
            return payroll.ToArray();
        }
    }
}