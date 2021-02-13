using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace HospitalMangementSystem
{
    public partial class AddPatient : Form
    {
        public AddPatient()
        {
            InitializeComponent();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            PaitentMain pmain = new PaitentMain();
            pmain.Show();
            this.Hide();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Patient patient = (Patient)getUserFactory.getUser("Patient");
            int pid = int.Parse(txtPatientId.Text);
            string pname = txtName.Text;
            string age = txtAge.Text;
            string gender = cbGender.Items[cbGender.SelectedIndex].ToString();
            string pcontact = txtContact.Text;
            string addrs = txtAddress.Text;

          
            patient.PatientId = pid;
            patient.PatientName = pname;
            patient.Address =addrs;
            patient.Contact = pcontact;
            patient.Gender = gender;

            patient.AddPatient();
            MessageBox.Show("Successfully Added!");
            

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
