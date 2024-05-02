using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace DB_Cars_Sales
{
    public partial class Main : Form
    {
        string connectionString = "Server=26.205.250.8;Port=5432;Database=mashinki; User Id = stas; Password = stas2002";
        
        public Main()
        {
            InitializeComponent();
            RefreshCarDealershipsDataGridView();
            RefreshCustomershipsDataGridView();
            radioButtonCustomerSurname.Checked = true;
        }

        public void RefreshCarDealershipsDataGridView()
        {
            CarDealershipsDataGridView.DataSource = CarDealershipsSqlConnectionReader();
        }

        public void RefreshCustomershipsDataGridView()
        {
            CustomerDataGridView.DataSource = CustomerssSqlConnectionReader();
        }

        private DataTable CarDealershipsSqlConnectionReader()
        {
            
            string sql = "SELECT * FROM car_dealerships";
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sql, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }

        }

        private DataTable CustomerssSqlConnectionReader()
        {

            string sql = "SELECT * FROM customers";
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sql, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("кулити!");
        }

        private void buttonAddDealership_Click(object sender, EventArgs e)
        {
            FormAddDealership formAddDealership = new FormAddDealership(this);
            formAddDealership.ShowDialog();
        }

        
        private void buttonDeleteDealership_Click(object sender, EventArgs e)
        {
            NpgsqlConnection connection;
            connection = new NpgsqlConnection(connectionString);
            if (CarDealershipsDataGridView.SelectedRows.Count > 0)
            {
                
                int selectedRowIndex = CarDealershipsDataGridView.SelectedRows[0].Index;
                string emailToDelete = CarDealershipsDataGridView.SelectedRows[0].Cells["Email"].Value.ToString();

                
                CarDealershipsDataGridView.Rows.RemoveAt(selectedRowIndex);

                
                try
                {
                    connection.Open();
                    string sql = "DELETE FROM car_dealerships WHERE email = @email";
                    using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@email", emailToDelete);
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Укажіть рядок з автосалоном, який треба видалити!");
            }
        }

        private void buttonCustomerSearch_Click(object sender, EventArgs e)
        {
            NpgsqlConnection connection;
            connection = new NpgsqlConnection(connectionString); //пум
            try
            {
                connection.Open();
                string query = "";
                if (radioButtonCustomerSurname.Checked)
                {
                    query = "SELECT * FROM customers WHERE LOWER(fullname) LIKE LOWER(@fullname)";
                    NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@fullname", "%" + textBoxCustomerSearch.Text + "%");
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    CustomerDataGridView.DataSource = dt;
                }
                else if (radioButtonCustomerPhone.Checked)
                {
                    query = "SELECT * FROM customers WHERE phone_number LIKE @phone_number";
                    NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@phone_number", "%" + textBoxCustomerSearch.Text + "%");
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    CustomerDataGridView.DataSource = dt;
                }
                else if (radioButtonCustomerDate.Checked)
                {
                    query = "SELECT * FROM customers WHERE birth_date = @birth_date";
                    NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@birth_date", DateTime.Parse(textBoxCustomerSearch.Text));
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    CustomerDataGridView.DataSource = dt;
                }
                
                
                
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
