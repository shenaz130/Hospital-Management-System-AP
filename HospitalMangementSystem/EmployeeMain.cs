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
    public partial class EmployeeMain : Form
    {
        public EmployeeMain()
        {
            InitializeComponent();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            hm.Show();
            this.Hide();
        }

        private void EmployeeMain_Load(object sender, EventArgs e)
        {
            GetEmpData();
        }

        private void GetEmpData()
        {
            try
            {
                MySqlConnection Connect = Connection.getConnection();
                string sql = @"SELECT staff_id, staff_name, department_id, staff_age, staff_contact_no, staff_add, staff_acc 
                                 FROM staff";
                MySqlCommand cmd = new MySqlCommand(sql, Connect);

                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable("staff");
                sda.Fill(dt);

                dataGridViewEmp.DataSource = dt;


                Connect.Close();

            }
            catch (Exception)
            {
                throw;
            }
        }

        public void SearchByKeyword(string keyword)
        {
            try
            {
                MySqlConnection Connect = Connection.getConnection();
                string sql = @"SELECT 
                                      staff_id, staff_name, department_id, staff_age, staff_contact_no, staff_add, staff_acc
                                      FROM
                                      staff
                                      WHERE staff_id =@keyword";
                MySqlCommand cmd = new MySqlCommand(sql, Connect);
                cmd.Parameters.AddWithValue("keyword", keyword+"%");

                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds, "staff");
                dataGridViewEmp.DataSource = ds.Tables["staff"];
                Connect.Close();
            }

            catch (Exception)
            {

                throw;
            }

        }

              private void btn_add_Click(object sender, EventArgs e)
              {

              }

              private void groupBox1_Enter(object sender, EventArgs e)
              {

              }
    }
}
