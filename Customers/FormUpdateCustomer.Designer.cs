namespace DB_Cars_Sales.Customers
{
    partial class FormUpdateCustomer
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
            this.textBoxPassportID = new System.Windows.Forms.TextBox();
            this.labelPassport = new System.Windows.Forms.Label();
            this.dateTimePickerBirthDate = new System.Windows.Forms.DateTimePicker();
            this.labelBirthDate = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxPassportID
            // 
            this.textBoxPassportID.Enabled = false;
            this.textBoxPassportID.Location = new System.Drawing.Point(12, 337);
            this.textBoxPassportID.MaxLength = 100;
            this.textBoxPassportID.Name = "textBoxPassportID";
            this.textBoxPassportID.Size = new System.Drawing.Size(262, 23);
            this.textBoxPassportID.TabIndex = 36;
            // 
            // labelPassport
            // 
            this.labelPassport.AutoSize = true;
            this.labelPassport.Location = new System.Drawing.Point(12, 319);
            this.labelPassport.Name = "labelPassport";
            this.labelPassport.Size = new System.Drawing.Size(115, 15);
            this.labelPassport.TabIndex = 35;
            this.labelPassport.Text = "ID паспорту клієнта";
            // 
            // dateTimePickerBirthDate
            // 
            this.dateTimePickerBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerBirthDate.Location = new System.Drawing.Point(13, 267);
            this.dateTimePickerBirthDate.Name = "dateTimePickerBirthDate";
            this.dateTimePickerBirthDate.Size = new System.Drawing.Size(261, 23);
            this.dateTimePickerBirthDate.TabIndex = 34;
            // 
            // labelBirthDate
            // 
            this.labelBirthDate.AutoSize = true;
            this.labelBirthDate.Location = new System.Drawing.Point(13, 249);
            this.labelBirthDate.Name = "labelBirthDate";
            this.labelBirthDate.Size = new System.Drawing.Size(146, 15);
            this.labelBirthDate.TabIndex = 33;
            this.labelBirthDate.Text = "Дата народження клієнта";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(13, 179);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(111, 15);
            this.labelAddress.TabIndex = 32;
            this.labelAddress.Text = "Адреса працівника";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(13, 197);
            this.textBoxAddress.MaxLength = 100;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(262, 23);
            this.textBoxAddress.TabIndex = 31;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(13, 109);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(120, 15);
            this.labelPhone.TabIndex = 30;
            this.labelPhone.Text = "Телефон працівника";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(13, 127);
            this.textBoxPhone.MaxLength = 25;
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(262, 23);
            this.textBoxPhone.TabIndex = 29;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(13, 39);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(91, 15);
            this.labelName.TabIndex = 28;
            this.labelName.Text = "ПІБ працівника";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 57);
            this.textBoxName.MaxLength = 100;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(262, 23);
            this.textBoxName.TabIndex = 27;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(148, 424);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(126, 42);
            this.buttonUpdate.TabIndex = 37;
            this.buttonUpdate.Text = "Оновити";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // FormUpdateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 478);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.textBoxPassportID);
            this.Controls.Add(this.labelPassport);
            this.Controls.Add(this.dateTimePickerBirthDate);
            this.Controls.Add(this.labelBirthDate);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.Name = "FormUpdateCustomer";
            this.Text = "Оновлення даних";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxPassportID;
        private Label labelPassport;
        private DateTimePicker dateTimePickerBirthDate;
        private Label labelBirthDate;
        private Label labelAddress;
        private TextBox textBoxAddress;
        private Label labelPhone;
        private TextBox textBoxPhone;
        private Label labelName;
        private TextBox textBoxName;
        private Button buttonUpdate;
    }
}