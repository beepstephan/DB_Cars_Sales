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

namespace DB_Cars_Sales.Customers
{
    public partial class FormUpdateCustomer : Form
    {
        private Main mainForm;
        private const string connectionString = "Server=26.205.250.8;Port=5432;Database=mashinki; User Id = stas; Password = stas2002";
        private NpgsqlConnection connection;
        public FormUpdateCustomer(Main main, string fullname, string phone, string address, DateTime birthDateTime, int passportID)
        {
            InitializeComponent();
            connection = new NpgsqlConnection(connectionString);
            mainForm = main;
            textBoxName.Text = fullname;
            textBoxPhone.Text = phone;
            textBoxAddress.Text = address;
            dateTimePickerBirthDate.Value = birthDateTime;
            textBoxPassportID.Text = passportID.ToString();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "" || textBoxPhone.Text == "" || textBoxAddress.Text == "" ||
                dateTimePickerBirthDate.Text == "" || textBoxPassportID.Text == "")
            {
                MessageBox.Show("Заповніть усі поля");
                return;
            }

            try
            {
                connection.Open();

                string updateQuery = "UPDATE customers SET fullname = @fullname, phone_number = @phone_number, address = @address, birth_date = @birth_date::timestamp WHERE passport_num = @passport_num";

                NpgsqlCommand updateQueryCommand = new NpgsqlCommand(updateQuery, connection);

                updateQueryCommand.Parameters.AddWithValue("@fullname", textBoxName.Text);
                updateQueryCommand.Parameters.AddWithValue("@phone_number", textBoxPhone.Text);
                updateQueryCommand.Parameters.AddWithValue("@address", textBoxAddress.Text);
                updateQueryCommand.Parameters.AddWithValue("@birth_date", dateTimePickerBirthDate.Value.ToString("yyyy-MM-dd"));
                updateQueryCommand.Parameters.AddWithValue("@passport_num", Int32.Parse(textBoxPassportID.Text));

                int checkExecute = updateQueryCommand.ExecuteNonQuery();
                if (checkExecute > 0)
                {
                    mainForm.RefreshCustomershipsDataGridView();
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
