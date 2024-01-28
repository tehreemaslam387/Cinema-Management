
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static Cinema_Management.Movies;

namespace Cinema_Management
{
    public partial class DeleteMovie : Form
    {
        public Movie DeletedMovie { get; private set; }
        private List<Movies.Movie> moviesList;
        private readonly string conString;
        

        public DeleteMovie(List<Movies.Movie> moviesList, string conString)
        {
            InitializeComponent();
            this.moviesList = moviesList;
            this.conString = conString;
            FetchMoviesFromDatabase();
        }
        private void FetchMoviesFromDatabase()
        {
            DatabaseOperations.FetchMoviesFromDatabase(moviesList, conString, dataGridView1);
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
           
            for (int i = dataGridView1.Rows.Count - 1; i >= 0; i--)
            {
                DataGridViewRow row = dataGridView1.Rows[i];

                
                DataGridViewCheckBoxCell checkBoxCell = row.Cells["Column1"] as DataGridViewCheckBoxCell;
                if (checkBoxCell != null && Convert.ToBoolean(checkBoxCell.Value))
                {
                    
                    string titleToDelete = row.Cells["Title"].Value.ToString();

                    DeleteRowFromDatabase(titleToDelete);

                    dataGridView1.Rows.RemoveAt(i);
                }
            }

            
            dataGridView1.Refresh();
        }

        private void DeleteRowFromDatabase(string title)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(conString))
                {
                    connection.Open();
                    string query = "DELETE FROM Movie WHERE Title = @Title";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("@Title", SqlDbType.NVarChar)).Value = title;
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting row from database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

