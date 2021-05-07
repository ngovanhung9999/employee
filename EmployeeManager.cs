using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManager
{
    public class EmployeeManager
    {
        private List<Person> _ListEmployee;

        public EmployeeManager(List<Person> list)
        {
            _ListEmployee = list;
        }

        public List<Person> ListEmployee
        {
            get
            {
                return _ListEmployee;
            }
            set
            {
                _ListEmployee = value;
            }
        }

        public EmployeeManager()
        {
            _ListEmployee = new List<Person>();
            Person p1 = new Manager("nguyen van a", "1/6/1997", 2.5, 400);
            _ListEmployee.Add (p1);
            Person p2 = new President("ngo van hung", null, 3.1, 2.1);
            _ListEmployee.Add (p2);
            Person p3 =
                new Employee("nguyen van b", "3/10/1995", 2.1, "ke toan");
            _ListEmployee.Add (p3);
        }

        public void Add()
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
                        _ListEmployee.Add (president);
                        anchor = false;
                        break;
                    case "2":
                        Person manager = new Manager();
                        manager.Input();
                        _ListEmployee.Add (manager);
                        anchor = false;
                        break;
                    case "3":
                        Person employee = new Employee();
                        employee.Input();
                        _ListEmployee.Add (employee);
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
            foreach (var item in ListEmployee)
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
    }
}
