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
    public partial class IT_project_info : Form
    {
        MySqlDataAdapter adpt;
        DataTable dt;
        public IT_project_info()
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


        }
        private void IT_project_info_Load(object sender, EventArgs e)
        {
            string constring = "server=localhost;uid=root;pwd=remote1234;database=company";
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = constring;
            adpt = new MySqlDataAdapter("SELECT  project.ProjectName,project.idProject,project.Budget,project.Duration FROM project INNER JOIN project_has_department ON project.idProject = project_has_department.Project_idProject INNER JOIN department ON project_has_department.Department_idDepartment = department.idDepartment WHERE department.DepartmentName = 'IT';", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Visible = false;
            maneger_IT open = new maneger_IT();
            open.Show();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isIdSearchSelected = radioButtonID.Checked;
            bool isNameSearchSelected = radioButtonName.Checked;
            string text = textBox1.Text;
            string constring = "server=localhost;uid=root;pwd=remote1234;database=company";

            if (!isIdSearchSelected && !isNameSearchSelected)
            {
                MessageBox.Show("Please select a search option.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (MySqlConnection con = new MySqlConnection(constring))
            {
                try
                {
                    con.Open();
                    MySqlDataAdapter adpt;
                    DataTable dt = new DataTable();

                    if (isIdSearchSelected)
                    {
                        string query = "SELECT \r\n    project.ProjectName, \r\n    project.idProject, \r\n    project.Budget, \r\n    project.Duration \r\nFROM \r\n    project\r\nINNER JOIN \r\n    project_has_department ON project.idProject = project_has_department.Project_idProject\r\nINNER JOIN \r\n    department ON project_has_department.Department_idDepartment = department.idDepartment\r\nWHERE \r\n    department.DepartmentName = 'IT'and project.idProject = @SearchText";
                        adpt = new MySqlDataAdapter(query, con);
                        adpt.SelectCommand.Parameters.AddWithValue("@SearchText", text);
                        adpt.Fill(dt);
                        dataGridView1.DataSource = dt;

                    }
                    else if (isNameSearchSelected)
                    {
                        string query = "SELECT \r\n    project.ProjectName, \r\n    project.idProject, \r\n    project.Budget, \r\n    project.Duration \r\nFROM \r\n    project\r\nINNER JOIN \r\n    project_has_department ON project.idProject = project_has_department.Project_idProject\r\nINNER JOIN \r\n    department ON project_has_department.Department_idDepartment = department.idDepartment\r\nWHERE \r\n    department.DepartmentName = 'IT' and project.ProjectName = @SearchText";
                        adpt = new MySqlDataAdapter(query, con);
                        adpt.SelectCommand.Parameters.AddWithValue("@SearchText", text);
                        adpt.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
    }

