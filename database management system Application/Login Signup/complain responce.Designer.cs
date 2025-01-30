namespace Login_Signup
{
    partial class complain_responce
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label5 = new Label();
            pictureBox7 = new PictureBox();
            label1 = new Label();
            button2 = new Button();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(662, 158);
            label5.Name = "label5";
            label5.Size = new Size(151, 35);
            label5.TabIndex = 24;
            label5.Text = "Complains";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox7
            // 
            pictureBox7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox7.BackColor = Color.Transparent;
            pictureBox7.BackgroundImage = Properties.Resources._FREE___HDconvert_com__WhatsApp_Image_2024_04_30_at_9_28_03_AM__2__removebg_preview;
            pictureBox7.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox7.Location = new Point(1, 1);
            pictureBox7.Margin = new Padding(3, 4, 3, 4);
            pictureBox7.MaximumSize = new Size(400, 192);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(231, 192);
            pictureBox7.TabIndex = 26;
            pictureBox7.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(400, 9);
            label1.Name = "label1";
            label1.Size = new Size(763, 136);
            label1.TabIndex = 25;
            label1.Text = "SPARK VISTA MARKETING\r\n MANAGEMENT SYSTEM";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(12, 231);
            button2.Name = "button2";
            button2.Size = new Size(118, 39);
            button2.TabIndex = 40;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(563, 260);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(368, 169);
            linkLabel1.TabIndex = 41;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Open Gmail";
            linkLabel1.TextAlign = ContentAlignment.MiddleCenter;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // complain_responce
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1472, 738);
            ControlBox = false;
            Controls.Add(linkLabel1);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(pictureBox7);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "complain_responce";
            Text = "complain_responce";
            WindowState = FormWindowState.Maximized;
            Load += complain_responce_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private PictureBox pictureBox7;
        private Label label1;
        private Button button2;
        private LinkLabel linkLabel1;
    }
}