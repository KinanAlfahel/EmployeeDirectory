using System;

namespace EmployeeDirectory
{
    class Program
    {


        static Payroll payroll = new Payroll();
        static IUI ui = new ConsoleUI();

        static void Main(string[] args)
        {
            SeedData();

            do
            {
                ShowMainMeny();
                UserInput();

            } while (true);
        }

        private static void UserInput()
        {
            switch (ui.GetInput())
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
                    ui.Print("Wrong input");
                    break;
            }
        }

        private static void AddEmployee()
        {
            do
            {
                ui.Print("Add an employee, Q for exit");
                string name = Util.AskForString("Name ", ui);

                if (name.Equals("Q")) break;

                int salary = Util.AskForInt("Salary ", ui);

                payroll.AddEmployee(name, salary);

            } while (true);
        }

        private static void PrintEmployees()
        {
            Employee[] employees = payroll.GetEmplyees();

            foreach (Employee employee in employees)
            {
                ui.Print(employee);
            }
        }

        private static void ShowMainMeny()
        {
           ui.Print("1. add employee");
           ui.Print("2. print employees");
           ui.Print("3. Quit");
        }

        private static void SeedData()
        {
            payroll.AddEmployee("Kalle", 20000);
            payroll.AddEmployee("Nisse", 30000);
            payroll.AddEmployee("Lisa", 40000);
        }
    }
}
