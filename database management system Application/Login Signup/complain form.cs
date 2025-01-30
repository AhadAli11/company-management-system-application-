using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Diagnostics;
namespace Login_Signup
{
    public partial class complain_form : Form
    {
        String randomCode;
        public static String to;
        public complain_form()
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

            //button location

            int button1_halfwidth = button1.Width / 2;
            button1_halfwidth = formhalfWidth - button1_halfwidth;
            button1.Location = new Point(button1_halfwidth, textBox1.Location.Y + textBox1.Height + 20);



            pictureBox7.Location = new Point(-100, 6);


        }
        private void complain_form_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Employee_Dashboard open = new Employee_Dashboard();
            open.Show();
        }
        //rvha urhj fpbj kkwz

        private void button1_Click(object sender, EventArgs e)
        {
            String from, pass, messageBody;
            Random rand = new Random();
            randomCode = (rand.Next(999999)).ToString();
            MailMessage message = new MailMessage();
            to = ("ahadali111366@gmail.com").ToString();
            from = "khizarqureshi5170@gmail.com";
            pass = "rvha urhj fpbj kkwz";
            messageBody = textBox1.Text;
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messageBody;
            message.Subject = "Complain";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);

            try
            {
                smtp.Send(message);
                MessageBox.Show("Complain Email has sent successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
       /* private void SendEmail(string recipientEmail, string subject, string body)
        {
            try
            {
                // SMTP server configuration
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587)
                {
                    Credentials = new NetworkCredential(Form1.instance.email, Form1.instance.password),
                    EnableSsl = true
                };

                // Creating the email message
                MailMessage mailMessage = new MailMessage
                {
                    From = new MailAddress(Form1.instance.email),
                    Subject = subject,
                    Body = body,
                    IsBodyHtml = true // Set to true if the email body is HTML
                };

                // Adding recipient
                mailMessage.To.Add(recipientEmail);

                // Sending the email
                smtpClient.Send(mailMessage);

                MessageBox.Show("Email sent successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while sending the email: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }*/
            
    }

