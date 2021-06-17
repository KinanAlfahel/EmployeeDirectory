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
                   ui.Print("You must enter a name");
                }
                else
                {
                    success = true;
                }

            } while (!success);

            return answer;
        }

        internal static int AskForInt(string v, IUI ui)
        {
            throw new NotImplementedException();
        }
    }
}