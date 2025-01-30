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
    public partial class Finance_Montly_Budget : Form
    {
        MySqlDataAdapter adpt;
        DataTable dt;

        public Finance_Montly_Budget()
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            manager___finance_ manfin = new manager___finance_();
            manfin.Show();
            this.Visible = false;
        }

        private void Finance_Montly_Budget_Load(object sender, EventArgs e)
        {
            string constring = "server=localhost;uid=root;pwd=remote1234;database=company";
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = constring;
            adpt = new MySqlDataAdapter("select * from monthlyBudgetProfit", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
