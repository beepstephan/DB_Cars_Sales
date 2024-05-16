using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Cars_Sales.Cars
{
    public partial class FormAddCar : Form
    {
        private Main mainForm;
        private const string connectionString = "Server=26.205.250.8;Port=5432;Database=mashinki; User Id = stas; Password = stas2002";
        public FormAddCar(Main main)
        {
            InitializeComponent();
            mainForm = main;
            SearchBrands();
            comboBoxBrand.SelectedIndex = 1; // = 0
            SearchModels();
            comboBoxModel.SelectedIndex = 1;
            SearchConfigurations();
            comboBoxConfiguration.SelectedIndex = 0;
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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string brand = comboBoxBrand.Text;
            string model = comboBoxModel.Text;  
            int year = (int)numericUpDownYear.Value;
            string bodytype = textBoxBodyshell.Text;
            string color = textBoxColor.Text;
            int mileage = Convert.ToInt32(textBoxMileage.Text);

            decimal price = Convert.ToDecimal(textBoxPrice.Text);
            string condition = textBoxCondition.Text;
            string VIN = textBoxVIN.Text;
            string description = textBoxDescription.Text;
            string configuration = comboBoxConfiguration.Text;
            string dealership = comboBoxDealership.Text;
            if (brand != null && model != null && textBoxBodyshell.Text != null 
                && textBoxColor.Text != null && textBoxMileage.Text != null 
                && textBoxPrice.Text != null && textBoxCondition.Text != null 
                && textBoxVIN.Text != null && textBoxDescription.Text != null)
            {
                string searchDealershipID = "SELECT dealership_id FROM car_dealerships WHERE name = @name";
                int dealershipOwnerID;
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    using (NpgsqlCommand command = new NpgsqlCommand(searchDealershipID, connection))
                    {
                        command.Parameters.AddWithValue("@name", dealership);
                        object result = command.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            dealershipOwnerID = Convert.ToInt32(result);

                            string insertCarQuery = "INSERT INTO cars (brand, model, year, bodytype, color, mileage, " +
                                "price, condition, VIN, description, configuration, dealership_owner) " +
                                "VALUES (@brand, @model, @year, @bodytype, @color, @mileage, @price, @condition, " +
                                "@VIN, @description, @configuration, @dealership_owner)";

                            using (NpgsqlCommand insertCommand = new NpgsqlCommand(insertCarQuery, connection))
                            {
                                insertCommand.Parameters.AddWithValue("@brand", brand);
                                insertCommand.Parameters.AddWithValue("@model", model);
                                insertCommand.Parameters.AddWithValue("@year", year);
                                insertCommand.Parameters.AddWithValue("@bodytype", bodytype);
                                insertCommand.Parameters.AddWithValue("@color", color);
                                insertCommand.Parameters.AddWithValue("@mileage", mileage);
                                insertCommand.Parameters.AddWithValue("@price", price);
                                insertCommand.Parameters.AddWithValue("@condition", condition);
                                insertCommand.Parameters.AddWithValue("@VIN", VIN);
                                insertCommand.Parameters.AddWithValue("@description", description);
                                insertCommand.Parameters.AddWithValue("@configuration", configuration);
                                insertCommand.Parameters.AddWithValue("@dealership_owner", dealershipOwnerID);

                                int checkExecute = insertCommand.ExecuteNonQuery();
                                if (checkExecute != 0)
                                {
                                    mainForm.RefreshCarsDataGridView();
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("йой, Ісус вас не любить");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Йой, шось пішло не так(");
                        }
                    }
                }
            }

        }
    }
}
