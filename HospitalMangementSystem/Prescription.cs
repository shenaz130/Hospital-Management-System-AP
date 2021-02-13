using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMangementSystem
{
    class Prescription
    {
        public int PrescriptionId
        {
            get;
            set;
        }
        public int AppId
        {
            get;
            set;
        }
        public int PatientId
        {
            get;
            set;
        }
        public string Date
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
