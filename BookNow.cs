using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static Cinema_Management.Movies;

namespace Cinema_Management
{
    public partial class BookNow : Form
    {
        private readonly List<Movie> moviesList;
        private readonly string conString;
        private Movie selectedMovie;

        public BookNow(List<Movie> moviesList, string conString)
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

            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Please enter customer name and number of tickets.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            selectedMovie = GetSelectedMovie();
            if (selectedMovie == null)
            {
                MessageBox.Show("Please select a movie.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string customerName = textBox1.Text;
            int numberOfTickets;

            if (!int.TryParse(textBox2.Text, out numberOfTickets) || numberOfTickets <= 0)
            {
                MessageBox.Show("Please enter a valid number of tickets.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            decimal totalPrice = CalculateTotalPrice(numberOfTickets, selectedMovie);


            InsertBooking(customerName, numberOfTickets, totalPrice);


            ShowReceipt(customerName, totalPrice);
        }

        private Movie GetSelectedMovie()
        {

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataGridViewCheckBoxCell checkBoxCell = row.Cells["Column1"] as DataGridViewCheckBoxCell;
                if (checkBoxCell != null && Convert.ToBoolean(checkBoxCell.Value))
                {

                    string title = row.Cells["Title"].Value.ToString();
                    string genre = row.Cells["Genre"].Value.ToString();
                    decimal pricePerTicket;


                    if (dataGridView1.Columns.Contains("PricePerTicket"))
                    {

                        if (decimal.TryParse(row.Cells["PricePerTicket"].Value.ToString(), out pricePerTicket))
                        {

                            return new Movie { Title = title, Genre = genre, PricePerTicket = pricePerTicket /* Add other properties */ };
                        }
                    }


                }
            }

            return null;
        }

        private decimal CalculateTotalPrice(int numberOfTickets, Movie movie)
        {

            if (movie != null)
            {
                decimal pricePerTicket = movie.PricePerTicket;
                return numberOfTickets * pricePerTicket;
            }

            return 0;
        }
        private void InsertBooking(string customerName, int numberOfTickets, decimal totalPrice)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(conString))
                {
                    connection.Open();
                    string query = "INSERT INTO Customer (MovieTitle, CustomerName, NumberOfTickets, TotalPrice) " +
                                   "VALUES (@MovieTitle, @CustomerName, @NumberOfTickets, @TotalPrice)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MovieTitle", selectedMovie.Title);
                        command.Parameters.AddWithValue("@CustomerName", customerName);
                        command.Parameters.AddWithValue("@NumberOfTickets", numberOfTickets);
                        command.Parameters.AddWithValue("@TotalPrice", totalPrice);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inserting booking into the database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowReceipt(string customerName, decimal totalPrice)
        {
            string receiptMessage = $" '{selectedMovie.Title}' is booked for {customerName}. " +
                                    $"Amount: {totalPrice:C}";

            MessageBox.Show(receiptMessage, "Booking Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
