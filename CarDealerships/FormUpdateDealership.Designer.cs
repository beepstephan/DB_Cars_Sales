namespace DB_Cars_Sales.CarDealerships
{
    partial class FormUpdateDealership
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
            buttonUpdate = new Button();
            label6 = new Label();
            textBoxAddress = new TextBox();
            label5 = new Label();
            textBoxServices = new TextBox();
            label4 = new Label();
            textBoxWorkingHours = new TextBox();
            label3 = new Label();
            textBoxEmail = new TextBox();
            label2 = new Label();
            textBoxPhone = new TextBox();
            label1 = new Label();
            textBoxName = new TextBox();
            SuspendLayout();
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(167, 402);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(126, 42);
            buttonUpdate.TabIndex = 27;
            buttonUpdate.Text = "Оновити";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(59, 326);
            label6.Name = "label6";
            label6.Size = new Size(112, 15);
            label6.TabIndex = 26;
            label6.Text = "Адреса автосалону";
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(59, 344);
            textBoxAddress.MaxLength = 100;
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(262, 23);
            textBoxAddress.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(59, 267);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 24;
            label5.Text = "Послуги";
            // 
            // textBoxServices
            // 
            textBoxServices.Location = new Point(59, 285);
            textBoxServices.Name = "textBoxServices";
            textBoxServices.Size = new Size(262, 23);
            textBoxServices.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(59, 207);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
            label4.TabIndex = 22;
            label4.Text = "Часи роботи";
            // 
            // textBoxWorkingHours
            // 
            textBoxWorkingHours.Location = new Point(59, 225);
            textBoxWorkingHours.Name = "textBoxWorkingHours";
            textBoxWorkingHours.Size = new Size(194, 23);
            textBoxWorkingHours.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 148);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 20;
            label3.Text = "Email автосалону";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(59, 166);
            textBoxEmail.MaxLength = 50;
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(194, 23);
            textBoxEmail.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 90);
            label2.Name = "label2";
            label2.Size = new Size(121, 15);
            label2.TabIndex = 18;
            label2.Text = "Телефон автосалону";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(59, 108);
            textBoxPhone.MaxLength = 25;
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(194, 23);
            textBoxPhone.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 32);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 16;
            label1.Text = "Назва автосалону";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(59, 50);
            textBoxName.MaxLength = 100;
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(262, 23);
            textBoxName.TabIndex = 15;
            // 
            // FormUpdateDealership
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 478);
            Controls.Add(buttonUpdate);
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
            Name = "FormUpdateDealership";
            Text = "Оновлення даних";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonUpdate;
        private Label label6;
        private TextBox textBoxAddress;
        private Label label5;
        private TextBox textBoxServices;
        private Label label4;
        private TextBox textBoxWorkingHours;
        private Label label3;
        private TextBox textBoxEmail;
        private Label label2;
        private TextBox textBoxPhone;
        private Label label1;
        private TextBox textBoxName;
    }
}