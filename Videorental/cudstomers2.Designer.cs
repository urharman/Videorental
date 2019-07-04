using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Videorental
{
    partial class customers2
    {
        /// <summary>
        /// Required designers variables.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposeds; otherwise, false.</param>
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customers2));
            this.btnAddcustomer = new System.Windows.Forms.Button();
            this.btnUpdateCostumer = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.movieDataSet = new Videorental.MovieDataSet();
            this.customerTableAdapter = new Videorental.MovieDataSetTableAdapters.CustomerTableAdapter();
            this.listview11111 = new System.Windows.Forms.ListView();
            this.CustID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.text1 = new System.Windows.Forms.TextBox();
            this.text2 = new System.Windows.Forms.TextBox();
            this.text3 = new System.Windows.Forms.TextBox();
            this.text4 = new System.Windows.Forms.TextBox();
            this.text5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddcustomer
            // 
            this.btnAddcustomer.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddcustomer.Location = new System.Drawing.Point(69, 305);
            this.btnAddcustomer.Name = "btnAddcustomer";
            this.btnAddcustomer.Size = new System.Drawing.Size(136, 37);
            this.btnAddcustomer.TabIndex = 1;
            this.btnAddcustomer.Text = " Add Customer";
            this.btnAddcustomer.UseVisualStyleBackColor = false;
            this.btnAddcustomer.Click += new System.EventHandler(this.btnAddcustomer_Click);
            // 
            // btnUpdateCostumer
            // 
            this.btnUpdateCostumer.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdateCostumer.Location = new System.Drawing.Point(290, 305);
            this.btnUpdateCostumer.Name = "btnUpdateCostumer";
            this.btnUpdateCostumer.Size = new System.Drawing.Size(153, 37);
            this.btnUpdateCostumer.TabIndex = 2;
            this.btnUpdateCostumer.Text = "Update Customer";
            this.btnUpdateCostumer.UseVisualStyleBackColor = false;
            this.btnUpdateCostumer.Click += new System.EventHandler(this.btnUpdateCostumer_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DodgerBlue;
            this.button3.Location = new System.Drawing.Point(548, 305);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 37);
            this.button3.TabIndex = 3;
            this.button3.Text = "Remove Customer";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.movieDataSet;
            // 
            // movieDataSet
            // 
            this.movieDataSet.DataSetName = "MovieDataSet";
            this.movieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // listview11111
            // 
            this.listview11111.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.listview11111.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CustID,
            this.FirstName,
            this.LastName,
            this.Address,
            this.Phone});
            this.listview11111.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.listview11111.Location = new System.Drawing.Point(35, 44);
            this.listview11111.Name = "listview11111";
            this.listview11111.Size = new System.Drawing.Size(707, 255);
            this.listview11111.TabIndex = 4;
            this.listview11111.UseCompatibleStateImageBehavior = false;
            this.listview11111.View = System.Windows.Forms.View.Details;
            this.listview11111.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged_1);
            // 
            // CustID
            // 
            this.CustID.Text = "Customer ID";
            this.CustID.Width = 86;
            // 
            // FirstName
            // 
            this.FirstName.Text = "First Name";
            this.FirstName.Width = 134;
            // 
            // LastName
            // 
            this.LastName.Text = "Last Name";
            this.LastName.Width = 136;
            // 
            // Address
            // 
            this.Address.Text = "Address";
            this.Address.Width = 175;
            // 
            // Phone
            // 
            this.Phone.Text = "Phone";
            this.Phone.Width = 173;
            // 
            // text1
            // 
            this.text1.Location = new System.Drawing.Point(54, 392);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(120, 20);
            this.text1.TabIndex = 5;
            // 
            // text2
            // 
            this.text2.Location = new System.Drawing.Point(196, 392);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(112, 20);
            this.text2.TabIndex = 6;
            this.text2.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // text3
            // 
            this.text3.Location = new System.Drawing.Point(343, 392);
            this.text3.Name = "text3";
            this.text3.Size = new System.Drawing.Size(115, 20);
            this.text3.TabIndex = 7;
            // 
            // text4
            // 
            this.text4.Location = new System.Drawing.Point(482, 392);
            this.text4.Name = "text4";
            this.text4.Size = new System.Drawing.Size(115, 20);
            this.text4.TabIndex = 8;
            // 
            // text5
            // 
            this.text5.Location = new System.Drawing.Point(631, 392);
            this.text5.Name = "text5";
            this.text5.Size = new System.Drawing.Size(111, 20);
            this.text5.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(54, 373);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Customer ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(193, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(343, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(482, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(631, 370);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.OrangeRed;
            this.label6.Location = new System.Drawing.Point(207, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(358, 38);
            this.label6.TabIndex = 15;
            this.label6.Text = "Customer Details Table";
            // 
            // customers2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1105, 547);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text5);
            this.Controls.Add(this.text4);
            this.Controls.Add(this.text3);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.listview11111);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnUpdateCostumer);
            this.Controls.Add(this.btnAddcustomer);
            this.Name = "customers2";
            this.Text = "cudstomers2";
            this.Load += new System.EventHandler(this.cudstomers2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void cudstomers2_Load(object sender, EventArgs e)
        {
            listview11111.Items.Clear(); //clear out old data in the listbox, we will need this later
                                     //load the connection string and pass it to the command
            string connectionString = @"Data Source=DESKTOP-U551NOV\SQLEXPRESS;Initial Catalog=Movie;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string queryString = "SELECT * FROM Customer ORDER by CustID";
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

        #endregion
        private System.Windows.Forms.Button btnAddcustomer;
        private System.Windows.Forms.Button btnUpdateCostumer;
        private System.Windows.Forms.Button button3;
        private MovieDataSet movieDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private MovieDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.ListView listview11111;
        private System.Windows.Forms.ColumnHeader CustID;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader LastName;
        private System.Windows.Forms.ColumnHeader Address;
        private System.Windows.Forms.ColumnHeader Phone;
        private System.Windows.Forms.TextBox text1;
        private System.Windows.Forms.TextBox text2;
        private System.Windows.Forms.TextBox text3;
        private System.Windows.Forms.TextBox text4;
        private System.Windows.Forms.TextBox text5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Label label6;
    }
}