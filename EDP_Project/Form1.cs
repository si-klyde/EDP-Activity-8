using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace EDP_Project
{
    public partial class login_form : Form
    {
        private string connectionString = "server=localhost;database=database_edp;uid=root;pwd=1052";
        public login_form()
        {
            InitializeComponent();
        }

        private void sign_in_btn_Click(object sender, EventArgs e)
        {
            string empId = id_text.Text;
            string empKey = key_text.Text;

            if (string.IsNullOrEmpty(empId) || string.IsNullOrEmpty(empKey))
            {
                MessageBox.Show("Please enter both employee ID and key.");
                return;
            }

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Query to check if the employee ID and key exist in the database
                    string query = "SELECT COUNT(*) FROM employees WHERE emp_id = @empId AND emp_key = @empKey";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@empId", empId);
                    command.Parameters.AddWithValue("@empKey", empKey);

                    // Execute the query
                    int count = Convert.ToInt32(command.ExecuteScalar());

                    // If count is greater than 0, login is successful
                    if (count > 0)
                    {
                        MessageBox.Show("Login successful!");
                        // Add code here to navigate to the next form or perform any actions after successful login
                        this.Hide();
                        var form = new reg_form();
                        this.Closed += (s, args) => this.Close();
                        form.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid employee ID or key.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
