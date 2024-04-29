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
            buttonDeleteDealership = new Button();
            buttonAddDealership = new Button();
            CarDealershipsDataGridView = new DataGridView();
            tabPageEmployees = new TabPage();
            tabPageCustomers = new TabPage();
            dataGridView1 = new DataGridView();
            tabPageTransactions = new TabPage();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            textBox1 = new TextBox();
            button1 = new Button();
            tabControl1.SuspendLayout();
            tabPageCarDealerships.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CarDealershipsDataGridView).BeginInit();
            tabPageCustomers.SuspendLayout();
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
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1054, 596);
            tabControl1.TabIndex = 1;
            // 
            // tabPageCars
            // 
            tabPageCars.Location = new Point(4, 24);
            tabPageCars.Name = "tabPageCars";
            tabPageCars.Padding = new Padding(3);
            tabPageCars.Size = new Size(1046, 568);
            tabPageCars.TabIndex = 0;
            tabPageCars.Text = "Автомобілі";
            tabPageCars.UseVisualStyleBackColor = true;
            // 
            // tabPageCarModels
            // 
            tabPageCarModels.Location = new Point(4, 24);
            tabPageCarModels.Name = "tabPageCarModels";
            tabPageCarModels.Padding = new Padding(3);
            tabPageCarModels.Size = new Size(1046, 568);
            tabPageCarModels.TabIndex = 1;
            tabPageCarModels.Text = "Моделі автомобілей";
            tabPageCarModels.UseVisualStyleBackColor = true;
            // 
            // tabPageCarDealerships
            // 
            tabPageCarDealerships.Controls.Add(buttonDeleteDealership);
            tabPageCarDealerships.Controls.Add(buttonAddDealership);
            tabPageCarDealerships.Controls.Add(CarDealershipsDataGridView);
            tabPageCarDealerships.Location = new Point(4, 24);
            tabPageCarDealerships.Name = "tabPageCarDealerships";
            tabPageCarDealerships.Padding = new Padding(3);
            tabPageCarDealerships.Size = new Size(1046, 568);
            tabPageCarDealerships.TabIndex = 2;
            tabPageCarDealerships.Text = "Автосалони";
            tabPageCarDealerships.UseVisualStyleBackColor = true;
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
            CarDealershipsDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CarDealershipsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CarDealershipsDataGridView.Location = new Point(112, 0);
            CarDealershipsDataGridView.Name = "CarDealershipsDataGridView";
            CarDealershipsDataGridView.RowTemplate.Height = 25;
            CarDealershipsDataGridView.Size = new Size(934, 568);
            CarDealershipsDataGridView.TabIndex = 1;
            // 
            // tabPageEmployees
            // 
            tabPageEmployees.Location = new Point(4, 24);
            tabPageEmployees.Name = "tabPageEmployees";
            tabPageEmployees.Size = new Size(1046, 568);
            tabPageEmployees.TabIndex = 3;
            tabPageEmployees.Text = "Працівники";
            tabPageEmployees.UseVisualStyleBackColor = true;
            // 
            // tabPageCustomers
            // 
            tabPageCustomers.Controls.Add(button1);
            tabPageCustomers.Controls.Add(textBox1);
            tabPageCustomers.Controls.Add(radioButton3);
            tabPageCustomers.Controls.Add(radioButton2);
            tabPageCustomers.Controls.Add(radioButton1);
            tabPageCustomers.Controls.Add(dataGridView1);
            tabPageCustomers.Location = new Point(4, 24);
            tabPageCustomers.Name = "tabPageCustomers";
            tabPageCustomers.Size = new Size(1046, 568);
            tabPageCustomers.TabIndex = 4;
            tabPageCustomers.Text = "Клієнти";
            tabPageCustomers.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 86);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1046, 482);
            dataGridView1.TabIndex = 0;
            // 
            // tabPageTransactions
            // 
            tabPageTransactions.Location = new Point(4, 24);
            tabPageTransactions.Name = "tabPageTransactions";
            tabPageTransactions.Size = new Size(1046, 568);
            tabPageTransactions.TabIndex = 5;
            tabPageTransactions.Text = "Транзакції";
            tabPageTransactions.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(189, 20);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(94, 19);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(334, 20);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(94, 19);
            radioButton2.TabIndex = 2;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(466, 20);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(94, 19);
            radioButton3.TabIndex = 3;
            radioButton3.TabStop = true;
            radioButton3.Text = "radioButton3";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(436, 57);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(695, 32);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1054, 596);
            Controls.Add(tabControl1);
            Name = "Main";
            Text = "DB Cars Sales";
            tabControl1.ResumeLayout(false);
            tabPageCarDealerships.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)CarDealershipsDataGridView).EndInit();
            tabPageCustomers.ResumeLayout(false);
            tabPageCustomers.PerformLayout();
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
        private DataGridView dataGridView1;
        private Button button1;
        private TextBox textBox1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
    }
}