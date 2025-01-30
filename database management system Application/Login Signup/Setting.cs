using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net.Mail;
using System.Net;


namespace Login_Signup
{
    public partial class Setting : Form
    {
        String randomCode;
        public static String to;
        private string connectionString = "server=localhost;uid=root;pwd=remote1234;database=company";
        public Setting()
        {
            InitializeComponent();

            this.Resize += Form1_Resize;
            groupBox2.Visible = false;
            groupBox2.Location = new Point(319, 67);
            groupBox4.Visible = false;
            groupBox4.Location = new Point(319, 67);
            groupBox3.Visible = false;
            groupBox3.Location = new Point(319, 67);
            groupBox5.Visible = false;
            groupBox5.Location = new Point(319, 67);
            //groupBox6.Location = new Point(319, 67);
            label6.Visible = false;
            label12.Visible = false;
            textBox4.Visible = false;
            button10.Visible = false;
            button9.Enabled = false;

            label13.Visible = false;
            label14.Visible = false;
            textBox8.Visible = false;
            button11.Visible = false;
            button12.Enabled = false;
            //dataGridView1.Visible = true;
            //dataGridView1.Location = new Point(319, 77);
            FixGroupBoxSize();
        }

        private void FixGroupBoxSize()
        {
            // Replace "groupBox1" with the name of your GroupBox
            //dataGridView1.Size = new Size(889, 717);
            groupBox2.Size = new Size(889, 729);
            groupBox3.Size = new Size(889, 729);
            groupBox4.Size = new Size(889, 729);
            groupBox5.Size = new Size(889, 729);
            //groupBox6.Size = new Size(889, 729);
            // Width = 200, Height = 100
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            Size size = this.Size;
            int formhalfWidth = size.Width / 2;
            int label1_halfwidth = label1.Width / 2;
            label1_halfwidth = formhalfWidth - label1_halfwidth;
            label1.Location = new Point(label1_halfwidth, 4);
            //setting icon location 
            int pictureBox1_halfwidth = pictureBox1.Width / 2;
            pictureBox1_halfwidth = formhalfWidth - pictureBox1_halfwidth;
            pictureBox1.Location = new Point(pictureBox1_halfwidth - 110, 8);
            //change password label
            int label2_halfwidth = label2.Width / 2;
            label2_halfwidth = formhalfWidth - label2_halfwidth;
            label2.Location = new Point(label2_halfwidth - 175, 30);
            //enter your current password
            int label3_halfwidth = label3.Width / 2;
            label3_halfwidth = formhalfWidth - label3_halfwidth;
            label3.Location = new Point(label3_halfwidth - 240, 100);
            //textbox current pass
            int textBox1_halfwidth = textBoxCurPass.Width / 2;
            textBox1_halfwidth = formhalfWidth - textBox1_halfwidth;
            textBoxCurPass.Location = new Point(textBox1_halfwidth - 180, 130);
            //enter new pass
            int label4_halfwidth = label4.Width / 2;
            label4_halfwidth = formhalfWidth - label4_halfwidth;
            label4.Location = new Point(label4_halfwidth - 252, 200);
            //new pass textbox
            int textBox2_halfwidth = textBoxNewPass.Width / 2;
            textBox2_halfwidth = formhalfWidth - textBox2_halfwidth;
            textBoxNewPass.Location = new Point(textBox2_halfwidth - 180, 230);
            //confirm new pass label
            int label5_halfwidth = label5.Width / 2;
            label5_halfwidth = formhalfWidth - label5_halfwidth;
            label5.Location = new Point(label5_halfwidth - 240, 305);
            //cnfrm new pass textbox
            int textBox3_halfwidth = textBoxConNewPass.Width / 2;
            textBox3_halfwidth = formhalfWidth - textBox3_halfwidth;
            textBoxConNewPass.Location = new Point(textBox3_halfwidth - 180, 335);
            //submit button
            int button7_halfwidth = button7.Width / 2;
            button7_halfwidth = formhalfWidth - button7_halfwidth;
            button7.Location = new Point(button7_halfwidth - 170, 425);
            //phone number label
            int label9_halfwidth = label9.Width / 2;
            label9_halfwidth = formhalfWidth - label9_halfwidth;
            label9.Location = new Point(label9_halfwidth - 175, 30);
            //enter your current phone number
            int label8_halfwidth = label8.Width / 2;
            label8_halfwidth = formhalfWidth - label8_halfwidth;
            label8.Location = new Point(label8_halfwidth - 220, 100);
            //textbox current pass
            int textBox6_halfwidth = textBox6.Width / 2;
            textBox6_halfwidth = formhalfWidth - textBox6_halfwidth;
            textBox6.Location = new Point(textBox6_halfwidth - 180, 130);
            //enter new ph no
            int label7_halfwidth = label7.Width / 2;
            label7_halfwidth = formhalfWidth - label7_halfwidth;
            label7.Location = new Point(label7_halfwidth - 232, 200);
            //new ph no textbox
            int textBox5_halfwidth = textBox5.Width / 2;
            textBox5_halfwidth = formhalfWidth - textBox5_halfwidth;
            textBox5.Location = new Point(textBox5_halfwidth - 180, 230);
            //submit button
            int button8_halfwidth = button8.Width / 2;
            button8_halfwidth = formhalfWidth - button8_halfwidth;
            button8.Location = new Point(button8_halfwidth - 173, 325);
            //Email Verification label
            int label11_halfwidth = label11.Width / 2;
            label11_halfwidth = formhalfWidth - label11_halfwidth;
            label11.Location = new Point(label11_halfwidth - 175, 30);
            //enter your Email
            int label10_halfwidth = label10.Width / 2;
            label10_halfwidth = formhalfWidth - label10_halfwidth;
            label10.Location = new Point(label10_halfwidth - 248, 100);
            //textbox email
            int textBox7_halfwidth = textBox7.Width / 2;
            textBox7_halfwidth = formhalfWidth - textBox7_halfwidth;
            textBox7.Location = new Point(textBox7_halfwidth - 175, 130);
            //submit button
            int button9_halfwidth = button9.Width / 2;
            button9_halfwidth = formhalfWidth - button9_halfwidth;
            button9.Location = new Point(button9_halfwidth - 170, 200);
            //email verification text label sent code
            int label6_halfwidth = label6.Width / 2;
            label6_halfwidth = formhalfWidth - label6_halfwidth;
            label6.Location = new Point(label6_halfwidth - 170, 300);
            //enter code
            int label12_halfwidth = label12.Width / 2;
            label12_halfwidth = formhalfWidth - label12_halfwidth;
            label12.Location = new Point(label12_halfwidth - 213, 350);
            //code textbox
            int textBox4_halfwidth = textBox4.Width / 2;
            textBox4_halfwidth = formhalfWidth - textBox4_halfwidth;
            textBox4.Location = new Point(textBox4_halfwidth - 166, 375);
            //verify button
            int button10_halfwidth = button10.Width / 2;
            button10_halfwidth = formhalfWidth - button10_halfwidth;
            button10.Location = new Point(button10_halfwidth - 160, 430);
            //Email ph no label
            int label16_halfwidth = label16.Width / 2;
            label16_halfwidth = formhalfWidth - label16_halfwidth;
            label16.Location = new Point(label16_halfwidth - 175, 30);
            //enter your ph no
            int label15_halfwidth = label15.Width / 2;
            label15_halfwidth = formhalfWidth - label15_halfwidth;
            label15.Location = new Point(label15_halfwidth - 248, 100);
            //textbox phone no
            int textBox9_halfwidth = textBox9.Width / 2;
            textBox9_halfwidth = formhalfWidth - textBox9_halfwidth;
            textBox9.Location = new Point(textBox9_halfwidth - 175, 130);
            //submit button
            int button12_halfwidth = button12.Width / 2;
            button12_halfwidth = formhalfWidth - button12_halfwidth;
            button12.Location = new Point(button12_halfwidth - 170, 200);
            //email verification text label sent code
            int label13_halfwidth = label13.Width / 2;
            label13_halfwidth = formhalfWidth - label13_halfwidth;
            label13.Location = new Point(label13_halfwidth - 170, 300);
            //enter code
            int label14_halfwidth = label14.Width / 2;
            label14_halfwidth = formhalfWidth - label14_halfwidth;
            label14.Location = new Point(label14_halfwidth - 213, 350);
            //code textbox
            int textBox8_halfwidth = textBox8.Width / 2;
            textBox8_halfwidth = formhalfWidth - textBox8_halfwidth;
            textBox8.Location = new Point(textBox8_halfwidth - 166, 375);
            //verify button
            int button11_halfwidth = button11.Width / 2;
            button11_halfwidth = formhalfWidth - button11_halfwidth;
            button11.Location = new Point(button11_halfwidth - 160, 430);
        }

        private void detail_Format(object sender, System.EventArgs eArgs)
        {

            this.textBoxCurPass.TextAlign = (HorizontalAlignment)VerticalAlignment.Center;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //dataGridView1.Visible = false;
            //groupBox6.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox2.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //dataGridView1.Visible = true;
            //groupBox6.Visible = true;
            groupBox5.Visible = false;
            groupBox3.Visible = false;
            groupBox2.Visible = false;
            groupBox4.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //dataGridView1.Visible = false;
            //groupBox6.Visible = false;
            groupBox5.Visible = false;
            groupBox3.Visible = false;
            groupBox2.Visible = false;
            groupBox4.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //dataGridView1.Visible = false;
            //groupBox6.Visible = false;
            groupBox5.Visible = false;
            groupBox2.Visible = false;
            groupBox4.Visible = false;
            groupBox3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //dataGridView1.Visible = false;
            //groupBox6.Visible = false;
            groupBox3.Visible = false;
            groupBox2.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label6.Visible = true;
            label12.Visible = true;
            textBox4.Visible = true;
            button10.Visible = true;
            String from, pass, messageBody;
            Random rand = new Random();
            randomCode = (rand.Next(999999)).ToString();
            MailMessage message = new MailMessage();
            to = (textBox7.Text).ToString();
            from = "moizulhaq331@gmail.com";
            pass = "ebkl ynre yogl vbbb";
            messageBody = "Thanks you for Joining Spark Vista Marketing. To activate your,please use the following verification code.\n Verification Code:" + randomCode;
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messageBody;
            message.Subject = "Email Verification Code";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);

            try
            {
                smtp.Send(message);
                MessageBox.Show("Verification Code Send Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            button9.Enabled = IsValidEmail(textBox7.Text);
        }

        private bool IsValidEmail(string email)
        {
            // Regular expression pattern for validating email addresses
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Check if the email matches the pattern and ends with "@gmail.com"
            return Regex.IsMatch(email, pattern) && email.EndsWith("@gmail.com", StringComparison.OrdinalIgnoreCase);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label13.Visible = true;
            label14.Visible = true;
            textBox8.Visible = true;
            button11.Visible = true;

            String from, pass, messageBody;
            Random rand = new Random();
            randomCode = (rand.Next(999999)).ToString();
            MailMessage message = new MailMessage();
            to = (Form1.instance.email).ToString();
            from = "moizulhaq331@gmail.com";
            pass = "ebkl ynre yogl vbbb";
            messageBody = "Thanks you for Joining Spark Vista Marketing. To activate your,please use the following verification code.\n Verification Code:" + randomCode;
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messageBody;
            message.Subject = "Email Verification Code";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);

            try
            {
                smtp.Send(message);
                MessageBox.Show("Verification Code Send Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            // Regular expression pattern for validating 11-digit phone numbers consisting of only numbers
            string pattern = @"^\d{11}$"; // Assuming an 11-digit phone number format

            // Check if the phone number matches the pattern
            return Regex.IsMatch(phoneNumber, pattern);
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            button12.Enabled = IsValidPhoneNumber(textBox9.Text);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string previouspage_roll;
            previouspage_roll = Form1.instance.roll;

            if (previouspage_roll == "Admin")
            {
                this.Hide();
                Admin_Dashboard admin = new Admin_Dashboard();
                admin.Show();
            }
            if (previouspage_roll == "Finance")
            {
                this.Hide();
                manager___finance_ admin = new manager___finance_();
                admin.Show();
            }
            if (previouspage_roll == "HR")
            {
                this.Hide();
                manager_HR admin = new manager_HR();
                admin.Show();
            }
            if (previouspage_roll == "IT")
            {
                this.Hide();
                maneger_IT admin = new maneger_IT();
                admin.Show();
            }
            if (previouspage_roll == "Employee")
            {
                this.Hide();
                Admin_Dashboard admin = new Admin_Dashboard();
                admin.Show();
            }
        }


        private void ChangePassword()
        {
            string oldPassword = textBoxCurPass.Text;
            string newPassword = textBoxNewPass.Text;
            string confirmNewPassword = textBoxConNewPass.Text;
            string personEmail = Form1.instance.email;
            if (newPassword != confirmNewPassword)
            {
                MessageBox.Show("New Password and Confirm Password do not match.");
                return;
            }

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();


                    string sql = "SELECT Password FROM signup WHERE Email = @email";
                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@email", personEmail);
                        object result = cmd.ExecuteScalar();

                        if (result == null)
                        {
                            MessageBox.Show("Email not found.");
                            return;
                        }

                        string storedPassword = result.ToString();

                        if (storedPassword == oldPassword)
                        {
                            UpdatePassword(personEmail, newPassword, con);
                            MessageBox.Show("Password changed successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Old password is incorrect.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void UpdatePassword(string email, string newPassword, MySqlConnection con)
        {
            string sql = "UPDATE signup SET Password = @NewPassword WHERE Email = @Email";
            using (MySqlCommand cmd = new MySqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@NewPassword", newPassword);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.ExecuteNonQuery();
            }
        }


        private void button7_Click(object sender, EventArgs e)
        {
            ChangePassword();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            ChangePhonenumber();
        }

        private void ChangePhonenumber()
        {
            string oldPhonenumber = textBox6.Text;
            string newPhonenumber = textBox5.Text;
            string personEmail = Form1.instance.email;

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();


                    string sql = "SELECT ContactNumber FROM employee WHERE Email = @email";
                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@email", personEmail);
                        object result = cmd.ExecuteScalar();

                        if (result == null)
                        {
                            MessageBox.Show("Email not found.");
                            return;
                        }

                        string storedPhonenumber = result.ToString();

                        if (storedPhonenumber == oldPhonenumber)
                        {
                            UpdatePhonenumber(personEmail, newPhonenumber, con);
                            MessageBox.Show("Phone Number changed successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Old Phone number is incorrect.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
        private void UpdatePhonenumber(string email, string newPhonenumber, MySqlConnection con)
        {
            string sql = "UPDATE employee SET ContactNumber = @NewPhonenumber WHERE Email = @Email";
            using (MySqlCommand cmd = new MySqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@NewPhonenumber", newPhonenumber);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.ExecuteNonQuery();
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (randomCode == (textBox4.Text).ToString())
            {
                to = textBox7.Text;
                Admin_Dashboard rp = new Admin_Dashboard();
                this.Hide();
                rp.Show();
            }
            else
            {
                MessageBox.Show("Wrong Code");
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (randomCode == (textBox8.Text).ToString())
            {
                to = Form1.instance.email;
                this.Hide();
                MessageBox.Show("Phone Number Verified Successfully!");
            }
            else
            {
                MessageBox.Show("Wrong Code");
            }

        }


        private string constring = "server=localhost;uid=root;pwd=remote1234;database=company";

        private void button6_Click(object sender, EventArgs e)
        {
            int EmployeeId = Form1.instance.empid;
            MessageBox.Show("Employee ID: " + EmployeeId);

            string sql = "UPDATE attendance SET AttendanceStatus = 'Absent' WHERE Employee_EmployeeId = @EmployeeId";

            using (MySqlConnection con = new MySqlConnection(constring))
            {
                con.Open();

                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@EmployeeId", EmployeeId); // Corrected parameter name

                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                        MessageBox.Show($"Updated {rowsAffected} rows in attendance table to 'Absent'.");
                    }
                    catch (Exception ex)
                    {
                        // Handle any exceptions
                    }

                }
            }
            Application.Exit();
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void Setting_Load(object sender, EventArgs e)
        {
            
        }
    }
}


  
