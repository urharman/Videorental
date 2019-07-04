namespace Videorental
{
    partial class Rented1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rented1));
            this.listView1 = new System.Windows.Forms.ListView();
            this.RMID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MovieIDFK = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CustIDFK = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateRented = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateReturned = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textMovie = new System.Windows.Forms.TextBox();
            this.textCustomer = new System.Windows.Forms.TextBox();
            this.textDateIssue = new System.Windows.Forms.TextBox();
            this.textReturnDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textRMID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.RMID,
            this.MovieIDFK,
            this.CustIDFK,
            this.DateRented,
            this.DateReturned});
            this.listView1.Location = new System.Drawing.Point(45, 72);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(689, 273);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // RMID
            // 
            this.RMID.Text = "RMID";
            this.RMID.Width = 114;
            // 
            // MovieIDFK
            // 
            this.MovieIDFK.Text = "MovieIDFK";
            this.MovieIDFK.Width = 163;
            // 
            // CustIDFK
            // 
            this.CustIDFK.Text = "CUSTIDFK";
            this.CustIDFK.Width = 93;
            // 
            // DateRented
            // 
            this.DateRented.Text = "DateRented";
            this.DateRented.Width = 106;
            // 
            // DateReturned
            // 
            this.DateReturned.Text = "DateReturned";
            this.DateReturned.Width = 207;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(136, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(477, 61);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rented Movies List";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button1.Location = new System.Drawing.Point(109, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Issue Movie";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button2.Location = new System.Drawing.Point(265, 360);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 29);
            this.button2.TabIndex = 3;
            this.button2.Text = "Return Movie";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textMovie
            // 
            this.textMovie.Location = new System.Drawing.Point(126, 418);
            this.textMovie.Name = "textMovie";
            this.textMovie.Size = new System.Drawing.Size(100, 20);
            this.textMovie.TabIndex = 4;
            // 
            // textCustomer
            // 
            this.textCustomer.Location = new System.Drawing.Point(282, 418);
            this.textCustomer.Name = "textCustomer";
            this.textCustomer.Size = new System.Drawing.Size(100, 20);
            this.textCustomer.TabIndex = 5;
            this.textCustomer.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textDateIssue
            // 
            this.textDateIssue.Location = new System.Drawing.Point(447, 418);
            this.textDateIssue.Name = "textDateIssue";
            this.textDateIssue.Size = new System.Drawing.Size(100, 20);
            this.textDateIssue.TabIndex = 6;
            // 
            // textReturnDate
            // 
            this.textReturnDate.Location = new System.Drawing.Point(627, 418);
            this.textReturnDate.Name = "textReturnDate";
            this.textReturnDate.Size = new System.Drawing.Size(100, 20);
            this.textReturnDate.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(133, 398);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Customer ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(291, 397);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Movie ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(613, 397);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Date Of Return";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Location = new System.Drawing.Point(444, 397);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Date Of Rent";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Location = new System.Drawing.Point(34, 396);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "RMID";
            // 
            // textRMID
            // 
            this.textRMID.Location = new System.Drawing.Point(20, 418);
            this.textRMID.Name = "textRMID";
            this.textRMID.Size = new System.Drawing.Size(100, 20);
            this.textRMID.TabIndex = 11;
            // 
            // Rented1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(858, 456);
            this.Controls.Add(this.textRMID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textReturnDate);
            this.Controls.Add(this.textDateIssue);
            this.Controls.Add(this.textCustomer);
            this.Controls.Add(this.textMovie);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Name = "Rented1";
            this.Text = "Rented1";
            this.Load += new System.EventHandler(this.Rented1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader RMID;
        private System.Windows.Forms.ColumnHeader MovieIDFK;
        private System.Windows.Forms.ColumnHeader CustIDFK;
        private System.Windows.Forms.ColumnHeader DateRented;
        private System.Windows.Forms.ColumnHeader DateReturned;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textMovie;
        private System.Windows.Forms.TextBox textCustomer;
        private System.Windows.Forms.TextBox textDateIssue;
        private System.Windows.Forms.TextBox textReturnDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textRMID;
    }
}