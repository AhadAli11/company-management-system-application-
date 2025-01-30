namespace Login_Signup
{
    partial class Teams
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teams));
            panel1 = new Panel();
            button3 = new Button();
            label1 = new Label();
            panel3 = new Panel();
            panel6 = new Panel();
            slidepic = new PictureBox();
            panel5 = new Panel();
            panel4 = new Panel();
            button2 = new Button();
            panel2 = new Panel();
            button1 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)slidepic).BeginInit();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button3);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(937, 80);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button3
            // 
            button3.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(816, 38);
            button3.Name = "button3";
            button3.Size = new Size(118, 39);
            button3.TabIndex = 41;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(409, 12);
            label1.Name = "label1";
            label1.Size = new Size(152, 53);
            label1.TabIndex = 0;
            label1.Text = "Teams";
            // 
            // panel3
            // 
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(panel2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 80);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(937, 597);
            panel3.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.Controls.Add(slidepic);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(54, 0);
            panel6.Margin = new Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(832, 533);
            panel6.TabIndex = 3;
            // 
            // slidepic
            // 
            slidepic.Dock = DockStyle.Fill;
            slidepic.Image = (Image)resources.GetObject("slidepic.Image");
            slidepic.Location = new Point(0, 0);
            slidepic.Margin = new Padding(3, 4, 3, 4);
            slidepic.Name = "slidepic";
            slidepic.Size = new Size(832, 533);
            slidepic.SizeMode = PictureBoxSizeMode.Zoom;
            slidepic.TabIndex = 0;
            slidepic.TabStop = false;
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(54, 533);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(832, 64);
            panel5.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Controls.Add(button2);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(886, 0);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(51, 597);
            panel4.TabIndex = 1;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            button2.BackColor = Color.Transparent;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Candara Light", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(0, 0);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(51, 533);
            button2.TabIndex = 0;
            button2.Text = ">";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(54, 597);
            panel2.TabIndex = 0;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            button1.BackColor = Color.Transparent;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Candara Light", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(0, 0);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(54, 533);
            button1.TabIndex = 0;
            button1.Text = "<";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 2500;
            timer1.Tick += timer1_Tick;
            // 
            // Teams
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 677);
            ControlBox = false;
            Controls.Add(panel3);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Teams";
            Text = "Teams";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)slidepic).EndInit();
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel6;
        private PictureBox slidepic;
        private Panel panel5;
        private Panel panel4;
        private Panel panel2;
        private Label label1;
        private Button button1;
        private Button button2;
        private System.Windows.Forms.Timer timer1;
        private Button button3;
    }
}