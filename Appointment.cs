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
    public partial class Appointment : Form
    {
        public Appointment()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            ReceptionistHome rh1 = new ReceptionistHome();
            rh1.Show();
            this.Hide();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            InsertDB();
        }

        private void Appointment_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void InsertDB()
        {
            SqlConnection con = null;
            SqlDataAdapter sda = null;
            try
            {
                con = new SqlConnection("Data Source=PAVEL-ANAM\\SQLEXPRESS;Initial Catalog=HMS;Persist Security Info=True;User ID=sa;Password=2580");
                con.Open();
                string quary = "INSERT INTO patient VALUES ('" + textTokenNo.Text + "','" + textName.Text + "','" + textAge.Text + "','" + textPhoneNo.Text + "','" + textCity.Text + "','" + textGender.Text + "','" + textProblem.Text + "','" + textMedicine.Text + "');";
                sda = new SqlDataAdapter(quary, con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully ADD Patient");
            }
            catch(Exception e)
            {
                MessageBox.Show("Not Successfully ADD Patient");
            }
            
        }
    }
}
