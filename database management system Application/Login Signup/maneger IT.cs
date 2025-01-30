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
    public partial class maneger_IT : Form
    {
        public maneger_IT()
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
            label5.Location = new Point(label5_halfwidth, panel1.Location.Y - 190);


            pictureBox7.Location = new Point(-100, 6);


        }

        private void maneger_IT_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(50, 0, 0, 0);

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            IT_Employee_Info itEmp = new IT_Employee_Info();
            itEmp.Show();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            IT_Employee_Info itEmp = new IT_Employee_Info();
            itEmp.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            IT_project_info itPro = new IT_project_info();
            itPro.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            IT_project_info itPro = new IT_project_info();
            itPro.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Available_Resources AR = new Available_Resources();
            AR.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Available_Resources AR = new Available_Resources();
            AR.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Setting Se = new Setting();
            Se.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Setting Se = new Setting();
            Se.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Teams Te = new Teams();
            Te.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Teams Te = new Teams();
            Te.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Issued_Resources IR = new Issued_Resources();
            IR.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Issued_Resources IR = new Issued_Resources();
            IR.Show();
        }
    }
}
