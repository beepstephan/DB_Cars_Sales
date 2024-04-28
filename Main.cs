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
            SqlConnectionReader();
        }

        private void SqlConnectionReader()
        {
            NpgsqlConnection conn = new NpgsqlConnection(connectionString);
            conn.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = conn;
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM car_dealerships";
            NpgsqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                DataTable data = new DataTable();
                data.Load(reader);
                testDataGridView.DataSource = data;
            }
            command.Dispose();
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("кулити!");
        }

    }
}
