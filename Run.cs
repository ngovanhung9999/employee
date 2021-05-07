using System;
using System.Collections.Generic;

namespace EmployeeManager
{
    public class Run
    {
        public void RunManager()
        {
            EmployeeManager manager = new EmployeeManager();
            string str = null;
            bool anchor = true;
            while (anchor)
            {
                Console.WriteLine("------------------------------------");
                this.Menu();
                Console.WriteLine("------------------------------------");
                Console.Write("Nhập Chọn: ");
                str = Console.ReadLine();
                switch (str)
                {
                    case "1":
                        Console.WriteLine("-------Thêm nhân viên");
                        manager.AddEmployee();
                        break;
                    case "2":
                        Console.WriteLine("-------Xem danh sách nhân viên");
                        manager.Show();
                        break;
                    case "3":
                        Console
                            .WriteLine("-------Xem nhân viên lương cao nhất");
                        Console.WriteLine(manager.HighestSalary().ToString());
                        break;

                    case "4":
                        Console.WriteLine("-------Xem nhân viên có phòng ban");
                        Console.Write("Nhập phòng ban: ");
                        string department = Console.ReadLine();
                        List<Person> listp2 = manager.FindTheDepartment(department);
                        if (listp2.Count == 0)
                        {
                            Console.WriteLine("Không tìm thấy nhân viên thuộc phòng ban: " + department);
                        }
                        else
                        {
                            manager.Show(listp2);
                        }
                        break;
                    case "5":
                        Console.WriteLine("-------Xem sắp xếp theo họ tên");
                        if( manager.SortEmployee()){
                             Console.WriteLine("Sắp xếp theo họ tên thành công");
                             manager.Show();
                        }else{
                             Console.WriteLine("Lỗi");
                        }
                        break;
                    case "0":
                        anchor = false;
                        break;
                    default:
                        Console
                            .WriteLine("Nhập lựa chọn sai,vui lòng nhập lại");
                        break;
                }
            }
        }

        public void Menu()
        {
            Console.WriteLine("\t-------MENU----------");
            Console.WriteLine("\t1. Thêm một nhân viên");
            Console.WriteLine("\t2. Xem danh sách");
            Console.WriteLine("\t3. Xem nhân viên có lương cao nhất");
            Console.WriteLine("\t4. Xem nhân viên có phòng ban");
            Console.WriteLine("\t5. Xem sắp xếp theo họ tên");
            Console.WriteLine("\t0. Thoát");
        }
    }
}
