using System;

namespace Videorental
{
    partial class movies1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(movies1));
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd_Movies = new System.Windows.Forms.Button();
            this.btnDeletes = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.MovieID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rating = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Year = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rental_Cost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Copies = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Plot = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Genre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textMovieID = new System.Windows.Forms.TextBox();
            this.TextRating = new System.Windows.Forms.TextBox();
            this.TextTitle = new System.Windows.Forms.TextBox();
            this.textYear = new System.Windows.Forms.TextBox();
            this.textRental_Cost = new System.Windows.Forms.TextBox();
            this.textCopies = new System.Windows.Forms.TextBox();
            this.textPlot = new System.Windows.Forms.TextBox();
            this.textGenre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Teal;
            this.btnUpdate.Location = new System.Drawing.Point(245, 276);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(149, 35);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update Movies";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd_Movies
            // 
            this.btnAdd_Movies.BackColor = System.Drawing.Color.Teal;
            this.btnAdd_Movies.Location = new System.Drawing.Point(36, 276);
            this.btnAdd_Movies.Name = "btnAdd_Movies";
            this.btnAdd_Movies.Size = new System.Drawing.Size(149, 35);
            this.btnAdd_Movies.TabIndex = 1;
            this.btnAdd_Movies.Text = "Add Movies";
            this.btnAdd_Movies.UseVisualStyleBackColor = false;
            this.btnAdd_Movies.Click += new System.EventHandler(this.btnAdd_Movies_Click);
            // 
            // btnDeletes
            // 
            this.btnDeletes.BackColor = System.Drawing.Color.Teal;
            this.btnDeletes.Location = new System.Drawing.Point(461, 276);
            this.btnDeletes.Name = "btnDeletes";
            this.btnDeletes.Size = new System.Drawing.Size(149, 35);
            this.btnDeletes.TabIndex = 2;
            this.btnDeletes.Text = "Delete Movies";
            this.btnDeletes.UseVisualStyleBackColor = false;
            this.btnDeletes.Click += new System.EventHandler(this.btnDeletes_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.CadetBlue;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MovieID,
            this.Rating,
            this.Title,
            this.Year,
            this.Rental_Cost,
            this.Copies,
            this.Plot,
            this.Genre});
            this.listView1.Location = new System.Drawing.Point(36, 50);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(587, 220);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged_1);
            // 
            // MovieID
            // 
            this.MovieID.Text = "Movie ID";
            this.MovieID.Width = 61;
            // 
            // Rating
            // 
            this.Rating.Text = "Rating";
            this.Rating.Width = 65;
            // 
            // Title
            // 
            this.Title.Text = "Title";
            this.Title.Width = 66;
            // 
            // Year
            // 
            this.Year.Text = "Year";
            this.Year.Width = 66;
            // 
            // Rental_Cost
            // 
            this.Rental_Cost.Text = "Rental_Cost";
            this.Rental_Cost.Width = 77;
            // 
            // Copies
            // 
            this.Copies.Text = "Copies";
            this.Copies.Width = 71;
            // 
            // Plot
            // 
            this.Plot.Text = "Plot";
            this.Plot.Width = 67;
            // 
            // Genre
            // 
            this.Genre.Text = "Genre";
            this.Genre.Width = 108;
            // 
            // textMovieID
            // 
            this.textMovieID.Location = new System.Drawing.Point(46, 345);
            this.textMovieID.Name = "textMovieID";
            this.textMovieID.Size = new System.Drawing.Size(100, 20);
            this.textMovieID.TabIndex = 4;
            this.textMovieID.TextChanged += new System.EventHandler(this.textMovieID_TextChanged);
            // 
            // TextRating
            // 
            this.TextRating.Location = new System.Drawing.Point(182, 345);
            this.TextRating.Name = "TextRating";
            this.TextRating.Size = new System.Drawing.Size(100, 20);
            this.TextRating.TabIndex = 4;
            // 
            // TextTitle
            // 
            this.TextTitle.Location = new System.Drawing.Point(334, 345);
            this.TextTitle.Name = "TextTitle";
            this.TextTitle.Size = new System.Drawing.Size(100, 20);
            this.TextTitle.TabIndex = 4;
            // 
            // textYear
            // 
            this.textYear.Location = new System.Drawing.Point(488, 345);
            this.textYear.Name = "textYear";
            this.textYear.Size = new System.Drawing.Size(100, 20);
            this.textYear.TabIndex = 4;
            // 
            // textRental_Cost
            // 
            this.textRental_Cost.Location = new System.Drawing.Point(46, 394);
            this.textRental_Cost.Name = "textRental_Cost";
            this.textRental_Cost.Size = new System.Drawing.Size(100, 20);
            this.textRental_Cost.TabIndex = 4;
            // 
            // textCopies
            // 
            this.textCopies.Location = new System.Drawing.Point(181, 394);
            this.textCopies.Name = "textCopies";
            this.textCopies.Size = new System.Drawing.Size(100, 20);
            this.textCopies.TabIndex = 5;
            // 
            // textPlot
            // 
            this.textPlot.Location = new System.Drawing.Point(334, 394);
            this.textPlot.Name = "textPlot";
            this.textPlot.Size = new System.Drawing.Size(100, 20);
            this.textPlot.TabIndex = 6;
            // 
            // textGenre
            // 
            this.textGenre.Location = new System.Drawing.Point(482, 394);
            this.textGenre.Name = "textGenre";
            this.textGenre.Size = new System.Drawing.Size(100, 20);
            this.textGenre.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Movie ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(182, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Rating";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(331, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(485, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Year";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Rental Cost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(182, 372);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Copies";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(334, 372);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "Plot";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(482, 371);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 18);
            this.label8.TabIndex = 12;
            this.label8.Text = "Genre";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.OrangeRed;
            this.label9.Location = new System.Drawing.Point(164, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(303, 38);
            this.label9.TabIndex = 13;
            this.label9.Text = "Movie Details Table";
            // 
            // movies1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(829, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textGenre);
            this.Controls.Add(this.textPlot);
            this.Controls.Add(this.textCopies);
            this.Controls.Add(this.textRental_Cost);
            this.Controls.Add(this.textYear);
            this.Controls.Add(this.TextTitle);
            this.Controls.Add(this.TextRating);
            this.Controls.Add(this.textMovieID);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnDeletes);
            this.Controls.Add(this.btnAdd_Movies);
            this.Controls.Add(this.btnUpdate);
            this.Name = "movies1";
            this.Text = "movies1";
            this.Load += new System.EventHandler(this.movies1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd_Movies;
        private System.Windows.Forms.Button btnDeletes;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader MovieID;
        private System.Windows.Forms.ColumnHeader Rating;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Year;
        private System.Windows.Forms.ColumnHeader Rental_Cost;
        private System.Windows.Forms.ColumnHeader Copies;
        private System.Windows.Forms.ColumnHeader Plot;
        private System.Windows.Forms.ColumnHeader Genre;
        private System.Windows.Forms.TextBox textMovieID;
        private System.Windows.Forms.TextBox TextRating;
        private System.Windows.Forms.TextBox TextTitle;
        private System.Windows.Forms.TextBox textYear;
        private System.Windows.Forms.TextBox textRental_Cost;
        private System.Windows.Forms.TextBox textCopies;
        private System.Windows.Forms.TextBox textPlot;
        private System.Windows.Forms.TextBox textGenre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}