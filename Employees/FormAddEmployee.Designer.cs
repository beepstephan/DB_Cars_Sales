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
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxPosition = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerBirthDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.dateTimePickerHireDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPassportID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxDealership = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.numericUpDownSalary = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Телефон працівника";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(12, 111);
            this.textBoxPhone.MaxLength = 25;
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(262, 23);
            this.textBoxPhone.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "ПІБ працівника";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 23);
            this.textBoxName.MaxLength = 100;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(262, 23);
            this.textBoxName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Посада працівника";
            // 
            // comboBoxPosition
            // 
            this.comboBoxPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPosition.FormattingEnabled = true;
            this.comboBoxPosition.Items.AddRange(new object[] {
            "Адміністратор",
            "Директор",
            "Продавець"});
            this.comboBoxPosition.Location = new System.Drawing.Point(12, 67);
            this.comboBoxPosition.Name = "comboBoxPosition";
            this.comboBoxPosition.Size = new System.Drawing.Size(262, 23);
            this.comboBoxPosition.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Дата народження працівника";
            // 
            // dateTimePickerBirthDate
            // 
            this.dateTimePickerBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerBirthDate.Location = new System.Drawing.Point(13, 155);
            this.dateTimePickerBirthDate.Name = "dateTimePickerBirthDate";
            this.dateTimePickerBirthDate.Size = new System.Drawing.Size(261, 23);
            this.dateTimePickerBirthDate.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Заробітна платня працівника";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Адреса працівника";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(13, 200);
            this.textBoxAddress.MaxLength = 100;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(262, 23);
            this.textBoxAddress.TabIndex = 15;
            // 
            // dateTimePickerHireDate
            // 
            this.dateTimePickerHireDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerHireDate.Location = new System.Drawing.Point(13, 288);
            this.dateTimePickerHireDate.Name = "dateTimePickerHireDate";
            this.dateTimePickerHireDate.Size = new System.Drawing.Size(261, 23);
            this.dateTimePickerHireDate.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(208, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "Дата прийому на роботу працівника";
            // 
            // textBoxPassportID
            // 
            this.textBoxPassportID.Location = new System.Drawing.Point(13, 334);
            this.textBoxPassportID.MaxLength = 100;
            this.textBoxPassportID.Name = "textBoxPassportID";
            this.textBoxPassportID.Size = new System.Drawing.Size(262, 23);
            this.textBoxPassportID.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 316);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "ID паспорту працівника";
            // 
            // comboBoxDealership
            // 
            this.comboBoxDealership.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDealership.FormattingEnabled = true;
            this.comboBoxDealership.Items.AddRange(new object[] {
            "Автосалон Audi",
            "Автосалон Volkswagen",
            "Автосалон Skoda",
            "Автосалон \"Бомбейський Пантеон\"",
            "Автосалон \"Вторинний Рай\""});
            this.comboBoxDealership.Location = new System.Drawing.Point(13, 378);
            this.comboBoxDealership.Name = "comboBoxDealership";
            this.comboBoxDealership.Size = new System.Drawing.Size(262, 23);
            this.comboBoxDealership.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 360);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(220, 15);
            this.label9.TabIndex = 23;
            this.label9.Text = "Автосалон, в якому працює працівник";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(148, 424);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(126, 42);
            this.buttonAdd.TabIndex = 25;
            this.buttonAdd.Text = "Додати";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // numericUpDownSalary
            // 
            this.numericUpDownSalary.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownSalary.Location = new System.Drawing.Point(13, 244);
            this.numericUpDownSalary.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownSalary.Name = "numericUpDownSalary";
            this.numericUpDownSalary.Size = new System.Drawing.Size(261, 23);
            this.numericUpDownSalary.TabIndex = 26;
            this.numericUpDownSalary.Value = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            // 
            // FormAddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 478);
            this.Controls.Add(this.numericUpDownSalary);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.comboBoxDealership);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxPassportID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePickerHireDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.dateTimePickerBirthDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxPosition);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxName);
            this.Name = "FormAddEmployee";
            this.Text = "Додати працівника";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSalary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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