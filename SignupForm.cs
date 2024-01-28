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

namespace Cinema_Management
{
    public partial class SignupForm : Form
    {
        private readonly string conString;

        public SignupForm(string conString)
        {
            InitializeComponent();
            this.conString = conString;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if (CreateUser(username, password))
            {
                MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error creating account. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CreateUser(string username, string password)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(conString))
                {
                    connection.Open();
                    string query = "INSERT INTO Users (Username, Password) VALUES (@Username, @Password)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        int rowsAffected = command.ExecuteNonQuery();

                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void SignupForm_Load(object sender, EventArgs e)
        {

        }
    }
}
