using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvvvsoleApp1
{
    internal class employee
    {
        int rollno;
        string name;
        string address;
        int pincode;
        int phoneno;
        int grosssal;
        int pf;

        public Emplyoee(int rollno,string name,string address,int pincode,int phoneno,int grosssal)
        {
            this.rollno = rollno;
            this.name = name;
            this.address = address;
            this.pincode = pincode;
            this.phoneno = phoneno;
            this.grosssal = grosssal;
            
        }

        public int GetEmpNetSalary()
        {
            int pf = 12 * grosssal / 100;
            int netsalary = grosssal - pf;
            return netsalary;
        }

        public char GetEmpGrade()
        {
            // netsalary = grosssal - pf;
            if (GetEmpNetSalary() > 10000)
            {
                return 'A';
            }
            else if (GetEmpNetSalary() > 5000)
            {
                return 'B';
            }
            else
                return 'C';
        }
    }
}
