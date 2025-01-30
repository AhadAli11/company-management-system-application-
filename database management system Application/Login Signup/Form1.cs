using MySql.Data.MySqlClient;
using Mysqlx.Session;

namespace Login_Signup
{
    public partial class Form1 : Form
    {
        public static Form1 instance;
        public string email, password;
        public int empid,id;
        public string roll;
        public Form1()
        {

            InitializeComponent();
            instance = this;
            textBoxPass.Text = "Password";
            textBoxEmail.Text = "Email";
            textBoxPass.PasswordChar = '\0';
            textBoxPass.GotFocus += new EventHandler(textBox2_GotFocus);
            //to close the application if this form is closed
            this.FormClosing += (sender, e) =>
            {
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    Application.Exit();
                }
            };
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            string empEmail = textBoxEmail.Text.ToString();
            string empPass = textBoxPass.Text.ToString();

            if (String.IsNullOrEmpty(empEmail) || String.IsNullOrEmpty(empPass))
            {
                MessageBox.Show("No empty fields are allowed!!!");
                return;
            }

            string constring = "server=localhost;uid=root;pwd=remote1234;database=company";
            using (MySqlConnection con = new MySqlConnection(constring))
            {
                try
                {
                    con.Open();
                    string sql = "SELECT signup.Password FROM employee INNER JOIN signup ON employee.Email = signup.Email WHERE employee.Email = @Email";
                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@Email", empEmail);

                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            email = empEmail;
                            password = empPass;
                            string storedPassword = result.ToString();
                            if (empPass == storedPassword)
                            {
                                string sql2 = "SELECT employee.Role FROM employee INNER JOIN signup ON employee.Email = signup.Email WHERE employee.Email = @Email";

                                using (MySqlCommand cmd2 = new MySqlCommand(sql2, con))
                                {
                                    string check_result = null;
                                    // check ager attandance phalay sy mark ha 
                                    try
                                    {
                                        string check_attandance = "select AttendanceStatus from attendance join employee on employee.EmployeeId= attendance.Employee_EmployeeId where employee.Email=@Email";

                                        using (MySqlCommand check = new MySqlCommand(check_attandance, con))
                                        {
                                            check.Parameters.AddWithValue("@Email", empEmail);
                                            object check_result2 = check.ExecuteScalar();

                                            check_result = check_result2.ToString();

                                        }
                                        if (check_result == "Absent")
                                        {

                                            string sqlemp_id2 = "SELECT EmployeeId FROM employee WHERE Email=@email";
                                            // Using block ensures disposal of MySqlCommand object after its use
                                            using (MySqlCommand emp2 = new MySqlCommand(sqlemp_id2, con))
                                            {
                                                string empEmail12 = empEmail; // Provide the employee's email address here


                                                // Add parameter for the email address
                                                emp2.Parameters.AddWithValue("@Email", empEmail12);
                                               

                                                try
                                                {

                                                    // Execute the query and retrieve the EmployeeId
                                                    object result12 = emp2.ExecuteScalar();
                                                    DateOnly date22 = DateOnly.FromDateTime(DateTime.Now); // Get the current date
                                                    TimeOnly time22 = TimeOnly.FromDateTime(DateTime.Now); // Get the current time

                                                    string temp2;
                                                    temp2 = result12.ToString(); // Convert result to string
                                                    empid = int.Parse(temp2);
                                                    int EmployeeId = int.Parse(temp2);

                                                    //string sql10 = "UPDATE attendance SET AttendanceStatus = 'Present' WHERE Employee_EmployeeId = @EmployeeId";
                                                    string sql10 = "UPDATE attendance SET TimeIn='" + time22 + "',Date='" + date22 + "',AttendanceStatus = 'Present' WHERE Employee_EmployeeId = @EmployeeId";

                                                    using (MySqlConnection con33 = new MySqlConnection(constring))
                                                    {
                                                        con33.Open();

                                                        using (MySqlCommand cmd33 = new MySqlCommand(sql10, con33))
                                                        {

                                                            cmd.Parameters.AddWithValue("@time22", time22);
                                                            cmd.Parameters.AddWithValue("@date22", date22);
                                                            cmd33.Parameters.AddWithValue("@EmployeeId", EmployeeId); // Assuming 'employeeId' is defined elsewhere


                                                            try
                                                            {
                                                                int rowsAffected = cmd33.ExecuteNonQuery();
                                                                MessageBox.Show("Your attendence is updated");
                                                            }
                                                            catch (Exception ex)
                                                            {
                                                            }

                                                        }

                                                    }
                                                }
                                                catch
                                                {

                                                }

                                            }
                                        }
                                    }
                                    catch
                                    {


                                        {
                                            DateOnly date = DateOnly.FromDateTime(DateTime.Now); // Get the current date
                                            TimeOnly time = TimeOnly.FromDateTime(DateTime.Now); // Get the current time
                                            string empEmail1 = empEmail; // Provide the employee's email address here
                                            int employeeId;
                                            string temp;
                                            string attendanceStatus = "Present"; // Assuming the attendance status is "Present"

                                            // SQL query to retrieve EmployeeId based on email
                                            string sqlemp_id = "SELECT EmployeeId FROM employee WHERE Email=@email";
                                           
                                            // Using block ensures disposal of MySqlCommand object after its use
                                            using (MySqlCommand emp = new MySqlCommand(sqlemp_id, con))
                                            {
                                                // Add parameter for the email address
                                                emp.Parameters.AddWithValue("@Email", empEmail1);

                                                

                                                try
                                                {

                                                    // Execute the query and retrieve the EmployeeId
                                                    object result1 = emp.ExecuteScalar();

                                                    // Check if the result is not null and convert it to int
                                                    if (result1 != null)
                                                    {
                                                        temp = result1.ToString(); // Convert result to string
                                                        empid = int.Parse(temp);
                                                        // Convert the retrieved EmployeeId to an integer
                                                        if (int.TryParse(temp, out employeeId))
                                                        {
                                                        }

                                                    }
                                                    else
                                                    {
                                                        return; // Exit the method if no EmployeeId is found
                                                    }
                                                }
                                                catch (Exception ex)
                                                {
                                                    return; // Exit the method in case of an error
                                                }
                                            }

                                            // SQL query to insert attendance record with parameters
                                            string query = "INSERT INTO attendance (Date, AttendanceStatus, TimeIn, Employee_EmployeeId) VALUES (@Date, @AttendanceStatus, @TimeIn, @EmployeeId)";

                                            // Using block ensures disposal of MySqlConnection and MySqlCommand objects after their use
                                            using (MySqlConnection connection = new MySqlConnection(constring))
                                            {
                                                MySqlCommand command = new MySqlCommand(query, connection);

                                                // Add parameters and their values
                                                command.Parameters.AddWithValue("@Date", date);
                                                command.Parameters.AddWithValue("@AttendanceStatus", attendanceStatus);
                                                command.Parameters.AddWithValue("@TimeIn", time);
                                                command.Parameters.AddWithValue("@EmployeeId", employeeId);
                                                



                                                try
                                                {
                                                    // Open the connection
                                                    connection.Open();

                                                    // Execute the query
                                                    int rowsAffected = command.ExecuteNonQuery();

                                                    // Inform the user of the result
                                                    MessageBox.Show($"Attendance record inserted successfully. Rows affected: {rowsAffected}");
                                                }
                                                catch (Exception ex)
                                                {
                                                    // Handle any errors
                                                    MessageBox.Show("An error occurred while inserting attendance record: " + ex.Message);
                                                }
                                            }
                                        }

                                    }







                                    cmd2.Parameters.AddWithValue("@Email", empEmail);
                                    object result2 = cmd2.ExecuteScalar();

                                    if (result2 != null)
                                    {
                                        string storedRole = result2.ToString();
                                        roll = storedRole;


                                        if (storedRole == "Admin")
                                        {
                                            this.Visible = false;
                                            Admin_Dashboard admin_Dashboard = new Admin_Dashboard();
                                            admin_Dashboard.Show();
                                        }
                                        else if (storedRole == "Finance")
                                        {
                                            this.Visible = false;
                                            manager___finance_ manager = new manager___finance_();
                                            manager.Show();
                                        }
                                        else if (storedRole == "IT")
                                        {
                                            this.Visible = false;
                                            maneger_IT maneger_IT = new maneger_IT();
                                            maneger_IT.Show();
                                        }
                                        else if (storedRole == "HR")
                                        {
                                            this.Visible = false;
                                            manager_HR manegar_HR = new manager_HR();
                                            manegar_HR.Show();
                                        }
                                        else if (storedRole == "Employee")
                                        {
                                            string sqlemp_id2 = "SELECT EmployeeId FROM employee WHERE Email=@email";
                                            // Using block ensures disposal of MySqlCommand object after its use
                                            using (MySqlCommand emp2 = new MySqlCommand(sqlemp_id2, con))
                                            {
                                                string empEmail12 = empEmail; // Provide the employee's email address here


                                                // Add parameter for the email address
                                                emp2.Parameters.AddWithValue("@Email", empEmail12);
                                                using (MySqlDataReader dr = emp2.ExecuteReader())
                                                {
                                                    if (dr.Read())
                                                    {
                                                        int employeeId0 = dr.GetInt32("EmployeeId");
                                                        id = employeeId0;
                                                    }
                                                   
                                                }


                                            }

                                            this.Visible = false;
                                            Employee_Dashboard manegar_HR = new Employee_Dashboard();
                                            manegar_HR.Show();
                                        }
                                        else
                                        {
                                            MessageBox.Show("You do not have the required role to access this dashboard.");
                                        }
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid email or password. ");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid email or password. ");
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void textBox2_GotFocus(object sender, EventArgs e)
        {
            if (textBoxPass.Text == "Password")
            {
                textBoxPass.Text = "";
                textBoxPass.PasswordChar = '*';
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
