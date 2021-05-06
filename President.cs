using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManager
{
    public class President : Person
    {
        private double _PositionCoefficient;
        public President() : base()
        {

        }

        public President(string fullName, string dateOfBirth, double coefficientsSalary, double positionCoefficient) : base(fullName, dateOfBirth, coefficientsSalary)
        {
            _PositionCoefficient = positionCoefficient;
        }

        public double PositionCoefficient
        {
            get
            { return _PositionCoefficient; }
            set
            {
                if (value > 1 && value < 20)
                {
                    _PositionCoefficient = value;
                }
                else
                {
                    _PositionCoefficient = 1;
                }

            }
        }

        public override void input()
        {
            base.input();
            Console.Write("Nhập hệ số vị trí: ");
            double number;
            Double.TryParse(Console.ReadLine(), out number);
            PositionCoefficient = number;
        }

        public override double salary()
        {
            return CoefficientsSalary*PositionCoefficient * 1500000;
        }

        public override string ToString()
        {
            return base.ToString() + $" - Lương:{salary()} - Hệ số vị trí:{PositionCoefficient}";
        }
    }
}
