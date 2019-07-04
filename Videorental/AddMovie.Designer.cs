namespace Videorental
{
    partial class AddMovie
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
            this.textID = new System.Windows.Forms.TextBox();
            this.textRating = new System.Windows.Forms.TextBox();
            this.textTitle = new System.Windows.Forms.TextBox();
            this.textYear = new System.Windows.Forms.TextBox();
            this.textCopies = new System.Windows.Forms.TextBox();
            this.MovieID = new System.Windows.Forms.Label();
            this.Rating = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.Year = new System.Windows.Forms.Label();
            this.Copies = new System.Windows.Forms.Label();
            this.btnMovieSave = new System.Windows.Forms.Button();
            this.textPlot = new System.Windows.Forms.TextBox();
            this.textGenre = new System.Windows.Forms.TextBox();
            this.textRental_Cost = new System.Windows.Forms.TextBox();
            this.Rantel_Cost = new System.Windows.Forms.Label();
            this.Plot = new System.Windows.Forms.Label();
            this.Genre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(67, 72);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(100, 20);
            this.textID.TabIndex = 0;
            this.textID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textRating
            // 
            this.textRating.Location = new System.Drawing.Point(214, 72);
            this.textRating.Name = "textRating";
            this.textRating.Size = new System.Drawing.Size(100, 20);
            this.textRating.TabIndex = 0;
            this.textRating.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textTitle
            // 
            this.textTitle.Location = new System.Drawing.Point(366, 72);
            this.textTitle.Name = "textTitle";
            this.textTitle.Size = new System.Drawing.Size(100, 20);
            this.textTitle.TabIndex = 0;
            this.textTitle.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textYear
            // 
            this.textYear.Location = new System.Drawing.Point(513, 72);
            this.textYear.Name = "textYear";
            this.textYear.Size = new System.Drawing.Size(100, 20);
            this.textYear.TabIndex = 0;
            this.textYear.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textCopies
            // 
            this.textCopies.Location = new System.Drawing.Point(67, 155);
            this.textCopies.Name = "textCopies";
            this.textCopies.Size = new System.Drawing.Size(100, 20);
            this.textCopies.TabIndex = 0;
            this.textCopies.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // MovieID
            // 
            this.MovieID.AutoSize = true;
            this.MovieID.Location = new System.Drawing.Point(67, 40);
            this.MovieID.Name = "MovieID";
            this.MovieID.Size = new System.Drawing.Size(50, 13);
            this.MovieID.TabIndex = 1;
            this.MovieID.Text = "Movie ID";
            this.MovieID.Click += new System.EventHandler(this.label1_Click);
            // 
            // Rating
            // 
            this.Rating.AutoSize = true;
            this.Rating.Location = new System.Drawing.Point(220, 40);
            this.Rating.Name = "Rating";
            this.Rating.Size = new System.Drawing.Size(38, 13);
            this.Rating.TabIndex = 1;
            this.Rating.Text = "Rating";
            this.Rating.Click += new System.EventHandler(this.label1_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(363, 40);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(27, 13);
            this.Title.TabIndex = 1;
            this.Title.Text = "Title";
            this.Title.Click += new System.EventHandler(this.label1_Click);
            // 
            // Year
            // 
            this.Year.AutoSize = true;
            this.Year.Location = new System.Drawing.Point(510, 40);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(29, 13);
            this.Year.TabIndex = 1;
            this.Year.Text = "Year";
            this.Year.Click += new System.EventHandler(this.label1_Click);
            // 
            // Copies
            // 
            this.Copies.AutoSize = true;
            this.Copies.Location = new System.Drawing.Point(67, 123);
            this.Copies.Name = "Copies";
            this.Copies.Size = new System.Drawing.Size(39, 13);
            this.Copies.TabIndex = 1;
            this.Copies.Text = "Copies";
            this.Copies.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnMovieSave
            // 
            this.btnMovieSave.Location = new System.Drawing.Point(220, 232);
            this.btnMovieSave.Name = "btnMovieSave";
            this.btnMovieSave.Size = new System.Drawing.Size(170, 52);
            this.btnMovieSave.TabIndex = 2;
            this.btnMovieSave.Text = "Save";
            this.btnMovieSave.UseVisualStyleBackColor = true;
            // 
            // textPlot
            // 
            this.textPlot.Location = new System.Drawing.Point(203, 155);
            this.textPlot.Name = "textPlot";
            this.textPlot.Size = new System.Drawing.Size(100, 20);
            this.textPlot.TabIndex = 0;
            this.textPlot.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textGenre
            // 
            this.textGenre.Location = new System.Drawing.Point(366, 155);
            this.textGenre.Name = "textGenre";
            this.textGenre.Size = new System.Drawing.Size(100, 20);
            this.textGenre.TabIndex = 0;
            this.textGenre.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textRental_Cost
            // 
            this.textRental_Cost.Location = new System.Drawing.Point(635, 72);
            this.textRental_Cost.Name = "textRental_Cost";
            this.textRental_Cost.Size = new System.Drawing.Size(100, 20);
            this.textRental_Cost.TabIndex = 0;
            this.textRental_Cost.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Rantel_Cost
            // 
            this.Rantel_Cost.AutoSize = true;
            this.Rantel_Cost.Location = new System.Drawing.Point(632, 40);
            this.Rantel_Cost.Name = "Rantel_Cost";
            this.Rantel_Cost.Size = new System.Drawing.Size(62, 13);
            this.Rantel_Cost.TabIndex = 1;
            this.Rantel_Cost.Text = "Rental Cost";
            this.Rantel_Cost.Click += new System.EventHandler(this.label1_Click);
            // 
            // Plot
            // 
            this.Plot.AutoSize = true;
            this.Plot.Location = new System.Drawing.Point(200, 123);
            this.Plot.Name = "Plot";
            this.Plot.Size = new System.Drawing.Size(25, 13);
            this.Plot.TabIndex = 1;
            this.Plot.Text = "Plot";
            this.Plot.Click += new System.EventHandler(this.label1_Click);
            // 
            // Genre
            // 
            this.Genre.AutoSize = true;
            this.Genre.Location = new System.Drawing.Point(365, 123);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(36, 13);
            this.Genre.TabIndex = 1;
            this.Genre.Text = "Genre";
            this.Genre.Click += new System.EventHandler(this.label1_Click);
            // 
            // AddMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMovieSave);
            this.Controls.Add(this.Rantel_Cost);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Genre);
            this.Controls.Add(this.Plot);
            this.Controls.Add(this.Copies);
            this.Controls.Add(this.Rating);
            this.Controls.Add(this.MovieID);
            this.Controls.Add(this.textRental_Cost);
            this.Controls.Add(this.textYear);
            this.Controls.Add(this.textGenre);
            this.Controls.Add(this.textTitle);
            this.Controls.Add(this.textCopies);
            this.Controls.Add(this.textPlot);
            this.Controls.Add(this.textRating);
            this.Controls.Add(this.textID);
            this.Name = "AddMovie";
            this.Text = "AddMovie";
            this.Load += new System.EventHandler(this.AddMovie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox textRating;
        private System.Windows.Forms.TextBox textTitle;
        private System.Windows.Forms.TextBox textYear;
        private System.Windows.Forms.TextBox textCopies;
        private System.Windows.Forms.Label MovieID;
        private System.Windows.Forms.Label Rating;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Year;
        private System.Windows.Forms.Label Copies;
        private System.Windows.Forms.Button btnMovieSave;
        private System.Windows.Forms.TextBox textPlot;
        private System.Windows.Forms.TextBox textGenre;
        private System.Windows.Forms.TextBox textRental_Cost;
        private System.Windows.Forms.Label Rantel_Cost;
        private System.Windows.Forms.Label Plot;
        private System.Windows.Forms.Label Genre;
    }
}