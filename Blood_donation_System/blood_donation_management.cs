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
using Excel = Microsoft.Office.Interop.Excel;

namespace Blood_donation_System
{
    public partial class blood_donation_management : Form
    {
        public blood_donation_management()
        {
            InitializeComponent();
        }

        private void blood_donation_management_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDataSet.donor' table. You can move, or remove it, as needed.
            this.donorTableAdapter.Fill(this.studentDataSet.donor);

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserLoginSystem obj = new UserLoginSystem();
            obj.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            adddonor obj = new adddonor();
            obj.Show();
        }

        private void keyUp_Event(object sender, KeyEventArgs e)
         {
             
         } 

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=PRANJAL-PC;Initial Catalog=student;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * from donor where name like '" +textBox1.Text + "%'",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                SqlConnection con = new SqlConnection("Data Source=PRANJAL-PC;Initial Catalog=student;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * from donor where contactno like '" + textBox2.Text + "%'", con);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                dataGridView1.DataSource = dtbl;
            }

        }

        private void copyAlltoClipboard()
        {
            
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridView1.SelectAll();
        DataObject dataObj = dataGridView1.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            
            
                copyAlltoClipboard();
                Microsoft.Office.Interop.Excel.Application xlexcel;
                Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
                Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;
                xlexcel = new Excel.Application();
                xlexcel.Visible = true;
                xlWorkBook = xlexcel.Workbooks.Add(misValue);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
                CR.Select();
                xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
            

        }
    }
    }
