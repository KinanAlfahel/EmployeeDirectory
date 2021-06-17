using System;

namespace EmployeeDirectory
{
    class Program
    {
        

        static Payroll payroll = new Payroll();

        static void Main(string[] args)
        {
            SeedData();

            do
            {
                ShowMainMeny();
               
                switch (Console.ReadLine())
                {
                    case "1":
                        AddEmployee();
                        break;
                    case "2":
                        PrintEmployees();
                        break;
                    case "3":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }


            } while (true);



        }

        private static void AddEmployee()
        {
            Console.WriteLine("Add an employee");
            string name = Util.AskForString("Name ");


           
            
            bool success2 = false;
            string salary;

            do
            {
                Console.WriteLine("Salary: ");
                salary = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(salary))
                {
                    Console.WriteLine("You must enter a salary");
                }
                else
                {
                    success2 = true;
                }

            } while (!success2);

            payroll.AddEmployee(name, int.Parse(salary));

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
