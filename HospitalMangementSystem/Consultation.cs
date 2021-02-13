using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMangementSystem
{
    public class Consultation
    {
        public int AppId
        {
            get;
            set;
        }
        public string AppDate
        {
            get;
            set;
        }
        public string AppTime
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
        public int DoctorId
        {
            get;
            set;
        }
        public int PatientContact
        {
            get;
            set;
        }
        public string Desease
        {
            get;
            set;
        }
        public int Amount
        {
            get;
            set;
        }
        public Billing Billing
        {
            get;
            set;
        }
    }
}
