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
    public partial class customers2 : Form

    {

        public customers2()

        {

            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection();
            string connectionString = @"Data Source=DESKTOP-U551NOV\SQLEXPRESS;Initial Catalog=Movie;Integrated Security=True";
            Con.ConnectionString = connectionString;
            string DeleteCommand = "Delete Customer Where CustID=@CustID";

            SqlCommand DeleteData = new SqlCommand(DeleteCommand, Con);
            DeleteData.Parameters.AddWithValue("@CustID", text1.Text);

            Con.Open();
            DeleteData.ExecuteNonQuery();
            Con.Close();
            MessageBox.Show("Data has been Removed From The List");
            loadDatabase();
        }

       // private void btnAddcustomer_Click(object sender, EventArgs e)
        //{
           // AddCustomer f2 = new AddCustomer();
            //f2.ShowDialog();
        //}

        //private void btnRemovecustomers_Click(object sender, EventArgs e)
        //{
          //  UpdateCustomer f2 = new UpdateCustomer();
            //f2.ShowDialog();
        //}

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void customers2_Load(object sender, EventArgs e)
        {
            listview11111.Items.Clear(); //clear out old data in the listbox, we will need this later
                                     //load the connection string and pass it to the command
            string connectionString = @"Data Source=DESKTOP-U551NOV\SQLEXPRESS;Initial Catalog=Movie;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string queryString = "SELECT * FROM Movies ORDER by CustID";
                //read in the data with a datareader open the data connection
                SqlCommand Command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataReader reader = Command.ExecuteReader();
                while (reader.Read())
                {
                    //add each row to the listbox
                    ListViewItem item = new ListViewItem(new[] {
reader["CustID"].ToString(), reader["FirstName"].ToString(),
reader["LastName"].ToString(), reader["Address"].ToString(),
reader["Phone"].ToString(),
 });
                    listview11111.Items.Add(item);
                }
                reader.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.customerTableAdapter.FillBy(this.movieDataSet.Customer);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }
        public void loadDatabase()
        {
             listview11111.Items.Clear();


        }

        private void btnAddcustomer_Click(object sender, EventArgs e)
        {
            listview11111.Items.Clear();
            // this puts the parameters into the code so that the data in the text boxes is added to the database
            string NewEntry = "INSERT INTO Customer (FirstName, LastName, Address, Phone) VALUES( @FirstName, @LastName, @Address, @Phone)";
            SqlConnection Con = new SqlConnection();
            string connectionString = @"Data Source=DESKTOP-U551NOV\SQLEXPRESS;Initial Catalog=Movie;Integrated Security=True";
            Con.ConnectionString = connectionString;
            using (SqlCommand newdata = new SqlCommand(NewEntry, Con))
            {

                newdata.Parameters.AddWithValue("@FirstName", text2.Text);
                newdata.Parameters.AddWithValue("@LastName", text3.Text);
                newdata.Parameters.AddWithValue("@Address", text4.Text);
                newdata.Parameters.AddWithValue("@Phone", text5.Text);


                Con.Open(); //open a connection to the database
                            //its a NONQuery as it doesn't return any data its only going up to the server
                newdata.ExecuteNonQuery(); //Run the Query
                Con.Close();

                MessageBox.Show("Data has been Inserted !! ");

                //Run the LoadDatabase method we made earler to see the new data.
                loadDatabase();
            }
        }

        private void btnUpdateCostumer_Click(object sender, EventArgs e)
        {
            // this puts the parameters into the code so that the data in the text boxes is added to the database
            string updatestatement = "UPDATE Customer set  FirstName=@FirstName, LastName=@LastName, Address=@Address, Phone=@Phone Where CustID=@CustID";
            SqlConnection Con = new SqlConnection();
            string connectionString = @"Data Source=DESKTOP-U551NOV\SQLEXPRESS;Initial Catalog=Movie;Integrated Security=True";
            Con.ConnectionString = connectionString;

            using (SqlCommand update = new SqlCommand(updatestatement, Con))
            {
                update.Parameters.AddWithValue("@CustID", text1.Text);
                update.Parameters.AddWithValue("@FirstName", text2.Text);
                update.Parameters.AddWithValue("@LastName", text3.Text);
                update.Parameters.AddWithValue("@Address", text4.Text);
                update.Parameters.AddWithValue("@Phone", text5.Text);


                Con.Open();
                //open a connection to the database
                //its a NONQuery as it doesn't return any data its only going up to the 
                update.ExecuteNonQuery();
                Con.Close();
                //Run the Query
                //a happy message box
                MessageBox.Show("Data Has Been Updated Thankss");

                //Run the LoadDatabase method we made earler to see the new data.
                //Run the LoadDatabase method we made earler to see the new data.
                loadDatabase();

            }
        }
    }
}
        

