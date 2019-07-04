namespace Videorental
{
    partial class UpdateMovies
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MovieID = new System.Windows.Forms.Label();
            this.Rating = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.Year = new System.Windows.Forms.Label();
            this.Rental_Cost = new System.Windows.Forms.Label();
            this.textMovieID = new System.Windows.Forms.TextBox();
            this.textRating = new System.Windows.Forms.TextBox();
            this.textTitle = new System.Windows.Forms.TextBox();
            this.textYear = new System.Windows.Forms.TextBox();
            this.textCopies = new System.Windows.Forms.TextBox();
            this.textPlot = new System.Windows.Forms.TextBox();
            this.textGenre = new System.Windows.Forms.TextBox();
            this.Copies = new System.Windows.Forms.Label();
            this.Plot = new System.Windows.Forms.Label();
            this.Genre = new System.Windows.Forms.Label();
            this.textRantal_Cost = new System.Windows.Forms.TextBox();
            this.btnUpdateMovie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MovieID
            // 
            this.MovieID.AutoSize = true;
            this.MovieID.Location = new System.Drawing.Point(48, 59);
            this.MovieID.Name = "MovieID";
            this.MovieID.Size = new System.Drawing.Size(50, 13);
            this.MovieID.TabIndex = 0;
            this.MovieID.Text = "Movie ID";
            // 
            // Rating
            // 
            this.Rating.AutoSize = true;
            this.Rating.Location = new System.Drawing.Point(221, 59);
            this.Rating.Name = "Rating";
            this.Rating.Size = new System.Drawing.Size(38, 13);
            this.Rating.TabIndex = 0;
            this.Rating.Text = "Rating";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(347, 59);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(27, 13);
            this.Title.TabIndex = 0;
            this.Title.Text = "Title";
            // 
            // Year
            // 
            this.Year.AutoSize = true;
            this.Year.Location = new System.Drawing.Point(489, 59);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(29, 13);
            this.Year.TabIndex = 0;
            this.Year.Text = "Year";
            this.Year.Click += new System.EventHandler(this.label4_Click);
            // 
            // Rental_Cost
            // 
            this.Rental_Cost.AutoSize = true;
            this.Rental_Cost.Location = new System.Drawing.Point(630, 59);
            this.Rental_Cost.Name = "Rental_Cost";
            this.Rental_Cost.Size = new System.Drawing.Size(62, 13);
            this.Rental_Cost.TabIndex = 0;
            this.Rental_Cost.Text = "Rental Cost";
            // 
            // textMovieID
            // 
            this.textMovieID.Location = new System.Drawing.Point(36, 95);
            this.textMovieID.Name = "textMovieID";
            this.textMovieID.Size = new System.Drawing.Size(100, 20);
            this.textMovieID.TabIndex = 1;
            this.textMovieID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textRating
            // 
            this.textRating.Location = new System.Drawing.Point(184, 95);
            this.textRating.Name = "textRating";
            this.textRating.Size = new System.Drawing.Size(100, 20);
            this.textRating.TabIndex = 1;
            this.textRating.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textTitle
            // 
            this.textTitle.Location = new System.Drawing.Point(339, 95);
            this.textTitle.Name = "textTitle";
            this.textTitle.Size = new System.Drawing.Size(100, 20);
            this.textTitle.TabIndex = 1;
            this.textTitle.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textYear
            // 
            this.textYear.Location = new System.Drawing.Point(467, 95);
            this.textYear.Name = "textYear";
            this.textYear.Size = new System.Drawing.Size(100, 20);
            this.textYear.TabIndex = 1;
            this.textYear.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textCopies
            // 
            this.textCopies.Location = new System.Drawing.Point(36, 164);
            this.textCopies.Name = "textCopies";
            this.textCopies.Size = new System.Drawing.Size(100, 20);
            this.textCopies.TabIndex = 1;
            this.textCopies.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textPlot
            // 
            this.textPlot.Location = new System.Drawing.Point(184, 164);
            this.textPlot.Name = "textPlot";
            this.textPlot.Size = new System.Drawing.Size(100, 20);
            this.textPlot.TabIndex = 1;
            this.textPlot.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textGenre
            // 
            this.textGenre.Location = new System.Drawing.Point(339, 164);
            this.textGenre.Name = "textGenre";
            this.textGenre.Size = new System.Drawing.Size(100, 20);
            this.textGenre.TabIndex = 1;
            this.textGenre.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Copies
            // 
            this.Copies.AutoSize = true;
            this.Copies.Location = new System.Drawing.Point(48, 130);
            this.Copies.Name = "Copies";
            this.Copies.Size = new System.Drawing.Size(39, 13);
            this.Copies.TabIndex = 0;
            this.Copies.Text = "Copies";
            // 
            // Plot
            // 
            this.Plot.AutoSize = true;
            this.Plot.Location = new System.Drawing.Point(221, 130);
            this.Plot.Name = "Plot";
            this.Plot.Size = new System.Drawing.Size(25, 13);
            this.Plot.TabIndex = 0;
            this.Plot.Text = "Plot";
            // 
            // Genre
            // 
            this.Genre.AutoSize = true;
            this.Genre.Location = new System.Drawing.Point(341, 130);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(36, 13);
            this.Genre.TabIndex = 0;
            this.Genre.Text = "Genre";
            this.Genre.Click += new System.EventHandler(this.label8_Click);
            // 
            // textRantal_Cost
            // 
            this.textRantal_Cost.Location = new System.Drawing.Point(599, 95);
            this.textRantal_Cost.Name = "textRantal_Cost";
            this.textRantal_Cost.Size = new System.Drawing.Size(100, 20);
            this.textRantal_Cost.TabIndex = 1;
            this.textRantal_Cost.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // btnUpdateMovie
            // 
            this.btnUpdateMovie.Location = new System.Drawing.Point(208, 238);
            this.btnUpdateMovie.Name = "btnUpdateMovie";
            this.btnUpdateMovie.Size = new System.Drawing.Size(283, 84);
            this.btnUpdateMovie.TabIndex = 2;
            this.btnUpdateMovie.Text = "Update Movie";
            this.btnUpdateMovie.UseVisualStyleBackColor = true;
            this.btnUpdateMovie.Click += new System.EventHandler(this.btnUpdateMovie_Click);
            // 
            // UpdateMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdateMovie);
            this.Controls.Add(this.textRantal_Cost);
            this.Controls.Add(this.textGenre);
            this.Controls.Add(this.textYear);
            this.Controls.Add(this.textPlot);
            this.Controls.Add(this.textTitle);
            this.Controls.Add(this.textCopies);
            this.Controls.Add(this.textRating);
            this.Controls.Add(this.textMovieID);
            this.Controls.Add(this.Rental_Cost);
            this.Controls.Add(this.Genre);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.Plot);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Copies);
            this.Controls.Add(this.Rating);
            this.Controls.Add(this.MovieID);
            this.Name = "UpdateMovies";
            this.Text = "UpdateMovies";
            this.Load += new System.EventHandler(this.UpdateMovies_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MovieID;
        private System.Windows.Forms.Label Rating;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Year;
        private System.Windows.Forms.Label Rental_Cost;
        private System.Windows.Forms.TextBox textMovieID;
        private System.Windows.Forms.TextBox textRating;
        private System.Windows.Forms.TextBox textTitle;
        private System.Windows.Forms.TextBox textYear;
        private System.Windows.Forms.TextBox textCopies;
        private System.Windows.Forms.TextBox textPlot;
        private System.Windows.Forms.TextBox textGenre;
        private System.Windows.Forms.Label Copies;
        private System.Windows.Forms.Label Plot;
        private System.Windows.Forms.Label Genre;
        private System.Windows.Forms.TextBox textRantal_Cost;
        private System.Windows.Forms.Button btnUpdateMovie;
    }
}