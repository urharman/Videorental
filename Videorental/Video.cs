using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Videorental
{
    public partial class Video : Form
    {
        public Video()
        {
            InitializeComponent();
        }

        private void btnMovies_Click(object sender, EventArgs e)
        {

        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {

        }

        private void circularButtons1_Click(object sender, EventArgs e)
        {

        }

        private void btnHistory_Click(object sender, EventArgs e)
        {

        }

        private void btnRented_Click(object sender, EventArgs e)
        {

        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {

        }
        // Customer Button atteched here axtention
        private void button1_Click(object sender, EventArgs e)
        {
            customers2 f2 = new customers2();
            f2.ShowDialog();
        }
        //Movies Button atteched here axtention
        private void btnMovies_Click_1(object sender, EventArgs e)
        {
            movies1 f2 = new movies1();
            f2.ShowDialog();
        }
        // Rented Button atteched here axtention
        private void btnRented_Click_1(object sender, EventArgs e)
        {
            Rented1 f2 = new Rented1();
            f2.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
