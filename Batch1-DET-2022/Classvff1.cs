﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1xsdx
{
    internal class Classvff1
    {
        private static int findAge(DateTime DOB)
        {
            int age = 0;
            age = DateTime.Now.Year - DOB.Year;
            if (DateTime.Now.DayOfYear < DOB.DayOfYear)
                age = age - 1;

            return age;
        }

    }

}
