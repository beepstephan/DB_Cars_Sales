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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DB_Cars_Sales.Transactions
{
    public partial class FormAddTransaction : Form
    {
        private Main mainForm;

        private const string connectionString = "Server=26.205.250.8;Port=5432;Database=mashinki; User Id = stas; Password = stas2002";
        private NpgsqlConnection connection;
        public FormAddTransaction(Main main)
        {
            InitializeComponent();
            mainForm = main;
            SearchCustomers();
            SearchEmployees();

            comboBoxCarDealership.SelectedIndex = 0;
        }

        private void SearchCustomers()
        {
            string searchCustomerName = "SELECT fullname FROM customers";
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand(searchCustomerName, connection);
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);
                DataTable table = new DataTable();

                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    comboBoxCustomer.DataSource = table;
                    comboBoxCustomer.DisplayMember = "fullname";
                    comboBoxCustomer.ValueMember = "fullname";
                }
            }
        }

        private void SearchEmployees()
        {
            string searchCustomerName = "SELECT fullname FROM employees";
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand(searchCustomerName, connection);
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);
                DataTable table = new DataTable();

                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    comboBoxEmployee.DataSource = table;
                    comboBoxEmployee.DisplayMember = "fullname";
                    comboBoxEmployee.ValueMember = "fullname";
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string VIN = textBoxVIN.Text.Trim();
            string customer = comboBoxCustomer.Text.Trim();
            string employee = comboBoxEmployee.Text.Trim();
            string carDealershop = comboBoxCarDealership.Text.Trim();
            string serviceName = textBoxServiceName.Text.Trim();
            int servicePrice = (int) numericUpDownServicePrice.Value;
            string serviceDescription = richTextBoxServiceDescription.Text;

            string customerPassportQuery = "SELECT passport_num FROM customers WHERE fullname = @fullname";
            string employeePassportQuery = "SELECT passport_id FROM employees WHERE fullname = @fullname";
            string dealershipQuery = "SELECT dealership_id FROM car_dealerships WHERE name = @name";
            string addServiceQuery = "INSERT INTO service (service_name, service_description, service_price) VALUES (@service_name, @service_description, @service_price)";
            string serviceQuery = "SELECT service_id FROM service WHERE service_name = @service_name AND service_description = @service_description AND service_price = @service_price";
            string addTransactionQuery = "INSERT INTO transactions (vin, customer_passport, employee_passport, service_id, dealership_id) VALUES (@vin, @customerPassport, @employeePassport, @serviceId, @dealershipId)";
            string addTransactionWithoutServiceQuery = "INSERT INTO transactions (vin, customer_passport, employee_passport, dealership_id) VALUES (@vin, @customerPassport, @employeePassport, @dealershipId)";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                int customerPassport = 0;
                using (NpgsqlCommand customerPassportCommand = new NpgsqlCommand(customerPassportQuery, connection))
                {
                    customerPassportCommand.Parameters.AddWithValue("@fullname", customer);
                    object customerResult = customerPassportCommand.ExecuteScalar();
                    if (customerResult != null && customerResult != DBNull.Value)
                    {
                        customerPassport = (int)customerResult;

                        int employeePassport = 0;
                        using (NpgsqlCommand employeePassportCommand = new NpgsqlCommand(employeePassportQuery, connection))
                        {
                            employeePassportCommand.Parameters.AddWithValue("@fullname", employee);
                            object employeeResult = employeePassportCommand.ExecuteScalar();
                            if (employeeResult != null && employeeResult != DBNull.Value)
                            {
                                employeePassport = (int)employeeResult;

                                int dealershipId = 0;
                                using (NpgsqlCommand dealershipIdCommand = new NpgsqlCommand(dealershipQuery, connection))
                                {
                                    dealershipIdCommand.Parameters.AddWithValue("@name", carDealershop);
                                    object dealershipResult = dealershipIdCommand.ExecuteScalar();
                                    if (dealershipResult != null && dealershipResult != DBNull.Value)
                                    {
                                        dealershipId = (int)dealershipResult;

                                        int serviceId = -1;
                                        if (serviceName.Length > 0)
                                        {
                                            using (NpgsqlCommand insertServiceCommand = new NpgsqlCommand(addServiceQuery, connection))
                                            {
                                                insertServiceCommand.Parameters.AddWithValue("service_name", serviceName);
                                                insertServiceCommand.Parameters.AddWithValue("service_description", serviceDescription);
                                                insertServiceCommand.Parameters.AddWithValue("service_price", servicePrice);

                                                int checkExecute = insertServiceCommand.ExecuteNonQuery();
                                                if (checkExecute > 0)
                                                {
                                                    using (NpgsqlCommand searchServiceCommand = new NpgsqlCommand(serviceQuery, connection))
                                                    {
                                                        searchServiceCommand.Parameters.AddWithValue("service_name", serviceName);
                                                        searchServiceCommand.Parameters.AddWithValue("service_description", serviceDescription);
                                                        searchServiceCommand.Parameters.AddWithValue("service_price", servicePrice);

                                                        object serviceResult = searchServiceCommand.ExecuteScalar();
                                                        if (serviceResult != null && serviceResult != DBNull.Value)
                                                        {
                                                            serviceId = (int)serviceResult;

                                                            using (NpgsqlCommand command = new NpgsqlCommand(addTransactionQuery, connection))
                                                            {
                                                                command.Parameters.AddWithValue("@vin", VIN);
                                                                command.Parameters.AddWithValue("@customerPassport", customerPassport);
                                                                command.Parameters.AddWithValue("@employeePassport", employeePassport);
                                                                command.Parameters.AddWithValue("@dealershipId", dealershipId);
                                                                command.Parameters.AddWithValue("@serviceId", serviceId);

                                                                int rowsAffected = command.ExecuteNonQuery();
                                                                if (rowsAffected > 0)
                                                                {
                                                                    mainForm.RefreshTransactionsDataGridView();
                                                                    this.Close();
                                                                }
                                                                else
                                                                {
                                                                    MessageBox.Show("Помилка додавання транзакту");
                                                                }
                                                            }
                                                        }
                                                        else MessageBox.Show("Сервіс не знайдено");
                                                    }
                                                }
                                                else MessageBox.Show("Помилка додавання сервісу");
                                            }

                                        }
                                        else
                                        {
                                            using (NpgsqlCommand command = new NpgsqlCommand(addTransactionWithoutServiceQuery, connection))
                                            {
                                                command.Parameters.AddWithValue("@vin", VIN);
                                                command.Parameters.AddWithValue("@customerPassport", customerPassport);
                                                command.Parameters.AddWithValue("@employeePassport", employeePassport);
                                                command.Parameters.AddWithValue("@dealershipId", dealershipId);

                                                int rowsAffected = command.ExecuteNonQuery();
                                                if (rowsAffected > 0)
                                                {
                                                    mainForm.RefreshTransactionsDataGridView();
                                                    this.Close();
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Помилка додавання транзакту");
                                                }
                                            }
                                        }
                                    }
                                    else MessageBox.Show("Автосалон не знайдено");
                                }
                            }
                            else MessageBox.Show("Продавець не знайдений");
                        }

                    }
                    else MessageBox.Show("Покупець не знайдений");
                }

                
            }

        }
    }
}
