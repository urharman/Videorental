using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Videorental
{
    public partial class UpdateMovies : Form
    {
        public UpdateMovies()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateMovie_Click(object sender, EventArgs e)
        {
            // this puts the parameters into the code so that the data in the text boxes is added to the database
            string updatestatement = "UPDATE Movies set movies=@MovieID, Rating=@Rating, Title=@Title, Year=@Year, Renatl_Cost=@Rental_Cost, Copies=@Copies, Plot=@Plot, Genre@Genre)";
 SqlConnection Con = new SqlConnection();
            string connectionString = @"Data Source=DESKTOP-U551NOV\SQLEXPRESS;Initial Catalog=Movie;Integrated Security=True";
            Con.ConnectionString = connectionString;

            using (SqlCommand update = new SqlCommand(updatestatement, Con))
            {
                update.Parameters.AddWithValue("@MovieID", textMovieID.Text);
                update.Parameters.AddWithValue("@Rating", textRating.Text);
                update.Parameters.AddWithValue("@Title", textTitle.Text);
                update.Parameters.AddWithValue("@Year", textYear.Text);
                update.Parameters.AddWithValue("@Rental_Cost", textRantal_Cost.Text);
                update.Parameters.AddWithValue("@Copies", textCopies.Text);
                update.Parameters.AddWithValue("@Plot", textPlot.Text);
                update.Parameters.AddWithValue("@Genre", textGenre.Text);

                Con.Open(); 
                //open a connection to the database
                            //its a NONQuery as it doesn't return any data its only going up to the 
                update.ExecuteNonQuery();
                Con.Close();
                //Run the Query
                                           //a happy message box
                MessageBox.Show("Data Has Been Updated Thankss");
            }
            //Run the LoadDatabase method we made earler to see the new data.
            
        }

        private void UpdateMovies_Load(object sender, EventArgs e)
        {

        }
    }
}
    
