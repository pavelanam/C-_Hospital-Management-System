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
    public partial class AddUsre : Form
    {
        public AddUsre()
        {
            InitializeComponent();
        }

        private void AddUsre_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            AdminHome ah3 = new AdminHome();
            ah3.Show();
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
                string quary = "INSERT INTO login VALUES ('" + textUserName.Text + "','" + textUserID.Text + "','" + textPassword.Text + "','" + textUserType.Text + "');";
                sda = new SqlDataAdapter(quary, con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully ADD User");
            }
            catch(Exception e)
            {
                MessageBox.Show("Not Successfully ADD User");
            }
           
        }
    }
}
