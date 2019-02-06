using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Employee
    {
        public int iD;
        public string fname;
        public string lname;
        public string email;

        public Employee(int ID, string Fname, string Lname, string Email)
        {
            iD = ID;
            fname = Fname;
            lname = Lname;
            email = Email;
        }
    }
}

