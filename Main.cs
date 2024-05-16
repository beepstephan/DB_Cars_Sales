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
using DB_Cars_Sales.CarDealerships;
using DB_Cars_Sales.Customers;
using DB_Cars_Sales.Employees;
using DB_Cars_Sales.Transactions;
using DB_Cars_Sales.CarModels;
using Npgsql;

namespace DB_Cars_Sales
{
    public partial class Main : Form
    {
        string connectionString = "Server=26.205.250.8;Port=5432;Database=mashinki; User Id = stas; Password = stas2002";

        public Main()
        {
            InitializeComponent();
            RefreshCarDealershipsDataGridView();
            RefreshCustomershipsDataGridView();
            RefreshEmployeessDataGridView();
            RefreshTransactionsDataGridView();
            RefreshModelsDataGridView();
            radioButtonCustomerSurname.Checked = true;
        }

        public void RefreshCarDealershipsDataGridView()
        {
            CarDealershipsDataGridView.DataSource = CarDealershipsSqlConnectionReader();
        }

        public void RefreshEmployeessDataGridView()
        {
            EmployeesDataGridView.DataSource = EmployeesSqlConnectionReader();
        }

        public void RefreshCustomershipsDataGridView()
        {
            CustomerDataGridView.DataSource = CustomerssSqlConnectionReader();
        }

        public void RefreshTransactionsDataGridView()
        {
            TransactionsDataGridView.DataSource = TransactionsSqlConnectionReader();
        }

        public void RefreshModelsDataGridView()
        {
            ModelsDataGridView.DataSource = ModelsSqlConnectionReader();
        }

        private DataTable CarDealershipsSqlConnectionReader()
        {

            string sql = "SELECT name, phone, email, working_hours, services, address FROM car_dealerships";
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sql, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }

        private DataTable EmployeesSqlConnectionReader()
        {

            string sql = "SELECT employees.fullname, employees.position, " +
                "employees.phone_number, employees.birth_date, " +
                "employees.address, employees.salary, " +
                "employees.hire_date, employees.passport_id, " +
                "car_dealerships.name AS dealership_name, " +
                "COUNT(transactions.employee_passport) AS total_sales " +
                "FROM employees " +
                "JOIN car_dealerships ON employees.dealership_job = car_dealerships.dealership_id " +
                "LEFT JOIN transactions ON employees.passport_id = transactions.employee_passport " +
                "GROUP BY employees.passport_id, car_dealerships.name;";
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sql, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }
        // с богом 
        private DataTable CustomerssSqlConnectionReader()
        {

            string sql = "SELECT * FROM customers";
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sql, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }

        }

        private DataTable TransactionsSqlConnectionReader()
        {

            string sql = "SELECT * FROM transactions";
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sql, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }

        }

        private DataTable ModelsSqlConnectionReader()
        {

            string sql = "SELECT * FROM car_models";
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sql, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("кулитии!");
        }

        private void buttonAddDealership_Click(object sender, EventArgs e)
        {
            FormAddDealership formAddDealership = new FormAddDealership(this);
            formAddDealership.ShowDialog();
        }


        private void buttonDeleteDealership_Click(object sender, EventArgs e)
        {
            NpgsqlConnection connection;
            connection = new NpgsqlConnection(connectionString);
            if (CarDealershipsDataGridView.SelectedRows.Count > 0)
            {

                int selectedRowIndex = CarDealershipsDataGridView.SelectedRows[0].Index;
                string emailToDelete = CarDealershipsDataGridView.SelectedRows[0].Cells["Email"].Value.ToString();


                CarDealershipsDataGridView.Rows.RemoveAt(selectedRowIndex);


                try
                {
                    connection.Open();
                    string sql = "DELETE FROM car_dealerships WHERE email = @email";
                    using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@email", emailToDelete);
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Укажіть рядок з автосалоном, який треба видалити!");
            }
        }

        private void buttonCustomerSearch_Click(object sender, EventArgs e)
        {
            NpgsqlConnection connection;
            connection = new NpgsqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = "";
                if (radioButtonCustomerSurname.Checked)
                {
                    query = "SELECT * FROM customers WHERE LOWER(fullname) LIKE LOWER(@fullname)";
                    NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@fullname", "%" + textBoxCustomerSearch.Text + "%");
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    CustomerDataGridView.DataSource = dt;
                }
                else if (radioButtonCustomerPhone.Checked)
                {
                    query = "SELECT * FROM customers WHERE phone_number LIKE @phone_number";
                    NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@phone_number", "%" + textBoxCustomerSearch.Text + "%");
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    CustomerDataGridView.DataSource = dt;
                }
                else if (radioButtonCustomerDate.Checked)
                {
                    query = "SELECT * FROM customers WHERE birth_date = @birth_date";
                    NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@birth_date", DateTime.Parse(textBoxCustomerSearch.Text));
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    CustomerDataGridView.DataSource = dt;
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void buttonUpdateDealership_Click(object sender, EventArgs e)
        {
            string name = CarDealershipsDataGridView.SelectedRows[0].Cells["name"].Value.ToString();
            string phone = CarDealershipsDataGridView.SelectedRows[0].Cells["phone"].Value.ToString();
            string email = CarDealershipsDataGridView.SelectedRows[0].Cells["email"].Value.ToString();
            string working_hours = CarDealershipsDataGridView.SelectedRows[0].Cells["working_hours"].Value.ToString();
            string services = CarDealershipsDataGridView.SelectedRows[0].Cells["services"].Value.ToString();
            string address = CarDealershipsDataGridView.SelectedRows[0].Cells["address"].Value.ToString();
            FormUpdateDealership formUpdateDealership = new FormUpdateDealership(this, name, phone, email, working_hours, services, address);
            formUpdateDealership.ShowDialog();
        }

        private void CarDealershipsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (CarDealershipsDataGridView.SelectedRows.Count == 1)
                buttonUpdateDealership.Enabled = true;
            else
                buttonUpdateDealership.Enabled = false;
        }

        private void textBoxEmployeeSearch_TextChanged(object sender, EventArgs e)
        {
            string name = textBoxEmployeeSearch.Text.Trim();
            string searchQuery;
            if (string.IsNullOrWhiteSpace(name))
            {
                searchQuery = "SELECT employees.fullname, employees.position, " +
                "employees.phone_number, employees.birth_date, " +
                "employees.address, employees.salary, " +
                "employees.hire_date, employees.passport_id, " +
                "car_dealerships.name AS dealership_name, " +
                "COUNT(transactions.employee_passport) AS total_sales " +
                "FROM employees " +
                "JOIN car_dealerships ON employees.dealership_job = car_dealerships.dealership_id " +
                "LEFT JOIN transactions ON employees.passport_id = transactions.employee_passport " +
                "GROUP BY employees.passport_id, car_dealerships.name;";
            }
            else
            {
                searchQuery = "SELECT employees.fullname, employees.position, " +
                "employees.phone_number, employees.birth_date, " +
                "employees.address, employees.salary, " +
                "employees.hire_date, employees.passport_id, " +
                "car_dealerships.name AS dealership_name, " +
                "COUNT(transactions.employee_passport) AS total_sales " +
                "FROM employees " +
                "JOIN car_dealerships ON employees.dealership_job = car_dealerships.dealership_id " +
                "LEFT JOIN transactions ON employees.passport_id = transactions.employee_passport " +
                "WHERE LOWER(employees.fullname) LIKE LOWER(@name) " +
                "GROUP BY employees.passport_id, car_dealerships.name;";
            }
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                using (NpgsqlCommand command = new NpgsqlCommand(searchQuery, connection))
                {
                    connection.Open();

                    if (!string.IsNullOrWhiteSpace(name))
                        command.Parameters.AddWithValue("@name", "%" + name + "%");

                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        EmployeesDataGridView.DataSource = dataTable;
                    }
                }
            }
        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            FormAddEmployee formAddEmployee = new FormAddEmployee(this);
            formAddEmployee.ShowDialog();
        }

        private void buttonDeleteEmployee_Click(object sender, EventArgs e)
        {
            NpgsqlConnection connection;
            connection = new NpgsqlConnection(connectionString);
            int selectedRowIndex = EmployeesDataGridView.SelectedRows[0].Index;
            int idToDelete = Convert.ToInt32(EmployeesDataGridView.SelectedRows[0].Cells["passport_id"].Value);


            EmployeesDataGridView.Rows.RemoveAt(selectedRowIndex);


            try
            {
                connection.Open();
                string sql = "DELETE FROM employees WHERE passport_id = @id";
                using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", idToDelete);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void EmployeesDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (EmployeesDataGridView.SelectedRows.Count == 1)
            {
                buttonDeleteEmployee.Enabled = true;
                buttonUpdateEmployee.Enabled = true;
            }
            else
            {
                buttonDeleteEmployee.Enabled = false;
                buttonUpdateEmployee.Enabled = false;
            }
        }

        private void buttonUpdateEmployee_Click(object sender, EventArgs e)
        {
            string fullname = EmployeesDataGridView.SelectedRows[0].Cells["fullname"].Value.ToString();
            string position = EmployeesDataGridView.SelectedRows[0].Cells["position"].Value.ToString();
            string phone = EmployeesDataGridView.SelectedRows[0].Cells["phone_number"].Value.ToString();
            DateTime birthDateTime = DateTime.Parse(EmployeesDataGridView.SelectedRows[0].Cells["birth_date"].Value.ToString());
            string address = EmployeesDataGridView.SelectedRows[0].Cells["address"].Value.ToString();
            int salary = (int)EmployeesDataGridView.SelectedRows[0].Cells["salary"].Value;
            DateTime hireDateTime = DateTime.Parse(EmployeesDataGridView.SelectedRows[0].Cells["hire_date"].Value.ToString());
            int passportID = (int)EmployeesDataGridView.SelectedRows[0].Cells["passport_id"].Value;
            string dealershipJob = EmployeesDataGridView.SelectedRows[0].Cells["dealership_name"].Value.ToString();

            FormUpdateEmployees formUpdateEmployees = new FormUpdateEmployees(this, fullname, position, phone, birthDateTime, address,
                salary, hireDateTime, passportID, dealershipJob);
            formUpdateEmployees.ShowDialog();
        }

        private void TransactionsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (TransactionsDataGridView.SelectedRows.Count == 1)
            {
                buttonCheckInfoTransaction.Enabled = true;
                buttonDeleteTransaction.Enabled = true;
            }
            else
            {
                buttonCheckInfoTransaction.Enabled = false;
                buttonDeleteTransaction.Enabled = false;
            }
        }

        private void buttonAddTransaction_Click(object sender, EventArgs e)
        {
            FormAddTransaction formAddTransaction = new FormAddTransaction(this);
            formAddTransaction.ShowDialog();
        }

        private void buttonDeleteTransaction_Click(object sender, EventArgs e)
        {
            NpgsqlConnection connection;
            connection = new NpgsqlConnection(connectionString);
            int selectedRowIndex = TransactionsDataGridView.SelectedRows[0].Index;
            int idToDelete = Convert.ToInt32(TransactionsDataGridView.SelectedRows[0].Cells["transaction_id"].Value);


            TransactionsDataGridView.Rows.RemoveAt(selectedRowIndex);


            try
            {
                connection.Open();
                string sql = "DELETE FROM transactions WHERE transaction_id = @id";
                using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", idToDelete);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void buttonCheckInfoTransaction_Click(object sender, EventArgs e)
        {
            int customerPassport = (int)TransactionsDataGridView.SelectedRows[0].Cells["customer_passport"].Value;
            int employeePassport = (int)TransactionsDataGridView.SelectedRows[0].Cells["employee_passport"].Value;
            int serviceId = (int)TransactionsDataGridView.SelectedRows[0].Cells["service_id"].Value;
            int dealershipId = (int)TransactionsDataGridView.SelectedRows[0].Cells["dealership_id"].Value;
            string VIN = TransactionsDataGridView.SelectedRows[0].Cells["vin"].Value.ToString();
            int transactionId = (int)TransactionsDataGridView.SelectedRows[0].Cells["transaction_id"].Value;
            FormCheckInfoTransaction formCheckInfoTransaction = new FormCheckInfoTransaction(this, transactionId);
            formCheckInfoTransaction.ShowDialog();
        }

        private void buttonAddModel_Click(object sender, EventArgs e)
        {
            FormAddModel formAddModel = new FormAddModel(this);
            formAddModel.ShowDialog();
        }

        private void buttonDeleteModel_Click(object sender, EventArgs e)
        {
            NpgsqlConnection connection;
            connection = new NpgsqlConnection(connectionString);
            int selectedRowIndex = ModelsDataGridView.SelectedRows[0].Index;
            string idToDelete = ModelsDataGridView.SelectedRows[0].Cells["configuration"].Value.ToString();

            ModelsDataGridView.Rows.RemoveAt(selectedRowIndex);

            try
            {
                connection.Open();
                string sql = "DELETE FROM model_info WHERE configuration = @configuration";
                string sql2 = "DELETE FROM car_models WHERE configuration = @configuration";
                using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@configuration", idToDelete);
                    command.ExecuteNonQuery();
                }
                using (NpgsqlCommand command = new NpgsqlCommand(sql2, connection))
                {
                    command.Parameters.AddWithValue("@configuration", idToDelete);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ModelsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (ModelsDataGridView.SelectedRows.Count == 1)
            {
                buttonDeleteModel.Enabled = true;
                buttonModelDetails.Enabled = true;
            }
            else
            {
                buttonDeleteModel.Enabled = false;
                buttonModelDetails.Enabled = false;
            }
        }

        private void buttonAddClient_Click(object sender, EventArgs e)
        {
            FormAddCustomer formAddCustomer = new FormAddCustomer(this);
            formAddCustomer.ShowDialog();
        }

        private void buttonUpdateClient_Click(object sender, EventArgs e)
        {
            string fullname = CustomerDataGridView.SelectedRows[0].Cells["fullname"].Value.ToString();
            string phone = CustomerDataGridView.SelectedRows[0].Cells["phone_number"].Value.ToString();
            DateTime birthDateTime = DateTime.Parse(CustomerDataGridView.SelectedRows[0].Cells["birth_date"].Value.ToString());
            string address = CustomerDataGridView.SelectedRows[0].Cells["address"].Value.ToString();
            int passportID = (int)CustomerDataGridView.SelectedRows[0].Cells["passport_num"].Value;
            FormUpdateCustomer formUpdateCustomer = new FormUpdateCustomer(this, fullname, phone, address, birthDateTime, passportID);
            formUpdateCustomer.ShowDialog();
        }

        private void CustomerDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (CustomerDataGridView.SelectedRows.Count == 1)
            {
                buttonUpdateClient.Enabled = true;
                buttonDeleteClient.Enabled = true;
            }
            else
            {
                buttonUpdateClient.Enabled = false;
                buttonDeleteClient.Enabled = false;
            }
        }

        private void buttonDeleteClient_Click(object sender, EventArgs e)
        {
            NpgsqlConnection connection;
            connection = new NpgsqlConnection(connectionString);
            if (CustomerDataGridView.SelectedRows.Count == 1)
            {

                int selectedRowIndex = CustomerDataGridView.SelectedRows[0].Index;
                int passportToDelete = (int)CustomerDataGridView.SelectedRows[0].Cells["passport_num"].Value;


                CustomerDataGridView.Rows.RemoveAt(selectedRowIndex);


                try
                {
                    connection.Open();
                    string sql = "DELETE FROM customers WHERE passport_num = @passport_num";
                    using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@passport_num", passportToDelete);
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Укажіть рядок з клієнтом, який треба видалити!");
            }
        }

        private void buttonModelDetails_Click(object sender, EventArgs e)
        {
            string configuration = ModelsDataGridView.SelectedRows[0].Cells["configuration"].Value.ToString();
            FormCheckInfoCarModels formCheckInfoCarModels = new FormCheckInfoCarModels(configuration);
            formCheckInfoCarModels.ShowDialog();
        }
    }
}
