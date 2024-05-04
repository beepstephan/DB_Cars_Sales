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
            this.tabPageCarModels = new System.Windows.Forms.TabPage();
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
            this.labelCustomerSearch = new System.Windows.Forms.Label();
            this.buttonCustomerSearch = new System.Windows.Forms.Button();
            this.textBoxCustomerSearch = new System.Windows.Forms.TextBox();
            this.radioButtonCustomerDate = new System.Windows.Forms.RadioButton();
            this.radioButtonCustomerPhone = new System.Windows.Forms.RadioButton();
            this.radioButtonCustomerSurname = new System.Windows.Forms.RadioButton();
            this.CustomerDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPageTransactions = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPageCarDealerships.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarDealershipsDataGridView)).BeginInit();
            this.tabPageEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesDataGridView)).BeginInit();
            this.tabPageCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDataGridView)).BeginInit();
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
            this.tabPageCars.BackColor = System.Drawing.Color.RosyBrown;
            this.tabPageCars.Location = new System.Drawing.Point(4, 24);
            this.tabPageCars.Name = "tabPageCars";
            this.tabPageCars.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCars.Size = new System.Drawing.Size(1046, 568);
            this.tabPageCars.TabIndex = 0;
            this.tabPageCars.Text = "Автомобілі";
            // 
            // tabPageCarModels
            // 
            this.tabPageCarModels.BackColor = System.Drawing.Color.RosyBrown;
            this.tabPageCarModels.Location = new System.Drawing.Point(4, 24);
            this.tabPageCarModels.Name = "tabPageCarModels";
            this.tabPageCarModels.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCarModels.Size = new System.Drawing.Size(1046, 568);
            this.tabPageCarModels.TabIndex = 1;
            this.tabPageCarModels.Text = "Моделі автомобілей";
            // 
            // tabPageCarDealerships
            // 
            this.tabPageCarDealerships.BackColor = System.Drawing.Color.RosyBrown;
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
            this.buttonUpdateDealership.Click += new System.EventHandler(this.buttonUpdateDealership_Click);
            // 
            // buttonDeleteDealership
            // 
            this.buttonDeleteDealership.Location = new System.Drawing.Point(8, 65);
            this.buttonDeleteDealership.Name = "buttonDeleteDealership";
            this.buttonDeleteDealership.Size = new System.Drawing.Size(98, 44);
            this.buttonDeleteDealership.TabIndex = 3;
            this.buttonDeleteDealership.Text = "Видалити автосалон";
            this.buttonDeleteDealership.UseVisualStyleBackColor = true;
            this.buttonDeleteDealership.Click += new System.EventHandler(this.buttonDeleteDealership_Click);
            // 
            // buttonAddDealership
            // 
            this.buttonAddDealership.Location = new System.Drawing.Point(8, 15);
            this.buttonAddDealership.Name = "buttonAddDealership";
            this.buttonAddDealership.Size = new System.Drawing.Size(98, 44);
            this.buttonAddDealership.TabIndex = 2;
            this.buttonAddDealership.Text = "Додати автосалон";
            this.buttonAddDealership.UseVisualStyleBackColor = true;
            this.buttonAddDealership.Click += new System.EventHandler(this.buttonAddDealership_Click);
            // 
            // CarDealershipsDataGridView
            // 
            this.CarDealershipsDataGridView.AllowUserToAddRows = false;
            this.CarDealershipsDataGridView.AllowUserToDeleteRows = false;
            this.CarDealershipsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CarDealershipsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarDealershipsDataGridView.Location = new System.Drawing.Point(112, 0);
            this.CarDealershipsDataGridView.Name = "CarDealershipsDataGridView";
            this.CarDealershipsDataGridView.ReadOnly = true;
            this.CarDealershipsDataGridView.RowTemplate.Height = 25;
            this.CarDealershipsDataGridView.Size = new System.Drawing.Size(934, 568);
            this.CarDealershipsDataGridView.TabIndex = 1;
            // 
            // tabPageEmployees
            // 
            this.tabPageEmployees.BackColor = System.Drawing.Color.RosyBrown;
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
            this.textBoxEmployeeSearch.TextChanged += new System.EventHandler(this.textBoxEmployeeSearch_TextChanged);
            // 
            // EmployeesDataGridView
            // 
            this.EmployeesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeesDataGridView.Location = new System.Drawing.Point(0, 86);
            this.EmployeesDataGridView.Name = "EmployeesDataGridView";
            this.EmployeesDataGridView.RowTemplate.Height = 25;
            this.EmployeesDataGridView.Size = new System.Drawing.Size(1046, 482);
            this.EmployeesDataGridView.TabIndex = 1;
            // 
            // tabPageCustomers
            // 
            this.tabPageCustomers.BackColor = System.Drawing.Color.RosyBrown;
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
            this.buttonCustomerSearch.Location = new System.Drawing.Point(945, 11);
            this.buttonCustomerSearch.Name = "buttonCustomerSearch";
            this.buttonCustomerSearch.Size = new System.Drawing.Size(93, 52);
            this.buttonCustomerSearch.TabIndex = 5;
            this.buttonCustomerSearch.Text = "Знайти";
            this.buttonCustomerSearch.UseVisualStyleBackColor = true;
            this.buttonCustomerSearch.Click += new System.EventHandler(this.buttonCustomerSearch_Click);
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
            this.radioButtonCustomerDate.Location = new System.Drawing.Point(784, 53);
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
            this.radioButtonCustomerPhone.Location = new System.Drawing.Point(784, 28);
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
            this.radioButtonCustomerSurname.Location = new System.Drawing.Point(784, 3);
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
            this.CustomerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerDataGridView.Location = new System.Drawing.Point(0, 86);
            this.CustomerDataGridView.Name = "CustomerDataGridView";
            this.CustomerDataGridView.RowTemplate.Height = 25;
            this.CustomerDataGridView.Size = new System.Drawing.Size(1046, 482);
            this.CustomerDataGridView.TabIndex = 0;
            // 
            // tabPageTransactions
            // 
            this.tabPageTransactions.BackColor = System.Drawing.Color.RosyBrown;
            this.tabPageTransactions.Location = new System.Drawing.Point(4, 24);
            this.tabPageTransactions.Name = "tabPageTransactions";
            this.tabPageTransactions.Size = new System.Drawing.Size(1046, 568);
            this.tabPageTransactions.TabIndex = 5;
            this.tabPageTransactions.Text = "Транзакції";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1054, 596);
            this.Controls.Add(this.tabControl1);
            this.Name = "Main";
            this.Text = "DB Cars Sales";
            this.tabControl1.ResumeLayout(false);
            this.tabPageCarDealerships.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CarDealershipsDataGridView)).EndInit();
            this.tabPageEmployees.ResumeLayout(false);
            this.tabPageEmployees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesDataGridView)).EndInit();
            this.tabPageCustomers.ResumeLayout(false);
            this.tabPageCustomers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDataGridView)).EndInit();
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
    }
}