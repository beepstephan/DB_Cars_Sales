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

namespace DB_Cars_Sales.Cars
{
    public partial class FormUpdateCar : Form
    {
        private Main mainForm;
        private const string connectionString = "Server=26.205.250.8;Port=5432;Database=mashinki; User Id = stas; Password = stas2002";
        public FormUpdateCar(Main main, string VIN)
        {
            InitializeComponent();
            mainForm = main;

            textBoxVIN.Text = VIN;

            SearchConfigurations();

            string query = "SELECT * FROM cars WHERE vin = @vin";
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@vin", VIN);

                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        if (dataTable.Rows.Count > 0)
                        {
                            DataRow row = dataTable.Rows[0];

                            comboBoxBrand.Text = row["brand"].ToString();
                            comboBoxModel.Text = row["model"].ToString();
                            numericUpDownYear.Value = (int)row["year"];
                            textBoxBodyshell.Text = row["bodytype"].ToString();
                            textBoxColor.Text = row["color"].ToString();
                            textBoxMileage.Text = row["mileage"].ToString();
                            textBoxPrice.Text = row["price"].ToString();
                            textBoxCondition.Text = row["condition"].ToString();
                            textBoxDescription.Text = row["description"].ToString();
                            SearchConfigurations();
                            comboBoxConfiguration.Text = row["configuration"].ToString();
                            comboBoxDealership.SelectedIndex = (int)row["dealership_owner"] - 1;
                        }
                        else
                        {
                            MessageBox.Show("Авто не знайдено");
                        }
                    }
                }
            }
            SearchBrands();
            SearchModels();
        }

        private void SearchBrands()
        {
            string searchBrands = "SELECT DISTINCT brand FROM car_models";
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand(searchBrands, connection);
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
            string searchModels = "SELECT DISTINCT model FROM car_models WHERE brand = @brand";
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (NpgsqlCommand command = new NpgsqlCommand(searchModels, connection))
                {
                    command.Parameters.AddWithValue("@brand", comboBoxBrand.Text);
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                    {
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
            }
        }

        private void SearchConfigurations()
        {
            string searchConfigurations = "SELECT configuration FROM car_models WHERE brand = @brand AND model = @model";
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (NpgsqlCommand command = new NpgsqlCommand(searchConfigurations, connection))
                {
                    command.Parameters.AddWithValue("@brand", comboBoxBrand.Text);
                    command.Parameters.AddWithValue("@model", comboBoxModel.Text); ;
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            comboBoxConfiguration.DataSource = table;
                            comboBoxConfiguration.DisplayMember = "configuration";
                            comboBoxConfiguration.ValueMember = "configuration";
                        }
                    }
                }
            }
        }

        private void comboBoxBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchModels();
        }

        private void comboBoxBrand_TextUpdate(object sender, EventArgs e)
        {
            SearchModels();
        }

        private void comboBoxModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchConfigurations();
        }

        private void comboBoxModel_TextUpdate(object sender, EventArgs e)
        {
            SearchConfigurations();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string brand = comboBoxBrand.Text;
            string model = comboBoxModel.Text;
            int year = (int)numericUpDownYear.Value;
            string bodytype = textBoxBodyshell.Text;
            string color = textBoxColor.Text;
            int mileage = Convert.ToInt32(textBoxMileage.Text);

            decimal price = Convert.ToDecimal(textBoxPrice.Text);
            string condition = textBoxCondition.Text;
            string vin = textBoxVIN.Text;
            string description = textBoxDescription.Text;
            string configuration = comboBoxConfiguration.Text;
            int dealership = comboBoxDealership.SelectedIndex + 1;

            string updateCarQuery = "UPDATE cars SET brand = @brand, model = @model, year = @year, " +
                            "bodytype = @bodytype, color = @color, mileage = @mileage, price = @price, " +
                            "condition = @condition, description = @description, configuration = @configuration, " +
                            "dealership_owner = @dealership_owner WHERE vin = @vin";
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand updateCommand = new NpgsqlCommand(updateCarQuery, connection))
                {
                    updateCommand.Parameters.AddWithValue("@brand", brand);
                    updateCommand.Parameters.AddWithValue("@model", model);
                    updateCommand.Parameters.AddWithValue("@year", year);
                    updateCommand.Parameters.AddWithValue("@bodytype", bodytype);
                    updateCommand.Parameters.AddWithValue("@color", color);
                    updateCommand.Parameters.AddWithValue("@mileage", mileage);
                    updateCommand.Parameters.AddWithValue("@price", price);
                    updateCommand.Parameters.AddWithValue("@condition", condition);
                    updateCommand.Parameters.AddWithValue("@description", description);
                    updateCommand.Parameters.AddWithValue("@configuration", configuration);
                    updateCommand.Parameters.AddWithValue("@dealership_owner", dealership);
                    updateCommand.Parameters.AddWithValue("@vin", vin);

                    int checkExecute = updateCommand.ExecuteNonQuery();
                    if (checkExecute != 0)
                    {
                        mainForm.RefreshCarsDataGridView();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Помилка оновлення");
                    }
                }
                connection.Close();
            }
            
        }
    }
}
