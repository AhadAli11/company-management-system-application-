using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Signup
{
    public partial class Admin_Employee_Info : Form
    {
        MySqlDataAdapter adpt;
        DataTable dt;
        public Admin_Employee_Info()
        {
            InitializeComponent();
            this.Resize += Form1_Resize; // Subscribe to the Resize event of the form


            textBox1.GotFocus += new EventHandler(textBox1_GotFocus);


            //to close the application if this form is closed
            this.FormClosing += (sender, e) =>
            {
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    Application.Exit();
                }
            };

        }

        private void textBox1_GotFocus(object sender, EventArgs e)
        { textBox1.Clear(); }

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

            button2.Location = new Point(this.Right - button2.Width - 10, this.Top + button2.Height);
        }
        private void Admin_Employee_Info_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox1.Location = new Point(0, 281);


            string constring = "server=localhost;uid=root;pwd=remote1234;database=company";
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = constring;
            adpt = new MySqlDataAdapter("SELECT \r\n    employee.EmployeeId,\r\n    employee.Name,\r\n    employee.Email,\r\n    employee.ContactNumber,\r\n    employee.Role,\r\n    employee.Salary,\r\n    employee.Department_idDepartment AS DepartmentID,\r\n    employee.Project_idProject AS ProjectId,\r\n    personalinformation.CNIC,\r\n    personalinformation.DOB AS 'Date of Birth',\r\n    personalinformation.Sex,\r\n    personalinformation.Address\r\nFROM \r\n    employee\r\nJOIN \r\n    personalinformation ON employee.EmployeeId = personalinformation.Employee_EmployeeId;\r\n", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Visible = false;
            Admin_Dashboard open = new Admin_Dashboard();
            open.Show();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Delete_emp_admin_ del = new Delete_emp_admin_();
            del.Show();
        }

        private void Duration_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            groupBox1.Visible = true;
            string text = textBox1.Text;

            string constring = "server=localhost;uid=root;pwd=remote1234;database=company";
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                try
                {
                    string query = @"SELECT
                            employee.Name AS 'Employee Name',
                            employee.EmployeeId AS 'Employee Id',
                            employee.Email AS 'Email',
                            employee.ContactNumber AS 'ContactNumber',
                            employee.Role AS 'Role',
                            employee.Salary AS 'Salary',
                            project.idProject AS 'Project Id',
                            department.idDepartment AS 'Department Id',
                            personalinformation.CNIC AS 'CNIC',
                            personalinformation.DOB AS 'DOB',
                            personalinformation.sex AS 'sex',
                            personalinformation.Address AS 'Address'
                         FROM 
                            project
                         JOIN 
                            employee ON employee.Project_idProject = project.idProject
                         JOIN 
                            department ON employee.Department_idDepartment = department.idDepartment
                         JOIN 
                            personalinformation ON employee.EmployeeId = personalinformation.Employee_EmployeeId
                         WHERE 
                            employee.EmployeeId = @text";

                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@text", text); // Add parameter value for @text

                    con.Open();
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            name.Text = dr["Employee Name"].ToString();
                            labelid.Text = dr["Employee Id"].ToString();
                            Email.Text = dr["Email"].ToString();
                            Number.Text = dr["ContactNumber"].ToString();
                            Role.Text = dr["Role"].ToString();
                            Salary.Text = dr["Salary"].ToString();
                            ProjectID.Text = dr["Project Id"].ToString();
                            DepartmentId.Text = dr["Department Id"].ToString();
                            CNIC.Text = dr["CNIC"].ToString();
                            DOB.Text = dr["DOB"].ToString();
                            Gender.Text = dr["sex"].ToString();
                            Address.Text = dr["Address"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("No record found.");
                        }
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
