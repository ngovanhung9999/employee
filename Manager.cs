using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManager
{
    public class Manager : Person
    {
        private int _NumberOfEmployee;
        public Manager() : base()
        {

        }

        public Manager(string fullName, string dateOfBirth, double coefficientsSalary, int numberOfPersonnel) : base(fullName, dateOfBirth, coefficientsSalary)
        {
            _NumberOfEmployee = numberOfPersonnel;
        }

        public int NumberOfEmployee
        {
            get
            { return _NumberOfEmployee; }
            set
            {
                if (value > 1 && value < 1000)
                {
                    _NumberOfEmployee = value;
                }
                else
                {
                    _NumberOfEmployee = 0;
                }

            }
        }

        public override void input()
        {
            base.input();
            Console.Write("Nhập số lượng nhân viên quản lý: ");
            int number;
            Int32.TryParse(Console.ReadLine(), out number);
            NumberOfEmployee = number;
        }

        public override double salary()
        {
            return CoefficientsSalary * 1500000;
        }

        public override string ToString()
        {
            return base.ToString() + $" - Lương:{salary()} - Số lượng nhân viên:{NumberOfEmployee}";
        }
    }
}
