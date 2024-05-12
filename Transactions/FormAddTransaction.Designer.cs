namespace DB_Cars_Sales.Transactions
{
    partial class FormAddTransaction
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
            label1 = new Label();
            textBoxVIN = new TextBox();
            comboBoxCustomer = new ComboBox();
            label3 = new Label();
            comboBoxEmployee = new ComboBox();
            label2 = new Label();
            comboBoxCarDealership = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            textBoxServiceName = new TextBox();
            buttonAdd = new Button();
            numericUpDownServicePrice = new NumericUpDown();
            label6 = new Label();
            richTextBoxServiceDescription = new RichTextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownServicePrice).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(117, 20);
            label1.TabIndex = 9;
            label1.Text = "VIN автомобіля";
            // 
            // textBoxVIN
            // 
            textBoxVIN.Location = new Point(12, 44);
            textBoxVIN.Margin = new Padding(3, 4, 3, 4);
            textBoxVIN.MaxLength = 100;
            textBoxVIN.Name = "textBoxVIN";
            textBoxVIN.Size = new Size(299, 27);
            textBoxVIN.TabIndex = 1;
            // 
            // comboBoxCustomer
            // 
            comboBoxCustomer.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCustomer.FormattingEnabled = true;
            comboBoxCustomer.Items.AddRange(new object[] { "" });
            comboBoxCustomer.Location = new Point(12, 110);
            comboBoxCustomer.Margin = new Padding(3, 4, 3, 4);
            comboBoxCustomer.Name = "comboBoxCustomer";
            comboBoxCustomer.Size = new Size(299, 28);
            comboBoxCustomer.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 86);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 12;
            label3.Text = "Покупець";
            // 
            // comboBoxEmployee
            // 
            comboBoxEmployee.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEmployee.FormattingEnabled = true;
            comboBoxEmployee.Location = new Point(12, 177);
            comboBoxEmployee.Margin = new Padding(3, 4, 3, 4);
            comboBoxEmployee.Name = "comboBoxEmployee";
            comboBoxEmployee.Size = new Size(299, 28);
            comboBoxEmployee.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 153);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 14;
            label2.Text = "Продавець";
            // 
            // comboBoxCarDealership
            // 
            comboBoxCarDealership.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCarDealership.FormattingEnabled = true;
            comboBoxCarDealership.Items.AddRange(new object[] { "Автосалон Audi", "Автосалон Volkswagen", "Автосалон Skoda", "Автосалон \"Бомбейський Пантеон\"", "Автосалон \"Вторинний Рай\"" });
            comboBoxCarDealership.Location = new Point(12, 245);
            comboBoxCarDealership.Margin = new Padding(3, 4, 3, 4);
            comboBoxCarDealership.Name = "comboBoxCarDealership";
            comboBoxCarDealership.Size = new Size(299, 28);
            comboBoxCarDealership.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 221);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 16;
            label4.Text = "Автосалон";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 287);
            label5.Name = "label5";
            label5.Size = new Size(105, 20);
            label5.TabIndex = 18;
            label5.Text = "Назва сервісу";
            // 
            // textBoxServiceName
            // 
            textBoxServiceName.Location = new Point(12, 311);
            textBoxServiceName.Margin = new Padding(3, 4, 3, 4);
            textBoxServiceName.MaxLength = 100;
            textBoxServiceName.Multiline = true;
            textBoxServiceName.Name = "textBoxServiceName";
            textBoxServiceName.Size = new Size(299, 27);
            textBoxServiceName.TabIndex = 5;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(177, 568);
            buttonAdd.Margin = new Padding(3, 4, 3, 4);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(144, 56);
            buttonAdd.TabIndex = 8;
            buttonAdd.Text = "Додати";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // numericUpDownServicePrice
            // 
            numericUpDownServicePrice.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            numericUpDownServicePrice.Location = new Point(12, 376);
            numericUpDownServicePrice.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDownServicePrice.Name = "numericUpDownServicePrice";
            numericUpDownServicePrice.Size = new Size(150, 27);
            numericUpDownServicePrice.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 353);
            label6.Name = "label6";
            label6.Size = new Size(95, 20);
            label6.TabIndex = 19;
            label6.Text = "Ціна сервісу";
            // 
            // richTextBoxServiceDescription
            // 
            richTextBoxServiceDescription.Location = new Point(12, 443);
            richTextBoxServiceDescription.Name = "richTextBoxServiceDescription";
            richTextBoxServiceDescription.Size = new Size(309, 90);
            richTextBoxServiceDescription.TabIndex = 7;
            richTextBoxServiceDescription.Text = "";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 420);
            label7.Name = "label7";
            label7.Size = new Size(99, 20);
            label7.TabIndex = 21;
            label7.Text = "Опис сервісу";
            // 
            // FormAddTransaction
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 637);
            Controls.Add(label7);
            Controls.Add(richTextBoxServiceDescription);
            Controls.Add(label6);
            Controls.Add(numericUpDownServicePrice);
            Controls.Add(buttonAdd);
            Controls.Add(label5);
            Controls.Add(textBoxServiceName);
            Controls.Add(comboBoxCarDealership);
            Controls.Add(label4);
            Controls.Add(comboBoxEmployee);
            Controls.Add(label2);
            Controls.Add(comboBoxCustomer);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(textBoxVIN);
            Name = "FormAddTransaction";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Додати транзакцію";
            ((System.ComponentModel.ISupportInitialize)numericUpDownServicePrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxVIN;
        private ComboBox comboBoxCustomer;
        private Label label3;
        private ComboBox comboBoxEmployee;
        private Label label2;
        private ComboBox comboBoxCarDealership;
        private Label label4;
        private Label label5;
        private TextBox textBoxServiceName;
        private Button buttonAdd;
        private NumericUpDown numericUpDownServicePrice;
        private Label label6;
        private RichTextBox richTextBoxServiceDescription;
        private Label label7;
    }
}