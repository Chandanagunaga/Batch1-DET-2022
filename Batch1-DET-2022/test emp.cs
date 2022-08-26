using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvvvsoleApp1
{
    internal class test_emp
    {
       public static void Main()
        {
            Emp e = new Emp(5050, "Mary", new DateOnly(2020, 8, 1));
            Console.WriteLine($"Year of experience{e.GetYearsofExp()}");
        }
    }
}
