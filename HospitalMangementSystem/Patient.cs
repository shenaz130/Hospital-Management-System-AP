using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HospitalMangementSystem
{
   public class Patient : User
    {
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
       public string PatientAddress
       {
           get;
           set;
       }
       public string PatientContact
       {
           get;
           set;
       }
       public string Gender
       {
           get;
           set;
       }

       

      
       public string Patientage
       {
           get;
           set;
       }

       //public Prescription Prescription
       //{
       //    get;
       //    set;
       //}




       internal void AddPatient()
       {
           MySqlConnection Connect = Connection.getConnection();
           string sql = @"INSERT into patient(p_id, p_name, p_age, p_contact_no, p_address, p_gender) VALUES (@id, @name,
                            @age,@gender, @contact, @addrs)";

           MySqlCommand cmd = new MySqlCommand(sql, Connect);

           cmd.Parameters.AddWithValue("id", this.PatientId);
           cmd.Parameters.AddWithValue("name", this.PatientName);
           cmd.Parameters.AddWithValue("age", this.Patientage);
           cmd.Parameters.AddWithValue("gender", this.Gender);
           cmd.Parameters.AddWithValue("contact", this.PatientContact);
           cmd.Parameters.AddWithValue("addrs", this.PatientAddress);
           Connect.Close();
        
       }

       internal void EditPatient()
       {
           MySqlConnection Connect = Connection.getConnection();
           string sql = @"UPDATE patient SET p_id=@id, p_name= @name, p_age=@age, p_contact_no=@contact, 
                            p_address=@addrs, p_gender=@gender
                            WHERE p_id" ;

           MySqlCommand cmd = new MySqlCommand(sql, Connect);

           cmd.Parameters.AddWithValue("id", this.PatientId);
           cmd.Parameters.AddWithValue("name", this.PatientName);
           cmd.Parameters.AddWithValue("age", this.Patientage);
           cmd.Parameters.AddWithValue("gender", this.Gender);
           cmd.Parameters.AddWithValue("contact", this.PatientContact);
           cmd.Parameters.AddWithValue("addrs", this.PatientAddress);
           Connect.Close();
       }

       internal void DeletePatient()
        {
            MySqlConnection Connect = Connection.getConnection();
                    string sql = "DELETE FROM patient WHERE  p_id=@id";
                    MySql.Data.MySqlClient.MySqlCommand cmd = new MySqlCommand(sql, Connect);


                    cmd.Parameters.AddWithValue("id", this.PatientId);
                    Connect.Close();
        }
       
   }
}
