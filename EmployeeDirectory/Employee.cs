namespace EmployeeDirectory
{
    internal class Employee 
    {
        public string Name { get; }
        public int Salary { get; }

        public SalaryLevel SalaryLevel => Salary < 25000 ? SalaryLevel.Junior : SalaryLevel.Senior;

        //public SalaryLevel SalaryLevel2
        //{
        //    get
        //    {
        //        if (Salary < 25000)
        //            return SalaryLevel.Junior;
        //        else
        //            return SalaryLevel.Senior;
        //    }
        //}


        public Employee(string name, int salary)
        {
            this.Name = name;
            this.Salary = salary;
        }

        public override string ToString()
        {
            return $"Name: {Name} Salary: {Salary}";
        }
    }
}