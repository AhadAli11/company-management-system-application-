using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Signup
{
    public partial class Delete_emp_admin_ : Form
    {
        private string connectionString = "server=localhost;uid=root;pwd=remote1234;database=company";

        public Delete_emp_admin_()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Admin_Employee_Info emp = new Admin_Employee_Info();
            emp.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (int.TryParse(textBox1.Text, out int empId))
            {
                DeleteEmployeeAndPersonalInfo(empId);
            }
            else
            {
                MessageBox.Show("Please enter a valid employee ID.");
            }


            this.Close();
            Admin_Employee_Info emp = new Admin_Employee_Info();
            emp.Show();
        }

        private void DeleteEmployeeAndPersonalInfo(int empId)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    string sql = @"
                        DELETE employee, personalinformation
                        FROM employee
                        INNER JOIN personalinformation ON employee.EmployeeId = personalinformation.Employee_EmployeeId
                        WHERE employee.EmployeeId = @empid;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@empid", empId);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Employee was deleted successfully.", "Deleting Employee", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("No matching records found to delete.", "Deleting Employee", MessageBoxButtons.OK);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void Delete_emp_admin__Load(object sender, EventArgs e)
        {

        }
    }
}
