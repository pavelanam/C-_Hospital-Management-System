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
    public partial class AddMedicine : Form
    {
        public AddMedicine()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            DoctorHome dh = new DoctorHome();
            dh.Show();
            this.Hide();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            AddDB();
        }
        private void AddDB()
        {
            SqlConnection con=null;
            SqlDataAdapter da=null;
            try
            {
                con = new SqlConnection("Data Source=PAVEL-ANAM\\SQLEXPRESS;Initial Catalog=HMS;Persist Security Info=True;User ID=sa;Password=2580");
                con.Open();
                string quary = "UPDATE patient SET Medicine='" + textMedicine.Text + "' WHERE TokenNo ='" + textTokenNo.Text + "'";
                da = new SqlDataAdapter(quary, con);
                da.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully Added");
            }
            catch(Exception e)
            {
                MessageBox.Show("Not Successfully Added");
            }
        }
    }
}
