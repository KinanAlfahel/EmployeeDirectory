using System;

namespace EmployeeDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            Robot robot = new Robot(12 , "Kalle");
            //var name = robot.GetName();

            try
            {
                 robot.Height = -55;
            }
            catch (Exception ex)
            {
                //Handle
                Console.WriteLine(ex.Message);
            }
       
        }
    }
}
