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
    public partial class DeletePatient : Form
    {
        public DeletePatient()
        {
            InitializeComponent();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            PaitentMain pmain = new PaitentMain();
            pmain.Show();
            this.Hide();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Patient patient = (Patient)getUserFactory.getUser("Patient");
            int pid = int.Parse(txtPatientId.Text);
            patient.PatientId = pid;
            patient.DeletePatient();
            MessageBox.Show("Successfully deleted!");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
