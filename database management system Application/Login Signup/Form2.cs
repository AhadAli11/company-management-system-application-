using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Login_Signup
{

    public partial class Form2 : Form
    {
        MySqlDataAdapter adpt;
        DataTable dt;
        public Form2()
        {
            InitializeComponent();
            textBoxPass.Text = "Password";
            textBoxPass.PasswordChar = '\0';
            textBoxPass.GotFocus += textBox3_GotFocus;
            //textBox3.TextChanged += textBox3_TextChanged;
            textBoxConPass.Text = "Confirm Password";
            textBoxConPass.PasswordChar = '\0';
            textBoxConPass.GotFocus += textBox4_GotFocus;
            //textBox4.TextChanged += textBox4_TextChanged;
            textBoxEmail.Text = "Email Address";
            textBoxEmail.GotFocus += textBox2_GotFocus;
            textBoxName.Text = "Full Name";
            textBoxName.GotFocus += textBox1_GotFocus;
            textBoxName.TextChanged += textBox1_TextChanged;
            textBoxName.Click += textBox1_Click;
            label4.Visible = false;
            label5.Visible = false;
            //SetTextBoxPosition();
            label5.VisibleChanged += Label5_VisibleChanged;

            // Set initial positions
            UpdatePictureBoxPosition();
            //label6.Text = "Please enter the verification code sent to your email!";
            label4.Visible = false;
            //pictureBox8.Visible = false;
            //panel5.Visible = false;
            //textBox5.Visible = false;
            //Verify.Visible = false;
            textBoxName.TextChanged += TextBox_TextChanged;
            textBoxEmail.TextChanged += TextBox_TextChanged;
            textBoxPass.TextChanged += TextBox_TextChanged;
            textBoxConPass.TextChanged += TextBox_TextChanged;
            pictureBox6.Click += pictureBox6_Click;
            //to close the application if this form is closed
            this.FormClosing += (sender, e) =>
            {
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    Application.Exit();
                }
            };
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            // When the text in any textbox changes, update the label visibility
            UpdateLabelVisibility();
        }

        private void UpdateLabelVisibility()
        {
            string password = textBoxPass.Text;
            bool IsValid = IsPasswordValid(password);
            // Check if any textbox is empty
            bool anyEmpty = string.IsNullOrWhiteSpace(textBoxName.Text) ||
                            string.IsNullOrWhiteSpace(textBoxEmail.Text) ||
                            string.IsNullOrWhiteSpace(textBoxPass.Text) ||
                            string.IsNullOrWhiteSpace(textBoxConPass.Text) ||
                            IsValid == false;

            // Set the visibility of the label based on whether any textbox is empty
            //label6.Visible = false;
            //pictureBox8.Visible = false;
            //panel5.Visible = false;
            //textBox5.Visible = false;
            //Verify.Visible = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Visible = false;
        }

        private void textBox1_GotFocus(object sender, EventArgs e)
        {
            if (textBoxName.Text == "Full Name")
            {
                textBoxName.Text = "";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBoxName.Text == "")
            {
                textBoxName.TextChanged -= textBox1_TextChanged;
                textBoxName.Text = "Full Name";
            }
        }

        private void textBox2_GotFocus(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "Email Address")
            {
                textBoxEmail.Text = "";
            }
        }

        private void textBox3_GotFocus(object sender, EventArgs e)
        {
            if (textBoxPass.Text == "Password")
            {
                textBoxPass.Text = "";
                textBoxPass.PasswordChar = '*';
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            CheckPasswordsMatch();
            validPassword();
        }

        private void textBox4_GotFocus(object sender, EventArgs e)
        {
            if (textBoxConPass.Text == "Confirm Password")
            {
                textBoxConPass.Text = "";
                textBoxConPass.PasswordChar = '*';
            }
        }

        private bool IsPasswordValid(string password)
        {
            // Password length between 8 and 32 characters
            if (password.Length < 8 || password.Length > 32)
                return false;

            // Contains at least one uppercase letter
            if (!Regex.IsMatch(password, "[A-Z]"))
                return false;

            // Contains at least one lowercase letter
            if (!Regex.IsMatch(password, "[a-z]"))
                return false;

            // Contains at least one digit
            if (!Regex.IsMatch(password, "[0-9]"))
                return false;

            // Contains at least one special character
            if (!Regex.IsMatch(password, "[^a-zA-Z0-9]"))
                return false;

            // Additional rules such as no dictionary words, no sequential characters, etc.
            // Add your custom rules here

            return true;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            CheckPasswordsMatch();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBoxName.Text = "";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            string empName, empPhoneNo, empEmail, empIdentityNo, empPass, empConPass;
            empName = textBoxName.Text.ToString();
            empPass = textBoxPass.Text.ToString();
            empConPass = textBoxConPass.Text.ToString();
            empEmail = textBoxEmail.Text.ToString();
            empIdentityNo = "";
            if (String.IsNullOrEmpty(empName) || String.IsNullOrEmpty(empEmail) || String.IsNullOrEmpty(empPass) || String.IsNullOrEmpty(empConPass))
            {
                MessageBox.Show("No empty fields are allowed!!!");
            }
            else
            {

                string constring = "server=localhost;uid=root;pwd=remote1234;database=comapny";
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = constring;
                con.Open();
                string sql = "Insert into signup (Name,Email,Password,ConfirmPassword) Values ('" + empName + "','" + empEmail + "','" + empPass + "', '" + empConPass + "' )";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                int a = cmd.ExecuteNonQuery();

                if (a > 0)
                {
                    MessageBox.Show("Account is succesfully created.");
                    textBoxName.Text = "Full Name";
                    textBoxEmail.Text = "Email Address";
                    textBoxPass.Text = "Password";
                    textBoxConPass.Text = "Confirm Password";
                }

            }
        }
        private void CheckPasswordsMatch()
        {

            if (textBoxPass.Text != textBoxConPass.Text)
            {
                label4.Text = "Passwords do not match!";
                label4.Visible = true;
            }
            else
            {
                label4.Visible = false;
            }
        }

        private void validPassword()
        {
            string password = textBoxPass.Text;
            bool isValid = IsPasswordValid(password);
            if (!isValid)
            {
                label5.Text = "Password do not meet the minimum requirements!" +
                    "\nYour Password should have minimum 8 characters \nincluding alphabets, digits and symbols!";
                label5.Visible = true;
            }
            else
            {
                label5.Visible = false;
            }
        }

        private void label5_TextChanged(object sender, EventArgs e)
        {

        }
        //private void SetTextBoxPosition()
        //{
        //    if (label5.Visible = true)
        //    {
        //        // Set the coordinates for the TextBox
        //        int x = 451; // X coordinate
        //        int y = 326; // Y coordinate

        //        // Set the location of the TextBox using the coordinates
        //        pictureBox5.Location = new System.Drawing.Point(x, y);
        //    }
        //    else
        //    {
        //        int x = 451;
        //        int y = 298;
        //        pictureBox5.Location = new System.Drawing.Point(x, y);
        //    }
        //}

        private void pictureBox5_(object sender, EventArgs e)
        {
            //SetTextBoxPosition();
        }

        private void Label5_VisibleChanged(object sender, EventArgs e)
        {
            // When the visibility of label5 changes, update the textbox position
            UpdatePictureBoxPosition();
        }

        private void UpdatePictureBoxPosition()
        {
            // Set the default position
            int x = 515;
            int y = 399;

            // If label5 is visible, adjust the position
            if (label5.Visible)
            {
                y = 465;
            }

            // Set the location of the TextBox using the coordinates
            pictureBox5.Location = new System.Drawing.Point(x, y);

            int z = 558;
            int w = 403;
            if (label5.Visible)
            {
                w = 475;
            }
            textBoxConPass.Location = new System.Drawing.Point(z, w);

            int q = 515;
            int e = 443;
            if (label5.Visible)
            {
                e = 508;
            }
            panel4.Location = new System.Drawing.Point(q, e);

            int r = 525;
            int t = 487;
            if (label5.Visible)
            {
                t = 575;
            }
            checkBox1.Location = new System.Drawing.Point(r, t);

            int i = 515;
            int u = 452;
            if (label5.Visible)
            {
                u = 530;
            }
            label4.Location = new System.Drawing.Point(i, u);

            int k = 595;
            int l = 520;
            if (label5.Visible)
            {
                l = 607;
            }
            pictureBox6.Location = new System.Drawing.Point(k, l);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin_Dashboard ad = new Admin_Dashboard();
            this.Visible = false;
            ad.Show();

        }
    }
}