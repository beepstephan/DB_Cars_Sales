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
            tabControl1 = new TabControl();
            tabPageCars = new TabPage();
            tabPageCarModels = new TabPage();
            buttonModelDetails = new Button();
            buttonDeleteModel = new Button();
            buttonAddModel = new Button();
            ModelsDataGridView = new DataGridView();
            tabPageCarDealerships = new TabPage();
            buttonUpdateDealership = new Button();
            buttonDeleteDealership = new Button();
            buttonAddDealership = new Button();
            CarDealershipsDataGridView = new DataGridView();
            tabPageEmployees = new TabPage();
            buttonUpdateEmployee = new Button();
            buttonDeleteEmployee = new Button();
            buttonAddEmployee = new Button();
            labelEmployeeSearch = new Label();
            textBoxEmployeeSearch = new TextBox();
            EmployeesDataGridView = new DataGridView();
            tabPageCustomers = new TabPage();
            labelCustomerSearch = new Label();
            buttonCustomerSearch = new Button();
            textBoxCustomerSearch = new TextBox();
            radioButtonCustomerDate = new RadioButton();
            radioButtonCustomerPhone = new RadioButton();
            radioButtonCustomerSurname = new RadioButton();
            CustomerDataGridView = new DataGridView();
            tabPageTransactions = new TabPage();
            buttonCheckInfoTransaction = new Button();
            buttonDeleteTransaction = new Button();
            buttonAddTransaction = new Button();
            TransactionsDataGridView = new DataGridView();
            tabControl1.SuspendLayout();
            tabPageCarModels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ModelsDataGridView).BeginInit();
            tabPageCarDealerships.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CarDealershipsDataGridView).BeginInit();
            tabPageEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EmployeesDataGridView).BeginInit();
            tabPageCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CustomerDataGridView).BeginInit();
            tabPageTransactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TransactionsDataGridView).BeginInit();
            SuspendLayout();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageCars = new System.Windows.Forms.TabPage();
            this.tabPageCarModels = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.tabControl1.SuspendLayout();
            this.tabPageCarModels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPageCarDealerships.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarDealershipsDataGridView)).BeginInit();
            this.tabPageEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesDataGridView)).BeginInit();
            this.tabPageCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDataGridView)).BeginInit();
            this.tabPageTransactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPageCars);
            tabControl1.Controls.Add(tabPageCarModels);
            tabControl1.Controls.Add(tabPageCarDealerships);
            tabControl1.Controls.Add(tabPageEmployees);
            tabControl1.Controls.Add(tabPageCustomers);
            tabControl1.Controls.Add(tabPageTransactions);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1054, 596);
            tabControl1.TabIndex = 1;
            // 
            // tabPageCars
            // 
            tabPageCars.BackColor = Color.FromArgb(255, 208, 208);
            tabPageCars.ForeColor = Color.Coral;
            tabPageCars.Location = new Point(4, 24);
            tabPageCars.Name = "tabPageCars";
            tabPageCars.Padding = new Padding(3);
            tabPageCars.Size = new Size(1046, 568);
            tabPageCars.TabIndex = 0;
            tabPageCars.Text = "Автомобілі";
            // 
            // tabPageCarModels
            // 
            tabPageCarModels.BackColor = Color.FromArgb(255, 208, 208);
            tabPageCarModels.Controls.Add(buttonModelDetails);
            tabPageCarModels.Controls.Add(buttonDeleteModel);
            tabPageCarModels.Controls.Add(buttonAddModel);
            tabPageCarModels.Controls.Add(ModelsDataGridView);
            tabPageCarModels.Location = new Point(4, 24);
            tabPageCarModels.Name = "tabPageCarModels";
            tabPageCarModels.Padding = new Padding(3);
            tabPageCarModels.Size = new Size(1046, 568);
            tabPageCarModels.TabIndex = 1;
            tabPageCarModels.Text = "Моделі автомобілей";
            // 
            // buttonModelDetails
            // 
            buttonModelDetails.Location = new Point(920, 20);
            buttonModelDetails.Name = "buttonModelDetails";
            buttonModelDetails.Size = new Size(98, 44);
            buttonModelDetails.TabIndex = 15;
            buttonModelDetails.Text = "Деталі";
            buttonModelDetails.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteModel
            // 
            buttonDeleteModel.Location = new Point(797, 20);
            buttonDeleteModel.Name = "buttonDeleteModel";
            buttonDeleteModel.Size = new Size(98, 44);
            buttonDeleteModel.TabIndex = 14;
            buttonDeleteModel.Text = "Видалити модель";
            buttonDeleteModel.UseVisualStyleBackColor = true;
            buttonDeleteModel.Click += buttonDeleteModel_Click;
            // 
            // buttonAddModel
            // 
            buttonAddModel.Location = new Point(667, 20);
            buttonAddModel.Name = "buttonAddModel";
            buttonAddModel.Size = new Size(98, 44);
            buttonAddModel.TabIndex = 13;
            buttonAddModel.Text = "Додати модель";
            buttonAddModel.UseVisualStyleBackColor = true;
            buttonAddModel.Click += buttonAddModel_Click;
            // 
            // ModelsDataGridView
            // 
            ModelsDataGridView.AllowUserToAddRows = false;
            ModelsDataGridView.AllowUserToDeleteRows = false;
            ModelsDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ModelsDataGridView.BackgroundColor = Color.FromArgb(255, 228, 228);
            ModelsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ModelsDataGridView.Location = new Point(0, 86);
            ModelsDataGridView.Name = "ModelsDataGridView";
            ModelsDataGridView.ReadOnly = true;
            ModelsDataGridView.RowHeadersWidth = 51;
            ModelsDataGridView.RowTemplate.Height = 25;
            ModelsDataGridView.Size = new Size(1046, 482);
            ModelsDataGridView.TabIndex = 2;
            ModelsDataGridView.SelectionChanged += ModelsDataGridView_SelectionChanged;
            // 
            // tabPageCarDealerships
            // 
            tabPageCarDealerships.BackColor = Color.FromArgb(255, 208, 208);
            tabPageCarDealerships.Controls.Add(buttonUpdateDealership);
            tabPageCarDealerships.Controls.Add(buttonDeleteDealership);
            tabPageCarDealerships.Controls.Add(buttonAddDealership);
            tabPageCarDealerships.Controls.Add(CarDealershipsDataGridView);
            tabPageCarDealerships.Location = new Point(4, 24);
            tabPageCarDealerships.Name = "tabPageCarDealerships";
            tabPageCarDealerships.Padding = new Padding(3);
            tabPageCarDealerships.Size = new Size(1046, 568);
            tabPageCarDealerships.TabIndex = 2;
            tabPageCarDealerships.Text = "Автосалони";
            // 
            // buttonUpdateDealership
            // 
            buttonUpdateDealership.Location = new Point(8, 115);
            buttonUpdateDealership.Name = "buttonUpdateDealership";
            buttonUpdateDealership.Size = new Size(98, 44);
            buttonUpdateDealership.TabIndex = 4;
            buttonUpdateDealership.Text = "Оновити дані";
            buttonUpdateDealership.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteDealership
            // 
            buttonDeleteDealership.Location = new Point(8, 65);
            buttonDeleteDealership.Name = "buttonDeleteDealership";
            buttonDeleteDealership.Size = new Size(98, 44);
            buttonDeleteDealership.TabIndex = 3;
            buttonDeleteDealership.Text = "Видалити автосалон";
            buttonDeleteDealership.UseVisualStyleBackColor = true;
            // 
            // buttonAddDealership
            // 
            buttonAddDealership.Location = new Point(8, 15);
            buttonAddDealership.Name = "buttonAddDealership";
            buttonAddDealership.Size = new Size(98, 44);
            buttonAddDealership.TabIndex = 2;
            buttonAddDealership.Text = "Додати автосалон";
            buttonAddDealership.UseVisualStyleBackColor = true;
            // 
            // CarDealershipsDataGridView
            // 
            CarDealershipsDataGridView.AllowUserToAddRows = false;
            CarDealershipsDataGridView.AllowUserToDeleteRows = false;
            CarDealershipsDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CarDealershipsDataGridView.BackgroundColor = Color.FromArgb(255, 228, 228);
            CarDealershipsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CarDealershipsDataGridView.Location = new Point(112, 0);
            CarDealershipsDataGridView.Name = "CarDealershipsDataGridView";
            CarDealershipsDataGridView.ReadOnly = true;
            CarDealershipsDataGridView.RowHeadersWidth = 51;
            CarDealershipsDataGridView.RowTemplate.Height = 25;
            CarDealershipsDataGridView.Size = new Size(934, 568);
            CarDealershipsDataGridView.TabIndex = 1;
            // 
            // tabPageEmployees
            // 
            tabPageEmployees.BackColor = Color.FromArgb(255, 208, 208);
            tabPageEmployees.Controls.Add(buttonUpdateEmployee);
            tabPageEmployees.Controls.Add(buttonDeleteEmployee);
            tabPageEmployees.Controls.Add(buttonAddEmployee);
            tabPageEmployees.Controls.Add(labelEmployeeSearch);
            tabPageEmployees.Controls.Add(textBoxEmployeeSearch);
            tabPageEmployees.Controls.Add(EmployeesDataGridView);
            tabPageEmployees.Location = new Point(4, 24);
            tabPageEmployees.Name = "tabPageEmployees";
            tabPageEmployees.Size = new Size(1046, 568);
            tabPageEmployees.TabIndex = 3;
            tabPageEmployees.Text = "Працівники";
            // 
            // buttonUpdateEmployee
            // 
            buttonUpdateEmployee.Location = new Point(940, 20);
            buttonUpdateEmployee.Name = "buttonUpdateEmployee";
            buttonUpdateEmployee.Size = new Size(98, 44);
            buttonUpdateEmployee.TabIndex = 11;
            buttonUpdateEmployee.Text = "Оновити дані";
            buttonUpdateEmployee.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteEmployee
            // 
            buttonDeleteEmployee.Enabled = false;
            buttonDeleteEmployee.Location = new Point(740, 20);
            buttonDeleteEmployee.Name = "buttonDeleteEmployee";
            buttonDeleteEmployee.Size = new Size(98, 44);
            buttonDeleteEmployee.TabIndex = 10;
            buttonDeleteEmployee.Text = "Видалити працівника";
            buttonDeleteEmployee.UseVisualStyleBackColor = true;
            // 
            // buttonAddEmployee
            // 
            buttonAddEmployee.Location = new Point(540, 20);
            buttonAddEmployee.Name = "buttonAddEmployee";
            buttonAddEmployee.Size = new Size(98, 44);
            buttonAddEmployee.TabIndex = 9;
            buttonAddEmployee.Text = "Додати працівника";
            buttonAddEmployee.UseVisualStyleBackColor = true;
            // 
            // labelEmployeeSearch
            // 
            labelEmployeeSearch.AutoSize = true;
            labelEmployeeSearch.Location = new Point(8, 20);
            labelEmployeeSearch.Name = "labelEmployeeSearch";
            labelEmployeeSearch.Size = new Size(228, 15);
            labelEmployeeSearch.TabIndex = 8;
            labelEmployeeSearch.Text = "Поле для вводу щоб знайти працівників";
            // 
            // textBoxEmployeeSearch
            // 
            textBoxEmployeeSearch.Location = new Point(8, 38);
            textBoxEmployeeSearch.Name = "textBoxEmployeeSearch";
            textBoxEmployeeSearch.Size = new Size(302, 23);
            textBoxEmployeeSearch.TabIndex = 7;
            // 
            // EmployeesDataGridView
            // 
            EmployeesDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EmployeesDataGridView.BackgroundColor = Color.FromArgb(255, 228, 228);
            EmployeesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EmployeesDataGridView.Location = new Point(0, 86);
            EmployeesDataGridView.Name = "EmployeesDataGridView";
            EmployeesDataGridView.RowHeadersWidth = 51;
            EmployeesDataGridView.RowTemplate.Height = 25;
            EmployeesDataGridView.Size = new Size(1046, 482);
            EmployeesDataGridView.TabIndex = 1;
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
            labelCustomerSearch.AutoSize = true;
            labelCustomerSearch.Location = new Point(8, 20);
            labelCustomerSearch.Name = "labelCustomerSearch";
            labelCustomerSearch.Size = new Size(206, 15);
            labelCustomerSearch.TabIndex = 6;
            labelCustomerSearch.Text = "Поле для вводу щоб знайти клієнтів";
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
            textBoxCustomerSearch.Location = new Point(8, 38);
            textBoxCustomerSearch.Name = "textBoxCustomerSearch";
            textBoxCustomerSearch.Size = new Size(302, 23);
            textBoxCustomerSearch.TabIndex = 4;
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
            tabPageTransactions.BackColor = Color.FromArgb(255, 208, 208);
            tabPageTransactions.Controls.Add(buttonCheckInfoTransaction);
            tabPageTransactions.Controls.Add(buttonDeleteTransaction);
            tabPageTransactions.Controls.Add(buttonAddTransaction);
            tabPageTransactions.Controls.Add(TransactionsDataGridView);
            tabPageTransactions.Location = new Point(4, 24);
            tabPageTransactions.Name = "tabPageTransactions";
            tabPageTransactions.Size = new Size(1046, 568);
            tabPageTransactions.TabIndex = 5;
            tabPageTransactions.Text = "Транзакції";
            // 
            // buttonCheckInfoTransaction
            // 
            buttonCheckInfoTransaction.Location = new Point(920, 20);
            buttonCheckInfoTransaction.Name = "buttonCheckInfoTransaction";
            buttonCheckInfoTransaction.Size = new Size(98, 44);
            buttonCheckInfoTransaction.TabIndex = 14;
            buttonCheckInfoTransaction.Text = "Деталі";
            buttonCheckInfoTransaction.UseVisualStyleBackColor = true;
            buttonCheckInfoTransaction.Click += buttonCheckInfoTransaction_Click;
            // 
            // buttonDeleteTransaction
            // 
            buttonDeleteTransaction.Enabled = false;
            buttonDeleteTransaction.Location = new Point(797, 20);
            buttonDeleteTransaction.Name = "buttonDeleteTransaction";
            buttonDeleteTransaction.Size = new Size(98, 44);
            buttonDeleteTransaction.TabIndex = 13;
            buttonDeleteTransaction.Text = "Видалити транзакцію";
            buttonDeleteTransaction.UseVisualStyleBackColor = true;
            buttonDeleteTransaction.Click += buttonDeleteTransaction_Click;
            // 
            // buttonAddTransaction
            // 
            buttonAddTransaction.Location = new Point(667, 20);
            buttonAddTransaction.Name = "buttonAddTransaction";
            buttonAddTransaction.Size = new Size(98, 44);
            buttonAddTransaction.TabIndex = 12;
            buttonAddTransaction.Text = "Додати транзакцію";
            buttonAddTransaction.UseVisualStyleBackColor = true;
            buttonAddTransaction.Click += buttonAddTransaction_Click;
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
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(225, 172, 172);
            ClientSize = new Size(1054, 596);
            Controls.Add(tabControl1);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DB Cars Sales";
            tabControl1.ResumeLayout(false);
            tabPageCarModels.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ModelsDataGridView).EndInit();
            tabPageCarDealerships.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)CarDealershipsDataGridView).EndInit();
            tabPageEmployees.ResumeLayout(false);
            tabPageEmployees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)EmployeesDataGridView).EndInit();
            tabPageCustomers.ResumeLayout(false);
            tabPageCustomers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CustomerDataGridView).EndInit();
            tabPageTransactions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)TransactionsDataGridView).EndInit();
            ResumeLayout(false);
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
    }
}