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
    public partial class Home : Form
    {
        private string NA;
        public Home()
        {
            InitializeComponent();
        }

        private void btn_Patient_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            MySqlConnection con;
            connetionString = "server=localhost;database=hmsdb;Uid=root;Pwd=;";
            con = new MySqlConnection(connetionString);
            con.Open();
            if (String.Compare(NA, "manager") == 0)
            {
                MessageBox.Show("YOU ARE NOT AUTHORIZED TO ACCESS THIS FUNCTION!!!");
            }
            else
            {
                 PaitentMain pm = new PaitentMain();
                 pm.Show();
                 this.Hide();
            }
           
        }

        private void btn_Employee_Click(object sender, EventArgs e)
        {
            EmployeeMain em = new EmployeeMain();
            em.Show();
            this.Hide();
        }

        private void btn_Consult_Click(object sender, EventArgs e)
        {
            ConsultMain cm = new ConsultMain();
            cm.Show();
            this.Hide();
        }

        private void btn_Prescrip_Click(object sender, EventArgs e)
        {
            PrescriptionMain pres = new PrescriptionMain();
            pres.Show();
            this.Hide();
        }

        private void btn_DietAdvc_Click(object sender, EventArgs e)
        {
            DeitAdvicesMain deit = new DeitAdvicesMain();
            deit.Show();
            this.Hide();
        }

        private void btn_Test_Click(object sender, EventArgs e)
        {
            TestMain test = new TestMain();
            test.Show();
            this.Hide();
        }

        private void btn_Med_Click(object sender, EventArgs e)
        {
            MedicationMain med = new MedicationMain();
            med.Show();
            this.Hide();
        }

        private void btn_Bill_Click(object sender, EventArgs e)
        {

        }

        private void btn_Report_Click(object sender, EventArgs e)
        {
            ReportMain rep = new ReportMain();
            rep.Show();
            this.Hide();
        }
    }
}
