using System;

namespace EmployeeDirectory
{
    //Statisk klass kan ej instansieras (med andra ord EJ : Util util = new Util())
    //Statiska klasser kan endast ha statiska medlemmar
    //Anropas med klassNamn.MetodNamn tex Util.AskForString("Hej!", new ConsoleUI())
    public static class Util
    {
        //Prompt = det vi vill skriva ut på skärmen
        //Ui hanterar input/output
        internal static string AskForString(string prompt, IUI ui)
        {
            bool success = false;
            string answer;

            //loopa tills användaren har skrivit in något
            //Än så länge ingen annan validering.
            do
            {
                ui.Print(prompt);
                answer = ui.GetInput();

                if (string.IsNullOrWhiteSpace(answer))
                {
                   ui.Print("You must enter something");
                }
                else
                {
                    success = true;
                }

            } while (!success);

            return answer;
        }

        internal static int AskForInt(string prompt, IUI ui)
        {
            bool success = false;
            int answer;

            do
            {
                string input = AskForString(prompt, ui);
                success =  int.TryParse(input, out answer) && answer > 0;

                if (!success)
                    ui.Print("Error");

            } while (!success);

            return answer;

        }
    }
}