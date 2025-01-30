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
    public partial class Admin_Dashboard : Form
    {



        public Admin_Dashboard()
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
            //Label 2 location setting
            Size panal = panel1.Size;
            int label2_half, panal_half = panal.Width / 2;
            label2_half = label2.Width / 2;
            label2_half = panal_half - label2_half;
            label2.Location = new Point(label2_half, 9);

            //panel locations
            panel11.Location = new Point(200, 100);
            panel13.Location = new Point(200, panel11.Location.Y + panel11.Height + 50);
            panel15.Location = new Point(200, panel13.Location.Y + panel13.Height + 50);
            panel12.Location = new Point(panel1.Location.X + panel11.Width + 120, 100);
            panel14.Location = new Point(panel1.Location.X + panel11.Width + 120, panel12.Location.Y + panel12.Height + 50);
            panel16.Location = new Point(panel1.Location.X + panel11.Width + 120, panel14.Location.Y + panel14.Height + 50);

            //picturebox
            pictureBox7.Location = new Point(this.Right - pictureBox7.Width, this.Top);
        }

        private void Form3_Load(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        bool sidebarExpand = true;
        private void sidebartimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                panel1.Width += 10;
                //location setting
                panel1.Location = new Point(sidebar.Width + 50, panel1.Location.Y);

                if (sidebar.Width <= 70)
                {
                    sidebarExpand = false;
                    sidebartimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                panel1.Width -= 10;
                //location setting
                panel1.Location = new Point(sidebar.Width + 50, panel1.Location.Y);

                if (sidebar.Width >= 314)
                {
                    sidebarExpand = true;
                    sidebartimer.Stop();
                }
            }
            //Label 2 location setting
            Size panal = panel1.Size;
            int label2_half, panal_half = panal.Width / 2;
            label2_half = label2.Width / 2;
            label2_half = panal_half - label2_half;
            label2.Location = new Point(label2_half, 9);

        }

        private void menu_Click(object sender, EventArgs e)
        {
            sidebartimer.Start();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void Employee_Click(object sender, EventArgs e)
        {
            Admin_Employee_Info admin_Employee_Info = new Admin_Employee_Info();
            this.Hide();
            admin_Employee_Info.Show();
        }

        private void Attendance_Click(object sender, EventArgs e)
        {
            Admin_Attendance admin_Attendance = new Admin_Attendance();
            this.Hide();
            admin_Attendance.Show();
        }

        private void Admin_report_Click(object sender, EventArgs e)
        {
            Admin_Report admin_Report = new Admin_Report();
            this.Hide();
            admin_Report.Show();
        }

        private void System_Click(object sender, EventArgs e)
        {
            Setting set = new Setting();
            this.Hide();
            set.Show();
        }

        private void projects_Click(object sender, EventArgs e)
        {
            Admin_project_Info admin_Project_Info = new Admin_project_Info();
            this.Hide();
            admin_Project_Info.Show();
        }

        private void Teams_Click(object sender, EventArgs e)
        {
            Teams team = new Teams();
            this.Hide();
            team.Show();
        }

        private void Personal_info_Click(object sender, EventArgs e)
        {
            Admin_personal_info admin_Personal_Info = new Admin_personal_info();
            this.Hide();
            admin_Personal_Info.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Admin_Employee_Info AEI = new Admin_Employee_Info();
            AEI.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Admin_Employee_Info AEI = new Admin_Employee_Info();
            AEI.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Admin_project_Info API = new Admin_project_Info();
            API.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Admin_project_Info API = new Admin_project_Info();
            API.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Admin_Report ARI = new Admin_Report();
            ARI.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Admin_Report ARI = new Admin_Report();
            ARI.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form2 Signup = new Form2();
            Signup.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form2 Signup = new Form2();
            Signup.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Admin_Attendance AAI = new Admin_Attendance();
            AAI.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Admin_Attendance AAI = new Admin_Attendance();
            AAI.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Setting Set = new Setting();
            Set.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Setting Set = new Setting();
            Set.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
