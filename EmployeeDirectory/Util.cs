using System;

namespace EmployeeDirectory
{
    public static class Util
    {
        internal static string AskForString(string prompt)
        {
            bool success = false;
            string answer;

            do
            {
                Console.WriteLine(prompt);
                answer = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(answer))
                {
                    Console.WriteLine("You must enter a name");
                }
                else
                {
                    success = true;
                }

            } while (!success);

            return answer;
        }
    }
}