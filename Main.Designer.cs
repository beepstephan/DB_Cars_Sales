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
            buttonUpdateTransaction = new Button();
            buttonDeleteTransaction = new Button();
            buttonAddTransaction = new Button();
            TransactionsDataGridView = new DataGridView();
            tabControl1.SuspendLayout();
            tabPageCarDealerships.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CarDealershipsDataGridView).BeginInit();
            tabPageEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EmployeesDataGridView).BeginInit();
            tabPageCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CustomerDataGridView).BeginInit();
            tabPageTransactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TransactionsDataGridView).BeginInit();
            SuspendLayout();
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
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1205, 795);
            tabControl1.TabIndex = 1;
            // 
            // tabPageCars
            // 
            tabPageCars.BackColor = Color.FromArgb(255, 208, 208);
            tabPageCars.ForeColor = Color.Coral;
            tabPageCars.Location = new Point(4, 29);
            tabPageCars.Margin = new Padding(3, 4, 3, 4);
            tabPageCars.Name = "tabPageCars";
            tabPageCars.Padding = new Padding(3, 4, 3, 4);
            tabPageCars.Size = new Size(1197, 762);
            tabPageCars.TabIndex = 0;
            tabPageCars.Text = "Автомобілі";
            // 
            // tabPageCarModels
            // 
            tabPageCarModels.BackColor = Color.FromArgb(255, 208, 208);
            tabPageCarModels.Location = new Point(4, 29);
            tabPageCarModels.Margin = new Padding(3, 4, 3, 4);
            tabPageCarModels.Name = "tabPageCarModels";
            tabPageCarModels.Padding = new Padding(3, 4, 3, 4);
            tabPageCarModels.Size = new Size(1197, 762);
            tabPageCarModels.TabIndex = 1;
            tabPageCarModels.Text = "Моделі автомобілей";
            // 
            // tabPageCarDealerships
            // 
            tabPageCarDealerships.BackColor = Color.FromArgb(255, 208, 208);
            tabPageCarDealerships.Controls.Add(buttonUpdateDealership);
            tabPageCarDealerships.Controls.Add(buttonDeleteDealership);
            tabPageCarDealerships.Controls.Add(buttonAddDealership);
            tabPageCarDealerships.Controls.Add(CarDealershipsDataGridView);
            tabPageCarDealerships.Location = new Point(4, 29);
            tabPageCarDealerships.Margin = new Padding(3, 4, 3, 4);
            tabPageCarDealerships.Name = "tabPageCarDealerships";
            tabPageCarDealerships.Padding = new Padding(3, 4, 3, 4);
            tabPageCarDealerships.Size = new Size(1197, 762);
            tabPageCarDealerships.TabIndex = 2;
            tabPageCarDealerships.Text = "Автосалони";
            // 
            // buttonUpdateDealership
            // 
            buttonUpdateDealership.Location = new Point(9, 153);
            buttonUpdateDealership.Margin = new Padding(3, 4, 3, 4);
            buttonUpdateDealership.Name = "buttonUpdateDealership";
            buttonUpdateDealership.Size = new Size(112, 59);
            buttonUpdateDealership.TabIndex = 4;
            buttonUpdateDealership.Text = "Оновити дані";
            buttonUpdateDealership.UseVisualStyleBackColor = true;
            buttonUpdateDealership.Click += buttonUpdateDealership_Click;
            // 
            // buttonDeleteDealership
            // 
            buttonDeleteDealership.Location = new Point(9, 87);
            buttonDeleteDealership.Margin = new Padding(3, 4, 3, 4);
            buttonDeleteDealership.Name = "buttonDeleteDealership";
            buttonDeleteDealership.Size = new Size(112, 59);
            buttonDeleteDealership.TabIndex = 3;
            buttonDeleteDealership.Text = "Видалити автосалон";
            buttonDeleteDealership.UseVisualStyleBackColor = true;
            buttonDeleteDealership.Click += buttonDeleteDealership_Click;
            // 
            // buttonAddDealership
            // 
            buttonAddDealership.Location = new Point(9, 20);
            buttonAddDealership.Margin = new Padding(3, 4, 3, 4);
            buttonAddDealership.Name = "buttonAddDealership";
            buttonAddDealership.Size = new Size(112, 59);
            buttonAddDealership.TabIndex = 2;
            buttonAddDealership.Text = "Додати автосалон";
            buttonAddDealership.UseVisualStyleBackColor = true;
            buttonAddDealership.Click += buttonAddDealership_Click;
            // 
            // CarDealershipsDataGridView
            // 
            CarDealershipsDataGridView.AllowUserToAddRows = false;
            CarDealershipsDataGridView.AllowUserToDeleteRows = false;
            CarDealershipsDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CarDealershipsDataGridView.BackgroundColor = Color.FromArgb(255, 228, 228);
            CarDealershipsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CarDealershipsDataGridView.Location = new Point(128, 0);
            CarDealershipsDataGridView.Margin = new Padding(3, 4, 3, 4);
            CarDealershipsDataGridView.Name = "CarDealershipsDataGridView";
            CarDealershipsDataGridView.ReadOnly = true;
            CarDealershipsDataGridView.RowHeadersWidth = 51;
            CarDealershipsDataGridView.RowTemplate.Height = 25;
            CarDealershipsDataGridView.Size = new Size(1067, 757);
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
            tabPageEmployees.Location = new Point(4, 29);
            tabPageEmployees.Margin = new Padding(3, 4, 3, 4);
            tabPageEmployees.Name = "tabPageEmployees";
            tabPageEmployees.Size = new Size(1197, 762);
            tabPageEmployees.TabIndex = 3;
            tabPageEmployees.Text = "Працівники";
            // 
            // buttonUpdateEmployee
            // 
            buttonUpdateEmployee.Location = new Point(1074, 27);
            buttonUpdateEmployee.Margin = new Padding(3, 4, 3, 4);
            buttonUpdateEmployee.Name = "buttonUpdateEmployee";
            buttonUpdateEmployee.Size = new Size(112, 59);
            buttonUpdateEmployee.TabIndex = 11;
            buttonUpdateEmployee.Text = "Оновити дані";
            buttonUpdateEmployee.UseVisualStyleBackColor = true;
            buttonUpdateEmployee.Click += buttonUpdateEmployee_Click;
            // 
            // buttonDeleteEmployee
            // 
            buttonDeleteEmployee.Enabled = false;
            buttonDeleteEmployee.Location = new Point(846, 27);
            buttonDeleteEmployee.Margin = new Padding(3, 4, 3, 4);
            buttonDeleteEmployee.Name = "buttonDeleteEmployee";
            buttonDeleteEmployee.Size = new Size(112, 59);
            buttonDeleteEmployee.TabIndex = 10;
            buttonDeleteEmployee.Text = "Видалити працівника";
            buttonDeleteEmployee.UseVisualStyleBackColor = true;
            buttonDeleteEmployee.Click += buttonDeleteEmployee_Click;
            // 
            // buttonAddEmployee
            // 
            buttonAddEmployee.Location = new Point(617, 27);
            buttonAddEmployee.Margin = new Padding(3, 4, 3, 4);
            buttonAddEmployee.Name = "buttonAddEmployee";
            buttonAddEmployee.Size = new Size(112, 59);
            buttonAddEmployee.TabIndex = 9;
            buttonAddEmployee.Text = "Додати працівника";
            buttonAddEmployee.UseVisualStyleBackColor = true;
            buttonAddEmployee.Click += buttonAddEmployee_Click;
            // 
            // labelEmployeeSearch
            // 
            labelEmployeeSearch.AutoSize = true;
            labelEmployeeSearch.Location = new Point(9, 27);
            labelEmployeeSearch.Name = "labelEmployeeSearch";
            labelEmployeeSearch.Size = new Size(291, 20);
            labelEmployeeSearch.TabIndex = 8;
            labelEmployeeSearch.Text = "Поле для вводу щоб знайти працівників";
            // 
            // textBoxEmployeeSearch
            // 
            textBoxEmployeeSearch.Location = new Point(9, 51);
            textBoxEmployeeSearch.Margin = new Padding(3, 4, 3, 4);
            textBoxEmployeeSearch.Name = "textBoxEmployeeSearch";
            textBoxEmployeeSearch.Size = new Size(345, 27);
            textBoxEmployeeSearch.TabIndex = 7;
            textBoxEmployeeSearch.TextChanged += textBoxEmployeeSearch_TextChanged;
            // 
            // EmployeesDataGridView
            // 
            EmployeesDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EmployeesDataGridView.BackgroundColor = Color.FromArgb(255, 228, 228);
            EmployeesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EmployeesDataGridView.Location = new Point(0, 115);
            EmployeesDataGridView.Margin = new Padding(3, 4, 3, 4);
            EmployeesDataGridView.Name = "EmployeesDataGridView";
            EmployeesDataGridView.RowHeadersWidth = 51;
            EmployeesDataGridView.RowTemplate.Height = 25;
            EmployeesDataGridView.Size = new Size(1195, 643);
            EmployeesDataGridView.TabIndex = 1;
            EmployeesDataGridView.SelectionChanged += EmployeesDataGridView_SelectionChanged;
            // 
            // tabPageCustomers
            // 
            tabPageCustomers.BackColor = Color.FromArgb(255, 208, 208);
            tabPageCustomers.Controls.Add(labelCustomerSearch);
            tabPageCustomers.Controls.Add(buttonCustomerSearch);
            tabPageCustomers.Controls.Add(textBoxCustomerSearch);
            tabPageCustomers.Controls.Add(radioButtonCustomerDate);
            tabPageCustomers.Controls.Add(radioButtonCustomerPhone);
            tabPageCustomers.Controls.Add(radioButtonCustomerSurname);
            tabPageCustomers.Controls.Add(CustomerDataGridView);
            tabPageCustomers.Location = new Point(4, 29);
            tabPageCustomers.Margin = new Padding(3, 4, 3, 4);
            tabPageCustomers.Name = "tabPageCustomers";
            tabPageCustomers.Size = new Size(1197, 762);
            tabPageCustomers.TabIndex = 4;
            tabPageCustomers.Text = "Клієнти";
            // 
            // labelCustomerSearch
            // 
            labelCustomerSearch.AutoSize = true;
            labelCustomerSearch.Location = new Point(9, 27);
            labelCustomerSearch.Name = "labelCustomerSearch";
            labelCustomerSearch.Size = new Size(260, 20);
            labelCustomerSearch.TabIndex = 6;
            labelCustomerSearch.Text = "Поле для вводу щоб знайти клієнтів";
            // 
            // buttonCustomerSearch
            // 
            buttonCustomerSearch.Location = new Point(1080, 15);
            buttonCustomerSearch.Margin = new Padding(3, 4, 3, 4);
            buttonCustomerSearch.Name = "buttonCustomerSearch";
            buttonCustomerSearch.Size = new Size(106, 69);
            buttonCustomerSearch.TabIndex = 5;
            buttonCustomerSearch.Text = "Знайти";
            buttonCustomerSearch.UseVisualStyleBackColor = true;
            buttonCustomerSearch.Click += buttonCustomerSearch_Click;
            // 
            // textBoxCustomerSearch
            // 
            textBoxCustomerSearch.Location = new Point(9, 51);
            textBoxCustomerSearch.Margin = new Padding(3, 4, 3, 4);
            textBoxCustomerSearch.Name = "textBoxCustomerSearch";
            textBoxCustomerSearch.Size = new Size(345, 27);
            textBoxCustomerSearch.TabIndex = 4;
            // 
            // radioButtonCustomerDate
            // 
            radioButtonCustomerDate.AutoSize = true;
            radioButtonCustomerDate.Location = new Point(896, 71);
            radioButtonCustomerDate.Margin = new Padding(3, 4, 3, 4);
            radioButtonCustomerDate.Name = "radioButtonCustomerDate";
            radioButtonCustomerDate.Size = new Size(184, 24);
            radioButtonCustomerDate.TabIndex = 3;
            radioButtonCustomerDate.TabStop = true;
            radioButtonCustomerDate.Text = "за датою народження";
            radioButtonCustomerDate.UseVisualStyleBackColor = true;
            // 
            // radioButtonCustomerPhone
            // 
            radioButtonCustomerPhone.AutoSize = true;
            radioButtonCustomerPhone.Location = new Point(896, 37);
            radioButtonCustomerPhone.Margin = new Padding(3, 4, 3, 4);
            radioButtonCustomerPhone.Name = "radioButtonCustomerPhone";
            radioButtonCustomerPhone.Size = new Size(127, 24);
            radioButtonCustomerPhone.TabIndex = 2;
            radioButtonCustomerPhone.TabStop = true;
            radioButtonCustomerPhone.Text = "за телефоном";
            radioButtonCustomerPhone.UseVisualStyleBackColor = true;
            // 
            // radioButtonCustomerSurname
            // 
            radioButtonCustomerSurname.AutoSize = true;
            radioButtonCustomerSurname.Location = new Point(896, 4);
            radioButtonCustomerSurname.Margin = new Padding(3, 4, 3, 4);
            radioButtonCustomerSurname.Name = "radioButtonCustomerSurname";
            radioButtonCustomerSurname.Size = new Size(126, 24);
            radioButtonCustomerSurname.TabIndex = 1;
            radioButtonCustomerSurname.TabStop = true;
            radioButtonCustomerSurname.Text = "за прізвищем";
            radioButtonCustomerSurname.UseVisualStyleBackColor = true;
            // 
            // CustomerDataGridView
            // 
            CustomerDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CustomerDataGridView.BackgroundColor = Color.FromArgb(255, 228, 228);
            CustomerDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustomerDataGridView.Location = new Point(0, 115);
            CustomerDataGridView.Margin = new Padding(3, 4, 3, 4);
            CustomerDataGridView.Name = "CustomerDataGridView";
            CustomerDataGridView.RowHeadersWidth = 51;
            CustomerDataGridView.RowTemplate.Height = 25;
            CustomerDataGridView.Size = new Size(1195, 643);
            CustomerDataGridView.TabIndex = 0;
            // 
            // tabPageTransactions
            // 
            tabPageTransactions.BackColor = Color.FromArgb(255, 208, 208);
            tabPageTransactions.Controls.Add(buttonUpdateTransaction);
            tabPageTransactions.Controls.Add(buttonDeleteTransaction);
            tabPageTransactions.Controls.Add(buttonAddTransaction);
            tabPageTransactions.Controls.Add(TransactionsDataGridView);
            tabPageTransactions.Location = new Point(4, 29);
            tabPageTransactions.Margin = new Padding(3, 4, 3, 4);
            tabPageTransactions.Name = "tabPageTransactions";
            tabPageTransactions.Size = new Size(1197, 762);
            tabPageTransactions.TabIndex = 5;
            tabPageTransactions.Text = "Транзакції";
            // 
            // buttonUpdateTransaction
            // 
            buttonUpdateTransaction.Location = new Point(1052, 26);
            buttonUpdateTransaction.Margin = new Padding(3, 4, 3, 4);
            buttonUpdateTransaction.Name = "buttonUpdateTransaction";
            buttonUpdateTransaction.Size = new Size(112, 59);
            buttonUpdateTransaction.TabIndex = 14;
            buttonUpdateTransaction.Text = "Оновити дані";
            buttonUpdateTransaction.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteTransaction
            // 
            buttonDeleteTransaction.Enabled = false;
            buttonDeleteTransaction.Location = new Point(911, 26);
            buttonDeleteTransaction.Margin = new Padding(3, 4, 3, 4);
            buttonDeleteTransaction.Name = "buttonDeleteTransaction";
            buttonDeleteTransaction.Size = new Size(112, 59);
            buttonDeleteTransaction.TabIndex = 13;
            buttonDeleteTransaction.Text = "Видалити транзакцію";
            buttonDeleteTransaction.UseVisualStyleBackColor = true;
            // 
            // buttonAddTransaction
            // 
            buttonAddTransaction.Location = new Point(762, 26);
            buttonAddTransaction.Margin = new Padding(3, 4, 3, 4);
            buttonAddTransaction.Name = "buttonAddTransaction";
            buttonAddTransaction.Size = new Size(112, 59);
            buttonAddTransaction.TabIndex = 12;
            buttonAddTransaction.Text = "Додати транзакцію";
            buttonAddTransaction.UseVisualStyleBackColor = true;
            buttonAddTransaction.Click += buttonAddTransaction_Click;
            // 
            // TransactionsDataGridView
            // 
            TransactionsDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TransactionsDataGridView.BackgroundColor = Color.FromArgb(255, 228, 228);
            TransactionsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TransactionsDataGridView.Location = new Point(0, 119);
            TransactionsDataGridView.Margin = new Padding(3, 4, 3, 4);
            TransactionsDataGridView.Name = "TransactionsDataGridView";
            TransactionsDataGridView.RowHeadersWidth = 51;
            TransactionsDataGridView.RowTemplate.Height = 25;
            TransactionsDataGridView.Size = new Size(1195, 643);
            TransactionsDataGridView.TabIndex = 1;
            TransactionsDataGridView.SelectionChanged += TransactionsDataGridView_SelectionChanged;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(225, 172, 172);
            ClientSize = new Size(1205, 795);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DB Cars Sales";
            tabControl1.ResumeLayout(false);
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
        private Button buttonUpdateTransaction;
        private Button buttonDeleteTransaction;
        private Button buttonAddTransaction;
    }
}