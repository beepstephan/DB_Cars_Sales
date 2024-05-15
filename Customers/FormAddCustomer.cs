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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace DB_Cars_Sales.Customers
{

    public partial class FormAddCustomer : Form
    {
        private Main mainForm;
        private const string connectionString = "Server=26.205.250.8;Port=5432;Database=mashinki; User Id = stas; Password = stas2002";
        private NpgsqlConnection connection;
        public FormAddCustomer(Main main)
        {
            InitializeComponent();
            connection = new NpgsqlConnection(connectionString);
            mainForm = main;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string fullname = textBoxName.Text.Trim();
            string phone = textBoxPhone.Text.Trim();
            DateTime birthDateTime = dateTimePickerBirthDate.Value;
            string birthDate = birthDateTime.ToString("yyyy-MM-dd");
            string address = textBoxAddress.Text.Trim();
            int passportID = Convert.ToInt32(textBoxPassportID.Text.Trim());


            if (textBoxName.Text == "" || textBoxPhone.Text == "" || birthDate == "" || textBoxAddress.Text == "" || textBoxPassportID.Text == "" )
            {
                MessageBox.Show("Введіть дані в усі поля!");
                return;
            }

            try
            {
                connection.Open();

                string addQuery = "INSERT INTO customers (fullname, phone_number, address, birth_date, passport_num) VALUES (@fullname, @phone, @address, @birthDate::timestamp, @passportID)";

                NpgsqlCommand addQueryCommand = new NpgsqlCommand(addQuery, connection);

                addQueryCommand.Parameters.AddWithValue("@fullname", fullname);
                addQueryCommand.Parameters.AddWithValue("@phone", phone);
                addQueryCommand.Parameters.AddWithValue("@address", address);
                addQueryCommand.Parameters.AddWithValue("@birthDate", birthDate);
                addQueryCommand.Parameters.AddWithValue("@passportID", passportID);

                int checkExecute = addQueryCommand.ExecuteNonQuery();
                if (checkExecute > 0)
                {
                    mainForm.RefreshCustomershipsDataGridView();
                }
                else
                {
                    MessageBox.Show("неа!");
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Close();
        }
    }
}
