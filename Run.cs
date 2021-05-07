using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                        manager.Add();
                        break;
                    case "2":
                        Console.WriteLine("-------Xem danh sách nhân viên");
                        manager.Show();
                        break;
                    case "3":
                        Console
                            .WriteLine("-------Xem nhân viên lương cao nhất");

                        //manager.highestSalary();
                        break;
                    case "4":
                        Console
                            .WriteLine("-------Xem nhân viên sinh nhật trong tháng");

                        // int month = 0;
                        // try {
                        // 	System.out.print("Nhập Tháng Sinh Nhật: ");
                        // 	month = Integer.parseInt(scanner.nextLine());
                        // } catch (Exception e) {
                        // 	e.printStackTrace();
                        // }
                        // ArrayList<Person> listp = manager.birthdaysOfTheMonth(month);
                        // if (listp.size() == 0) {
                        // 	System.out.println("Không tìm thấy nhân viên có sinh nhật trong tháng " + month);
                        // } else {
                        // 	manager.show(listp);
                        // }
                        break;
                    case "5":
                        // System.out.println("-------Xem Nhân Viên Có Phòng Ban");
                        // System.out.print("Nhập Phòng Ban: ");
                        // str = scanner.nextLine();
                        // ArrayList<Person> listp2 = manager.findTheDepartment(str);
                        // if (listp2.size() == 0) {
                        // 	System.out.println("Không tìm thấy nhân viên thuộc phòng ban " + str);
                        // } else {
                        // 	manager.show(listp2);
                        // }
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
            Console.WriteLine("\t4. Xem nhân viên có sinh nhật trong tháng");
            Console.WriteLine("\t5. Xem nhân viên có phòng ban");
            Console.WriteLine("\t0. Thoát");
        }
    }
}
