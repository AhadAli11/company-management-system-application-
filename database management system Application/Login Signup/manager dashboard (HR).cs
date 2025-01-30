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
    public partial class manager_HR : Form
    {
        public manager_HR()
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

        private void label7_Click(object sender, EventArgs e)
        {
            Resourse_Request_Response resinfo = new Resourse_Request_Response();
            resinfo.Show();
            this.Visible = false;

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            complain_responce resinfo = new complain_responce();
            resinfo.Show();
            this.Visible = false;

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(50, 0, 0, 0);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            EmployeeHiring resinfo = new EmployeeHiring();
            resinfo.Show();
            this.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            EmployeeHiring resinfo = new EmployeeHiring();
            resinfo.Show();
            this.Visible = false;

        }

        private void label3_Click(object sender, EventArgs e)
        {
            ProjectInfo resinfo = new ProjectInfo();
            resinfo.Show();
            this.Visible = false;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ProjectInfo resinfo = new ProjectInfo();
            resinfo.Show();
            this.Visible = false;

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Attendance resinfo = new Attendance();
            resinfo.Show();
            this.Visible = false;

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Attendance resinfo = new Attendance();
            resinfo.Show();
            this.Visible = false;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            HR_Report resinfo = new HR_Report();
            resinfo.Show();
            this.Visible = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            HR_Report resinfo = new HR_Report();
            resinfo.Show();
            this.Visible = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            complain_responce resinfo = new complain_responce();
            resinfo.Show();
            this.Visible = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Resourse_Request_Response resinfo = new Resourse_Request_Response();
            resinfo.Show();
            this.Visible = false;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Setting set = new Setting();
            this.Hide();
            set.Show();
        }
    }
}
