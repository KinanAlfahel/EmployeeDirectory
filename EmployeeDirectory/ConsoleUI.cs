using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDirectory
{
    public class ConsoleUI : IUI
    {
        public string GetInput()
        {
            return Console.ReadLine();
        }

        public void Print(string message)
        {
            Console.WriteLine(message);
        }

        public void Print(Employee employee)
        {
            Console.WriteLine(employee);
        }
    }

    public class TestUI : IUI
    {
        public string GetInput()
        {
            throw new NotImplementedException();
        }

        public void Print(Employee employee)
        {
            throw new NotImplementedException();
        }

        public void Print(string message)
        {
            throw new NotImplementedException();
        }
    }
}
