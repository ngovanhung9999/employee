using System;
namespace EmployeeManager
{
    public class Employee : Person
    {
        private string _Department;
        public Employee() : base()
        {

        }

        public Employee(string fullName, string dateOfBirth, double? coefficientsSalary, string department) 
        : base(fullName, dateOfBirth, coefficientsSalary)
        {
            _Department = department;
        }

        public string Department
        {
            get
            { return _Department; }
            set
            { _Department = value; }
        }

        public override void Input()
        {
            base.Input();
            Console.Write("Nhập phòng ban: ");
            Department = Console.ReadLine();
        }

        public override double Salary()
        {
            return CoefficientsSalary * 1500000;
        }

        public override string ToString()
        {
            return base.ToString() + $"- Lương:{String.Format("{0:0}", Salary())}đ - Phòng ban:{Department}";
        }
    }
}
