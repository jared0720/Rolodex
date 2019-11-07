using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Rolodex
{
    public partial class Rolodex : Form
    {
        public Rolodex()
        {
            InitializeComponent();
            PopulateDataTable();
        }

        string CONST_CONNECTION = "Data Source=DESKTOP-R5JBOUL\\SQLEXPRESS;Initial Catalog=RolodexProject;Integrated Security=True";
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter dataAdapter;
        string query = String.Empty;


        private void btn_add_Click(object sender, EventArgs e)
        {
            AddEditContact();
            MessageBox.Show("Contact added successfully.");
        }
        private void btn_edit_Click(object sender, EventArgs e)
        {
            AddEditContact();
            MessageBox.Show("Contact edited successfully.");
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            DeleteContact();
            MessageBox.Show("Contact deleted successfully.");
        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            SearchContact();
        }
        private void btn_clearSearch_Click(object sender, EventArgs e)
        {
            PopulateDataTable();
            ClearTextBoxes();
        }
        private void PopulateTextBoxesOn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgv_table.CurrentRow;

            txt_firstName.Text = row.Cells["txtFirstName"].Value.ToString();
            txt_lastName.Text = row.Cells["txtLastName"].Value.ToString();
            txt_phone.Text = row.Cells["txtPhoneNumber"].Value.ToString();
            txt_email.Text = row.Cells["txtEmail"].Value.ToString();
            txt_address.Text = row.Cells["txtAddress"].Value.ToString();
            txt_city.Text = row.Cells["txtCity"].Value.ToString();
            txt_state.Text = row.Cells["txtState"].Value.ToString();
        }

        private void PopulateDataTable() 
        {
            query = "SELECT * FROM Rolodex2";
            connection = new SqlConnection(CONST_CONNECTION);
            dataAdapter = new SqlDataAdapter(query, connection);
            var dataTable = new DataTable();

            using (connection)
            {
                dataAdapter.Fill(dataTable);
                dgv_table.ReadOnly = true;
                dgv_table.DataSource = dataTable;
            }
            dgv_table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void ClearTextBoxes()
        {
            txt_firstName.Text = "";
            txt_lastName.Text = "";
            txt_phone.Text = "";
            txt_email.Text = "";
            txt_address.Text = "";
            txt_city.Text = "";
            txt_state.Text = "";
        }

        private void AddEditContact()
        {
            query = "IF @ID = 0 INSERT INTO Rolodex2 (FirstName, LastName, PhoneNumber, Email, Address, City, State) " +
                       "VALUES (@FirstName, @LastName, @PhoneNumber, @Email, @Address, @City, @State) " +
                       "ELSE UPDATE Rolodex2 " +
                       "SET FirstName = @FirstName, LastName = @LastName, PhoneNumber = @PhoneNumber, Email = @Email, Address = @Address, City = @City, State = @State " +
                       "WHERE ID = @ID";
            connection = new SqlConnection(CONST_CONNECTION);
            command = new SqlCommand(query, connection);
            DataGridViewRow row = dgv_table.CurrentRow;

            using (connection)
            {
                using (command)
                {
                    connection.Open();

                    if (row.Cells["txtID"].Value == DBNull.Value)
                    {
                        command.Parameters.AddWithValue("@ID", 0);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@ID", Convert.ToInt32(row.Cells["txtID"].Value));
                    }
                    command.Parameters.AddWithValue("@FirstName", txt_firstName.Text);
                    command.Parameters.AddWithValue("@LastName", txt_lastName.Text);
                    command.Parameters.AddWithValue("@PhoneNumber", txt_phone.Text);
                    command.Parameters.AddWithValue("@Email", txt_email.Text);
                    command.Parameters.AddWithValue("@Address", txt_address.Text);
                    command.Parameters.AddWithValue("@City", txt_city.Text);
                    command.Parameters.AddWithValue("@State", txt_state.Text);
                    command.ExecuteNonQuery();
                }
            }
            ClearTextBoxes();
            PopulateDataTable();
        }

        private void DeleteContact()
        {
            query = "DELETE FROM Rolodex2 WHERE @ID = ID";
            connection = new SqlConnection(CONST_CONNECTION);
            command = new SqlCommand(query, connection);

            using (connection)
            {
                using (command)
                {
                    connection.Open();

                    command.Parameters.AddWithValue("@ID", Convert.ToInt32(dgv_table.CurrentRow.Cells["txtID"].Value));
                    command.ExecuteNonQuery();
                }
            }
            ClearTextBoxes();
            PopulateDataTable();
        }

        private void SearchContact()
        {
            query = "SELECT * FROM Rolodex2 WHERE (FirstName LIKE '%" + txt_firstName.Text + "%') " +
                "AND (LastName LIKE '%" + txt_lastName.Text + "%') " +
                "AND (PhoneNumber LIKE '%" + txt_phone.Text + "%') " +
                "AND (Email LIKE '%" + txt_email.Text + "%') " +
                "AND (Address LIKE '%" + txt_address.Text + "%') " +
                "AND (City LIKE '%" + txt_city.Text + "%') " +
                "AND (State LIKE '%" + txt_state.Text + "%') ";
            connection = new SqlConnection(CONST_CONNECTION);
            dataAdapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();

            using (connection)
            {
                using (dataAdapter)
                {
                    dataAdapter.Fill(dataTable);
                    dgv_table.DataSource = dataTable;
                }
            }
        }
    }
}