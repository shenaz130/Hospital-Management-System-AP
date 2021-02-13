using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMangementSystem
{
    public class Employee : User
    {
        public string Name
        {
            get;
            set;
        }

        public string Password
        {
            get;
            set;
        }
        public int ContactNo
        {
            get;
            set;
        }

        public string Address
        {
            get;
            set;
        }

        public int NIC
        {
            get;
            set;
        }

        public string Gender
        {
            get;
            set;
        }

       
    }

}
