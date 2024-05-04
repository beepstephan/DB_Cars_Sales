namespace DB_Cars_Sales
{
    partial class FormAddDealership
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxWorkingHours = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxServices = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(49, 46);
            this.textBoxName.MaxLength = 100;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(262, 23);
            this.textBoxName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Назва автосалону";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Телефон автосалону";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(49, 104);
            this.textBoxPhone.MaxLength = 25;
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(194, 23);
            this.textBoxPhone.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email автосалону";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(49, 162);
            this.textBoxEmail.MaxLength = 50;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(194, 23);
            this.textBoxEmail.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Часи роботи";
            // 
            // textBoxWorkingHours
            // 
            this.textBoxWorkingHours.Location = new System.Drawing.Point(49, 221);
            this.textBoxWorkingHours.Name = "textBoxWorkingHours";
            this.textBoxWorkingHours.Size = new System.Drawing.Size(194, 23);
            this.textBoxWorkingHours.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Послуги";
            // 
            // textBoxServices
            // 
            this.textBoxServices.Location = new System.Drawing.Point(49, 281);
            this.textBoxServices.Name = "textBoxServices";
            this.textBoxServices.Size = new System.Drawing.Size(262, 23);
            this.textBoxServices.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Адреса автосалону";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(49, 340);
            this.textBoxAddress.MaxLength = 100;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(262, 23);
            this.textBoxAddress.TabIndex = 12;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(157, 398);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(126, 42);
            this.buttonAdd.TabIndex = 14;
            this.buttonAdd.Text = "Додати";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // FormAddDealership
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 478);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxServices);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxWorkingHours);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxName);
            this.Name = "FormAddDealership";
            this.Text = "Додати Автосалон";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxName;
        private Label label1;
        private Label label2;
        private TextBox textBoxPhone;
        private Label label3;
        private TextBox textBoxEmail;
        private Label label4;
        private TextBox textBoxWorkingHours;
        private Label label5;
        private TextBox textBoxServices;
        private Label label6;
        private TextBox textBoxAddress;
        private Button buttonAdd;
    }
}