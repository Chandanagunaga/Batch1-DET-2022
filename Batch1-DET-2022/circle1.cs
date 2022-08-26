using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvvvsoleApp1
{
    internal class circle1
    {
        int r;
        public circle1(int r)
        {
            this.r = r;
        }
        public double Getarea()
        {
            return Math.PI * r * r;
        }

    }
}
