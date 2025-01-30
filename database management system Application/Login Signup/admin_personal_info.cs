using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Login_Signup
{
    public partial class Admin_personal_info
        : Form
    {
        MySqlDataAdapter adpt;
        DataTable dt;
        public Admin_personal_info()
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
            Admin_Dashboard open = new Admin_Dashboard();
            open.Show();
        }

        private void Admin_personal_info_Load(object sender, EventArgs e)
        {
            string email = "moizulhaq331@gmail.com";
            string constring = "server=localhost;uid=root;pwd=remote1234;database=company";
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                try
                {
                    string query = "SELECT personalinformation.Name,\r\n       personalinformation.CNIC,\r\n       employee.ContactNumber,\r\n       personalinformation.DOB,\r\n       personalinformation.Sex,\r\n       personalinformation.Address,\r\n       employee.EmployeeId\r\nFROM personalinformation\r\nINNER JOIN employee ON personalinformation.Employee_EmployeeId = employee.EmployeeId\r\nWHERE employee.Email = 'moizulhaq331@gmail.com';"; // Adjust the query as needed
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    con.Open();
                    MySqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        labelName.Text = dr["Name"].ToString(); // Assuming the label is named labelName
                        labelCnic.Text = dr["CNIC"].ToString();
                        labelNum.Text = dr["ContactNumber"].ToString();
                        labelDOB.Text = dr["DOB"].ToString();
                        labelGen.Text = dr["Sex"].ToString();
                        labelAdd.Text = dr["Address"].ToString();
                        labelEmpId.Text = dr["EmployeeId"].ToString();
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
