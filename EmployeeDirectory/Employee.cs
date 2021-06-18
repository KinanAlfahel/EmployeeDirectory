namespace EmployeeDirectory
{
    public class Employee 
    {
        //Properties
        //Här utan setters vi kan alltså inte ändra värdet efter det satts
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


        //Konstruktor
        public Employee(string name, int salary)
        {
            this.Name = name;
            this.Salary = salary;
        }

        //Metoder
        //Vi specialiserar betendet av ToString() metoden. Istället för default implementationen så vill vi att den här koden körs när vi anropar .ToString() på en Employee instans
        public override string ToString()
        {
            return $"Name: {Name} Salary: {Salary}";
        }
    }
}