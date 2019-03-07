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
    public partial class AddReceptionist : Form
    {
        public AddReceptionist()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            ReceptionistPanal rp = new ReceptionistPanal();
            rp.Show();
            this.Hide();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            InsertDB();
        }
        private void InsertDB()
        { 
            SqlConnection con=null;
            SqlDataAdapter sda=null;
            try
            {
                con = new SqlConnection("Data Source=PAVEL-ANAM\\SQLEXPRESS;Initial Catalog=HMS;Persist Security Info=True;User ID=sa;Password=2580");
                con.Open();
                string quary = "INSERT INTO receptionist VALUES ('" + textName.Text + "','" + textID.Text + "','" + textAge.Text + "','" + textContact.Text + "','" + textCity.Text + "','" + textGender.Text + "','" + textQualification.Text + "'," + textSalary.Text + ");";
                sda = new SqlDataAdapter(quary, con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully ADD Information");
            }
            catch(Exception e)
            {
                MessageBox.Show("Not Successfully ADD Information");
            }
        }
    }
}
