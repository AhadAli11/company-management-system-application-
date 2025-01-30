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
    public partial class Teams : Form
    {
        private int imgnumber = 1;  // Keep track of the current image number
        private const int totalImages = 9;
        public Teams()
        {
            InitializeComponent();
            this.Resize += Teams_Resize;
        }
        private void Teams_Resize(object sender, EventArgs e)
        {
            Size size = this.Size;
            int formhalfWidth = size.Width / 2;
            int label1_halfwidth = label1.Width / 2;
            label1_halfwidth = formhalfWidth - label1_halfwidth;
            label1.Location = new Point(label1_halfwidth, 10);
            button3.Location=new Point (this.Right-button3.Width,this.Top+button3.Height);
        }

        private void LoadNextImage()
        {
            if (imgnumber == 9)
            {
                imgnumber = 1;
            }
            slidepic.ImageLocation = string.Format(@"Images\{0}.jpg", imgnumber);
            imgnumber++;
        }

        private void LoadPreviousImage()
        {
            imgnumber--;
            if (imgnumber < 1)
            {
                imgnumber = totalImages;
            }
            slidepic.ImageLocation = string.Format(@"Images\{0}.jpg", imgnumber);
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadNextImage();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadPreviousImage();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string previouspage_roll;
            previouspage_roll = Form1.instance.roll;

            if (previouspage_roll == "Admin")
            {
                this.Hide();
                Admin_Dashboard Tm = new Admin_Dashboard();
                Tm.Show();
            }
            if (previouspage_roll == "Finance")
            {
                this.Hide();
                manager___finance_ tm = new manager___finance_();
                tm.Show();
            }
            if (previouspage_roll == "IT")
            {
                this.Hide();
                maneger_IT tm = new maneger_IT();
                tm.Show();
            }
            if (previouspage_roll == "Employee")
            {
                this.Hide();
                Admin_Dashboard tm = new Admin_Dashboard();
                tm.Show();
            }
        }
    }
}
