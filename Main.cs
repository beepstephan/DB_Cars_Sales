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
        
        public Main()
        {
            InitializeComponent();
            RefreshDataGridView();


        }

        public void RefreshDataGridView()
        {
            testDataGridView.DataSource = SqlConnectionReader();
        }

        private DataTable SqlConnectionReader()
        {
            string connectionString = "Server=26.205.250.8;Port=5432;Database=mashinki; User Id = stas; Password = stas2002";
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
            MessageBox.Show("кулитии!");
        }

        private void buttonAddDealership_Click(object sender, EventArgs e)
        {
            FormAddDealership formAddDealership = new FormAddDealership(this);
            formAddDealership.ShowDialog();
        }
    }
}
