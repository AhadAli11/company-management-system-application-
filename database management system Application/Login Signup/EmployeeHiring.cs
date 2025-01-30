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
    public partial class EmployeeHiring : Form
    {
        public EmployeeHiring()
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

            //int button1width = button1.Width / 2;
            //button1width = formhalfWidth - button1width;
            //button1.Location = new Point(button1width, 250);

            pictureBox7.Location = new Point(-100, 6);


        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            manager_HR open = new manager_HR();
            open.Show();
            this.Visible = false;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string empName, empPhoneNo, empEmail, empCnic, empRole, empId, empSalary, empDOB, empDept, empProj, empGen, empAdd;
            empName = textBoxName.Text.ToString();
            empPhoneNo = textBoxNum.Text.ToString();
            empRole = textBoxRole.Text.ToString();
            empEmail = textBoxEmail.Text.ToString();
            empCnic = textBoxCnic.Text.ToString();
            empSalary = textBoxSalary.Text.ToString();
            empDOB = textBoxDOB.Text.ToString();
            empDept = textBoxDept.Text.ToString();
            empProj = textBoxProj.Text.ToString();
            empGen = textBoxGen.Text.ToString();
            empAdd = textBoxAddress.Text.ToString();
            empId = textBoxEmpId.Text.ToString();

            if (String.IsNullOrEmpty(empName) || String.IsNullOrEmpty(empEmail) || String.IsNullOrEmpty(empPhoneNo) || String.IsNullOrEmpty(empRole) || String.IsNullOrEmpty(empCnic) || String.IsNullOrEmpty(empSalary) || String.IsNullOrEmpty(empDOB) || String.IsNullOrEmpty(empDept) || String.IsNullOrEmpty(empProj) || String.IsNullOrEmpty(empGen) || String.IsNullOrEmpty(empAdd))
            {
                MessageBox.Show("No empty fields are allowed!!!");
            }
            else
            {

                string constring = "server=localhost;uid=root;pwd=remote1234;database=company";
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = constring;
                con.Open();
                // For employee table
                string sql = "Insert into employee (EmployeeId,Name,Email,ContactNumber,Role,Salary,Department_idDepartment,Project_idProject) Values ('" + empId + "','" + empName + "','" + empEmail + "','" + empPhoneNo + "', '" + empRole + "', '" + empSalary + "','" + empDept + "', '" + empProj + "')";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                int a = cmd.ExecuteNonQuery();

                string sql1 = "Insert into personalinformation (CNIC,Name,DOB,Sex,Address,Employee_EmployeeId) Values ('" + empCnic + "','" + empName + "','" + empDOB + "', '" + empGen + "', '" + empAdd + "','" + empId + "')";
                MySqlCommand cmd1 = new MySqlCommand(sql1, con);
                int a1 = cmd1.ExecuteNonQuery();



                MessageBox.Show("Employee Hired Successfully.");




            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmployeeHiring_Load(object sender, EventArgs e)
        {

        }
    }
}
