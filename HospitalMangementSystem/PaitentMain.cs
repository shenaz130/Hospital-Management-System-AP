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
    public partial class PaitentMain : Form
    {
        public PaitentMain()
        {
            InitializeComponent();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            hm.Show();
            this.Hide();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            AddPatient ap = new AddPatient();
            ap.Show();
            this.Hide();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            UpdatePatient up = new UpdatePatient();
            up.Show();
            this.Hide();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DeletePatient del = new DeletePatient();
            del.Show();
            this.Hide();
        }
    }
}
