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

namespace DB_Cars_Sales.Employees
{
    public partial class FormAddEmployee : Form
    {
        private Main mainForm;

        private const string connectionString = "Server=26.205.250.8;Port=5432;Database=mashinki; User Id = stas; Password = stas2002";
        private NpgsqlConnection connection;
        public FormAddEmployee(Main main)
        {
            InitializeComponent();
            connection = new NpgsqlConnection(connectionString);
            mainForm = main;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string fullname = textBoxName.Text.Trim();
            string position = comboBoxPosition.Text.Trim();
            string phone = textBoxPhone.Text.Trim();
            DateTime birthDateTime = dateTimePickerBirthDate.Value;
            string birthDate = birthDateTime.ToString("yyyy-MM-dd");
            string address = textBoxAddress.Text.Trim();
            int salary = Convert.ToInt32(numericUpDownSalary.Value);
            DateTime hireDateTime = dateTimePickerHireDate.Value;
            string hireDate = hireDateTime.ToString("yyyy-MM-dd");
            int passportID = Convert.ToInt32(textBoxPassportID.Text.Trim());
            string dealershipJob = comboBoxDealership.Text.Trim();

            string searchDealershipID = "SELECT dealership_id FROM car_dealerships WHERE name = @name";
            int dealershipJobID;
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand command = new NpgsqlCommand(searchDealershipID, connection))
                {
                    command.Parameters.AddWithValue("@name", dealershipJob);
                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        dealershipJobID = Convert.ToInt32(result);

                        string insertEmployeeQuery = "INSERT INTO employees (fullname, position, phone_number, birth_date, address, salary, hire_date, passport_id, dealership_job) " +
                            "VALUES (@fullname, @position, @phone_number, @birth_date::timestamp, @address, @salary, @hire_date::timestamp, @passport_id, @dealership_job)";

                        using (NpgsqlCommand insertCommand = new NpgsqlCommand(insertEmployeeQuery, connection))
                        {
                            insertCommand.Parameters.AddWithValue("@fullname", fullname);
                            insertCommand.Parameters.AddWithValue("@position", position);
                            insertCommand.Parameters.AddWithValue("@phone_number", phone);
                            insertCommand.Parameters.AddWithValue("@birth_date", birthDate);
                            insertCommand.Parameters.AddWithValue("@address", address);
                            insertCommand.Parameters.AddWithValue("@salary", salary);
                            insertCommand.Parameters.AddWithValue("@hire_date", hireDate);
                            insertCommand.Parameters.AddWithValue("@passport_id", passportID);
                            insertCommand.Parameters.AddWithValue("@dealership_job", dealershipJobID);
                            
                            int checkExecute = insertCommand.ExecuteNonQuery();
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
        }

        
    }
}
