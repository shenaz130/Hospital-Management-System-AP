using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMangementSystem
{
    public class Billing
    {
        public int BillId
        {
            get;
            set;
        }
        public int PatientId
        {
            get;
            set;
        }
        public string PatientName
        {
            get;
            set;
        }
        public int AppId
        {
            get;
            set;
        }
        public int Amount
        {
            get;
            set;
        }
        public Test Test
        {
            get;
            set;
        }
        

    }
}
