namespace Login_Signup
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            textBoxEmail = new TextBox();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            textBoxPass = new TextBox();
            panel2 = new Panel();
            label1 = new Label();
            checkBox1 = new CheckBox();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.dd;
            pictureBox1.Location = new Point(91, 497);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(211, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // textBoxEmail
            // 
            textBoxEmail.BackColor = SystemColors.ButtonFace;
            textBoxEmail.BorderStyle = BorderStyle.None;
            textBoxEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxEmail.ForeColor = SystemColors.MenuText;
            textBoxEmail.Location = new Point(91, 261);
            textBoxEmail.Margin = new Padding(3, 4, 3, 4);
            textBoxEmail.Multiline = true;
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(274, 41);
            textBoxEmail.TabIndex = 1;
            textBoxEmail.Text = "Email Address";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(49, 301);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(317, 5);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.noun_login_801390_removebg_preview;
            pictureBox2.Location = new Point(49, 256);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(35, 45);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.Password_removebg_preview;
            pictureBox3.Location = new Point(49, 363);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(35, 36);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // textBoxPass
            // 
            textBoxPass.BackColor = SystemColors.ButtonFace;
            textBoxPass.BorderStyle = BorderStyle.None;
            textBoxPass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPass.ForeColor = SystemColors.MenuText;
            textBoxPass.Location = new Point(90, 363);
            textBoxPass.Margin = new Padding(3, 4, 3, 4);
            textBoxPass.Multiline = true;
            textBoxPass.Name = "textBoxPass";
            textBoxPass.Size = new Size(274, 41);
            textBoxPass.TabIndex = 5;
            textBoxPass.Text = "Password";
            textBoxPass.TextChanged += textBox2_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(49, 407);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(317, 5);
            panel2.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI Semibold", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(142, 159);
            label1.Name = "label1";
            label1.Size = new Size(145, 62);
            label1.TabIndex = 7;
            label1.Text = "Login";
            label1.Click += label1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Cursor = Cursors.Hand;
            checkBox1.Location = new Point(49, 433);
            checkBox1.Margin = new Padding(3, 4, 3, 4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(129, 24);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Remember me";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(62, 25);
            label5.Name = "label5";
            label5.Size = new Size(338, 124);
            label5.TabIndex = 12;
            label5.Text = "Welcome Back\r\n\r\n";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(97, 93);
            label6.Name = "label6";
            label6.Size = new Size(229, 41);
            label6.TabIndex = 13;
            label6.Text = "to Sparks Vista!";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 721);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(checkBox1);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(textBoxPass);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Controls.Add(textBoxEmail);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBoxEmail;
        private Panel panel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private TextBox textBoxPass;
        private Panel panel2;
        private Label label1;
        private CheckBox checkBox1;
        private Label label5;
        private Label label6;
    }
}
