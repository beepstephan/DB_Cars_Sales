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
            textBoxName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBoxPhone = new TextBox();
            label3 = new Label();
            textBoxEmail = new TextBox();
            label4 = new Label();
            textBoxWorkingHours = new TextBox();
            label5 = new Label();
            textBoxServices = new TextBox();
            label6 = new Label();
            textBoxAddress = new TextBox();
            buttonAdd = new Button();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(49, 46);
            textBoxName.MaxLength = 100;
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(262, 23);
            textBoxName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 28);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 3;
            label1.Text = "Назва автосалону";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 86);
            label2.Name = "label2";
            label2.Size = new Size(121, 15);
            label2.TabIndex = 5;
            label2.Text = "Телефон автосалону";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(49, 104);
            textBoxPhone.MaxLength = 25;
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(194, 23);
            textBoxPhone.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 144);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 7;
            label3.Text = "Email автосалону";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(49, 162);
            textBoxEmail.MaxLength = 50;
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(194, 23);
            textBoxEmail.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 203);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
            label4.TabIndex = 9;
            label4.Text = "Часи роботи";
            // 
            // textBoxWorkingHours
            // 
            textBoxWorkingHours.Location = new Point(49, 221);
            textBoxWorkingHours.Name = "textBoxWorkingHours";
            textBoxWorkingHours.Size = new Size(194, 23);
            textBoxWorkingHours.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 263);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 11;
            label5.Text = "Послуги";
            // 
            // textBoxServices
            // 
            textBoxServices.Location = new Point(49, 281);
            textBoxServices.Name = "textBoxServices";
            textBoxServices.Size = new Size(262, 23);
            textBoxServices.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(49, 322);
            label6.Name = "label6";
            label6.Size = new Size(112, 15);
            label6.TabIndex = 13;
            label6.Text = "Адреса автосалону";
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(49, 340);
            textBoxAddress.MaxLength = 100;
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(262, 23);
            textBoxAddress.TabIndex = 12;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(157, 398);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(126, 42);
            buttonAdd.TabIndex = 14;
            buttonAdd.Text = "Додати";
            buttonAdd.UseVisualStyleBackColor = true;
            // 
            // FormAddDealership
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 478);
            Controls.Add(buttonAdd);
            Controls.Add(label6);
            Controls.Add(textBoxAddress);
            Controls.Add(label5);
            Controls.Add(textBoxServices);
            Controls.Add(label4);
            Controls.Add(textBoxWorkingHours);
            Controls.Add(label3);
            Controls.Add(textBoxEmail);
            Controls.Add(label2);
            Controls.Add(textBoxPhone);
            Controls.Add(label1);
            Controls.Add(textBoxName);
            Name = "FormAddDealership";
            Text = "Додати Автосалон";
            ResumeLayout(false);
            PerformLayout();
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