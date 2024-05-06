namespace DB_Cars_Sales.Employees
{
    partial class FormUpdateEmployees
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
            numericUpDownSalary = new NumericUpDown();
            buttonUpdate = new Button();
            comboBoxDealership = new ComboBox();
            label9 = new Label();
            textBoxPassportID = new TextBox();
            label8 = new Label();
            dateTimePickerHireDate = new DateTimePicker();
            label7 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBoxAddress = new TextBox();
            dateTimePickerBirthDate = new DateTimePicker();
            label4 = new Label();
            comboBoxPosition = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            textBoxPhone = new TextBox();
            label1 = new Label();
            textBoxName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSalary).BeginInit();
            SuspendLayout();
            // 
            // numericUpDownSalary
            // 
            numericUpDownSalary.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownSalary.Location = new Point(23, 248);
            numericUpDownSalary.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDownSalary.Name = "numericUpDownSalary";
            numericUpDownSalary.Size = new Size(261, 23);
            numericUpDownSalary.TabIndex = 45;
            numericUpDownSalary.Value = new decimal(new int[] { 20000, 0, 0, 0 });
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(159, 424);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(126, 42);
            buttonUpdate.TabIndex = 44;
            buttonUpdate.Text = "Оновити";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // comboBoxDealership
            // 
            comboBoxDealership.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDealership.FormattingEnabled = true;
            comboBoxDealership.Items.AddRange(new object[] { "Автосалон Audi", "Автосалон Volkswagen", "Автосалон Skoda", "Автосалон \"Бомбейський Пантеон\"", "Автосалон \"Вторинний Рай\"" });
            comboBoxDealership.Location = new Point(23, 382);
            comboBoxDealership.Name = "comboBoxDealership";
            comboBoxDealership.Size = new Size(262, 23);
            comboBoxDealership.TabIndex = 43;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(23, 364);
            label9.Name = "label9";
            label9.Size = new Size(220, 15);
            label9.TabIndex = 42;
            label9.Text = "Автосалон, в якому працює працівник";
            // 
            // textBoxPassportID
            // 
            textBoxPassportID.Location = new Point(23, 338);
            textBoxPassportID.MaxLength = 100;
            textBoxPassportID.Name = "textBoxPassportID";
            textBoxPassportID.ReadOnly = true;
            textBoxPassportID.Size = new Size(262, 23);
            textBoxPassportID.TabIndex = 41;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(23, 320);
            label8.Name = "label8";
            label8.Size = new Size(137, 15);
            label8.TabIndex = 40;
            label8.Text = "ID паспорту працівника";
            // 
            // dateTimePickerHireDate
            // 
            dateTimePickerHireDate.Format = DateTimePickerFormat.Short;
            dateTimePickerHireDate.Location = new Point(23, 292);
            dateTimePickerHireDate.Name = "dateTimePickerHireDate";
            dateTimePickerHireDate.Size = new Size(261, 23);
            dateTimePickerHireDate.TabIndex = 39;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 274);
            label7.Name = "label7";
            label7.Size = new Size(208, 15);
            label7.TabIndex = 38;
            label7.Text = "Дата прийому на роботу працівника";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 230);
            label5.Name = "label5";
            label5.Size = new Size(168, 15);
            label5.TabIndex = 37;
            label5.Text = "Заробітна платня працівника";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 186);
            label6.Name = "label6";
            label6.Size = new Size(111, 15);
            label6.TabIndex = 36;
            label6.Text = "Адреса працівника";
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(23, 204);
            textBoxAddress.MaxLength = 100;
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(262, 23);
            textBoxAddress.TabIndex = 35;
            // 
            // dateTimePickerBirthDate
            // 
            dateTimePickerBirthDate.Format = DateTimePickerFormat.Short;
            dateTimePickerBirthDate.Location = new Point(23, 159);
            dateTimePickerBirthDate.Name = "dateTimePickerBirthDate";
            dateTimePickerBirthDate.Size = new Size(261, 23);
            dateTimePickerBirthDate.TabIndex = 34;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 141);
            label4.Name = "label4";
            label4.Size = new Size(168, 15);
            label4.TabIndex = 33;
            label4.Text = "Дата народження працівника";
            // 
            // comboBoxPosition
            // 
            comboBoxPosition.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPosition.FormattingEnabled = true;
            comboBoxPosition.Items.AddRange(new object[] { "Адміністратор", "Директор", "Продавець" });
            comboBoxPosition.Location = new Point(22, 71);
            comboBoxPosition.Name = "comboBoxPosition";
            comboBoxPosition.Size = new Size(262, 23);
            comboBoxPosition.TabIndex = 32;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 53);
            label3.Name = "label3";
            label3.Size = new Size(112, 15);
            label3.TabIndex = 31;
            label3.Text = "Посада працівника";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 97);
            label2.Name = "label2";
            label2.Size = new Size(120, 15);
            label2.TabIndex = 30;
            label2.Text = "Телефон працівника";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(22, 115);
            textBoxPhone.MaxLength = 25;
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(262, 23);
            textBoxPhone.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 9);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 28;
            label1.Text = "ПІБ працівника";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(22, 27);
            textBoxName.MaxLength = 100;
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(262, 23);
            textBoxName.TabIndex = 27;
            // 
            // FormUpdateEmployees
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 478);
            Controls.Add(numericUpDownSalary);
            Controls.Add(buttonUpdate);
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
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormUpdateEmployees";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormUpdateEmployees";
            ((System.ComponentModel.ISupportInitialize)numericUpDownSalary).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDownSalary;
        private Button buttonUpdate;
        private ComboBox comboBoxDealership;
        private Label label9;
        private TextBox textBoxPassportID;
        private Label label8;
        private DateTimePicker dateTimePickerHireDate;
        private Label label7;
        private Label label5;
        private Label label6;
        private TextBox textBoxAddress;
        private DateTimePicker dateTimePickerBirthDate;
        private Label label4;
        private ComboBox comboBoxPosition;
        private Label label3;
        private Label label2;
        private TextBox textBoxPhone;
        private Label label1;
        private TextBox textBoxName;
    }
}