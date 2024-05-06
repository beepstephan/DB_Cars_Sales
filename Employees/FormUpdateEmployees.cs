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

namespace DB_Cars_Sales.Employees
{
    public partial class FormUpdateEmployees : Form
    {
        private Main mainForm;
        private const string connectionString = "Server=26.205.250.8;Port=5432;Database=mashinki; User Id = stas; Password = stas2002";
        private NpgsqlConnection connection;

        public FormUpdateEmployees(Main main, string fullname, string position, string phone, DateTime birthDateTime,
            string address, int salary, DateTime hireDateTime, int passportID, string dealershipJob)
        {
            InitializeComponent();
            connection = new NpgsqlConnection(connectionString);
            textBoxName.Text = fullname; comboBoxPosition.Text = position; textBoxPhone.Text = phone;
            dateTimePickerBirthDate.Value = birthDateTime; textBoxAddress.Text = address; numericUpDownSalary.Value = salary;
            dateTimePickerHireDate.Value = hireDateTime; textBoxPassportID.Text = passportID.ToString(); comboBoxDealership.Text = dealershipJob;
            mainForm = main;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "" || textBoxPhone.Text == "" || textBoxAddress.Text == "" ||
               textBoxPassportID.Text == "" || comboBoxPosition.Text == "" || comboBoxDealership.Text == "")
            {
                MessageBox.Show("Заповніть усі поля");
                return;
            }

            string searchDealershipName = "SELECT dealership_id FROM car_dealerships WHERE name = @name";
            string dealershipJob = comboBoxDealership.Text;
            int dealershipJobID;
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand command = new NpgsqlCommand(searchDealershipName, connection))
                {
                    command.Parameters.AddWithValue("@name", dealershipJob);
                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        dealershipJobID = Convert.ToInt32(result);

                        string updateEmployeeQuery = "UPDATE employees SET fullname = @fullname, position = @position, phone_number = @phone_number, " +
                            "birth_date = @birth_date::timestamp, address = @address, salary = @salary, hire_date = @hire_date::timestamp, " +
                            "dealership_job = @dealership_job WHERE passport_id = @passport_id";

                        using (NpgsqlCommand updateCommand = new NpgsqlCommand(updateEmployeeQuery, connection))
                        {
                            updateCommand.Parameters.AddWithValue("@fullname", textBoxName.Text.Trim());
                            updateCommand.Parameters.AddWithValue("@position", comboBoxPosition.Text.Trim());
                            updateCommand.Parameters.AddWithValue("@phone_number", textBoxPhone.Text.Trim());
                            updateCommand.Parameters.AddWithValue("@birth_date", dateTimePickerBirthDate.Value.ToString("yyyy-MM-dd"));
                            updateCommand.Parameters.AddWithValue("@address", textBoxAddress.Text.Trim());
                            updateCommand.Parameters.AddWithValue("@salary", (int) numericUpDownSalary.Value);
                            updateCommand.Parameters.AddWithValue("@hire_date", dateTimePickerHireDate.Value.ToString("yyyy-MM-dd"));
                            updateCommand.Parameters.AddWithValue("@passport_id", Int32.Parse(textBoxPassportID.Text));
                            updateCommand.Parameters.AddWithValue("@dealership_job", dealershipJobID);

                            int checkExecute = updateCommand.ExecuteNonQuery();
                            if (checkExecute != 0)
                            {
                                mainForm.RefreshEmployeessDataGridView();
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
                        Console.WriteLine("Автосалон з вказаним ім'ям не знайден.");
                    }
                }
            }

            this.Close();
        }
    }
}
