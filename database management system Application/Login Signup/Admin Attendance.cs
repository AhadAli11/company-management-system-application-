using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Signup
{
    public partial class Admin_Attendance : Form
    {
        MySqlDataAdapter adpt;
        DataTable dt;
        public Admin_Attendance()
        {
            InitializeComponent();
            this.Resize += Form1_Resize; // Subscribe to the Resize event of the form

            //to close the application if this form is closed
            this.FormClosing += (sender, e) =>
            {
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    Application.Exit();
                }
            };
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            //LANBEL 1 location setting
            Size size = this.Size;
            int formhalfWidth = size.Width / 2;
            int label1_halfwidth = label1.Width / 2;
            label1_halfwidth = formhalfWidth - label1_halfwidth;
            label1.Location = new Point(label1_halfwidth, 0);


            //dashboard label location setting

            int label5_halfwidth = label5.Width / 2;
            label5_halfwidth = formhalfWidth - label5_halfwidth;
            label5.Location = new Point(label5_halfwidth, 190);


            pictureBox7.Location = new Point(-100, 6);


        }
       

        private void Admin_Attendance_Load(object sender, EventArgs e)
        {
            string constring = "server=localhost;uid=root;pwd=remote1234;database=company";

            using (MySqlConnection con = new MySqlConnection(constring))
            {
                try
                {
                    con.Open();
                    string query = "select Employee_EmployeeId as 'Employee Id',Date,AttendanceStatus as 'Attendance Status',TimeIn as 'Time In' \r\nfrom attendance";
                    adpt = new MySqlDataAdapter(query, con);
                    dt = new DataTable();
                    adpt.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Admin_Dashboard open = new Admin_Dashboard();
            open.Show();
          
        }
    }
}
