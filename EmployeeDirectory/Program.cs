using System;

namespace EmployeeDirectory
{
    class Program
    {

        //Instansierar en payroll och ett ui
        //Scoopade till hela klassen
        static Payroll payroll = new Payroll();
        static IUI ui = new ConsoleUI();

        //Programmets startpunkt
        //Får bara finnas EN!
        static void Main(string[] args)
        {
            //Skapar lite dummy data
            SeedData();

            //ProgramLoop körs till användaren väljer att avsluta
            do
            {
                ShowMainMeny();
                UserInput();

            } while (true);
        }

        private static void UserInput()
        {
            //Tar ett värde från användaren
            //Testar olika case. Användaren skriver in "1" då körs AddEmployee metoden. 
            //Om vi inte träffar något case körs default koden
            switch (ui.GetInput())
            {
                case "1":
                    AddEmployee();
                    break;
                case "2":
                    PrintEmployees();
                    break;
                case "3":
                    //Avslutar programmet
                    Environment.Exit(0);
                    break;
                default:
                    ui.Print("Wrong input");
                    break;
            }
        }

        private static void AddEmployee()
        {
            //Loopar tills användaren trycker "Q"
            do
            {
                ui.Print("Add an employee, Q for exit");
                string name = Util.AskForString("Name ", ui); //Säkerställer att vi får en input som inte är tom

                if (name.Equals("Q")) break;                  //Hoppar ur loopen och återgår till ProgramLoopen

                int salary = Util.AskForInt("Salary ", ui);   //Säkerställer att vi får tillbaks en int som är störren än 0

                payroll.AddEmployee(name, salary);            

            } while (true);
        }

        private static void PrintEmployees()
        {
            //Hämtar alla Employees från PayRoll som en kopia
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
