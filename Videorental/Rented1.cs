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
    public partial class Rented1 : Form
    {
        public Rented1()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection();
        string connection_String = @"Data Source=DESKTOP-U551NOV\SQLEXPRESS;Initial Catalog=Movie;Integrated Security=True";
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        public void loadDatabase()
        {
            listView1.Items.Clear();


        }

        private void Rented1_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear(); //clear out old data in the listbox, we will need this later
                                     //load the connection string and pass it to the command
            string connectionString = @"Data Source=DESKTOP-U551NOV\SQLEXPRESS;Initial Catalog=Movie;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string queryString = "SELECT * FROM RentedMovies ORDER by CustIDFK";
                //read in the data with a datareader open the data connection
                SqlCommand Command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                while (reader.Read())
                {
                    //add each row to the listbox
                    ListViewItem item = new ListViewItem(new[] {
reader["RMID"].ToString(), reader["MovieIDFK"].ToString(),
reader["CustIDFK"].ToString(), reader["DateRented"].ToString(),
reader["DateReturned"].ToString()
 });
                    listView1.Items.Add(item);
                }
                reader.Close();

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            // this puts the parameters into the code so that the data in the text boxes is added to the database
            string NewEntry = "INSERT INTO RentedMovies (MovieIDFK, CustIDFK, DateRented, DateReturned) VALUES ( @Movie, @Customer, @DateIssue, @DateRented)";
            SqlConnection Con = new SqlConnection();
            string connectionString = @"Data Source=DESKTOP-U551NOV\SQLEXPRESS;Initial Catalog=Movie;Integrated Security=True";
            Con.ConnectionString = connectionString;
            using (SqlCommand newdata = new SqlCommand(NewEntry, Con)) 
            {

                newdata.Parameters.AddWithValue("@Movie", textMovie.Text);
                newdata.Parameters.AddWithValue("@Customer", textCustomer.Text);
                newdata.Parameters.AddWithValue("@DateIssue", textDateIssue.Text);
                newdata.Parameters.AddWithValue("@DateRented", textReturnDate.Text);

                Con.Open(); //open a connection to the database
                            //its a NONQuery as it doesn't return any data its only going up to the server
                newdata.ExecuteNonQuery(); //Run the Query
                Con.Close();

                MessageBox.Show("Data has been Inserted !! ");

                //Run the LoadDatabase method we made earler to see the new data.
                loadDatabase();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // this puts the parameters into the code so that the data in the text boxes is added to the database
            string updatestatement = "UPDATE RentedMovies set  MovieIDFK=@MovieIDFK, CustIDFK=@CustIDFK, DateRented=@DateIssue, DateReturned=@DateReturned where RMID=@RMID ";
            SqlConnection Con = new SqlConnection();
            string connectionString = @"Data Source=DESKTOP-U551NOV\SQLEXPRESS;Initial Catalog=Movie;Integrated Security=True";
            Con.ConnectionString = connectionString;

            using (SqlCommand update = new SqlCommand(updatestatement, Con))
            {
                update.Parameters.AddWithValue("RMID", textRMID.Text);
                update.Parameters.AddWithValue("@MovieIDFK", textMovie.Text);
                update.Parameters.AddWithValue("@CustIDFK", textCustomer.Text);
                update.Parameters.AddWithValue("@DateIssue", textDateIssue.Text);
                update.Parameters.AddWithValue("@DateReturned", textReturnDate.Text);
              

                Con.Open();
                //open a connection to the database
                //its a NONQuery as it doesn't return any data its only going up to the 
                update.ExecuteNonQuery();
                Con.Close();
                //Run the Query
                //a happy message box
                MessageBox.Show("Movie Returned have been Submitted");
                loadDatabase();
            }
            //Run the LoadDatabase method we made earler to see the new data.

        }
    }
    }
    
