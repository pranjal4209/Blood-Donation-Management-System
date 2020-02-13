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
using System.Text.RegularExpressions;

namespace Blood_donation_System
{
    public partial class adddonor : Form
    {
        public adddonor()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void adddonor_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {       
            
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=PRANJAL-PC;Initial Catalog=student;Integrated Security=True";
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into donor values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();

            if(textBox3.Text.Length < 10)
            {
                MessageBox.Show("Invalid number...");
            }
           else if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("cant be empty....");
            }
            else if (String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("cant be empty....");
            }
            else if (String.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("cant be empty....");
            }
            else if (String.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("cant be empty....");
            }
            else if (String.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("cant be empty....");
            }
            else
            {
                MessageBox.Show("Record Saved Successfully....");
                this.Close();
                blood_donation_management obj = new blood_donation_management();
                obj.Show();
            }            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            blood_donation_management obj = new blood_donation_management();
            obj.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
                MessageBox.Show("Name can't be empty");
            textBox1.Focus();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Regex re = new Regex("^9[0-9]{9}");

            if(textBox3.Text.Length > 10 )
            {
                MessageBox.Show("Invalid Indian Mobile Number!!");
                textBox3.Focus();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Blood group can't be empty....");
                textBox2.Focus();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Address can't be empty....");
                textBox4.Focus();
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show(" Blood bank can't be empty....");
                textBox5.Focus();
            }
        }
    }
}
