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

namespace DB_Cars_Sales
{
    public partial class FormAddDealership : Form
    {
        private Main mainForm;
        
        private const string connectionString = "Server=26.205.250.8;Port=5432;Database=mashinki; User Id = stas; Password = stas2002";
        private NpgsqlConnection connection;



        public FormAddDealership(Main main)
        {
            InitializeComponent();
            connection = new NpgsqlConnection(connectionString);
            mainForm = main;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text.Trim();
            string phone = textBoxPhone.Text.Trim();
            string email = textBoxEmail.Text.Trim();
            string workingHours = textBoxWorkingHours.Text.Trim();
            string services = textBoxServices.Text.Trim();
            string address = textBoxAddress.Text.Trim();

            if (name == "" || phone == "" || email == "" || workingHours == "" || services == "" || address == "")
            {
                MessageBox.Show("Введіть дані в усі поля!");
                return;
            }

            try
            {
                connection.Open();

                string addQuery = "INSERT INTO car_dealerships (name, phone, email, working_hours, services, address) VALUES (@name, @phone, @email, @workingHours, @services, @address)";
                
                NpgsqlCommand addQueryCommand = new NpgsqlCommand(addQuery, connection);
                
                addQueryCommand.Parameters.AddWithValue("@name", name);
                addQueryCommand.Parameters.AddWithValue("@phone", phone);
                addQueryCommand.Parameters.AddWithValue("@email", email);
                addQueryCommand.Parameters.AddWithValue("@workingHours", workingHours);
                addQueryCommand.Parameters.AddWithValue("@services", services);
                addQueryCommand.Parameters.AddWithValue("@address", address);

                int checkExecute = addQueryCommand.ExecuteNonQuery();
                if (checkExecute > 0)
                {
                    MessageBox.Show("все охуенно!");
                    mainForm.RefreshDataGridView();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("все хуево!");
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }
        private void ClearFields()
        {
            textBoxName.Clear();
            textBoxPhone.Clear();
            textBoxEmail.Clear();
            textBoxWorkingHours.Clear();
            textBoxServices.Clear();
            textBoxAddress.Clear();
        }
    }
}
