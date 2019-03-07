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
    public partial class DeletReceptionist : Form
    {
        public DeletReceptionist()
        {
            InitializeComponent();
        }

        private void DeletReceptionist_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            ReceptionistPanal rp1 = new ReceptionistPanal();
            rp1.Show();
            this.Hide();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            DeletDB();
        }
        private void DeletDB()
        {
            SqlConnection con = null;
            SqlDataAdapter sda = null;
            try
            {
                con = new SqlConnection("Data Source=PAVEL-ANAM\\SQLEXPRESS;Initial Catalog=HMS;Persist Security Info=True;User ID=sa;Password=2580");
                con.Open();
                string quary = "DELETE FROM receptionist WHERE ID ='" + textID.Text + "'";
                sda = new SqlDataAdapter(quary, con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully Delete");
            }
            catch(Exception e)
            {
                MessageBox.Show("Not Successfully Delete");
            }
            
        }
    }
}
