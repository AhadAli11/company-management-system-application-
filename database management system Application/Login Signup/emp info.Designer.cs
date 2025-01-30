namespace Login_Signup
{
    partial class emp_info
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
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label2 = new Label();
            button1 = new Button();
            pictureBox7 = new PictureBox();
            groupBox1 = new GroupBox();
            labelEmpId = new Label();
            label10 = new Label();
            labelAdd = new Label();
            labelGen = new Label();
            labelDOB = new Label();
            labelNum = new Label();
            labelCnic = new Label();
            labelName = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(500, 19);
            label1.Name = "label1";
            label1.Size = new Size(572, 102);
            label1.TabIndex = 0;
            label1.Text = "SPARK VISTA MARKETING \r\n MANAGEMENT SYSTEM";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ImageAlign = ContentAlignment.TopCenter;
            label2.Location = new Point(595, 134);
            label2.Name = "label2";
            label2.Size = new Size(401, 34);
            label2.TabIndex = 9;
            label2.Text = "Employees Personal Information";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(-1, 189);
            button1.Name = "button1";
            button1.Size = new Size(118, 39);
            button1.TabIndex = 40;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox7.BackColor = Color.Transparent;
            pictureBox7.BackgroundImage = Properties.Resources._FREE___HDconvert_com__WhatsApp_Image_2024_04_30_at_9_28_03_AM__2__removebg_preview;
            pictureBox7.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox7.Location = new Point(-1, 1);
            pictureBox7.Margin = new Padding(3, 4, 3, 4);
            pictureBox7.MaximumSize = new Size(400, 192);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(203, 167);
            pictureBox7.TabIndex = 41;
            pictureBox7.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = Color.SkyBlue;
            groupBox1.Controls.Add(labelEmpId);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(labelAdd);
            groupBox1.Controls.Add(labelGen);
            groupBox1.Controls.Add(labelDOB);
            groupBox1.Controls.Add(labelNum);
            groupBox1.Controls.Add(labelCnic);
            groupBox1.Controls.Add(labelName);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(-9, 234);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1541, 621);
            groupBox1.TabIndex = 43;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // labelEmpId
            // 
            labelEmpId.BackColor = Color.LightCyan;
            labelEmpId.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            labelEmpId.Location = new Point(904, 582);
            labelEmpId.Name = "labelEmpId";
            labelEmpId.Size = new Size(322, 53);
            labelEmpId.TabIndex = 13;
            labelEmpId.Text = "Address :";
            labelEmpId.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(612, 592);
            label10.Name = "label10";
            label10.Size = new Size(155, 25);
            label10.TabIndex = 12;
            label10.Text = "Employee ID :";
            // 
            // labelAdd
            // 
            labelAdd.BackColor = Color.LightCyan;
            labelAdd.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            labelAdd.Location = new Point(904, 500);
            labelAdd.Name = "labelAdd";
            labelAdd.Size = new Size(322, 53);
            labelAdd.TabIndex = 11;
            labelAdd.Text = "Address :";
            labelAdd.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelGen
            // 
            labelGen.BackColor = Color.LightCyan;
            labelGen.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            labelGen.Location = new Point(904, 434);
            labelGen.Name = "labelGen";
            labelGen.Size = new Size(322, 48);
            labelGen.TabIndex = 10;
            labelGen.Text = "Gender :";
            labelGen.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelDOB
            // 
            labelDOB.BackColor = Color.LightCyan;
            labelDOB.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            labelDOB.Location = new Point(904, 359);
            labelDOB.Name = "labelDOB";
            labelDOB.Size = new Size(322, 49);
            labelDOB.TabIndex = 9;
            labelDOB.Text = "Date Of Birth :";
            labelDOB.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelNum
            // 
            labelNum.BackColor = Color.LightCyan;
            labelNum.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            labelNum.Location = new Point(904, 289);
            labelNum.Name = "labelNum";
            labelNum.Size = new Size(322, 49);
            labelNum.TabIndex = 8;
            labelNum.Text = "Phone Number :";
            labelNum.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelCnic
            // 
            labelCnic.BackColor = Color.LightCyan;
            labelCnic.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            labelCnic.Location = new Point(904, 219);
            labelCnic.Name = "labelCnic";
            labelCnic.Size = new Size(322, 43);
            labelCnic.TabIndex = 7;
            labelCnic.Text = "CNIC :";
            labelCnic.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelName
            // 
            labelName.BackColor = Color.LightCyan;
            labelName.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            labelName.Location = new Point(904, 150);
            labelName.Name = "labelName";
            labelName.Size = new Size(322, 42);
            labelName.TabIndex = 6;
            labelName.Text = "Full Name :";
            labelName.TextAlign = ContentAlignment.MiddleCenter;
            labelName.Click += labelName_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(612, 510);
            label8.Name = "label8";
            label8.Size = new Size(107, 25);
            label8.TabIndex = 5;
            label8.Text = "Address :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(612, 441);
            label7.Name = "label7";
            label7.Size = new Size(102, 25);
            label7.TabIndex = 4;
            label7.Text = "Gender :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(612, 368);
            label6.Name = "label6";
            label6.Size = new Size(164, 25);
            label6.TabIndex = 3;
            label6.Text = "Date Of Birth :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(612, 294);
            label5.Name = "label5";
            label5.Size = new Size(179, 25);
            label5.TabIndex = 2;
            label5.Text = "Phone Number :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(612, 226);
            label4.Name = "label4";
            label4.Size = new Size(86, 25);
            label4.TabIndex = 1;
            label4.Text = "CNIC :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(612, 150);
            label3.Name = "label3";
            label3.Size = new Size(129, 25);
            label3.TabIndex = 0;
            label3.Text = "Full Name :";
            // 
            // emp_info
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1522, 858);
            ControlBox = false;
            Controls.Add(groupBox1);
            Controls.Add(pictureBox7);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "emp_info";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += emp_info_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label2;
        private Button button1;
        private PictureBox pictureBox7;
        private GroupBox groupBox1;
        private Label labelEmpId;
        private Label label10;
        private Label labelAdd;
        private Label labelGen;
        private Label labelDOB;
        private Label labelNum;
        private Label labelCnic;
        private Label labelName;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}
