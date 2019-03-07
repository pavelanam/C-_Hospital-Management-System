using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hospital_Management_System
{
    public partial class ReceptionistHome : Form
    {
        public ReceptionistHome()
        {
            InitializeComponent();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            login l3 = new login();
            l3.Show();
            this.Hide();
        }

        private void buttonAppointment_Click(object sender, EventArgs e)
        {
            Appointment a = new Appointment();
            a.Show();
            this.Hide();
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            ViewDB();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            PatientSearch ps = new PatientSearch();
            ps.Show();
            this.Hide();
        }

        private void ReceptionistHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void ViewDB()
        {
            SqlConnection con = null;
            SqlDataAdapter sda = null;
            try
            {
                con = new SqlConnection("Data Source=PAVEL-ANAM\\SQLEXPRESS;Initial Catalog=HMS;Persist Security Info=True;User ID=sa;Password=2580");
                con.Open();
                string quary = "SELECT * FROM patient";
                sda = new SqlDataAdapter(quary, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show("Not Show");
            }
            
        }
    }
}
