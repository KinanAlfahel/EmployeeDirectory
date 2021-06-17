namespace EmployeeDirectory
{
    public interface IUI
    {
        string GetInput();
        void Print(Employee employee);
        void Print(string message);
    }
}