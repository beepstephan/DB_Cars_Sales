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
            this.buttonDeleteDealership = new System.Windows.Forms.Button();
            this.buttonAddDealership = new System.Windows.Forms.Button();
            this.testDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPageEmployees = new System.Windows.Forms.TabPage();
            this.tabPageCustomers = new System.Windows.Forms.TabPage();
            this.tabPageTransactions = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPageCarDealerships.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageCars);
            this.tabControl1.Controls.Add(this.tabPageCarModels);
            this.tabControl1.Controls.Add(this.tabPageCarDealerships);
            this.tabControl1.Controls.Add(this.tabPageEmployees);
            this.tabControl1.Controls.Add(this.tabPageCustomers);
            this.tabControl1.Controls.Add(this.tabPageTransactions);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1054, 596);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageCars
            // 
            this.tabPageCars.Location = new System.Drawing.Point(4, 24);
            this.tabPageCars.Name = "tabPageCars";
            this.tabPageCars.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCars.Size = new System.Drawing.Size(1046, 568);
            this.tabPageCars.TabIndex = 0;
            this.tabPageCars.Text = "Cars";
            this.tabPageCars.UseVisualStyleBackColor = true;
            // 
            // tabPageCarModels
            // 
            this.tabPageCarModels.Location = new System.Drawing.Point(4, 24);
            this.tabPageCarModels.Name = "tabPageCarModels";
            this.tabPageCarModels.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCarModels.Size = new System.Drawing.Size(1046, 568);
            this.tabPageCarModels.TabIndex = 1;
            this.tabPageCarModels.Text = "Car Models";
            this.tabPageCarModels.UseVisualStyleBackColor = true;
            // 
            // tabPageCarDealerships
            // 
            this.tabPageCarDealerships.Controls.Add(this.buttonDeleteDealership);
            this.tabPageCarDealerships.Controls.Add(this.buttonAddDealership);
            this.tabPageCarDealerships.Controls.Add(this.testDataGridView);
            this.tabPageCarDealerships.Location = new System.Drawing.Point(4, 24);
            this.tabPageCarDealerships.Name = "tabPageCarDealerships";
            this.tabPageCarDealerships.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCarDealerships.Size = new System.Drawing.Size(1046, 568);
            this.tabPageCarDealerships.TabIndex = 2;
            this.tabPageCarDealerships.Text = "Car Dealerships";
            this.tabPageCarDealerships.UseVisualStyleBackColor = true;
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
            // testDataGridView
            // 
            this.testDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.testDataGridView.Location = new System.Drawing.Point(112, 0);
            this.testDataGridView.Name = "testDataGridView";
            this.testDataGridView.RowTemplate.Height = 25;
            this.testDataGridView.Size = new System.Drawing.Size(934, 568);
            this.testDataGridView.TabIndex = 1;
            // 
            // tabPageEmployees
            // 
            this.tabPageEmployees.Location = new System.Drawing.Point(4, 24);
            this.tabPageEmployees.Name = "tabPageEmployees";
            this.tabPageEmployees.Size = new System.Drawing.Size(1046, 568);
            this.tabPageEmployees.TabIndex = 3;
            this.tabPageEmployees.Text = "Employees";
            this.tabPageEmployees.UseVisualStyleBackColor = true;
            // 
            // tabPageCustomers
            // 
            this.tabPageCustomers.Location = new System.Drawing.Point(4, 24);
            this.tabPageCustomers.Name = "tabPageCustomers";
            this.tabPageCustomers.Size = new System.Drawing.Size(1046, 568);
            this.tabPageCustomers.TabIndex = 4;
            this.tabPageCustomers.Text = "Customers";
            this.tabPageCustomers.UseVisualStyleBackColor = true;
            // 
            // tabPageTransactions
            // 
            this.tabPageTransactions.Location = new System.Drawing.Point(4, 24);
            this.tabPageTransactions.Name = "tabPageTransactions";
            this.tabPageTransactions.Size = new System.Drawing.Size(1046, 568);
            this.tabPageTransactions.TabIndex = 5;
            this.tabPageTransactions.Text = "Transactions";
            this.tabPageTransactions.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 596);
            this.Controls.Add(this.tabControl1);
            this.Name = "Main";
            this.Text = "Main";
            this.tabControl1.ResumeLayout(false);
            this.tabPageCarDealerships.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.testDataGridView)).EndInit();
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
        private DataGridView testDataGridView;
        private Button buttonAddDealership;
        private Button buttonDeleteDealership;
    }
}