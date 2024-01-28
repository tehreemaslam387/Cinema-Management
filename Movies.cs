
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Cinema_Management
{
    public partial class Movies : Form
    {
        private List<Movies.Movie> moviesList;
        private readonly string conString;
        
        public Movies(List<Movies.Movie> moviesList, string conString)
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
        

        public class Movie
        {
            public string Title { get; set; }
            public string Genre { get; set; }
            public DateTime ReleaseDate { get; set; }
            public DateTime Timing { get; set; }
            public decimal PricePerTicket { get; set; }  

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}