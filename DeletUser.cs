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
    public partial class DeletUser : Form
    {
        public DeletUser()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            AdminHome ad4 = new AdminHome();
            ad4.Show();
            this.Hide();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            DeletDB();
        }
        private void DeletDB()
        {
            string x = "A-001";
            string h = textID.Text;
            string quary = null;

            SqlConnection con = new SqlConnection("Data Source=PAVEL-ANAM\\SQLEXPRESS;Initial Catalog=HMS;Persist Security Info=True;User ID=sa;Password=2580");
            con.Open();

            if (x.Equals(h))
            {
                MessageBox.Show("Cannot Delet This User");
            }
            else
            {
                quary = "DELETE FROM login WHERE UserID ='" + textID.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(quary, con);
                da.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully Delete");
            }
            
            
        }

        private void DeletUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonViewAll_Click(object sender, EventArgs e)
        {
            ViewDB();
        }
        private void ViewDB()
        {
            SqlConnection con = new SqlConnection("Data Source=PAVEL-ANAM\\SQLEXPRESS;Initial Catalog=HMS;Persist Security Info=True;User ID=sa;Password=2580");
            con.Open();
            string quary = "SELECT * FROM login";
            SqlDataAdapter da = new SqlDataAdapter(quary, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
