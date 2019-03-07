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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            textPassword.PasswordChar = '*';
            textPassword.MaxLength = 50;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            check();
        }

        private void login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void check()
        {
            SqlConnection con = null;
            SqlDataAdapter sda = null;
            DataTable dt = null;
            try
            {
                con = new SqlConnection("Data Source=PAVEL-ANAM\\SQLEXPRESS;Initial Catalog=HMS;Persist Security Info=True;User ID=sa;Password=2580");
                sda = new SqlDataAdapter("select UserType from login where UserID ='" + textUserID.Text + "' and Password = '" + textPassword.Text + "' ", con);
                dt = new DataTable();
                sda.Fill(dt);
                //MessageBox.Show(dt.Rows[0][0].ToString());
                if (dt.Rows[0][0].ToString() == "Admin")
                {
                    AdminHome ah = new AdminHome();
                    ah.Show();
                    this.Hide();
                }
                else if (dt.Rows[0][0].ToString() == "Doctor")
                {
                    DoctorHome dh = new DoctorHome();
                    dh.Show();
                    this.Hide();
                }
                else if (dt.Rows[0][0].ToString() == "Receptionist")
                {
                    ReceptionistHome rh = new ReceptionistHome();
                    rh.Show();
                    this.Hide();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Invalid ID Or Password");
            }
        }
    }
}
