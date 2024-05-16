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
            comboBoxBrand.SelectedIndex = 1; // = 0
            SearchModels();
            SearchGearbox();
            comboBoxDrive.SelectedIndex = 0;
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

        private void SearchGearbox()
        {
            string searchGearbox = "SELECT DISTINCT gearbox_type FROM model_info";
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand(searchGearbox, connection);
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);
                DataTable table = new DataTable();

                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    comboBoxGearboxType.DataSource = table;
                    comboBoxGearboxType.DisplayMember = "gearbox_type";
                    comboBoxGearboxType.ValueMember = "gearbox_type";
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

            float engineCapacity = (float)numericUpDownEngineCapacity.Value;
            int cylindersNum = (int)numericUpDownCilinders.Value;
            int power = (int)numericUpDownPower.Value;
            int maxSpeed = (int)numericUpDownMaxSpeed.Value;
            float accelerationTo100 = (float)numericUpDownAcceleration.Value;
            string gearboxType = comboBoxGearboxType.Text.Trim();
            int gearsNum = (int)numericUpDownGearsNum.Value;
            float fuelConsumption = (float)numericUpDownFuelConsumption.Value;

            if (brand.Length == 0 || model.Length == 0 || configuration.Length == 0 || bodyshell.Length == 0 || engine.Length == 0 || engine.Length == 0 || drive.Length == 0 || years.Length == 0 || gearboxType.Length == 0)
            {
                MessageBox.Show("Заповніть усі поля");
            }
            else
            {
                string addModelQuery = "INSERT INTO car_models (brand, model, configuration, bodyshell, engine, transmission, drive, release_years) VALUES (@brand, @model, @configuration, @bodyshell, @engine, @transmission, @drive, @release_years)";
                string addModelInfoQuery = "INSERT INTO model_info (configuration, engine_capacity, cylinders_num, power, max_speed, acceleration_to_100, gearbox_type, number_of_gears, fuel_consumption) VALUES (@configuration, @engine_capacity, @cylinders_num, @power, @max_speed, @acceleration_to_100, @gearbox_type, @number_of_gears, @fuel_consumption)";
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
                    using (NpgsqlCommand insertModelInfoComand = new NpgsqlCommand(addModelInfoQuery, connection))
                    {
                        insertModelInfoComand.Parameters.AddWithValue("@configuration", configuration);
                        insertModelInfoComand.Parameters.AddWithValue("@engine_capacity", engineCapacity);
                        insertModelInfoComand.Parameters.AddWithValue("@cylinders_num", cylindersNum);
                        insertModelInfoComand.Parameters.AddWithValue("@power", power);
                        insertModelInfoComand.Parameters.AddWithValue("@max_speed", maxSpeed);
                        insertModelInfoComand.Parameters.AddWithValue("@acceleration_to_100", accelerationTo100);
                        insertModelInfoComand.Parameters.AddWithValue("@gearbox_type", gearboxType);
                        insertModelInfoComand.Parameters.AddWithValue("@number_of_gears", gearsNum);
                        insertModelInfoComand.Parameters.AddWithValue("@fuel_consumption", fuelConsumption);

                        int checkExecute = insertModelInfoComand.ExecuteNonQuery();
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

        private void comboBoxBrand_TextUpdate(object sender, EventArgs e)
        {
            SearchModels();
        }

        private void comboBoxBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchModels();
        }
    }
}
