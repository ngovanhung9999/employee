using System;
using System.Text.RegularExpressions;
namespace EmployeeManager
{
    public abstract class Person
    {
        protected string _FullName;
        protected string _DateOfBirth;
        protected double _CoefficientsSalary;
        public Person()
        {

        }
        public Person(string fullName, string dateOfBirth, double? coefficientsSalary)
        {
            _FullName = fullName;
            _DateOfBirth = dateOfBirth;
            if (coefficientsSalary != null)
            {
                _CoefficientsSalary = coefficientsSalary.Value;
            }
            else
            {
                _CoefficientsSalary = 1;
            }
        }

        public string FullName
        {
            get
            { return _FullName; }
            set
            { _FullName = value; }
        }

        public string DateOfBirth
        {
            get
            { return _DateOfBirth; }
            set
            {
                if (Regex.IsMatch(value, @"^([0-2][0-9]|(3)[0-1])(\/)(((0)[0-9])|((1)[0-2]))(\/)\d{4}$"))
                {
                    _DateOfBirth = value;
                }
                else
                {
                    _DateOfBirth="00/00/0000";
                }
            }
        }

        public double CoefficientsSalary
        {
            get
            { return _CoefficientsSalary; }
            set
            {

                if (value > 1 && value < 100)
                {
                    _CoefficientsSalary = value;
                }
                else
                {
                    _CoefficientsSalary = 1;
                }
            }
        }

        public virtual void Input()
        {
            Console.Write("Nhập họ tên: ");
            FullName = Console.ReadLine();
            Console.Write("Nhập ngày sinh: ");
            DateOfBirth = Console.ReadLine();
            Console.Write("Nhập hệ số lương: ");
            double coefficientsSalary;
            Double.TryParse(Console.ReadLine(), out coefficientsSalary);
            CoefficientsSalary = coefficientsSalary;
        }
        public override string ToString()
        {
            return $"Họ tên:{FullName} - Ngày sinh:{DateOfBirth} - Hệ số lương:{CoefficientsSalary}";
        }
        public abstract Double Salary();
    }
}
