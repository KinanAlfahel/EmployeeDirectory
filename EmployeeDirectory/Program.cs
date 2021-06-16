using System;

namespace EmployeeDirectory
{
    class Program
    {
        static void Main(string[] args)
        {

            Robot robot = new Robot(12 , "Kalle");
            Robot robot2 = new Robot();
            robot2.Name = "Nisse";
            //var name = robot.GetName();

            var rName = robot.Name;
            robot.Name = "Nytt namn";

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
