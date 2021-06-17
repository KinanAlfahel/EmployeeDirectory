using System;

namespace EmployeeDirectory
{
    public static class Util
    {
        internal static string AskForString(string prompt, IUI ui)
        {
            bool success = false;
            string answer;

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