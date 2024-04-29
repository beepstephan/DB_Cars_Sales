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
            RefreshDataGridView();
        }

        public void RefreshDataGridView()
        {
            CarDealershipsDataGridView.DataSource = SqlConnectionReader();
        }

        private DataTable SqlConnectionReader()
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
    }
}
