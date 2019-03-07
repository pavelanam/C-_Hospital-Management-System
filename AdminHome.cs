using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class AdminHome : Form
    {
        public AdminHome()
        {
            InitializeComponent();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            login l = new login();
            l.Show();
            this.Hide();
        }

        private void AdminHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonDoctor_Click(object sender, EventArgs e)
        {
            DoctorPanal dp = new DoctorPanal();
            dp.Show();
            this.Hide();
        }

        private void buttonReceptionist_Click(object sender, EventArgs e)
        {
            ReceptionistPanal rp = new ReceptionistPanal();
            rp.Show();
            this.Hide();
        }

        private void buttonUser_Click(object sender, EventArgs e)
        {
            AddUsre au = new AddUsre();
            au.Show();
            this.Hide();
        }

        private void buttonDelet_Click(object sender, EventArgs e)
        {
            DeletUser du = new DeletUser();
            du.Show();
            this.Hide();
        }
    }
}
