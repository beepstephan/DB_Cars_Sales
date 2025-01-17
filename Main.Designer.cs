﻿namespace DB_Cars_Sales
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            tabControl1 = new TabControl();
            tabPageCars = new TabPage();
            buttonSearchCar = new Button();
            buttonUpdateCar = new Button();
            buttonCheckCarInfo = new Button();
            buttonDeleteCar = new Button();
            buttonAddCar = new Button();
            numericUpDownPriceFrom = new NumericUpDown();
            numericUpDownPriceTo = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            numericUpDownYearTo = new NumericUpDown();
            numericUpDownYearFrom = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            labelPrice = new Label();
            labelYear = new Label();
            labelModel = new Label();
            comboBoxModel = new ComboBox();
            labelBrand = new Label();
            comboBoxBrand = new ComboBox();
            labelBodytype = new Label();
            comboBoxBodytype = new ComboBox();
            CarsDataGridView = new DataGridView();
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
            buttonDeleteClient = new Button();
            buttonUpdateClient = new Button();
            buttonAddClient = new Button();
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
            dataGridView1 = new DataGridView();
            tabControl1.SuspendLayout();
            tabPageCars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPriceFrom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPriceTo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownYearTo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownYearFrom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CarsDataGridView).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            tabPageCars.Controls.Add(buttonSearchCar);
            tabPageCars.Controls.Add(buttonUpdateCar);
            tabPageCars.Controls.Add(buttonCheckCarInfo);
            tabPageCars.Controls.Add(buttonDeleteCar);
            tabPageCars.Controls.Add(buttonAddCar);
            tabPageCars.Controls.Add(numericUpDownPriceFrom);
            tabPageCars.Controls.Add(numericUpDownPriceTo);
            tabPageCars.Controls.Add(label3);
            tabPageCars.Controls.Add(label4);
            tabPageCars.Controls.Add(numericUpDownYearTo);
            tabPageCars.Controls.Add(numericUpDownYearFrom);
            tabPageCars.Controls.Add(label2);
            tabPageCars.Controls.Add(label1);
            tabPageCars.Controls.Add(labelPrice);
            tabPageCars.Controls.Add(labelYear);
            tabPageCars.Controls.Add(labelModel);
            tabPageCars.Controls.Add(comboBoxModel);
            tabPageCars.Controls.Add(labelBrand);
            tabPageCars.Controls.Add(comboBoxBrand);
            tabPageCars.Controls.Add(labelBodytype);
            tabPageCars.Controls.Add(comboBoxBodytype);
            tabPageCars.Controls.Add(CarsDataGridView);
            tabPageCars.ForeColor = Color.Coral;
            tabPageCars.Location = new Point(4, 29);
            tabPageCars.Margin = new Padding(3, 4, 3, 4);
            tabPageCars.Name = "tabPageCars";
            tabPageCars.Padding = new Padding(3, 4, 3, 4);
            tabPageCars.Size = new Size(1197, 762);
            tabPageCars.TabIndex = 0;
            tabPageCars.Text = "Автомобілі";
            // 
            // buttonSearchCar
            // 
            buttonSearchCar.ForeColor = SystemColors.ActiveCaptionText;
            buttonSearchCar.Location = new Point(616, 8);
            buttonSearchCar.Margin = new Padding(3, 4, 3, 4);
            buttonSearchCar.Name = "buttonSearchCar";
            buttonSearchCar.Size = new Size(106, 125);
            buttonSearchCar.TabIndex = 25;
            buttonSearchCar.Text = "Знайти авто";
            buttonSearchCar.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateCar
            // 
            buttonUpdateCar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonUpdateCar.ForeColor = SystemColors.ActiveCaptionText;
            buttonUpdateCar.Location = new Point(1074, 8);
            buttonUpdateCar.Margin = new Padding(3, 4, 3, 4);
            buttonUpdateCar.Name = "buttonUpdateCar";
            buttonUpdateCar.Size = new Size(112, 59);
            buttonUpdateCar.TabIndex = 24;
            buttonUpdateCar.Text = "Оновити дані ";
            buttonUpdateCar.UseVisualStyleBackColor = true;
            buttonUpdateCar.Click += buttonUpdateCar_Click;
            // 
            // buttonCheckCarInfo
            // 
            buttonCheckCarInfo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonCheckCarInfo.ForeColor = SystemColors.ActiveCaptionText;
            buttonCheckCarInfo.Location = new Point(1074, 75);
            buttonCheckCarInfo.Margin = new Padding(3, 4, 3, 4);
            buttonCheckCarInfo.Name = "buttonCheckCarInfo";
            buttonCheckCarInfo.Size = new Size(112, 59);
            buttonCheckCarInfo.TabIndex = 23;
            buttonCheckCarInfo.Text = "Деталі";
            buttonCheckCarInfo.UseVisualStyleBackColor = true;
            buttonCheckCarInfo.Click += buttonCheckCarInfo_Click;
            // 
            // buttonDeleteCar
            // 
            buttonDeleteCar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDeleteCar.ForeColor = SystemColors.ActiveCaptionText;
            buttonDeleteCar.Location = new Point(955, 73);
            buttonDeleteCar.Margin = new Padding(3, 4, 3, 4);
            buttonDeleteCar.Name = "buttonDeleteCar";
            buttonDeleteCar.Size = new Size(112, 59);
            buttonDeleteCar.TabIndex = 22;
            buttonDeleteCar.Text = "Видалити авто";
            buttonDeleteCar.UseVisualStyleBackColor = true;
            buttonDeleteCar.Click += buttonDeleteCar_Click;
            // 
            // buttonAddCar
            // 
            buttonAddCar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAddCar.ForeColor = SystemColors.ActiveCaptionText;
            buttonAddCar.Location = new Point(955, 8);
            buttonAddCar.Margin = new Padding(3, 4, 3, 4);
            buttonAddCar.Name = "buttonAddCar";
            buttonAddCar.Size = new Size(112, 59);
            buttonAddCar.TabIndex = 21;
            buttonAddCar.Text = "Додати авто";
            buttonAddCar.UseVisualStyleBackColor = true;
            buttonAddCar.Click += buttonAddCar_Click;
            // 
            // numericUpDownPriceFrom
            // 
            numericUpDownPriceFrom.Location = new Point(386, 77);
            numericUpDownPriceFrom.Margin = new Padding(3, 4, 3, 4);
            numericUpDownPriceFrom.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            numericUpDownPriceFrom.Name = "numericUpDownPriceFrom";
            numericUpDownPriceFrom.Size = new Size(83, 27);
            numericUpDownPriceFrom.TabIndex = 20;
            numericUpDownPriceFrom.Value = new decimal(new int[] { 10000, 0, 0, 0 });
            // 
            // numericUpDownPriceTo
            // 
            numericUpDownPriceTo.Location = new Point(509, 77);
            numericUpDownPriceTo.Margin = new Padding(3, 4, 3, 4);
            numericUpDownPriceTo.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            numericUpDownPriceTo.Name = "numericUpDownPriceTo";
            numericUpDownPriceTo.Size = new Size(83, 27);
            numericUpDownPriceTo.TabIndex = 19;
            numericUpDownPriceTo.Value = new decimal(new int[] { 100000, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(477, 80);
            label3.Name = "label3";
            label3.Size = new Size(28, 20);
            label3.TabIndex = 17;
            label3.Text = "До";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(353, 80);
            label4.Name = "label4";
            label4.Size = new Size(30, 20);
            label4.TabIndex = 16;
            label4.Text = "Від";
            // 
            // numericUpDownYearTo
            // 
            numericUpDownYearTo.Location = new Point(231, 77);
            numericUpDownYearTo.Margin = new Padding(3, 4, 3, 4);
            numericUpDownYearTo.Maximum = new decimal(new int[] { 2024, 0, 0, 0 });
            numericUpDownYearTo.Name = "numericUpDownYearTo";
            numericUpDownYearTo.Size = new Size(59, 27);
            numericUpDownYearTo.TabIndex = 15;
            numericUpDownYearTo.Value = new decimal(new int[] { 2024, 0, 0, 0 });
            // 
            // numericUpDownYearFrom
            // 
            numericUpDownYearFrom.Location = new Point(133, 77);
            numericUpDownYearFrom.Margin = new Padding(3, 4, 3, 4);
            numericUpDownYearFrom.Maximum = new decimal(new int[] { 2024, 0, 0, 0 });
            numericUpDownYearFrom.Name = "numericUpDownYearFrom";
            numericUpDownYearFrom.Size = new Size(59, 27);
            numericUpDownYearFrom.TabIndex = 14;
            numericUpDownYearFrom.Value = new decimal(new int[] { 1885, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(199, 80);
            label2.Name = "label2";
            label2.Size = new Size(28, 20);
            label2.TabIndex = 13;
            label2.Text = "До";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(99, 80);
            label1.Name = "label1";
            label1.Size = new Size(30, 20);
            label1.TabIndex = 12;
            label1.Text = "Від";
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.ForeColor = Color.Black;
            labelPrice.Location = new Point(299, 80);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(59, 20);
            labelPrice.TabIndex = 11;
            labelPrice.Text = "Ціна, ₴:";
            // 
            // labelYear
            // 
            labelYear.AutoSize = true;
            labelYear.ForeColor = Color.Black;
            labelYear.Location = new Point(9, 80);
            labelYear.Name = "labelYear";
            labelYear.Size = new Size(89, 20);
            labelYear.TabIndex = 10;
            labelYear.Text = "Рік випуску:";
            // 
            // labelModel
            // 
            labelModel.AutoSize = true;
            labelModel.ForeColor = Color.Black;
            labelModel.Location = new Point(454, 4);
            labelModel.Name = "labelModel";
            labelModel.Size = new Size(63, 20);
            labelModel.TabIndex = 9;
            labelModel.Text = "Модель";
            // 
            // comboBoxModel
            // 
            comboBoxModel.FormattingEnabled = true;
            comboBoxModel.Location = new Point(454, 28);
            comboBoxModel.Margin = new Padding(3, 4, 3, 4);
            comboBoxModel.Name = "comboBoxModel";
            comboBoxModel.Size = new Size(138, 28);
            comboBoxModel.TabIndex = 8;
            // 
            // labelBrand
            // 
            labelBrand.AutoSize = true;
            labelBrand.ForeColor = Color.Black;
            labelBrand.Location = new Point(215, 4);
            labelBrand.Name = "labelBrand";
            labelBrand.Size = new Size(58, 20);
            labelBrand.TabIndex = 7;
            labelBrand.Text = "Марка ";
            // 
            // comboBoxBrand
            // 
            comboBoxBrand.FormattingEnabled = true;
            comboBoxBrand.Location = new Point(215, 28);
            comboBoxBrand.Margin = new Padding(3, 4, 3, 4);
            comboBoxBrand.Name = "comboBoxBrand";
            comboBoxBrand.Size = new Size(138, 28);
            comboBoxBrand.TabIndex = 6;
            // 
            // labelBodytype
            // 
            labelBodytype.AutoSize = true;
            labelBodytype.ForeColor = Color.Black;
            labelBodytype.Location = new Point(9, 4);
            labelBodytype.Name = "labelBodytype";
            labelBodytype.Size = new Size(84, 20);
            labelBodytype.TabIndex = 5;
            labelBodytype.Text = "Тип кузову";
            // 
            // comboBoxBodytype
            // 
            comboBoxBodytype.FormattingEnabled = true;
            comboBoxBodytype.Location = new Point(9, 28);
            comboBoxBodytype.Margin = new Padding(3, 4, 3, 4);
            comboBoxBodytype.Name = "comboBoxBodytype";
            comboBoxBodytype.Size = new Size(138, 28);
            comboBoxBodytype.TabIndex = 4;
            // 
            // CarsDataGridView
            // 
            CarsDataGridView.AllowUserToAddRows = false;
            CarsDataGridView.AllowUserToDeleteRows = false;
            CarsDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CarsDataGridView.BackgroundColor = Color.FromArgb(255, 228, 228);
            CarsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Coral;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            CarsDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            CarsDataGridView.Location = new Point(0, 141);
            CarsDataGridView.Margin = new Padding(3, 4, 3, 4);
            CarsDataGridView.Name = "CarsDataGridView";
            CarsDataGridView.ReadOnly = true;
            CarsDataGridView.RowHeadersWidth = 51;
            CarsDataGridView.RowTemplate.Height = 25;
            CarsDataGridView.Size = new Size(1195, 616);
            CarsDataGridView.TabIndex = 3;
            // 
            // tabPageCarModels
            // 
            tabPageCarModels.BackColor = Color.FromArgb(255, 208, 208);
            tabPageCarModels.Controls.Add(buttonModelDetails);
            tabPageCarModels.Controls.Add(buttonDeleteModel);
            tabPageCarModels.Controls.Add(buttonAddModel);
            tabPageCarModels.Controls.Add(ModelsDataGridView);
            tabPageCarModels.Location = new Point(4, 29);
            tabPageCarModels.Margin = new Padding(3, 4, 3, 4);
            tabPageCarModels.Name = "tabPageCarModels";
            tabPageCarModels.Padding = new Padding(3, 4, 3, 4);
            tabPageCarModels.Size = new Size(1197, 762);
            tabPageCarModels.TabIndex = 1;
            tabPageCarModels.Text = "Моделі автомобілей";
            // 
            // buttonModelDetails
            // 
            buttonModelDetails.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonModelDetails.Location = new Point(1051, 27);
            buttonModelDetails.Margin = new Padding(3, 4, 3, 4);
            buttonModelDetails.Name = "buttonModelDetails";
            buttonModelDetails.Size = new Size(112, 59);
            buttonModelDetails.TabIndex = 15;
            buttonModelDetails.Text = "Деталі";
            buttonModelDetails.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteModel
            // 
            buttonDeleteModel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDeleteModel.Location = new Point(911, 27);
            buttonDeleteModel.Margin = new Padding(3, 4, 3, 4);
            buttonDeleteModel.Name = "buttonDeleteModel";
            buttonDeleteModel.Size = new Size(112, 59);
            buttonDeleteModel.TabIndex = 14;
            buttonDeleteModel.Text = "Видалити модель";
            buttonDeleteModel.UseVisualStyleBackColor = true;
            // 
            // buttonAddModel
            // 
            buttonAddModel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAddModel.Location = new Point(762, 27);
            buttonAddModel.Margin = new Padding(3, 4, 3, 4);
            buttonAddModel.Name = "buttonAddModel";
            buttonAddModel.Size = new Size(112, 59);
            buttonAddModel.TabIndex = 13;
            buttonAddModel.Text = "Додати модель";
            buttonAddModel.UseVisualStyleBackColor = true;
            // 
            // ModelsDataGridView
            // 
            ModelsDataGridView.AllowUserToAddRows = false;
            ModelsDataGridView.AllowUserToDeleteRows = false;
            ModelsDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ModelsDataGridView.BackgroundColor = Color.FromArgb(255, 228, 228);
            ModelsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ModelsDataGridView.Location = new Point(0, 115);
            ModelsDataGridView.Margin = new Padding(3, 4, 3, 4);
            ModelsDataGridView.Name = "ModelsDataGridView";
            ModelsDataGridView.ReadOnly = true;
            ModelsDataGridView.RowHeadersWidth = 51;
            ModelsDataGridView.RowTemplate.Height = 25;
            ModelsDataGridView.Size = new Size(1195, 643);
            ModelsDataGridView.TabIndex = 2;
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
            buttonUpdateEmployee.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonUpdateEmployee.Location = new Point(1074, 27);
            buttonUpdateEmployee.Margin = new Padding(3, 4, 3, 4);
            buttonUpdateEmployee.Name = "buttonUpdateEmployee";
            buttonUpdateEmployee.Size = new Size(112, 59);
            buttonUpdateEmployee.TabIndex = 11;
            buttonUpdateEmployee.Text = "Оновити дані";
            buttonUpdateEmployee.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteEmployee
            // 
            buttonDeleteEmployee.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDeleteEmployee.Enabled = false;
            buttonDeleteEmployee.Location = new Point(911, 27);
            buttonDeleteEmployee.Margin = new Padding(3, 4, 3, 4);
            buttonDeleteEmployee.Name = "buttonDeleteEmployee";
            buttonDeleteEmployee.Size = new Size(112, 59);
            buttonDeleteEmployee.TabIndex = 10;
            buttonDeleteEmployee.Text = "Видалити працівника";
            buttonDeleteEmployee.UseVisualStyleBackColor = true;
            // 
            // buttonAddEmployee
            // 
            buttonAddEmployee.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAddEmployee.Location = new Point(742, 27);
            buttonAddEmployee.Margin = new Padding(3, 4, 3, 4);
            buttonAddEmployee.Name = "buttonAddEmployee";
            buttonAddEmployee.Size = new Size(112, 59);
            buttonAddEmployee.TabIndex = 9;
            buttonAddEmployee.Text = "Додати працівника";
            buttonAddEmployee.UseVisualStyleBackColor = true;
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
            // 
            // EmployeesDataGridView
            // 
            EmployeesDataGridView.AllowUserToAddRows = false;
            EmployeesDataGridView.AllowUserToDeleteRows = false;
            EmployeesDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EmployeesDataGridView.BackgroundColor = Color.FromArgb(255, 228, 228);
            EmployeesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EmployeesDataGridView.Location = new Point(0, 115);
            EmployeesDataGridView.Margin = new Padding(3, 4, 3, 4);
            EmployeesDataGridView.Name = "EmployeesDataGridView";
            EmployeesDataGridView.ReadOnly = true;
            EmployeesDataGridView.RowHeadersWidth = 51;
            EmployeesDataGridView.RowTemplate.Height = 25;
            EmployeesDataGridView.Size = new Size(1195, 643);
            EmployeesDataGridView.TabIndex = 1;
            // 
            // tabPageCustomers
            // 
            tabPageCustomers.BackColor = Color.FromArgb(255, 208, 208);
            tabPageCustomers.Controls.Add(buttonDeleteClient);
            tabPageCustomers.Controls.Add(buttonUpdateClient);
            tabPageCustomers.Controls.Add(buttonAddClient);
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
            // buttonDeleteClient
            // 
            buttonDeleteClient.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDeleteClient.Enabled = false;
            buttonDeleteClient.Location = new Point(955, 29);
            buttonDeleteClient.Margin = new Padding(3, 4, 3, 4);
            buttonDeleteClient.Name = "buttonDeleteClient";
            buttonDeleteClient.Size = new Size(112, 69);
            buttonDeleteClient.TabIndex = 13;
            buttonDeleteClient.Text = "Видалити клієнта";
            buttonDeleteClient.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateClient
            // 
            buttonUpdateClient.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonUpdateClient.Location = new Point(1074, 29);
            buttonUpdateClient.Margin = new Padding(3, 4, 3, 4);
            buttonUpdateClient.Name = "buttonUpdateClient";
            buttonUpdateClient.Size = new Size(112, 69);
            buttonUpdateClient.TabIndex = 14;
            buttonUpdateClient.Text = "Оновити дані ";
            buttonUpdateClient.UseVisualStyleBackColor = true;
            // 
            // buttonAddClient
            // 
            buttonAddClient.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAddClient.Location = new Point(837, 29);
            buttonAddClient.Margin = new Padding(3, 4, 3, 4);
            buttonAddClient.Name = "buttonAddClient";
            buttonAddClient.Size = new Size(112, 69);
            buttonAddClient.TabIndex = 12;
            buttonAddClient.Text = "Додати клієнта";
            buttonAddClient.UseVisualStyleBackColor = true;
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
            buttonCustomerSearch.Location = new Point(599, 29);
            buttonCustomerSearch.Margin = new Padding(3, 4, 3, 4);
            buttonCustomerSearch.Name = "buttonCustomerSearch";
            buttonCustomerSearch.Size = new Size(106, 69);
            buttonCustomerSearch.TabIndex = 5;
            buttonCustomerSearch.Text = "Знайти клієнта";
            buttonCustomerSearch.UseVisualStyleBackColor = true;
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
            radioButtonCustomerDate.Location = new Point(415, 83);
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
            radioButtonCustomerPhone.Location = new Point(415, 49);
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
            radioButtonCustomerSurname.Location = new Point(415, 16);
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
            CustomerDataGridView.AllowUserToAddRows = false;
            CustomerDataGridView.AllowUserToDeleteRows = false;
            CustomerDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CustomerDataGridView.BackgroundColor = Color.FromArgb(255, 228, 228);
            CustomerDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustomerDataGridView.Location = new Point(0, 115);
            CustomerDataGridView.Margin = new Padding(3, 4, 3, 4);
            CustomerDataGridView.Name = "CustomerDataGridView";
            CustomerDataGridView.ReadOnly = true;
            CustomerDataGridView.RowHeadersWidth = 51;
            CustomerDataGridView.RowTemplate.Height = 25;
            CustomerDataGridView.Size = new Size(1195, 643);
            CustomerDataGridView.TabIndex = 0;
            // 
            // tabPageTransactions
            // 
            tabPageTransactions.BackColor = Color.FromArgb(255, 208, 208);
            tabPageTransactions.Controls.Add(buttonCheckInfoTransaction);
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
            // buttonCheckInfoTransaction
            // 
            buttonCheckInfoTransaction.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonCheckInfoTransaction.Location = new Point(1051, 27);
            buttonCheckInfoTransaction.Margin = new Padding(3, 4, 3, 4);
            buttonCheckInfoTransaction.Name = "buttonCheckInfoTransaction";
            buttonCheckInfoTransaction.Size = new Size(112, 59);
            buttonCheckInfoTransaction.TabIndex = 14;
            buttonCheckInfoTransaction.Text = "Деталі";
            buttonCheckInfoTransaction.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteTransaction
            // 
            buttonDeleteTransaction.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDeleteTransaction.Enabled = false;
            buttonDeleteTransaction.Location = new Point(911, 27);
            buttonDeleteTransaction.Margin = new Padding(3, 4, 3, 4);
            buttonDeleteTransaction.Name = "buttonDeleteTransaction";
            buttonDeleteTransaction.Size = new Size(112, 59);
            buttonDeleteTransaction.TabIndex = 13;
            buttonDeleteTransaction.Text = "Видалити транзакцію";
            buttonDeleteTransaction.UseVisualStyleBackColor = true;
            // 
            // buttonAddTransaction
            // 
            buttonAddTransaction.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAddTransaction.Location = new Point(762, 27);
            buttonAddTransaction.Margin = new Padding(3, 4, 3, 4);
            buttonAddTransaction.Name = "buttonAddTransaction";
            buttonAddTransaction.Size = new Size(112, 59);
            buttonAddTransaction.TabIndex = 12;
            buttonAddTransaction.Text = "Додати транзакцію";
            buttonAddTransaction.UseVisualStyleBackColor = true;
            // 
            // TransactionsDataGridView
            // 
            TransactionsDataGridView.AllowUserToAddRows = false;
            TransactionsDataGridView.AllowUserToDeleteRows = false;
            TransactionsDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TransactionsDataGridView.BackgroundColor = Color.FromArgb(255, 228, 228);
            TransactionsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TransactionsDataGridView.Location = new Point(0, 115);
            TransactionsDataGridView.Margin = new Padding(3, 4, 3, 4);
            TransactionsDataGridView.Name = "TransactionsDataGridView";
            TransactionsDataGridView.ReadOnly = true;
            TransactionsDataGridView.RowHeadersWidth = 51;
            TransactionsDataGridView.RowTemplate.Height = 25;
            TransactionsDataGridView.Size = new Size(1195, 643);
            TransactionsDataGridView.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(240, 150);
            dataGridView1.TabIndex = 0;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(225, 172, 172);
            ClientSize = new Size(1205, 795);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1140, 782);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DB Cars Sales";
            tabControl1.ResumeLayout(false);
            tabPageCars.ResumeLayout(false);
            tabPageCars.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPriceFrom).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPriceTo).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownYearTo).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownYearFrom).EndInit();
            ((System.ComponentModel.ISupportInitialize)CarsDataGridView).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridView CarsDataGridView;
        private Label labelBodytype;
        private ComboBox comboBoxBodytype;
        private NumericUpDown numericUpDownYearTo;
        private NumericUpDown numericUpDownYearFrom;
        private Label label2;
        private Label label1;
        private Label labelPrice;
        private Label labelYear;
        private Label labelModel;
        private ComboBox comboBoxModel;
        private Label labelBrand;
        private ComboBox comboBoxBrand;
        private NumericUpDown numericUpDownPriceFrom;
        private NumericUpDown numericUpDownPriceTo;
        private Label label3;
        private Label label4;
        private Button buttonCheckCarInfo;
        private Button buttonDeleteCar;
        private Button buttonAddCar;
        private Button buttonSearchCar;
        private Button buttonUpdateCar;
    }
}