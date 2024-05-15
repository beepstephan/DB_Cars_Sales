using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Cars_Sales.CarModels
{
    public partial class FormAddModel : Form
    {
        private Main mainForm;

        private const string connectionString = "Server=26.205.250.8;Port=5432;Database=mashinki; User Id = stas; Password = stas2002";
        public FormAddModel(Main main)
        {
            InitializeComponent();
            mainForm = main;
            SearchBrands();
            SearchModels();
            comboBoxDrive.SelectedIndex = 0;
        }

        private void SearchBrands()
        {
            string searchCustomerName = "SELECT DISTINCT brand FROM car_models";
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand(searchCustomerName, connection);
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);
                DataTable table = new DataTable();

                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    comboBoxBrand.DataSource = table;
                    comboBoxBrand.DisplayMember = "brand";
                    comboBoxBrand.ValueMember = "brand";
                }
            }
        }

        private void SearchModels()
        {
            string searchCustomerName = "SELECT DISTINCT model FROM car_models";
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand(searchCustomerName, connection);
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);
                DataTable table = new DataTable();

                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    comboBoxModel.DataSource = table;
                    comboBoxModel.DisplayMember = "model";
                    comboBoxModel.ValueMember = "model";
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string brand = comboBoxBrand.Text.Trim();
            string model = comboBoxModel.Text.Trim();
            string configuration = textBoxConfiguration.Text.Trim();
            string bodyshell = textBoxBodyshell.Text.Trim();
            string engine = textBoxEngine.Text.Trim();
            string transmission = textBoxTransmission.Text.Trim();
            string drive = comboBoxDrive.Text.Trim();
            string years = textBoxYears.Text.Trim();

            if (brand.Length == 0 || model.Length == 0 || configuration.Length == 0 || bodyshell.Length == 0 || engine.Length == 0 || engine.Length == 0 || drive.Length == 0 || years.Length == 0)
            {
                MessageBox.Show("Заповніть усі поля");
            }
            else
            {
                string addModelQuery = "INSERT INTO car_models (brand, model, configuration, bodyshell, engine, transmission, drive, release_years) VALUES (@brand, @model, @configuration, @bodyshell, @engine, @transmission, @drive, @release_years)";
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    using (NpgsqlCommand insertModelComand = new NpgsqlCommand(addModelQuery, connection))
                    {
                        insertModelComand.Parameters.AddWithValue("@brand", brand);
                        insertModelComand.Parameters.AddWithValue("@model", model);
                        insertModelComand.Parameters.AddWithValue("@configuration", configuration);
                        insertModelComand.Parameters.AddWithValue("@bodyshell", bodyshell);
                        insertModelComand.Parameters.AddWithValue("@engine", engine);
                        insertModelComand.Parameters.AddWithValue("@transmission", transmission);
                        insertModelComand.Parameters.AddWithValue("@drive", drive);
                        insertModelComand.Parameters.AddWithValue("@release_years", years);

                        int checkExecute = insertModelComand.ExecuteNonQuery();
                        if (checkExecute != 0)
                        {
                            mainForm.RefreshModelsDataGridView();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Помилка вставлення");
                        }
                    }
                }
            }
        }

    }
}
