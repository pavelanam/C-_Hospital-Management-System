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
    public partial class ReceptionistPanal : Form
    {
        public ReceptionistPanal()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddReceptionist ar = new AddReceptionist();
            ar.Show();
            this.Hide();
        }

        private void buttonDelet_Click(object sender, EventArgs e)
        {
            DeletReceptionist dr = new DeletReceptionist();
            dr.Show();
            this.Hide();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            UpdateReceptionist ur = new UpdateReceptionist();
            ur.Show();
            this.Hide();
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            ViewDB();
        }
        private void ReceptionistPanal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            ReceptionistSearch rs = new ReceptionistSearch();
            rs.Show();
            this.Hide();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            AdminHome ah1 = new AdminHome();
            ah1.Show();
            this.Hide();
        }
        private void ViewDB()
        {
            SqlConnection con = null;
            SqlDataAdapter sda = null;
            try
            {
                con = new SqlConnection("Data Source=PAVEL-ANAM\\SQLEXPRESS;Initial Catalog=HMS;Persist Security Info=True;User ID=sa;Password=2580");
                con.Open();
                string quary = "SELECT * FROM receptionist";
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
