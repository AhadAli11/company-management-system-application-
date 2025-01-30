

namespace Login_Signup
{
    partial class Finance_Montly_Budget
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
            dataGridView1 = new DataGridView();
            pictureBox7 = new PictureBox();
            label1 = new Label();
            label5 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 288);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1530, 454);
            dataGridView1.TabIndex = 37;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // pictureBox7
            // 
            pictureBox7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox7.BackColor = Color.Transparent;
            pictureBox7.BackgroundImage = Properties.Resources._FREE___HDconvert_com__WhatsApp_Image_2024_04_30_at_9_28_03_AM__2__removebg_preview;
            pictureBox7.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox7.Location = new Point(0, 0);
            pictureBox7.Margin = new Padding(3, 4, 3, 4);
            pictureBox7.MaximumSize = new Size(400, 192);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(231, 192);
            pictureBox7.TabIndex = 36;
            pictureBox7.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(399, 8);
            label1.Name = "label1";
            label1.Size = new Size(763, 136);
            label1.TabIndex = 35;
            label1.Text = "SPARK VISTA MARKETING\r\n MANAGEMENT SYSTEM";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(640, 157);
            label5.Name = "label5";
            label5.Size = new Size(303, 35);
            label5.TabIndex = 38;
            label5.Text = "Montly Budget Report";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 201);
            button1.Name = "button1";
            button1.Size = new Size(118, 39);
            button1.TabIndex = 39;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Finance_Montly_Budget
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1534, 743);
            ControlBox = false;
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox7);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Finance_Montly_Budget";
            Text = "Finance_Montly_Budget";
            WindowState = FormWindowState.Maximized;
            Load += Finance_Montly_Budget_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private PictureBox pictureBox7;
        private Label label1;
        private Label label5;
        private Button button1;
    }
}