namespace Rolodex
{
    partial class Rolodex
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.txt_firstName = new System.Windows.Forms.TextBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_city = new System.Windows.Forms.TextBox();
            this.txt_state = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.dgv_table = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_lastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_clearSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_table)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(139, 54);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(90, 20);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "First Name:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(110, 118);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(119, 20);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Phone Number:";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(157, 182);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(72, 20);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "Address:";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(190, 214);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(39, 20);
            this.lbl4.TabIndex = 3;
            this.lbl4.Text = "City:";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(177, 246);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(52, 20);
            this.lbl5.TabIndex = 4;
            this.lbl5.Text = "State:";
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Location = new System.Drawing.Point(177, 150);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(52, 20);
            this.lbl6.TabIndex = 5;
            this.lbl6.Text = "Email:";
            // 
            // txt_firstName
            // 
            this.txt_firstName.Location = new System.Drawing.Point(235, 54);
            this.txt_firstName.Name = "txt_firstName";
            this.txt_firstName.Size = new System.Drawing.Size(311, 26);
            this.txt_firstName.TabIndex = 6;
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(235, 118);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(311, 26);
            this.txt_phone.TabIndex = 7;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(235, 150);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(311, 26);
            this.txt_email.TabIndex = 8;
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(235, 182);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(311, 26);
            this.txt_address.TabIndex = 9;
            // 
            // txt_city
            // 
            this.txt_city.Location = new System.Drawing.Point(235, 214);
            this.txt_city.Name = "txt_city";
            this.txt_city.Size = new System.Drawing.Size(311, 26);
            this.txt_city.TabIndex = 10;
            // 
            // txt_state
            // 
            this.txt_state.Location = new System.Drawing.Point(235, 246);
            this.txt_state.Name = "txt_state";
            this.txt_state.Size = new System.Drawing.Size(311, 26);
            this.txt_state.TabIndex = 11;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(103, 307);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(126, 35);
            this.btn_add.TabIndex = 12;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(235, 307);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(126, 35);
            this.btn_edit.TabIndex = 13;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(367, 307);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(126, 35);
            this.btn_delete.TabIndex = 14;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(499, 307);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(126, 35);
            this.btn_search.TabIndex = 15;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // dgv_table
            // 
            this.dgv_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtId,
            this.txtFirstName,
            this.txtLastName,
            this.txtPhoneNumber,
            this.txtEmail,
            this.txtAddress,
            this.txtCity,
            this.txtState});
            this.dgv_table.Location = new System.Drawing.Point(739, 57);
            this.dgv_table.Name = "dgv_table";
            this.dgv_table.RowHeadersWidth = 62;
            this.dgv_table.RowTemplate.Height = 28;
            this.dgv_table.Size = new System.Drawing.Size(1325, 285);
            this.dgv_table.TabIndex = 16;
            this.dgv_table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PopulateTextBoxesOn_CellClick);
            // 
            // txtId
            // 
            this.txtId.DataPropertyName = "ID";
            this.txtId.HeaderText = "ID";
            this.txtId.MinimumWidth = 8;
            this.txtId.Name = "txtId";
            this.txtId.Visible = false;
            this.txtId.Width = 150;
            // 
            // txtFirstName
            // 
            this.txtFirstName.DataPropertyName = "FirstName";
            this.txtFirstName.HeaderText = "First Name";
            this.txtFirstName.MinimumWidth = 8;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Width = 150;
            // 
            // txtLastName
            // 
            this.txtLastName.DataPropertyName = "LastName";
            this.txtLastName.HeaderText = "Last Name";
            this.txtLastName.MinimumWidth = 8;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Width = 150;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.DataPropertyName = "PhoneNumber";
            this.txtPhoneNumber.HeaderText = "Phone Number";
            this.txtPhoneNumber.MinimumWidth = 8;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Width = 150;
            // 
            // txtEmail
            // 
            this.txtEmail.DataPropertyName = "Email";
            this.txtEmail.HeaderText = "Email";
            this.txtEmail.MinimumWidth = 8;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Width = 150;
            // 
            // txtAddress
            // 
            this.txtAddress.DataPropertyName = "Address";
            this.txtAddress.HeaderText = "Address";
            this.txtAddress.MinimumWidth = 8;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Width = 150;
            // 
            // txtCity
            // 
            this.txtCity.DataPropertyName = "City";
            this.txtCity.HeaderText = "City";
            this.txtCity.MinimumWidth = 8;
            this.txtCity.Name = "txtCity";
            this.txtCity.Width = 150;
            // 
            // txtState
            // 
            this.txtState.DataPropertyName = "State";
            this.txtState.HeaderText = "State";
            this.txtState.MinimumWidth = 8;
            this.txtState.Name = "txtState";
            this.txtState.Width = 150;
            // 
            // txt_lastName
            // 
            this.txt_lastName.Location = new System.Drawing.Point(235, 86);
            this.txt_lastName.Name = "txt_lastName";
            this.txt_lastName.Size = new System.Drawing.Size(311, 26);
            this.txt_lastName.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Last Name:";
            // 
            // btn_clearSearch
            // 
            this.btn_clearSearch.Location = new System.Drawing.Point(499, 348);
            this.btn_clearSearch.Name = "btn_clearSearch";
            this.btn_clearSearch.Size = new System.Drawing.Size(126, 35);
            this.btn_clearSearch.TabIndex = 19;
            this.btn_clearSearch.Text = "Clear Search";
            this.btn_clearSearch.UseVisualStyleBackColor = true;
            this.btn_clearSearch.Click += new System.EventHandler(this.btn_clearSearch_Click);
            // 
            // Rolodex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2087, 450);
            this.Controls.Add(this.btn_clearSearch);
            this.Controls.Add(this.txt_lastName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_table);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_state);
            this.Controls.Add(this.txt_city);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.txt_firstName);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Name = "Rolodex";
            this.Text = "Rolodex";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.TextBox txt_firstName;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_city;
        private System.Windows.Forms.TextBox txt_state;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DataGridView dgv_table;
        private System.Windows.Forms.TextBox txt_lastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtId;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtState;
        private System.Windows.Forms.Button btn_clearSearch;
    }
}

