using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMangementSystem
{
    class getUserFactory
    {
        public static User getUser(String User){
       
           switch(User){
               case "Doctor":
                   return new Doctor();
                   break;
               case "Nurse":
                   return new Nurse();
                   break;
               case "Receptionist":
                   return new Receptionist();
                   break;
               case "Employee":
                   return new Employee();
                   break;
               case "Patient":
                   return new Patient();
                   break;

               default:
                   return null;
           
           }
    }
}
