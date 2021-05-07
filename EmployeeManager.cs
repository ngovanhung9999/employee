using System;
using System.Collections.Generic;
using System.Linq;
namespace EmployeeManager
{
    public class EmployeeManager : List<Person>
    {
        public EmployeeManager()
        {
            Person p1 = new Manager("nguyen van a", "1/6/1997", 2.5, 400);
            Person p2 = new President("nguyen van c", "2/6/1997", 3.1, 2.6);
            Person p3 =
                new Employee("nguyen van b", "3/6/1997", null, "ke toan");
            Person p4 =
           new Employee("nguyen van e", "4/6/1997", 2.1, "kinh doanh");
            this.Add(p2);
            this.Add(p1);
            this.Add(p3);
            this.Add(p4);
        }

        public void AddEmployee()
        {
            string str = null;
            bool anchor = true;
            while (anchor)
            {
                Console.WriteLine("\t1. Thêm giám dốc");
                Console.WriteLine("\t2. Thêm quản lý");
                Console.WriteLine("\t3. Thêm nhân viên");
                Console.Write("Nhập chọn: ");
                str = Console.ReadLine();
                switch (str)
                {
                    case "1":
                        Person president = new President();
                        president.Input();
                        this.Add(president);
                        anchor = false;
                        break;
                    case "2":
                        Person manager = new Manager();
                        manager.Input();
                        this.Add(manager);
                        anchor = false;
                        break;
                    case "3":
                        Person employee = new Employee();
                        employee.Input();
                        this.Add(employee);
                        anchor = false;
                        break;
                    default:
                        Console
                            .WriteLine("Nhập lựa chọn sai, vui lòng nhập lại");
                        break;
                }
            }
        }

        public void Show()
        {
            int number = 1;
            foreach (var item in this)
            {
                Console.Write($"\t-STT:{number}  ");
                Console.WriteLine(item.ToString());
                number++;
            }
        }

        public void Show(List<Person> list)
        {
            int number = 1;
            foreach (var item in list)
            {
                Console.Write($"\t-STT:{number}  ");
                Console.WriteLine(item.ToString());
                number++;
            }
        }
        public Person HighestSalary()
        {
            double max = this.Max(person => person.Salary());
            var result = from person in this
                         where person.Salary() == max
                         select person;
            return result.ToArray()[0];
        }

        public List<Person> FindTheDepartment(string department)
        {
            var result = from person in this
                         where person.GetType() == typeof(Employee)
                         select person;
            var employees = result.Where(employees =>
            {
                Employee temp = (Employee)employees;
                return temp.Department.Equals(department);
            });
            return employees.ToList();
        }
        public bool SortEmployee()
        {
            try
            {
                this.Sort(new SortByName());
                return true;
            }catch(Exception e){
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}
