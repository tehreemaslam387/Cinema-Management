using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using System.Data.SqlClient;
using static Cinema_Management.Movies;



namespace Cinema_Management
{
   
    public partial class Form1 : Form
    {
        public MovieManager movieManager;
       

        public Form1()
        {
            InitializeComponent();
     
            movieManager = new MovieManager();
           
        }

        public void button1_Click(object sender, EventArgs e)
        {
            
            movieManager.ShowMoviesForm();
        }

       public void button2_Click(object sender, EventArgs e)
        {
            movieManager.ShowAddMovieForm();
        }

       public void button3_Click(object sender, EventArgs e)
        {
            movieManager.ShowDeleteMovieForm();
        }

       public void button4_Click(object sender, EventArgs e)
        {
            movieManager.ShowBookNowForm();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
