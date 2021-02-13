
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HospitalMangementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            MySqlConnection Connect = Connection.getConnection();
            CheckLogin(Connect, txt_UserId.Text,txt_Password.Text);


        }
          
         public void CheckLogin(MySqlConnection connect, string UserId, string Password){

             string sql ="SELECT * FROM user WHERE user_id='" + UserId + "' AND password='" + Password + "'";

             MySqlCommand cmd = new MySqlCommand(sql, Connect);
                try
                {
                    MySqlDataReader reader = cmd.ExecuteReader();
                    string privilege = "NA";
                    while (reader.Read())
                    {
                        privilege = reader.GetString("privilage");
                    }

                   Console.Write("Privilege : " + privilege);

                   MessageBox.Show("You are granted with Access as " + privilege);
                   Home hm = new Home();
                   hm.Show();
                   this.Hide();  
                }
                catch (IndexOutOfRangeException ex)
                {
                    MessageBox.Show("Invalid username or password");

                }
         
                Connect.Close();
}

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        

}
}
        
    }

