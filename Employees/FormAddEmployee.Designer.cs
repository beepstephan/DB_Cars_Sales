namespace DB_Cars_Sales.Employees
{
    partial class FormAddEmployee
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
            label2 = new Label();
            textBoxPhone = new TextBox();
            label1 = new Label();
            textBoxName = new TextBox();
            label3 = new Label();
            comboBoxPosition = new ComboBox();
            label4 = new Label();
            dateTimePickerBirthDate = new DateTimePicker();
            label5 = new Label();
            label6 = new Label();
            textBoxAddress = new TextBox();
            dateTimePickerHireDate = new DateTimePicker();
            label7 = new Label();
            textBoxPassportID = new TextBox();
            label8 = new Label();
            comboBoxDealership = new ComboBox();
            label9 = new Label();
            buttonAdd = new Button();
            numericUpDownSalary = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSalary).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 93);
            label2.Name = "label2";
            label2.Size = new Size(120, 15);
            label2.TabIndex = 9;
            label2.Text = "Телефон працівника";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(12, 111);
            textBoxPhone.MaxLength = 25;
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(262, 23);
            textBoxPhone.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 5);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 7;
            label1.Text = "ПІБ працівника";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(12, 23);
            textBoxName.MaxLength = 100;
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(262, 23);
            textBoxName.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 49);
            label3.Name = "label3";
            label3.Size = new Size(112, 15);
            label3.TabIndex = 10;
            label3.Text = "Посада працівника";
            // 
            // comboBoxPosition
            // 
            comboBoxPosition.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPosition.FormattingEnabled = true;
            comboBoxPosition.Items.AddRange(new object[] { "Адміністратор", "Директор", "Продавець" });
            comboBoxPosition.Location = new Point(12, 67);
            comboBoxPosition.Name = "comboBoxPosition";
            comboBoxPosition.Size = new Size(262, 23);
            comboBoxPosition.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 137);
            label4.Name = "label4";
            label4.Size = new Size(168, 15);
            label4.TabIndex = 13;
            label4.Text = "Дата народження працівника";
            // 
            // dateTimePickerBirthDate
            // 
            dateTimePickerBirthDate.Format = DateTimePickerFormat.Short;
            dateTimePickerBirthDate.Location = new Point(13, 155);
            dateTimePickerBirthDate.Name = "dateTimePickerBirthDate";
            dateTimePickerBirthDate.Size = new Size(261, 23);
            dateTimePickerBirthDate.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 226);
            label5.Name = "label5";
            label5.Size = new Size(168, 15);
            label5.TabIndex = 17;
            label5.Text = "Заробітна платня працівника";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 182);
            label6.Name = "label6";
            label6.Size = new Size(111, 15);
            label6.TabIndex = 16;
            label6.Text = "Адреса працівника";
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(13, 200);
            textBoxAddress.MaxLength = 100;
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(262, 23);
            textBoxAddress.TabIndex = 15;
            // 
            // dateTimePickerHireDate
            // 
            dateTimePickerHireDate.Format = DateTimePickerFormat.Short;
            dateTimePickerHireDate.Location = new Point(13, 288);
            dateTimePickerHireDate.Name = "dateTimePickerHireDate";
            dateTimePickerHireDate.Size = new Size(261, 23);
            dateTimePickerHireDate.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 270);
            label7.Name = "label7";
            label7.Size = new Size(208, 15);
            label7.TabIndex = 19;
            label7.Text = "Дата прийому на роботу працівника";
            // 
            // textBoxPassportID
            // 
            textBoxPassportID.Location = new Point(13, 334);
            textBoxPassportID.MaxLength = 100;
            textBoxPassportID.Name = "textBoxPassportID";
            textBoxPassportID.Size = new Size(262, 23);
            textBoxPassportID.TabIndex = 22;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 316);
            label8.Name = "label8";
            label8.Size = new Size(137, 15);
            label8.TabIndex = 21;
            label8.Text = "ID паспорту працівника";
            // 
            // comboBoxDealership
            // 
            comboBoxDealership.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDealership.FormattingEnabled = true;
            comboBoxDealership.Items.AddRange(new object[] { "Автосалон Audi", "Автосалон Volkswagen", "Автосалон Skoda", "Автосалон \"Бомбейський Пантеон\"", "Автосалон \"Вторинний Рай\"" });
            comboBoxDealership.Location = new Point(13, 378);
            comboBoxDealership.Name = "comboBoxDealership";
            comboBoxDealership.Size = new Size(262, 23);
            comboBoxDealership.TabIndex = 24;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(13, 360);
            label9.Name = "label9";
            label9.Size = new Size(220, 15);
            label9.TabIndex = 23;
            label9.Text = "Автосалон, в якому працює працівник";
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(148, 424);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(126, 42);
            buttonAdd.TabIndex = 25;
            buttonAdd.Text = "Додати";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // numericUpDownSalary
            // 
            numericUpDownSalary.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownSalary.Location = new Point(13, 244);
            numericUpDownSalary.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDownSalary.Name = "numericUpDownSalary";
            numericUpDownSalary.Size = new Size(261, 23);
            numericUpDownSalary.TabIndex = 26;
            numericUpDownSalary.Value = new decimal(new int[] { 20000, 0, 0, 0 });
            // 
            // FormAddEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 478);
            Controls.Add(numericUpDownSalary);
            Controls.Add(buttonAdd);
            Controls.Add(comboBoxDealership);
            Controls.Add(label9);
            Controls.Add(textBoxPassportID);
            Controls.Add(label8);
            Controls.Add(dateTimePickerHireDate);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(textBoxAddress);
            Controls.Add(dateTimePickerBirthDate);
            Controls.Add(label4);
            Controls.Add(comboBoxPosition);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxPhone);
            Controls.Add(label1);
            Controls.Add(textBoxName);
            Name = "FormAddEmployee";
            Text = "Додати працівника";
            ((System.ComponentModel.ISupportInitialize)numericUpDownSalary).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox textBoxPhone;
        private Label label1;
        private TextBox textBoxName;
        private Label label3;
        private ComboBox comboBoxPosition;
        private Label label4;
        private DateTimePicker dateTimePickerBirthDate;
        private Label label5;
        private Label label6;
        private TextBox textBoxAddress;
        private DateTimePicker dateTimePickerHireDate;
        private Label label7;
        private TextBox textBoxPassportID;
        private Label label8;
        private ComboBox comboBoxDealership;
        private Label label9;
        private Button buttonAdd;
        private NumericUpDown numericUpDownSalary;
    }
}