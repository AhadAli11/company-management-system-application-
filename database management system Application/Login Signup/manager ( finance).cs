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
    public partial class manager___finance_ : Form
    {
        public manager___finance_()
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
            label5.Location = new Point(label5_halfwidth, panel1.Location.Y - 220);


            pictureBox7.Location = new Point(-100, 6);


        }


        private void manager___finance__Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(50, 0, 0, 0);

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Finance_Montly_Budget setting = new Finance_Montly_Budget();
            setting.Show();
            this.Visible = false;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            EmployeeInfo resinfo = new EmployeeInfo();
            resinfo.Show();
            this.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            EmployeeInfo resinfo = new EmployeeInfo();
            resinfo.Show();
            this.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Project_Budget_Information resinfo = new Project_Budget_Information();
            resinfo.Show();
            this.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Resource_Info resinfo = new Resource_Info();
            resinfo.Show();
            this.Visible = false;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Resource_Info resinfo = new Resource_Info();
            resinfo.Show();
            this.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Project_Budget_Information resinfo = new Project_Budget_Information();
            resinfo.Show();
            this.Visible = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Setting setting = new Setting();
            setting.Show();
            this.Visible = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Setting setting = new Setting();
            setting.Show();
            this.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Finance_Montly_Budget setting = new Finance_Montly_Budget();
            setting.Show();
            this.Visible = false;

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Teams t = new Teams();
            this.Hide();
            t.Show();

        }
    }
}
