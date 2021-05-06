using System;
using System.Text;
namespace EmployeeManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            President employee=new President();
            employee.input();
            Console.WriteLine(employee.ToString());
        }
    }
}
