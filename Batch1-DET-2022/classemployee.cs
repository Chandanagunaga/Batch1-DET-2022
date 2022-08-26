using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvvvsoleApp1
{
    internal class classemployee
    {
        public static void Main()
        {
            Employee emp = new Employee(22783, "Chandana", Bangalore",560098,8105893428,30000);
            Console.WriteLine($"Employeee's net salary {emp.GetEmpNetSalary()}");
            Console.WriteLine($"Employee's grade is {emp.GetEmpGrade()}");
        }
    }
}
