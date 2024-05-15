namespace DB_Cars_Sales.Customers
{
    partial class FormAddCustomer
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
            this.labelAddress = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPassportID = new System.Windows.Forms.TextBox();
            this.labelPassport = new System.Windows.Forms.Label();
            this.dateTimePickerBirthDate = new System.Windows.Forms.DateTimePicker();
            this.labelBirthDate = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(12, 179);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(111, 15);
            this.labelAddress.TabIndex = 22;
            this.labelAddress.Text = "Адреса працівника";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(12, 197);
            this.textBoxAddress.MaxLength = 100;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(262, 23);
            this.textBoxAddress.TabIndex = 21;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(12, 109);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(120, 15);
            this.labelPhone.TabIndex = 20;
            this.labelPhone.Text = "Телефон працівника";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(12, 127);
            this.textBoxPhone.MaxLength = 25;
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(262, 23);
            this.textBoxPhone.TabIndex = 19;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 39);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(91, 15);
            this.labelName.TabIndex = 18;
            this.labelName.Text = "ПІБ працівника";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(11, 57);
            this.textBoxName.MaxLength = 100;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(262, 23);
            this.textBoxName.TabIndex = 17;
            // 
            // textBoxPassportID
            // 
            this.textBoxPassportID.Location = new System.Drawing.Point(11, 337);
            this.textBoxPassportID.MaxLength = 100;
            this.textBoxPassportID.Name = "textBoxPassportID";
            this.textBoxPassportID.Size = new System.Drawing.Size(262, 23);
            this.textBoxPassportID.TabIndex = 26;
            // 
            // labelPassport
            // 
            this.labelPassport.AutoSize = true;
            this.labelPassport.Location = new System.Drawing.Point(12, 319);
            this.labelPassport.Name = "labelPassport";
            this.labelPassport.Size = new System.Drawing.Size(115, 15);
            this.labelPassport.TabIndex = 25;
            this.labelPassport.Text = "ID паспорту клієнта";
            // 
            // dateTimePickerBirthDate
            // 
            this.dateTimePickerBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerBirthDate.Location = new System.Drawing.Point(12, 267);
            this.dateTimePickerBirthDate.Name = "dateTimePickerBirthDate";
            this.dateTimePickerBirthDate.Size = new System.Drawing.Size(261, 23);
            this.dateTimePickerBirthDate.TabIndex = 24;
            // 
            // labelBirthDate
            // 
            this.labelBirthDate.AutoSize = true;
            this.labelBirthDate.Location = new System.Drawing.Point(13, 249);
            this.labelBirthDate.Name = "labelBirthDate";
            this.labelBirthDate.Size = new System.Drawing.Size(146, 15);
            this.labelBirthDate.TabIndex = 23;
            this.labelBirthDate.Text = "Дата народження клієнта";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(148, 424);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(126, 42);
            this.buttonAdd.TabIndex = 27;
            this.buttonAdd.Text = "Додати";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // FormAddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 478);
            this.Controls.Add(this.buttonAdd);
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
            this.Name = "FormAddCustomer";
            this.Text = "Додати клієнта";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelAddress;
        private TextBox textBoxAddress;
        private Label labelPhone;
        private TextBox textBoxPhone;
        private Label labelName;
        private TextBox textBoxName;
        private TextBox textBoxPassportID;
        private Label labelPassport;
        private DateTimePicker dateTimePickerBirthDate;
        private Label labelBirthDate;
        private Button buttonAdd;
    }
}