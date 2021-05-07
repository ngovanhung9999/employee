using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public Person(string fullName, string dateOfBirth, double coefficientsSalary)
        {
            _FullName = fullName;
            _DateOfBirth = dateOfBirth;
            _CoefficientsSalary = coefficientsSalary;

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
            { _DateOfBirth = value; }
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
