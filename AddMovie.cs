
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
    public partial class AddMovie : Form
    {
        private readonly List<Movies.Movie> moviesList;
        private readonly string conString;

        public string Title { get; private set; }
        public string Genre { get; private set; }
        public DateTime ReleaseDate { get; private set; }
        public DateTime Timings { get; private set; }
        public Decimal PricePerTicket { get; private set; }
        public Movies.Movie NewMovie { get; private set; }

        public AddMovie(List<Movies.Movie> moviesList, string conString)
        {
            InitializeComponent();
            this.moviesList = moviesList;
            this.conString = conString;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Title = textBox1.Text;
            Genre = textBox2.Text;

            if (Decimal.TryParse(textBox5.Text, out Decimal pricePerTicket))
                PricePerTicket = pricePerTicket;
            else
            {
                MessageBox.Show("Invalid PricePerTicket format. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (DateTime.TryParse(textBox3.Text, out DateTime releaseDate))
                ReleaseDate = releaseDate;
            else
            {
                MessageBox.Show("Invalid Release Date format. Please enter a valid date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (DateTime.TryParse(textBox4.Text, out DateTime timings))
                Timings = timings;
            else
            {
                MessageBox.Show("Invalid Timings format. Please enter a valid time.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            NewMovie = new Movies.Movie
            {
                Title = Title,
                Genre = Genre,
                ReleaseDate = ReleaseDate,
                Timing = Timings,
                PricePerTicket = PricePerTicket,


            };

            SaveMovieToDatabase(NewMovie);


            MessageBox.Show("Movie is added.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void SaveMovieToDatabase(Movies.Movie movie)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(conString))
                {
                    connection.Open();
                    string query = "INSERT INTO Movie (Title, Genre, ReleaseDate, Timing, PricePerTicket) " +
                                   "VALUES (@Title, @Genre, @ReleaseDate, @Timing, @PricePerTicket)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Title", movie.Title);
                        command.Parameters.AddWithValue("@Genre", movie.Genre);
                        command.Parameters.AddWithValue("@ReleaseDate", movie.ReleaseDate);
                        command.Parameters.AddWithValue("@Timing", movie.Timing);
                        command.Parameters.AddWithValue("@PricePerTicket", movie.PricePerTicket);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving movie to database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
