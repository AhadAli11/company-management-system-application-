using Google.Protobuf.WellKnownTypes;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Login_Signup
{
    public partial class EmployeeInfo : Form
    {
        MySqlDataAdapter adpt;
        DataTable dt;

        public EmployeeInfo()
        {
            InitializeComponent();
            dataGridView1.Visible = true;
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
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void EmployeeInfo_Load(object sender, EventArgs e)
        {
            groupBox1.Location = new Point (1, 291);
            groupBox1.Visible = false;
            
            string constring = "server=localhost;uid=root;pwd=remote1234;database=company";
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = constring;
            adpt = new MySqlDataAdapter("select EmployeeId,Name,ContactNumber,Salary from employee", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {dataGridView1.Visible = false;
            groupBox1.Visible=true;
            string date = textBox1.Text;
            string constring = "server=localhost;uid=root;pwd=remote1234;database=company";
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                try
                {
                    string query = "select EmployeeId, Name, ContactNumber, Salary from employee where EmployeeId = @date";

                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@date", date); // Adding the parameter

                    con.Open();
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            labelName.Text = dr["Name"].ToString(); // Access the actual column name
                            labelid.Text = dr["EmployeeId"].ToString();
                            Contactnumber.Text = dr["ContactNumber"].ToString();
                            salary.Text = dr["Salary"].ToString();
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

        private void button2_Click(object sender, EventArgs e)
        {
            manager___finance_ manfin = new manager___finance_();
            manfin.Show();
            this.Visible = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }
    }
}
