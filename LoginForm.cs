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

    public partial class LoginForm : Form
    {
        private readonly string conString;
        private readonly MovieManager movieManager;
        public LoginForm(string conString)
        {
            InitializeComponent();
            this.conString = conString;
            movieManager = new MovieManager();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if (LoginUser(username, password))
            {
                movieManager.ShowForm1();
                this.Hide();  
            }
            else
            {
                MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SignupForm signupForm = new SignupForm(conString);
            signupForm.ShowDialog();
        }
        public bool LoginUser(string username, string password)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(conString))
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND Password = @Password";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        int count = (int)command.ExecuteScalar();

                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during login: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }
    }


}
