using System;
using System.Text;

namespace EmployeeManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Run run =new Run();
            run.RunManager();
        }
    }
}
