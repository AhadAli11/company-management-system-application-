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
    public partial class Admin_project_Info : Form
    {
        MySqlDataAdapter adpt;
        DataTable dt;
        public Admin_project_Info()
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
        {
            textBox1.Clear();


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
        private void Admin_project_Info_Load(object sender, EventArgs e)
        {
            groupBox1.Location = new Point(1, 291);
            groupBox1.Visible = false;

            string constring = "server=localhost;uid=root;pwd=remote1234;database=company";
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = constring;
            adpt = new MySqlDataAdapter("Select * from project", con);
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            groupBox1.Visible = true;
            string projectId = textBox1.Text; // Assuming the textbox contains the project ID
            string constring = "server=localhost;uid=root;pwd=remote1234;database=company";

            using (MySqlConnection con = new MySqlConnection(constring))
            {
                try
                {
                    string query = "SELECT idProject, ProjectName, Budget, Duration FROM project WHERE idProject = @projectId";

                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@projectId", projectId); // Adding the parameter

                    con.Open();
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            ProjectName.Text = dr["ProjectName"].ToString(); // Access the actual column name
                            ProjectID.Text = dr["idProject"].ToString();
                            Budget.Text = dr["Budget"].ToString();
                            Duration.Text = dr["Duration"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("No project found with the given ID.");
                        }
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }


        }
    }
}
