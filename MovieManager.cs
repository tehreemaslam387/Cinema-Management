using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema_Management
{
    public class MovieManager
    {
        private List<Movies.Movie> moviesList;
        private readonly string conString;

        public MovieManager()
        {
            conString = @"Data Source=DESKTOP-NFCDOBH\SQLEXPRESS;Initial Catalog=cinema management;Integrated Security=True;Connect Timeout=30";
            moviesList = new List<Movies.Movie>();
        }

        public void ShowMoviesForm()
        {
            using (Movies moviesForm = new Movies(moviesList, conString))
            {
                moviesForm.ShowDialog();
            }
        }

        public void ShowForm1()
        {
            using (Form1 form1 = new Form1())
            {
                form1.ShowDialog();
            }
        }
        
        public void ShowAddMovieForm()
        {
            using (AddMovie addMovieForm = new AddMovie(moviesList, conString))
            {
                addMovieForm.ShowDialog();
            }
        }

        public void ShowDeleteMovieForm()
        {
            using (DeleteMovie deleteMovieForm = new DeleteMovie(moviesList, conString))
            {
                deleteMovieForm.ShowDialog();
            }
        }

        public void ShowBookNowForm()
        {
            using (BookNow bookNowForm = new BookNow(moviesList, conString))
            {
                bookNowForm.ShowDialog();
            }
        }
    }
}
