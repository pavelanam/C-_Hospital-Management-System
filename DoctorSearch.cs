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
    public partial class DoctorSearch : Form
    {
        public DoctorSearch()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            DoctorPanal dp2 = new DoctorPanal();
            dp2.Show();
            this.Hide();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            SearchDB();
        }
        private void SearchDB()
        {
            SqlConnection con = null;
            SqlDataAdapter sda = null;
            try
            {
                con = new SqlConnection("Data Source=PAVEL-ANAM\\SQLEXPRESS;Initial Catalog=HMS;Persist Security Info=True;User ID=sa;Password=2580");
                con.Open();
                string quary = "select * from doctor where ID='" + textISearch.Text + "' or Name like'%" + textISearch.Text + "%'";
                sda = new SqlDataAdapter(quary, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView.DataSource = dt;
                con.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show("Not Found");
            }
            
        }

        private void DoctorSearch_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
