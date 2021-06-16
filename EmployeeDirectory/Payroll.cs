using System;
using System.Collections.Generic;

namespace EmployeeDirectory
{
    internal class Payroll
    {

        private List<Employee> payroll;

        public Payroll()
        {
            payroll = new List<Employee>();
        }

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