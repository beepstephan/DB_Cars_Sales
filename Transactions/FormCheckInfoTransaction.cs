using Npgsql;
using System.Data;


namespace DB_Cars_Sales.Transactions
{
    public partial class FormCheckInfoTransaction : Form
    {
        private Main mainForm;
        private const string connectionString = "Server=26.205.250.8;Port=5432;Database=mashinki; User Id = stas; Password = stas2002";
        private NpgsqlConnection connection;
        public FormCheckInfoTransaction(Main main, int transactionId)
        {
            InitializeComponent();
            connection = new NpgsqlConnection(connectionString);
            mainForm = main;
            string sql = "SELECT cars.brand, cars.model, cars.price, " +
                "customers.fullname AS customer_name, " +
                "employees.fullname AS employee_name, car_dealerships.name AS dealership_name, " +
                "service.service_name, service.service_description, service.service_price " +
                "FROM cars JOIN transactions ON cars.vin = transactions.vin " +
                "JOIN customers ON transactions.customer_passport = customers.passport_num " +
                "JOIN employees ON transactions.employee_passport = employees.passport_id " +
                "JOIN car_dealerships ON transactions.dealership_id = car_dealerships.dealership_id " +
                "JOIN service ON transactions.service_id = service.service_id " +
                "WHERE transactions.transaction_id = @id;";
            using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
            {
                // Добавляем параметр @id
                command.Parameters.AddWithValue("@id", transactionId);

                using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    if (dataTable.Rows.Count > 0)
                    {
                        // Получаем первую строку данных
                        DataRow row = dataTable.Rows[0];

                        // Извлекаем значения из столбцов по их именам
                        string brand = row["brand"].ToString();
                        string model = row["model"].ToString();
                        decimal price = Convert.ToDecimal(row["price"]);
                        string customerName = row["customer_name"].ToString();
                        string employeeName = row["employee_name"].ToString();
                        string dealershipName = row["dealership_name"].ToString();
                        string serviceName = row["service_name"].ToString();
                        string serviceDescription = row["service_description"].ToString();
                        decimal servicePrice = Convert.ToDecimal(row["service_price"]);

                        labelBrand.Text = "Марка авто: " + brand;
                        labelModel.Text = "Модель авто: " + model;
                        labelЗPrice.Text = "Ціна авто: " + price;
                        labelCustomerName.Text = "Покупець авто: " + customerName;
                        labelEmployeeName.Text = "Продавець авто: " + employeeName;
                        labelDealershipName.Text = "Автосалон, який продав авто: " + dealershipName;
                        labelService.Text = "Деталі сервісу авто: " + serviceDescription;
                    }
                    else
                    {
                        // В случае отсутствия данных можно выполнить какие-то действия или вывести сообщение об ошибке
                    }
                }
            }


        }

        

    }
}
