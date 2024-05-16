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
    public partial class FormCheckInfoCarModels : Form
    {
        private const string connectionString = "Server=26.205.250.8;Port=5432;Database=mashinki; User Id = stas; Password = stas2002";
        private NpgsqlConnection connection;
        public FormCheckInfoCarModels(string model_configuration)
        {
            InitializeComponent();
            connection = new NpgsqlConnection(connectionString);
            string sql = "SELECT * FROM model_info WHERE configuration = @configuration";
            using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@configuration", model_configuration);

                using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    if (dataTable.Rows.Count > 0)
                    {
                        DataRow row = dataTable.Rows[0];

                        string configuration = row["configuration"].ToString();
                        decimal engineCapacity = (decimal) row["engine_capacity"];
                        int cylindersNum = (int) row["cylinders_num"];
                        int power = (int) row["power"];
                        int maxSpeed = (int) row["max_speed"];
                        decimal accelerationTo100 = (decimal) row["acceleration_to_100"];
                        string gearboxType = row["gearbox_type"].ToString();
                        int gearsNum = (int) row["number_of_gears"];
                        decimal fuelConsumption = (decimal) row["fuel_consumption"];

                        labelConfiguration.Text = $"Конфігурація: {configuration}";
                        labelEngineCapacity.Text = $"Об'єм двигуна, л: {engineCapacity}";
                        labelCylindersNum.Text = $"Кількість циліндрів: {cylindersNum}";
                        labelPower.Text = $"Потужність: {power}";
                        labelMaxSpeed.Text = $"Максимальна швидкість, км/год: {maxSpeed}";
                        labelAccelerationTo100.Text = $"Розгін до 100 км/год, с: {accelerationTo100}";
                        labelGearboxType.Text = $"Тип коробки передач: {gearboxType}";
                        labelGearsNum.Text = $"Кількість передач: {gearsNum}";
                        labelFuelConsumption.Text = $"Витрати пального, л: {fuelConsumption}";
                    }
                    else
                    {
                        MessageBox.Show("Інформацію не знайдено");
                    }
                }
            }
        }
    }
}
