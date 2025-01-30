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
    public partial class Delete_Project_Admin_ : Form
    {
        private string connectionString = "server=localhost;uid=root;pwd=remote1234;database=company";

        public Delete_Project_Admin_()
        {
            InitializeComponent();
        }

        private void Delete_Project_Admin__Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int empId))
            {
                DeleteProjectInfo(empId);
            }
            else
            {
                MessageBox.Show("Please enter a valid Project ID.");
            }


            this.Close();
            Admin_project_Info emp = new Admin_project_Info();
            emp.Show();
        }
        private void DeleteProjectInfo(int projId)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    string sql = @"
            UPDATE employee
            SET Project_idProject = NULL
            WHERE Project_idProject = @projid";

                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@projid", projId);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Employee Project reference was deleted successfully.", "Deleting Project", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("No matching records found to delete in employee.", "Deleting Project", MessageBoxButtons.OK);
                        }
                    }

                    // Delete the project record
                    string sql1 = @"
            DELETE FROM project 
            WHERE idProject = @projid";

                    using (MySqlCommand cmd1 = new MySqlCommand(sql1, con))
                    {
                        cmd1.Parameters.AddWithValue("@projid", projId);
                        int rowsAffected1 = cmd1.ExecuteNonQuery();

                        if (rowsAffected1 > 0)
                        {
                            MessageBox.Show("Project was deleted successfully.", "Deleting Project", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("No matching records found to delete in project.", "Deleting Project", MessageBoxButtons.OK);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Admin_project_Info emp = new Admin_project_Info();
            emp.Show();
        }   
    }
}
