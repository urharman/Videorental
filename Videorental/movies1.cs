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
    public partial class movies1 : Form

    {
        public movies1()
        {
            InitializeComponent();
        }
        private SqlConnection connection = new SqlConnection();

        //We need a connection to the Database


       SqlConnection Con = new SqlConnection();
      string connection_String = @"Data Source=DESKTOP-U551NOV\SQLEXPRESS;Initial Catalog=Movie;Integrated Security=True";
       //Connection.Connection String = ConnectionString;
      DataTable Add_movies = new DataTable();
       

      //  private void btnUpdate_Click(object sender, EventArgs e)
       // {
       //     UpdateMovies f2 = new UpdateMovies();
       //     f2.ShowDialog();/
       // }

       // private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
       // {

       // }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void movies1_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear(); //clear out old data in the listbox, we will need this later
                                     //load the connection string and pass it to the command
            string connectionString = @"Data Source=DESKTOP-U551NOV\SQLEXPRESS;Initial Catalog=Movie;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string queryString = "SELECT * FROM Movies ORDER by MovieID";
                //read in the data with a datareader open the data connection
                SqlCommand Command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                while (reader.Read())
                {
                    //add each row to the listbox
                    ListViewItem item = new ListViewItem(new[] {
reader["MovieID"].ToString(), reader["Rating"].ToString(),
reader["Title"].ToString(), reader["Year"].ToString(),
reader["Rental_Cost"].ToString(), reader["Copies"].ToString(),reader["Plot"].ToString(),reader["Genre"].ToString(),
 });
                    listView1.Items.Add(item);
                }
                reader.Close();
            }
        }

        private void textDelete_TextChanged(object sender, EventArgs e)
        {

        }

        private void textAdd_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textNew_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPrevious_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Movies_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            // this puts the parameters into the code so that the data in the text boxes is added to the database
            string NewEntry = "INSERT INTO Movies (Rating, Title, Year, Rental_Cost, Copies, Plot, Genre) VALUES( @Rating, @Title, @Year, @Rental_Cost, @Copies, @Plot, @Genre)";
            SqlConnection Con = new SqlConnection();
                string connectionString = @"Data Source=DESKTOP-U551NOV\SQLEXPRESS;Initial Catalog=Movie;Integrated Security=True";
            Con.ConnectionString = connectionString;
            using (SqlCommand newdata = new SqlCommand(NewEntry, Con))
            {

                newdata.Parameters.AddWithValue("@Rating", TextRating.Text);
                newdata.Parameters.AddWithValue("@Title", TextTitle.Text);
                newdata.Parameters.AddWithValue("@Year", textYear.Text);
                newdata.Parameters.AddWithValue("@Rental_Cost", textRental_Cost.Text);
                newdata.Parameters.AddWithValue("@Copies", textCopies.Text);
                newdata.Parameters.AddWithValue("@Plot", textPlot.Text);
                newdata.Parameters.AddWithValue("@Genre", textGenre.Text);

                Con.Open(); //open a connection to the database
                            //its a NONQuery as it doesn't return any data its only going up to the server
                newdata.ExecuteNonQuery(); //Run the Query
                Con.Close();

                MessageBox.Show("Data has been Inserted !! ");

                //Run the LoadDatabase method we made earler to see the new data.
                loadDatabase();
            }
        }

        public void loadDatabase()
        {
            listView1.Items.Clear();

           
        }

        private void btnDeletes_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection();
            string connectionString = @"Data Source=DESKTOP-U551NOV\SQLEXPRESS;Initial Catalog=Movie;Integrated Security=True";
            Con.ConnectionString = connectionString;
            string DeleteCommand = "Delete Movies where MovieID=@MovieID";

            SqlCommand DeleteData = new SqlCommand(DeleteCommand, Con);
            DeleteData.Parameters.AddWithValue("@MovieID", textMovieID.Text);

            Con.Open();
            DeleteData.ExecuteNonQuery();
            Con.Close();
            //This message is show that Movie is Deleted
            MessageBox.Show("Movie is Deleted from List");
            loadDatabase();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // this puts the parameters into the code so that the data in the text boxes is added to the database
            string updatestatement = "UPDATE Movies set  Rating=@Rating, Title=@Title, Year=@Year, Rental_Cost=@Rental_Cost, Copies=@Copies, Plot=@Plot, Genre=@Genre where MovieID=@MovieID";
            SqlConnection Con = new SqlConnection();
            string connectionString = @"Data Source=DESKTOP-U551NOV\SQLEXPRESS;Initial Catalog=Movie;Integrated Security=True";
            Con.ConnectionString = connectionString;

            using (SqlCommand update = new SqlCommand(updatestatement, Con))
            {
                update.Parameters.AddWithValue("MovieID", textMovieID.Text);
                update.Parameters.AddWithValue("@Rating", TextRating.Text);
                update.Parameters.AddWithValue("@Title", TextTitle.Text);
                update.Parameters.AddWithValue("@Year", textYear.Text);
                update.Parameters.AddWithValue("@Rental_Cost", textRental_Cost.Text);
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
                loadDatabase();
            }
            //Run the LoadDatabase method we made earler to see the new data.

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textMovieID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIssue_Click(object sender, EventArgs e)
        {

        }
    }
    }



    

