namespace Login_Signup
{
    partial class Resource_Info
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
            radioButtonName = new RadioButton();
            radioButtonID = new RadioButton();
            button1 = new Button();
            textBox1 = new TextBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(616, 171);
            label5.Name = "label5";
            label5.Size = new Size(302, 35);
            label5.TabIndex = 28;
            label5.Text = "Resources Information";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox7
            // 
            pictureBox7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox7.BackColor = Color.Transparent;
            pictureBox7.BackgroundImage = Properties.Resources._FREE___HDconvert_com__WhatsApp_Image_2024_04_30_at_9_28_03_AM__2__removebg_preview;
            pictureBox7.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox7.Location = new Point(0, 3);
            pictureBox7.Margin = new Padding(3, 4, 3, 4);
            pictureBox7.MaximumSize = new Size(400, 192);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(231, 192);
            pictureBox7.TabIndex = 30;
            pictureBox7.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(399, 11);
            label1.Name = "label1";
            label1.Size = new Size(763, 136);
            label1.TabIndex = 29;
            label1.Text = "SPARK VISTA MARKETING\r\n MANAGEMENT SYSTEM";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 314);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1358, 433);
            dataGridView1.TabIndex = 31;
            // 
            // radioButtonName
            // 
            radioButtonName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            radioButtonName.AutoSize = true;
            radioButtonName.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButtonName.Location = new Point(1149, 280);
            radioButtonName.Name = "radioButtonName";
            radioButtonName.Size = new Size(110, 27);
            radioButtonName.TabIndex = 36;
            radioButtonName.TabStop = true;
            radioButtonName.Text = "BY Name";
            radioButtonName.UseVisualStyleBackColor = true;
            // 
            // radioButtonID
            // 
            radioButtonID.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            radioButtonID.AutoSize = true;
            radioButtonID.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioButtonID.Location = new Point(1012, 281);
            radioButtonID.Name = "radioButtonID";
            radioButtonID.Size = new Size(82, 27);
            radioButtonID.TabIndex = 35;
            radioButtonID.TabStop = true;
            radioButtonID.Text = "BY ID";
            radioButtonID.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(1281, 230);
            button1.Name = "button1";
            button1.Size = new Size(90, 45);
            button1.TabIndex = 34;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(1011, 230);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(274, 45);
            textBox1.TabIndex = 33;
            textBox1.Text = "Search Resources";
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(11, 236);
            button2.Name = "button2";
            button2.Size = new Size(118, 39);
            button2.TabIndex = 37;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Resource_Info
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(button2);
            Controls.Add(radioButtonName);
            Controls.Add(radioButtonID);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            Controls.Add(pictureBox7);
            Controls.Add(label1);
            Name = "Resource_Info";
            Text = "Resource_Info";
            WindowState = FormWindowState.Maximized;
            Load += Resource_Info_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private PictureBox pictureBox7;
        private Label label1;
        private DataGridView dataGridView1;
        private RadioButton radioButtonName;
        private RadioButton radioButtonID;
        private Button button1;
        private TextBox textBox1;
        private Button button2;
    }
}