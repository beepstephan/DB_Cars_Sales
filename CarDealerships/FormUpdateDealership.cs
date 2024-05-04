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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace DB_Cars_Sales.CarDealerships
{
    public partial class FormUpdateDealership : Form
    {
        private Main mainForm;
        private const string connectionString = "Server=26.205.250.8;Port=5432;Database=mashinki; User Id = stas; Password = stas2002";
        private NpgsqlConnection connection;

        public FormUpdateDealership(Main main, string name, string phone, string email, string working_hours, string services, string address)
        {
            InitializeComponent();
            connection = new NpgsqlConnection(connectionString);
            textBoxName.Text = name; textBoxPhone.Text = phone; textBoxEmail.Text = email;
            textBoxWorkingHours.Text = working_hours; textBoxServices.Text = services; textBoxAddress.Text = address;
            mainForm = main;
        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "" || textBoxPhone.Text == "" || textBoxEmail.Text == "" ||
                textBoxWorkingHours.Text == "" || textBoxServices.Text == "" || textBoxAddress.Text == "")
            {
                MessageBox.Show("Заповніть усі поля");
                return;
            }

            try
            {
                connection.Open();

                string updateQuery = "UPDATE car_dealerships SET name = @name, phone = @phone, email = @email, working_hours = @workingHours, services = @services, address = @address WHERE email = @email";

                NpgsqlCommand updateQueryCommand = new NpgsqlCommand(updateQuery, connection);

                updateQueryCommand.Parameters.AddWithValue("@name", textBoxName.Text);
                updateQueryCommand.Parameters.AddWithValue("@phone", textBoxPhone.Text);
                updateQueryCommand.Parameters.AddWithValue("@email", textBoxEmail.Text);
                updateQueryCommand.Parameters.AddWithValue("@workingHours", textBoxWorkingHours.Text);
                updateQueryCommand.Parameters.AddWithValue("@services", textBoxServices.Text);
                updateQueryCommand.Parameters.AddWithValue("@address", textBoxAddress.Text);

                int checkExecute = updateQueryCommand.ExecuteNonQuery();
                if (checkExecute > 0)
                {
                    mainForm.RefreshCarDealershipsDataGridView();
                }
                else
                {
                    MessageBox.Show("Помилка оновлення");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            connection.Close();
            this.Close();
        }
    }
}
