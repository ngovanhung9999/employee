using System;

namespace EmployeeManager
{
    public class President : Person
    {
        private double _PositionCoefficient;
        public President() : base()
        {

        }

        public President(string fullName, string dateOfBirth, double coefficientsSalary, double? positionCoefficient)
        : base(fullName, dateOfBirth, coefficientsSalary)
        {
            if (positionCoefficient != null)
            {
                _PositionCoefficient = positionCoefficient.Value;
            }
            else
            {
                _PositionCoefficient = 1;
            }

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

        public override void Input()
        {
            base.Input();
            Console.Write("Nhập hệ số vị trí: ");
            double number;
            Double.TryParse(Console.ReadLine(), out number);
            PositionCoefficient = number;
        }

        public override double Salary()
        {
            return CoefficientsSalary * PositionCoefficient * 1500000;
        }

        public override string ToString()
        {
            return base.ToString() + $" - Lương:{String.Format("{0:0}", Salary())}đ - Hệ số vị trí:{PositionCoefficient}";
        }
    }
}
