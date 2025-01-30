using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Encoders;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Login_Signup
{
    public partial class emp_info
        : Form
    {
        public emp_info()
        {
            InitializeComponent();
            this.Resize += Form1_Resize;
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
            Size size = this.Size;
            int formhalfWidth = size.Width / 2;
            int label1_halfwidth = label1.Width / 2;
            label1_halfwidth = formhalfWidth - label1_halfwidth;
            label1.Location = new Point(label1_halfwidth, 0);
            int label2_halfwidth = label2.Width / 2;
            label2_halfwidth = formhalfWidth - label2_halfwidth;
            label2.Location = new Point(label2_halfwidth, label1.Height + 10);


        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Employee_Dashboard open = new Employee_Dashboard();
            open.Show();
        }

        private void emp_info_Load(object sender, EventArgs e)
        {
            int eee;
            eee = Form1.instance.id;
            try
            {
                string constring = "server=localhost;uid=root;pwd=remote1234;database=company";

                using (MySqlConnection con = new MySqlConnection(constring))
                {
                    string query = "SELECT employee.Name, CNIC, employee.ContactNumber, DOB, Sex, Address, Employee_EmployeeId FROM personalinformation JOIN employee ON personalinformation.Employee_EmployeeId = employee.EmployeeId WHERE employee.EmployeeId = @EmployeeId";

                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@EmployeeId", eee); // Use @EmployeeId as parameter name

                    con.Open();
                    MySqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        labelName.Text = dr["Name"].ToString();
                        labelCnic.Text = dr["CNIC"].ToString();
                        labelNum.Text = dr["ContactNumber"].ToString();
                        labelDOB.Text = dr["DOB"].ToString();
                        labelGen.Text = dr["Sex"].ToString();
                        labelAdd.Text = dr["Address"].ToString();
                        labelEmpId.Text = dr["Employee_EmployeeId"].ToString();
                    }
                    else
                    {
                        // No data found for the provided EmployeeId
                        MessageBox.Show("No data found for the provided EmployeeId.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
            private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }
    }
}
