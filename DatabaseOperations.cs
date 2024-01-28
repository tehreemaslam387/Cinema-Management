using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static Cinema_Management.Movies;

namespace Cinema_Management
{


    public static class DatabaseOperations
    {
        public static void FetchMoviesFromDatabase(List<Movies.Movie> moviesList, string conString, DataGridView dataGridView1)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(conString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Movie";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);
                            dataGridView1.DataSource = dataTable;


                            foreach (DataRow row in dataTable.Rows)
                            {
                                Movie movie = new Movie
                                {
                                    Title = row["Title"].ToString(),
                                    Genre = row["Genre"].ToString(),
                                    ReleaseDate = Convert.ToDateTime(row["ReleaseDate"]),
                                    Timing = Convert.ToDateTime(row["Timing"]),
                                    PricePerTicket = Convert.ToDecimal(row["PricePerTicket"])
                                };
                                moviesList.Add(movie);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching movies from the database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
    
}

