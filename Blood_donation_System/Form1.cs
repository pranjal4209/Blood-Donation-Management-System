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

namespace Blood_donation_System
{
    public partial class UserLoginSystem : Form
    {
        public UserLoginSystem()
        {
            InitializeComponent();
        }

        private void UserLoginSystem_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=PRANJAL-PC;Initial Catalog=student;Integrated Security=True";
            SqlCommand cmd = new SqlCommand("select * from login where username='" + txtUsername.Text +"' and password='" + txtPassword.Text +"'",con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                MessageBox.Show("You Have Successfully Logged In...");
                this.Hide();
                blood_donation_management sd = new blood_donation_management();
                sd.Show();
            }
            else
            {
                MessageBox.Show("Invalid Login Please Check Username and Password ");
               
            }
            con.Close();
           // MessageBox.Show(txtUsername.Text + " " + txtPassword.Text);

        }


        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
