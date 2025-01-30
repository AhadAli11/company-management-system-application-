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
    public partial class Employee_project_info : Form
    {
        public Employee_project_info()
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

        private void Employee_project_info_Load(object sender, EventArgs e)
        {
            string constring = "server=localhost;uid=root;pwd=remote1234;database=company";
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                int myid = Form1.instance.id; // Ensure that Form1.instance.id returns the correct Employee ID

                try
                {
                    string query = @"SELECT 
                            employee.Name AS 'Employee Name',
                            employee.EmployeeId AS 'Employee Id',
                            project.idProject AS 'Project Id',
                            project.ProjectName AS 'Project Name',
                            department.idDepartment AS 'Department Id',
                            department.DepartmentName AS 'Department Name',
                            project.Duration
                         FROM 
                            project
                         JOIN 
                            employee ON employee.Project_idProject = project.idProject
                         JOIN 
                            department ON employee.Department_idDepartment = department.idDepartment
                         WHERE 
                            employee.EmployeeId = @myid;";

                    MySqlCommand cmd = new MySqlCommand(query, con);
                    // Add the parameter to the command
                    cmd.Parameters.AddWithValue("@myid", myid);
                    con.Open();
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            labelName.Text = dr["Employee Name"].ToString(); // Use the alias as defined in the query
                            labelid.Text = dr["Employee Id"].ToString();
                            projectName.Text = dr["Project Name"].ToString();
                            projectId.Text = dr["Project Id"].ToString();
                            Duration.Text = dr["Duration"].ToString();
                            DepartmentName.Text = dr["Department Name"].ToString();
                            DepartmentId.Text = dr["Department Id"].ToString();
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
            private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Employee_Dashboard open = new Employee_Dashboard();
            open.Show();
        }

        private void labelCnic_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
