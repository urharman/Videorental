namespace Videorental
{
    partial class UpdateCustomer
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
            this.Customer_ID = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.Label();
            this.textCustomerID = new System.Windows.Forms.TextBox();
            this.textFirstName = new System.Windows.Forms.TextBox();
            this.textLastName = new System.Windows.Forms.TextBox();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Customer_ID
            // 
            this.Customer_ID.AutoSize = true;
            this.Customer_ID.Location = new System.Drawing.Point(110, 74);
            this.Customer_ID.Name = "Customer_ID";
            this.Customer_ID.Size = new System.Drawing.Size(65, 13);
            this.Customer_ID.TabIndex = 0;
            this.Customer_ID.Text = "Customer ID";
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Location = new System.Drawing.Point(234, 74);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(54, 13);
            this.FirstName.TabIndex = 0;
            this.FirstName.Text = "FirstName";
            this.FirstName.Click += new System.EventHandler(this.label2_Click);
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(389, 74);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(55, 13);
            this.LastName.TabIndex = 0;
            this.LastName.Text = "LastName";
            this.LastName.Click += new System.EventHandler(this.label3_Click);
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Location = new System.Drawing.Point(484, 74);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(45, 13);
            this.Address.TabIndex = 0;
            this.Address.Text = "Address";
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Location = new System.Drawing.Point(630, 74);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(38, 13);
            this.Phone.TabIndex = 0;
            this.Phone.Text = "Phone";
            // 
            // textCustomerID
            // 
            this.textCustomerID.Location = new System.Drawing.Point(91, 113);
            this.textCustomerID.Name = "textCustomerID";
            this.textCustomerID.Size = new System.Drawing.Size(100, 20);
            this.textCustomerID.TabIndex = 1;
            this.textCustomerID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textFirstName
            // 
            this.textFirstName.Location = new System.Drawing.Point(224, 113);
            this.textFirstName.Name = "textFirstName";
            this.textFirstName.Size = new System.Drawing.Size(100, 20);
            this.textFirstName.TabIndex = 1;
            this.textFirstName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textLastName
            // 
            this.textLastName.Location = new System.Drawing.Point(359, 113);
            this.textLastName.Name = "textLastName";
            this.textLastName.Size = new System.Drawing.Size(100, 20);
            this.textLastName.TabIndex = 1;
            // 
            // textAddress
            // 
            this.textAddress.Location = new System.Drawing.Point(487, 113);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(100, 20);
            this.textAddress.TabIndex = 1;
            // 
            // textPhone
            // 
            this.textPhone.Location = new System.Drawing.Point(623, 113);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(100, 20);
            this.textPhone.TabIndex = 1;
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.Location = new System.Drawing.Point(288, 239);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(241, 62);
            this.btnUpdateCustomer.TabIndex = 3;
            this.btnUpdateCustomer.Text = "Update Details";
            this.btnUpdateCustomer.UseVisualStyleBackColor = true;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // UpdateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdateCustomer);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.textAddress);
            this.Controls.Add(this.textLastName);
            this.Controls.Add(this.textFirstName);
            this.Controls.Add(this.textCustomerID);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.Customer_ID);
            this.Name = "UpdateCustomer";
            this.Text = "UpdateCustomer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Customer_ID;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.TextBox textCustomerID;
        private System.Windows.Forms.TextBox textFirstName;
        private System.Windows.Forms.TextBox textLastName;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.Button btnUpdateCustomer;
    }
}