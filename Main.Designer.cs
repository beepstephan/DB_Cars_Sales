namespace DB_Cars_Sales
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageCars = new System.Windows.Forms.TabPage();
            this.CarsDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPageCarModels = new System.Windows.Forms.TabPage();
            this.buttonModelDetails = new System.Windows.Forms.Button();
            this.buttonDeleteModel = new System.Windows.Forms.Button();
            this.buttonAddModel = new System.Windows.Forms.Button();
            this.ModelsDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPageCarDealerships = new System.Windows.Forms.TabPage();
            this.buttonUpdateDealership = new System.Windows.Forms.Button();
            this.buttonDeleteDealership = new System.Windows.Forms.Button();
            this.buttonAddDealership = new System.Windows.Forms.Button();
            this.CarDealershipsDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPageEmployees = new System.Windows.Forms.TabPage();
            this.buttonUpdateEmployee = new System.Windows.Forms.Button();
            this.buttonDeleteEmployee = new System.Windows.Forms.Button();
            this.buttonAddEmployee = new System.Windows.Forms.Button();
            this.labelEmployeeSearch = new System.Windows.Forms.Label();
            this.textBoxEmployeeSearch = new System.Windows.Forms.TextBox();
            this.EmployeesDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPageCustomers = new System.Windows.Forms.TabPage();
            this.buttonDeleteClient = new System.Windows.Forms.Button();
            this.buttonUpdateClient = new System.Windows.Forms.Button();
            this.buttonAddClient = new System.Windows.Forms.Button();
            this.labelCustomerSearch = new System.Windows.Forms.Label();
            this.buttonCustomerSearch = new System.Windows.Forms.Button();
            this.textBoxCustomerSearch = new System.Windows.Forms.TextBox();
            this.radioButtonCustomerDate = new System.Windows.Forms.RadioButton();
            this.radioButtonCustomerPhone = new System.Windows.Forms.RadioButton();
            this.radioButtonCustomerSurname = new System.Windows.Forms.RadioButton();
            this.CustomerDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPageTransactions = new System.Windows.Forms.TabPage();
            this.buttonCheckInfoTransaction = new System.Windows.Forms.Button();
            this.buttonDeleteTransaction = new System.Windows.Forms.Button();
            this.buttonAddTransaction = new System.Windows.Forms.Button();
            this.TransactionsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPageCars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarsDataGridView)).BeginInit();
            this.tabPageCarModels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ModelsDataGridView)).BeginInit();
            this.tabPageCarDealerships.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarDealershipsDataGridView)).BeginInit();
            this.tabPageEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesDataGridView)).BeginInit();
            this.tabPageCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDataGridView)).BeginInit();
            this.tabPageTransactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageCars);
            this.tabControl1.Controls.Add(this.tabPageCarModels);
            this.tabControl1.Controls.Add(this.tabPageCarDealerships);
            this.tabControl1.Controls.Add(this.tabPageEmployees);
            this.tabControl1.Controls.Add(this.tabPageCustomers);
            this.tabControl1.Controls.Add(this.tabPageTransactions);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1054, 596);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageCars
            // 
            this.tabPageCars.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tabPageCars.Controls.Add(this.CarsDataGridView);
            this.tabPageCars.ForeColor = System.Drawing.Color.Coral;
            this.tabPageCars.Location = new System.Drawing.Point(4, 24);
            this.tabPageCars.Name = "tabPageCars";
            this.tabPageCars.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCars.Size = new System.Drawing.Size(1046, 568);
            this.tabPageCars.TabIndex = 0;
            this.tabPageCars.Text = "Автомобілі";
            // 
            // CarsDataGridView
            // 
            this.CarsDataGridView.AllowUserToAddRows = false;
            this.CarsDataGridView.AllowUserToDeleteRows = false;
            this.CarsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CarsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.CarsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarsDataGridView.Location = new System.Drawing.Point(0, 86);
            this.CarsDataGridView.Name = "CarsDataGridView";
            this.CarsDataGridView.ReadOnly = true;
            this.CarsDataGridView.RowHeadersWidth = 51;
            this.CarsDataGridView.RowTemplate.Height = 25;
            this.CarsDataGridView.Size = new System.Drawing.Size(1046, 482);
            this.CarsDataGridView.TabIndex = 3;
            // 
            // tabPageCarModels
            // 
            this.tabPageCarModels.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tabPageCarModels.Controls.Add(this.buttonModelDetails);
            this.tabPageCarModels.Controls.Add(this.buttonDeleteModel);
            this.tabPageCarModels.Controls.Add(this.buttonAddModel);
            this.tabPageCarModels.Controls.Add(this.ModelsDataGridView);
            this.tabPageCarModels.Location = new System.Drawing.Point(4, 24);
            this.tabPageCarModels.Name = "tabPageCarModels";
            this.tabPageCarModels.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCarModels.Size = new System.Drawing.Size(1046, 568);
            this.tabPageCarModels.TabIndex = 1;
            this.tabPageCarModels.Text = "Моделі автомобілей";
            // 
            // buttonModelDetails
            // 
            this.buttonModelDetails.Location = new System.Drawing.Point(920, 20);
            this.buttonModelDetails.Name = "buttonModelDetails";
            this.buttonModelDetails.Size = new System.Drawing.Size(98, 44);
            this.buttonModelDetails.TabIndex = 15;
            this.buttonModelDetails.Text = "Деталі";
            this.buttonModelDetails.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteModel
            // 
            this.buttonDeleteModel.Location = new System.Drawing.Point(797, 20);
            this.buttonDeleteModel.Name = "buttonDeleteModel";
            this.buttonDeleteModel.Size = new System.Drawing.Size(98, 44);
            this.buttonDeleteModel.TabIndex = 14;
            this.buttonDeleteModel.Text = "Видалити модель";
            this.buttonDeleteModel.UseVisualStyleBackColor = true;
            // 
            // buttonAddModel
            // 
            this.buttonAddModel.Location = new System.Drawing.Point(667, 20);
            this.buttonAddModel.Name = "buttonAddModel";
            this.buttonAddModel.Size = new System.Drawing.Size(98, 44);
            this.buttonAddModel.TabIndex = 13;
            this.buttonAddModel.Text = "Додати модель";
            this.buttonAddModel.UseVisualStyleBackColor = true;
            // 
            // ModelsDataGridView
            // 
            this.ModelsDataGridView.AllowUserToAddRows = false;
            this.ModelsDataGridView.AllowUserToDeleteRows = false;
            this.ModelsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ModelsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.ModelsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ModelsDataGridView.Location = new System.Drawing.Point(0, 86);
            this.ModelsDataGridView.Name = "ModelsDataGridView";
            this.ModelsDataGridView.ReadOnly = true;
            this.ModelsDataGridView.RowHeadersWidth = 51;
            this.ModelsDataGridView.RowTemplate.Height = 25;
            this.ModelsDataGridView.Size = new System.Drawing.Size(1046, 482);
            this.ModelsDataGridView.TabIndex = 2;
            // 
            // tabPageCarDealerships
            // 
            this.tabPageCarDealerships.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tabPageCarDealerships.Controls.Add(this.buttonUpdateDealership);
            this.tabPageCarDealerships.Controls.Add(this.buttonDeleteDealership);
            this.tabPageCarDealerships.Controls.Add(this.buttonAddDealership);
            this.tabPageCarDealerships.Controls.Add(this.CarDealershipsDataGridView);
            this.tabPageCarDealerships.Location = new System.Drawing.Point(4, 24);
            this.tabPageCarDealerships.Name = "tabPageCarDealerships";
            this.tabPageCarDealerships.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCarDealerships.Size = new System.Drawing.Size(1046, 568);
            this.tabPageCarDealerships.TabIndex = 2;
            this.tabPageCarDealerships.Text = "Автосалони";
            // 
            // buttonUpdateDealership
            // 
            this.buttonUpdateDealership.Location = new System.Drawing.Point(8, 115);
            this.buttonUpdateDealership.Name = "buttonUpdateDealership";
            this.buttonUpdateDealership.Size = new System.Drawing.Size(98, 44);
            this.buttonUpdateDealership.TabIndex = 4;
            this.buttonUpdateDealership.Text = "Оновити дані";
            this.buttonUpdateDealership.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteDealership
            // 
            this.buttonDeleteDealership.Location = new System.Drawing.Point(8, 65);
            this.buttonDeleteDealership.Name = "buttonDeleteDealership";
            this.buttonDeleteDealership.Size = new System.Drawing.Size(98, 44);
            this.buttonDeleteDealership.TabIndex = 3;
            this.buttonDeleteDealership.Text = "Видалити автосалон";
            this.buttonDeleteDealership.UseVisualStyleBackColor = true;
            // 
            // buttonAddDealership
            // 
            this.buttonAddDealership.Location = new System.Drawing.Point(8, 15);
            this.buttonAddDealership.Name = "buttonAddDealership";
            this.buttonAddDealership.Size = new System.Drawing.Size(98, 44);
            this.buttonAddDealership.TabIndex = 2;
            this.buttonAddDealership.Text = "Додати автосалон";
            this.buttonAddDealership.UseVisualStyleBackColor = true;
            // 
            // CarDealershipsDataGridView
            // 
            this.CarDealershipsDataGridView.AllowUserToAddRows = false;
            this.CarDealershipsDataGridView.AllowUserToDeleteRows = false;
            this.CarDealershipsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CarDealershipsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.CarDealershipsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarDealershipsDataGridView.Location = new System.Drawing.Point(112, 0);
            this.CarDealershipsDataGridView.Name = "CarDealershipsDataGridView";
            this.CarDealershipsDataGridView.ReadOnly = true;
            this.CarDealershipsDataGridView.RowHeadersWidth = 51;
            this.CarDealershipsDataGridView.RowTemplate.Height = 25;
            this.CarDealershipsDataGridView.Size = new System.Drawing.Size(934, 568);
            this.CarDealershipsDataGridView.TabIndex = 1;
            // 
            // tabPageEmployees
            // 
            this.tabPageEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tabPageEmployees.Controls.Add(this.buttonUpdateEmployee);
            this.tabPageEmployees.Controls.Add(this.buttonDeleteEmployee);
            this.tabPageEmployees.Controls.Add(this.buttonAddEmployee);
            this.tabPageEmployees.Controls.Add(this.labelEmployeeSearch);
            this.tabPageEmployees.Controls.Add(this.textBoxEmployeeSearch);
            this.tabPageEmployees.Controls.Add(this.EmployeesDataGridView);
            this.tabPageEmployees.Location = new System.Drawing.Point(4, 24);
            this.tabPageEmployees.Name = "tabPageEmployees";
            this.tabPageEmployees.Size = new System.Drawing.Size(1046, 568);
            this.tabPageEmployees.TabIndex = 3;
            this.tabPageEmployees.Text = "Працівники";
            // 
            // buttonUpdateEmployee
            // 
            this.buttonUpdateEmployee.Location = new System.Drawing.Point(940, 20);
            this.buttonUpdateEmployee.Name = "buttonUpdateEmployee";
            this.buttonUpdateEmployee.Size = new System.Drawing.Size(98, 44);
            this.buttonUpdateEmployee.TabIndex = 11;
            this.buttonUpdateEmployee.Text = "Оновити дані";
            this.buttonUpdateEmployee.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteEmployee
            // 
            this.buttonDeleteEmployee.Enabled = false;
            this.buttonDeleteEmployee.Location = new System.Drawing.Point(740, 20);
            this.buttonDeleteEmployee.Name = "buttonDeleteEmployee";
            this.buttonDeleteEmployee.Size = new System.Drawing.Size(98, 44);
            this.buttonDeleteEmployee.TabIndex = 10;
            this.buttonDeleteEmployee.Text = "Видалити працівника";
            this.buttonDeleteEmployee.UseVisualStyleBackColor = true;
            // 
            // buttonAddEmployee
            // 
            this.buttonAddEmployee.Location = new System.Drawing.Point(540, 20);
            this.buttonAddEmployee.Name = "buttonAddEmployee";
            this.buttonAddEmployee.Size = new System.Drawing.Size(98, 44);
            this.buttonAddEmployee.TabIndex = 9;
            this.buttonAddEmployee.Text = "Додати працівника";
            this.buttonAddEmployee.UseVisualStyleBackColor = true;
            // 
            // labelEmployeeSearch
            // 
            this.labelEmployeeSearch.AutoSize = true;
            this.labelEmployeeSearch.Location = new System.Drawing.Point(8, 20);
            this.labelEmployeeSearch.Name = "labelEmployeeSearch";
            this.labelEmployeeSearch.Size = new System.Drawing.Size(228, 15);
            this.labelEmployeeSearch.TabIndex = 8;
            this.labelEmployeeSearch.Text = "Поле для вводу щоб знайти працівників";
            // 
            // textBoxEmployeeSearch
            // 
            this.textBoxEmployeeSearch.Location = new System.Drawing.Point(8, 38);
            this.textBoxEmployeeSearch.Name = "textBoxEmployeeSearch";
            this.textBoxEmployeeSearch.Size = new System.Drawing.Size(302, 23);
            this.textBoxEmployeeSearch.TabIndex = 7;
            // 
            // EmployeesDataGridView
            // 
            this.EmployeesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeesDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.EmployeesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeesDataGridView.Location = new System.Drawing.Point(0, 86);
            this.EmployeesDataGridView.Name = "EmployeesDataGridView";
            this.EmployeesDataGridView.RowHeadersWidth = 51;
            this.EmployeesDataGridView.RowTemplate.Height = 25;
            this.EmployeesDataGridView.Size = new System.Drawing.Size(1046, 482);
            this.EmployeesDataGridView.TabIndex = 1;
            // 
            // tabPageCustomers
            // 
            this.tabPageCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tabPageCustomers.Controls.Add(this.buttonDeleteClient);
            this.tabPageCustomers.Controls.Add(this.buttonUpdateClient);
            this.tabPageCustomers.Controls.Add(this.buttonAddClient);
            this.tabPageCustomers.Controls.Add(this.labelCustomerSearch);
            this.tabPageCustomers.Controls.Add(this.buttonCustomerSearch);
            this.tabPageCustomers.Controls.Add(this.textBoxCustomerSearch);
            this.tabPageCustomers.Controls.Add(this.radioButtonCustomerDate);
            this.tabPageCustomers.Controls.Add(this.radioButtonCustomerPhone);
            this.tabPageCustomers.Controls.Add(this.radioButtonCustomerSurname);
            this.tabPageCustomers.Controls.Add(this.CustomerDataGridView);
            this.tabPageCustomers.Location = new System.Drawing.Point(4, 24);
            this.tabPageCustomers.Name = "tabPageCustomers";
            this.tabPageCustomers.Size = new System.Drawing.Size(1046, 568);
            this.tabPageCustomers.TabIndex = 4;
            this.tabPageCustomers.Text = "Клієнти";
            // 
            // buttonDeleteClient
            // 
            this.buttonDeleteClient.Enabled = false;
            this.buttonDeleteClient.Location = new System.Drawing.Point(784, 22);
            this.buttonDeleteClient.Name = "buttonDeleteClient";
            this.buttonDeleteClient.Size = new System.Drawing.Size(98, 52);
            this.buttonDeleteClient.TabIndex = 13;
            this.buttonDeleteClient.Text = "Видалити клієнта";
            this.buttonDeleteClient.UseVisualStyleBackColor = true;
            this.buttonDeleteClient.Click += new System.EventHandler(this.buttonDeleteClient_Click);
            // 
            // buttonUpdateClient
            // 
            this.buttonUpdateClient.Location = new System.Drawing.Point(888, 22);
            this.buttonUpdateClient.Name = "buttonUpdateClient";
            this.buttonUpdateClient.Size = new System.Drawing.Size(150, 52);
            this.buttonUpdateClient.TabIndex = 14;
            this.buttonUpdateClient.Text = "Оновити дані військовозобов\'язаного";
            this.buttonUpdateClient.UseVisualStyleBackColor = true;
            this.buttonUpdateClient.Click += new System.EventHandler(this.buttonUpdateClient_Click);
            // 
            // buttonAddClient
            // 
            this.buttonAddClient.Location = new System.Drawing.Point(680, 22);
            this.buttonAddClient.Name = "buttonAddClient";
            this.buttonAddClient.Size = new System.Drawing.Size(98, 52);
            this.buttonAddClient.TabIndex = 12;
            this.buttonAddClient.Text = "Додати клієнта";
            this.buttonAddClient.UseVisualStyleBackColor = true;
            this.buttonAddClient.Click += new System.EventHandler(this.buttonAddClient_Click);
            // 
            // labelCustomerSearch
            // 
            this.labelCustomerSearch.AutoSize = true;
            this.labelCustomerSearch.Location = new System.Drawing.Point(8, 20);
            this.labelCustomerSearch.Name = "labelCustomerSearch";
            this.labelCustomerSearch.Size = new System.Drawing.Size(206, 15);
            this.labelCustomerSearch.TabIndex = 6;
            this.labelCustomerSearch.Text = "Поле для вводу щоб знайти клієнтів";
            // 
            // buttonCustomerSearch
            // 
            this.buttonCustomerSearch.Location = new System.Drawing.Point(524, 22);
            this.buttonCustomerSearch.Name = "buttonCustomerSearch";
            this.buttonCustomerSearch.Size = new System.Drawing.Size(93, 52);
            this.buttonCustomerSearch.TabIndex = 5;
            this.buttonCustomerSearch.Text = "Знайти клієнта";
            this.buttonCustomerSearch.UseVisualStyleBackColor = true;
            // 
            // textBoxCustomerSearch
            // 
            this.textBoxCustomerSearch.Location = new System.Drawing.Point(8, 38);
            this.textBoxCustomerSearch.Name = "textBoxCustomerSearch";
            this.textBoxCustomerSearch.Size = new System.Drawing.Size(302, 23);
            this.textBoxCustomerSearch.TabIndex = 4;
            // 
            // radioButtonCustomerDate
            // 
            this.radioButtonCustomerDate.AutoSize = true;
            this.radioButtonCustomerDate.Location = new System.Drawing.Point(363, 62);
            this.radioButtonCustomerDate.Name = "radioButtonCustomerDate";
            this.radioButtonCustomerDate.Size = new System.Drawing.Size(144, 19);
            this.radioButtonCustomerDate.TabIndex = 3;
            this.radioButtonCustomerDate.TabStop = true;
            this.radioButtonCustomerDate.Text = "за датою народження";
            this.radioButtonCustomerDate.UseVisualStyleBackColor = true;
            // 
            // radioButtonCustomerPhone
            // 
            this.radioButtonCustomerPhone.AutoSize = true;
            this.radioButtonCustomerPhone.Location = new System.Drawing.Point(363, 37);
            this.radioButtonCustomerPhone.Name = "radioButtonCustomerPhone";
            this.radioButtonCustomerPhone.Size = new System.Drawing.Size(102, 19);
            this.radioButtonCustomerPhone.TabIndex = 2;
            this.radioButtonCustomerPhone.TabStop = true;
            this.radioButtonCustomerPhone.Text = "за телефоном";
            this.radioButtonCustomerPhone.UseVisualStyleBackColor = true;
            // 
            // radioButtonCustomerSurname
            // 
            this.radioButtonCustomerSurname.AutoSize = true;
            this.radioButtonCustomerSurname.Location = new System.Drawing.Point(363, 12);
            this.radioButtonCustomerSurname.Name = "radioButtonCustomerSurname";
            this.radioButtonCustomerSurname.Size = new System.Drawing.Size(100, 19);
            this.radioButtonCustomerSurname.TabIndex = 1;
            this.radioButtonCustomerSurname.TabStop = true;
            this.radioButtonCustomerSurname.Text = "за прізвищем";
            this.radioButtonCustomerSurname.UseVisualStyleBackColor = true;
            // 
            // CustomerDataGridView
            // 
            this.CustomerDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomerDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.CustomerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerDataGridView.Location = new System.Drawing.Point(0, 86);
            this.CustomerDataGridView.Name = "CustomerDataGridView";
            this.CustomerDataGridView.RowHeadersWidth = 51;
            this.CustomerDataGridView.RowTemplate.Height = 25;
            this.CustomerDataGridView.Size = new System.Drawing.Size(1046, 482);
            this.CustomerDataGridView.TabIndex = 0;
            this.CustomerDataGridView.SelectionChanged += new System.EventHandler(this.CustomerDataGridView_SelectionChanged);
            // 
            // tabPageTransactions
            // 
            this.tabPageTransactions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tabPageTransactions.Controls.Add(this.buttonCheckInfoTransaction);
            this.tabPageTransactions.Controls.Add(this.buttonDeleteTransaction);
            this.tabPageTransactions.Controls.Add(this.buttonAddTransaction);
            this.tabPageTransactions.Controls.Add(this.TransactionsDataGridView);
            this.tabPageTransactions.Location = new System.Drawing.Point(4, 24);
            this.tabPageTransactions.Name = "tabPageTransactions";
            this.tabPageTransactions.Size = new System.Drawing.Size(1046, 568);
            this.tabPageTransactions.TabIndex = 5;
            this.tabPageTransactions.Text = "Транзакції";
            // 
            // buttonCheckInfoTransaction
            // 
            this.buttonCheckInfoTransaction.Location = new System.Drawing.Point(920, 20);
            this.buttonCheckInfoTransaction.Name = "buttonCheckInfoTransaction";
            this.buttonCheckInfoTransaction.Size = new System.Drawing.Size(98, 44);
            this.buttonCheckInfoTransaction.TabIndex = 14;
            this.buttonCheckInfoTransaction.Text = "Деталі";
            this.buttonCheckInfoTransaction.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteTransaction
            // 
            this.buttonDeleteTransaction.Enabled = false;
            this.buttonDeleteTransaction.Location = new System.Drawing.Point(797, 20);
            this.buttonDeleteTransaction.Name = "buttonDeleteTransaction";
            this.buttonDeleteTransaction.Size = new System.Drawing.Size(98, 44);
            this.buttonDeleteTransaction.TabIndex = 13;
            this.buttonDeleteTransaction.Text = "Видалити транзакцію";
            this.buttonDeleteTransaction.UseVisualStyleBackColor = true;
            // 
            // buttonAddTransaction
            // 
            this.buttonAddTransaction.Location = new System.Drawing.Point(667, 20);
            this.buttonAddTransaction.Name = "buttonAddTransaction";
            this.buttonAddTransaction.Size = new System.Drawing.Size(98, 44);
            this.buttonAddTransaction.TabIndex = 12;
            this.buttonAddTransaction.Text = "Додати транзакцію";
            this.buttonAddTransaction.UseVisualStyleBackColor = true;
            // 
            // TransactionsDataGridView
            // 
            this.TransactionsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TransactionsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.TransactionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransactionsDataGridView.Location = new System.Drawing.Point(0, 86);
            this.TransactionsDataGridView.Name = "TransactionsDataGridView";
            this.TransactionsDataGridView.RowHeadersWidth = 51;
            this.TransactionsDataGridView.RowTemplate.Height = 25;
            this.TransactionsDataGridView.Size = new System.Drawing.Size(1046, 482);
            this.TransactionsDataGridView.TabIndex = 1;
            this.TransactionsDataGridView.SelectionChanged += new System.EventHandler(this.TransactionsDataGridView_SelectionChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(172)))), ((int)(((byte)(172)))));
            this.ClientSize = new System.Drawing.Size(1054, 596);
            this.Controls.Add(this.tabControl1);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DB Cars Sales";
            this.tabControl1.ResumeLayout(false);
            this.tabPageCars.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CarsDataGridView)).EndInit();
            this.tabPageCarModels.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ModelsDataGridView)).EndInit();
            this.tabPageCarDealerships.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CarDealershipsDataGridView)).EndInit();
            this.tabPageEmployees.ResumeLayout(false);
            this.tabPageEmployees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesDataGridView)).EndInit();
            this.tabPageCustomers.ResumeLayout(false);
            this.tabPageCustomers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDataGridView)).EndInit();
            this.tabPageTransactions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TransactionsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private TabControl tabControl1;
        private TabPage tabPageCars;
        private TabPage tabPageCarModels;
        private TabPage tabPageCarDealerships;
        private TabPage tabPageEmployees;
        private TabPage tabPageCustomers;
        private TabPage tabPageTransactions;
        private DataGridView CarDealershipsDataGridView;
        private Button buttonAddDealership;
        private Button buttonDeleteDealership;
        private DataGridView CustomerDataGridView;
        private Button buttonCustomerSearch;
        private TextBox textBoxCustomerSearch;
        private RadioButton radioButtonCustomerDate;
        private RadioButton radioButtonCustomerPhone;
        private RadioButton radioButtonCustomerSurname;
        private Label labelCustomerSearch;
        private DataGridView EmployeesDataGridView;
        private Button buttonUpdateDealership;
        private Label labelEmployeeSearch;
        private TextBox textBoxEmployeeSearch;
        private Button buttonUpdateEmployee;
        private Button buttonDeleteEmployee;
        private Button buttonAddEmployee;
        private DataGridView TransactionsDataGridView;
        private Button buttonCheckInfoTransaction;
        private Button buttonDeleteTransaction;
        private Button buttonAddTransaction;
        private DataGridView ModelsDataGridView;
        private Button buttonModelDetails;
        private Button buttonDeleteModel;
        private Button buttonAddModel;
        private DataGridView dataGridView1;
        private Button buttonAddClient;
        private Button buttonUpdateClient;
        private Button buttonDeleteClient;
        private DataGridView CarsDataGridView;
    }
}