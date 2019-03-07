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
    public partial class UpdateDoctor : Form
    {
        public UpdateDoctor()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            DoctorPanal dp3 = new DoctorPanal();
            dp3.Show();
            this.Hide();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            UpdateDB();
        }

        private void UpdateDoctor_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void UpdateDB()
        {
            SqlConnection con = null;
            SqlDataAdapter sda = null;
            try
            {
                con = new SqlConnection("Data Source=PAVEL-ANAM\\SQLEXPRESS;Initial Catalog=HMS;Persist Security Info=True;User ID=sa;Password=2580");
                con.Open();
                string quary = "UPDATE doctor SET Name='" + textName.Text + "' , Age='" + textAge.Text + "' , Contact='" + textContact.Text + "' , City='" + textCity.Text + "' , Gender='" + textGender.Text + "' , Qualification='" + textQualification.Text + "' , Specialist='" + textSpecialist.Text + "' , Salary='" + textSalary.Text + "' WHERE ID='" + textID.Text + "'";
                sda = new SqlDataAdapter(quary, con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully Update");
            }
            catch(Exception e)
            {
                MessageBox.Show("Not Successfully Update");
            }
           
        }
    }
}
