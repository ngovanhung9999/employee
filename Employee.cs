﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManager
{
    public class Employee : Person
    {
        private string _Department;
        public Employee() : base()
        {

        }

        public Employee(string fullName, string dateOfBirth, double coefficientsSalary, string department) : base(fullName, dateOfBirth, coefficientsSalary)
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

        public override void input()
        {
            base.input();
            Console.Write("Nhập phòng ban: ");
            Department = Console.ReadLine();
        }

        public override double salary()
        {
            return CoefficientsSalary * 1500000;
        }

        public override string ToString()
        {
            return base.ToString() + $"- Lương:{salary()} - Phòng ban:{Department}";
        }
    }
}