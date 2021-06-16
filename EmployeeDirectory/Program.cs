using System;

namespace EmployeeDirectory
{
    class Program
    {
        static Payroll payroll = new Payroll();

        static void Main(string[] args)
        {

            //Employee employee = new Employee(name: "Kalle", salary: 345667);
            SeedData();

            Employee[] employees = payroll.GetEmplyees();

            foreach (Employee employee in employees)
            {
                Console.WriteLine($"Name: {employee.Name} Salary: {employee.Salary}");
            }
        }

        private static void SeedData()
        {
            payroll.AddEmployee("Kalle", 20000);
            payroll.AddEmployee("Nisse", 30000);
            payroll.AddEmployee("Lisa", 40000);
        }
    }
}
