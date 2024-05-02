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
            tabPageCustomers = new TabPage();
            labelCustomerSearch = new Label();
            buttonCustomerSearch = new Button();
            textBoxCustomerSearch = new TextBox();
            radioButtonCustomerDate = new RadioButton();
            radioButtonCustomerPhone = new RadioButton();
            radioButtonCustomerSurname = new RadioButton();
            CustomerDataGridView = new DataGridView();
            tabPageTransactions = new TabPage();
            tabControl1.SuspendLayout();
            tabPageCarDealerships.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CarDealershipsDataGridView).BeginInit();
            tabPageCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CustomerDataGridView).BeginInit();
            SuspendLayout();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageCars = new System.Windows.Forms.TabPage();
            this.tabPageCarModels = new System.Windows.Forms.TabPage();
            this.tabPageCarDealerships = new System.Windows.Forms.TabPage();
            this.buttonDeleteDealership = new System.Windows.Forms.Button();
            this.buttonAddDealership = new System.Windows.Forms.Button();
            this.CarDealershipsDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPageEmployees = new System.Windows.Forms.TabPage();
            this.tabPageCustomers = new System.Windows.Forms.TabPage();
            this.labelCustomerSearch = new System.Windows.Forms.Label();
            this.buttonCustomerSearch = new System.Windows.Forms.Button();
            this.textBoxCustomerSearch = new System.Windows.Forms.TextBox();
            this.radioButtonCustomerDate = new System.Windows.Forms.RadioButton();
            this.radioButtonCustomerPhone = new System.Windows.Forms.RadioButton();
            this.radioButtonCustomerSurname = new System.Windows.Forms.RadioButton();
            this.CustomerDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPageTransactions = new System.Windows.Forms.TabPage();
            this.EmployeesDataGridView = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPageCarDealerships.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarDealershipsDataGridView)).BeginInit();
            this.tabPageEmployees.SuspendLayout();
            this.tabPageCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesDataGridView)).BeginInit();
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
            tabPageCars.BackColor = Color.RosyBrown;
            tabPageCars.Location = new Point(4, 24);
            tabPageCars.Name = "tabPageCars";
            tabPageCars.Padding = new Padding(3);
            tabPageCars.Size = new Size(1046, 568);
            tabPageCars.TabIndex = 0;
            tabPageCars.Text = "Автомобілі";
            // 
            // tabPageCarModels
            // 
            tabPageCarModels.BackColor = Color.RosyBrown;
            tabPageCarModels.Location = new Point(4, 24);
            tabPageCarModels.Name = "tabPageCarModels";
            tabPageCarModels.Padding = new Padding(3);
            tabPageCarModels.Size = new Size(1046, 568);
            tabPageCarModels.TabIndex = 1;
            tabPageCarModels.Text = "Моделі автомобілей";
            // 
            // tabPageCarDealerships
            // 
            tabPageCarDealerships.BackColor = Color.RosyBrown;
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
            buttonUpdateDealership.Text = "Видалити автосалон";
            buttonUpdateDealership.UseVisualStyleBackColor = true;
            buttonUpdateDealership.Click += buttonUpdateDealership_Click;
            // 
            // buttonDeleteDealership
            // 
            buttonDeleteDealership.Location = new Point(8, 65);
            buttonDeleteDealership.Name = "buttonDeleteDealership";
            buttonDeleteDealership.Size = new Size(98, 44);
            buttonDeleteDealership.TabIndex = 3;
            buttonDeleteDealership.Text = "Видалити автосалон";
            buttonDeleteDealership.UseVisualStyleBackColor = true;
            buttonDeleteDealership.Click += buttonDeleteDealership_Click;
            // 
            // buttonAddDealership
            // 
            buttonAddDealership.Location = new Point(8, 15);
            buttonAddDealership.Name = "buttonAddDealership";
            buttonAddDealership.Size = new Size(98, 44);
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
            CarDealershipsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CarDealershipsDataGridView.Location = new Point(112, 0);
            CarDealershipsDataGridView.Name = "CarDealershipsDataGridView";
            CarDealershipsDataGridView.ReadOnly = true;
            CarDealershipsDataGridView.RowTemplate.Height = 25;
            CarDealershipsDataGridView.Size = new Size(934, 568);
            CarDealershipsDataGridView.TabIndex = 1;
            // 
            // tabPageEmployees
            // 
            tabPageEmployees.BackColor = Color.RosyBrown;
            tabPageEmployees.Location = new Point(4, 24);
            tabPageEmployees.Name = "tabPageEmployees";
            tabPageEmployees.Size = new Size(1046, 568);
            tabPageEmployees.TabIndex = 3;
            tabPageEmployees.Text = "Працівники";
            this.tabPageEmployees.BackColor = System.Drawing.Color.RosyBrown;
            this.tabPageEmployees.Controls.Add(this.EmployeesDataGridView);
            this.tabPageEmployees.Location = new System.Drawing.Point(4, 24);
            this.tabPageEmployees.Name = "tabPageEmployees";
            this.tabPageEmployees.Size = new System.Drawing.Size(1046, 568);
            this.tabPageEmployees.TabIndex = 3;
            this.tabPageEmployees.Text = "Працівники";
            // 
            // tabPageCustomers
            // 
            tabPageCustomers.BackColor = Color.RosyBrown;
            tabPageCustomers.Controls.Add(labelCustomerSearch);
            tabPageCustomers.Controls.Add(buttonCustomerSearch);
            tabPageCustomers.Controls.Add(textBoxCustomerSearch);
            tabPageCustomers.Controls.Add(radioButtonCustomerDate);
            tabPageCustomers.Controls.Add(radioButtonCustomerPhone);
            tabPageCustomers.Controls.Add(radioButtonCustomerSurname);
            tabPageCustomers.Controls.Add(CustomerDataGridView);
            tabPageCustomers.Location = new Point(4, 24);
            tabPageCustomers.Name = "tabPageCustomers";
            tabPageCustomers.Size = new Size(1046, 568);
            tabPageCustomers.TabIndex = 4;
            tabPageCustomers.Text = "Клієнти";
            // 
            // labelCustomerSearch
            // 
            labelCustomerSearch.AutoSize = true;
            labelCustomerSearch.Location = new Point(67, 22);
            labelCustomerSearch.Name = "labelCustomerSearch";
            labelCustomerSearch.Size = new Size(206, 15);
            labelCustomerSearch.TabIndex = 6;
            labelCustomerSearch.Text = "Поле для вводу щоб знайти клієнтів";
            // 
            // buttonCustomerSearch
            // 
            buttonCustomerSearch.Location = new Point(945, 11);
            buttonCustomerSearch.Name = "buttonCustomerSearch";
            buttonCustomerSearch.Size = new Size(93, 52);
            buttonCustomerSearch.TabIndex = 5;
            buttonCustomerSearch.Text = "Знайти";
            buttonCustomerSearch.UseVisualStyleBackColor = true;
            buttonCustomerSearch.Click += buttonCustomerSearch_Click;
            // 
            // textBoxCustomerSearch
            // 
            textBoxCustomerSearch.Location = new Point(67, 40);
            textBoxCustomerSearch.Name = "textBoxCustomerSearch";
            textBoxCustomerSearch.Size = new Size(302, 23);
            textBoxCustomerSearch.TabIndex = 4;
            // 
            // radioButtonCustomerDate
            // 
            radioButtonCustomerDate.AutoSize = true;
            radioButtonCustomerDate.Location = new Point(784, 53);
            radioButtonCustomerDate.Name = "radioButtonCustomerDate";
            radioButtonCustomerDate.Size = new Size(144, 19);
            radioButtonCustomerDate.TabIndex = 3;
            radioButtonCustomerDate.TabStop = true;
            radioButtonCustomerDate.Text = "за датою народження";
            radioButtonCustomerDate.UseVisualStyleBackColor = true;
            // 
            // radioButtonCustomerPhone
            // 
            radioButtonCustomerPhone.AutoSize = true;
            radioButtonCustomerPhone.Location = new Point(784, 28);
            radioButtonCustomerPhone.Name = "radioButtonCustomerPhone";
            radioButtonCustomerPhone.Size = new Size(102, 19);
            radioButtonCustomerPhone.TabIndex = 2;
            radioButtonCustomerPhone.TabStop = true;
            radioButtonCustomerPhone.Text = "за телефоном";
            radioButtonCustomerPhone.UseVisualStyleBackColor = true;
            // 
            // radioButtonCustomerSurname
            // 
            radioButtonCustomerSurname.AutoSize = true;
            radioButtonCustomerSurname.Location = new Point(784, 3);
            radioButtonCustomerSurname.Name = "radioButtonCustomerSurname";
            radioButtonCustomerSurname.Size = new Size(100, 19);
            radioButtonCustomerSurname.TabIndex = 1;
            radioButtonCustomerSurname.TabStop = true;
            radioButtonCustomerSurname.Text = "за прізвищем";
            radioButtonCustomerSurname.UseVisualStyleBackColor = true;
            // 
            // CustomerDataGridView
            // 
            CustomerDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CustomerDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustomerDataGridView.Location = new Point(0, 86);
            CustomerDataGridView.Name = "CustomerDataGridView";
            CustomerDataGridView.RowTemplate.Height = 25;
            CustomerDataGridView.Size = new Size(1046, 482);
            CustomerDataGridView.TabIndex = 0;
            // 
            // tabPageTransactions
            // 
            tabPageTransactions.BackColor = Color.RosyBrown;
            tabPageTransactions.Location = new Point(4, 24);
            tabPageTransactions.Name = "tabPageTransactions";
            tabPageTransactions.Size = new Size(1046, 568);
            tabPageTransactions.TabIndex = 5;
            tabPageTransactions.Text = "Транзакції";
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
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1054, 596);
            Controls.Add(tabControl1);
            Name = "Main";
            Text = "DB Cars Sales";
            tabControl1.ResumeLayout(false);
            tabPageCarDealerships.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)CarDealershipsDataGridView).EndInit();
            tabPageCustomers.ResumeLayout(false);
            tabPageCustomers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CustomerDataGridView).EndInit();
            ResumeLayout(false);
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
            this.tabPageCustomers.ResumeLayout(false);
            this.tabPageCustomers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesDataGridView)).EndInit();
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
    }
}