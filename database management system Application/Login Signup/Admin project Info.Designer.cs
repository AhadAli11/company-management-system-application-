namespace Login_Signup
{
    partial class Admin_project_Info
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            textBox1 = new TextBox();
            button2 = new Button();
            groupBox1 = new GroupBox();
            Duration = new Label();
            Budget = new Label();
            ProjectID = new Label();
            ProjectName = new Label();
            label6 = new Label();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(646, 156);
            label5.Name = "label5";
            label5.Size = new Size(266, 35);
            label5.TabIndex = 16;
            label5.Text = "Project Information";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox7
            // 
            pictureBox7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox7.BackColor = Color.Transparent;
            pictureBox7.BackgroundImage = Properties.Resources._FREE___HDconvert_com__WhatsApp_Image_2024_04_30_at_9_28_03_AM__2__removebg_preview;
            pictureBox7.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox7.Location = new Point(-1, -1);
            pictureBox7.Margin = new Padding(3, 4, 3, 4);
            pictureBox7.MaximumSize = new Size(400, 192);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(231, 192);
            pictureBox7.TabIndex = 18;
            pictureBox7.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(398, 7);
            label1.Name = "label1";
            label1.Size = new Size(763, 136);
            label1.TabIndex = 17;
            label1.Text = "SPARK VISTA MARKETING\r\n MANAGEMENT SYSTEM";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-1, 313);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1533, 420);
            dataGridView1.TabIndex = 19;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(1442, 206);
            button1.Name = "button1";
            button1.Size = new Size(90, 45);
            button1.TabIndex = 23;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(1172, 206);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(274, 45);
            textBox1.TabIndex = 22;
            textBox1.Text = "Search Projects";
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(12, 241);
            button2.Name = "button2";
            button2.Size = new Size(118, 39);
            button2.TabIndex = 40;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = Color.SkyBlue;
            groupBox1.Controls.Add(Duration);
            groupBox1.Controls.Add(Budget);
            groupBox1.Controls.Add(ProjectID);
            groupBox1.Controls.Add(ProjectName);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(12, 209);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1484, 515);
            groupBox1.TabIndex = 46;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // Duration
            // 
            Duration.BackColor = Color.LightCyan;
            Duration.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            Duration.Location = new Point(904, 438);
            Duration.Name = "Duration";
            Duration.Size = new Size(237, 49);
            Duration.TabIndex = 9;
            Duration.Text = "Duration";
            Duration.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Budget
            // 
            Budget.BackColor = Color.LightCyan;
            Budget.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            Budget.Location = new Point(904, 338);
            Budget.Name = "Budget";
            Budget.Size = new Size(237, 49);
            Budget.TabIndex = 8;
            Budget.Text = "Budget";
            Budget.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ProjectID
            // 
            ProjectID.BackColor = Color.LightCyan;
            ProjectID.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            ProjectID.Location = new Point(904, 249);
            ProjectID.Name = "ProjectID";
            ProjectID.Size = new Size(237, 43);
            ProjectID.TabIndex = 7;
            ProjectID.Text = "Project Id:";
            ProjectID.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ProjectName
            // 
            ProjectName.BackColor = Color.LightCyan;
            ProjectName.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            ProjectName.Location = new Point(904, 166);
            ProjectName.Name = "ProjectName";
            ProjectName.Size = new Size(237, 43);
            ProjectName.TabIndex = 6;
            ProjectName.Text = "Project Name:";
            ProjectName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(613, 450);
            label6.Name = "label6";
            label6.Size = new Size(110, 25);
            label6.TabIndex = 3;
            label6.Text = "Duration:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(613, 350);
            label2.Name = "label2";
            label2.Size = new Size(93, 25);
            label2.TabIndex = 2;
            label2.Text = "Budget:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(613, 258);
            label4.Name = "label4";
            label4.Size = new Size(122, 25);
            label4.TabIndex = 1;
            label4.Text = "Project Id:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(613, 175);
            label3.Name = "label3";
            label3.Size = new Size(159, 25);
            label3.TabIndex = 0;
            label3.Text = "Project Name:";
            // 
            // Admin_project_Info
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1534, 745);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            Controls.Add(pictureBox7);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Admin_project_Info";
            Text = "Admin_project_Info";
            WindowState = FormWindowState.Maximized;
            Load += Admin_project_Info_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private PictureBox pictureBox7;
        private Label label1;
        private DataGridView dataGridView1;
        private Button button1;
        private TextBox textBox1;
        private Button button2;
        private GroupBox groupBox1;
        private Label Duration;
        private Label Budget;
        private Label ProjectID;
        private Label ProjectName;
        private Label label6;
        private Label label2;
        private Label label4;
        private Label label3;
    }
}