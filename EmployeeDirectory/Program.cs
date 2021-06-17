using System;

namespace EmployeeDirectory
{
    class Program
    {
        

        static Payroll payroll = new Payroll();

        static void Main(string[] args)
        {
            Employee employee1 = new Employee("Test", 1000);
            employee1.ToString();

            //Employee employee = new Employee(name: "Kalle", salary: 345667);
            SeedData();

            do
            {
                ShowMainMeny();
               
                switch (Console.ReadLine())
                {
                    case "1":

                        break;
                    case "2":
                        PrintEmployees();
                        break;
                    case "3":
                        Environment.Exit(0);
                        break;

                    default:
                        break;
                }


            } while (true);



        }

        private static void PrintEmployees()
        {
            Employee[] employees = payroll.GetEmplyees();

            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee.ToString());
            }
        }

        private static void ShowMainMeny()
        {
            Console.WriteLine("1. add employee");
            Console.WriteLine("2. print employees");
            Console.WriteLine("3. Quit");
        }

        private static void SeedData()
        {
            payroll.AddEmployee("Kalle", 20000);
            payroll.AddEmployee("Nisse", 30000);
            payroll.AddEmployee("Lisa", 40000);
        }
    }
}
