namespace DB_Cars_Sales.CarModels
{
    partial class FormAddModel
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
            textBoxBrand = new TextBox();
            label2 = new Label();
            textBoxModel = new TextBox();
            label3 = new Label();
            textBoxConfiguration = new TextBox();
            label4 = new Label();
            textBoxBodyshell = new TextBox();
            label5 = new Label();
            textBoxEngine = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBoxYears = new TextBox();
            buttonAdd = new Button();
            textBoxTransmission = new TextBox();
            comboBoxDrive = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 9;
            label1.Text = "Назва бренду";
            // 
            // textBoxBrand
            // 
            textBoxBrand.Location = new Point(12, 27);
            textBoxBrand.MaxLength = 100;
            textBoxBrand.Name = "textBoxBrand";
            textBoxBrand.Size = new Size(262, 23);
            textBoxBrand.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 11;
            label2.Text = "Назва моделі";
            // 
            // textBoxModel
            // 
            textBoxModel.Location = new Point(12, 71);
            textBoxModel.MaxLength = 100;
            textBoxModel.Name = "textBoxModel";
            textBoxModel.Size = new Size(262, 23);
            textBoxModel.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 97);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 13;
            label3.Text = "Конфігурація";
            // 
            // textBoxConfiguration
            // 
            textBoxConfiguration.Location = new Point(12, 115);
            textBoxConfiguration.MaxLength = 100;
            textBoxConfiguration.Name = "textBoxConfiguration";
            textBoxConfiguration.Size = new Size(262, 23);
            textBoxConfiguration.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 141);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 15;
            label4.Text = "Тип кузова";
            // 
            // textBoxBodyshell
            // 
            textBoxBodyshell.Location = new Point(12, 159);
            textBoxBodyshell.MaxLength = 50;
            textBoxBodyshell.Name = "textBoxBodyshell";
            textBoxBodyshell.Size = new Size(262, 23);
            textBoxBodyshell.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 185);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 17;
            label5.Text = "Двигун";
            // 
            // textBoxEngine
            // 
            textBoxEngine.Location = new Point(12, 203);
            textBoxEngine.MaxLength = 75;
            textBoxEngine.Name = "textBoxEngine";
            textBoxEngine.Size = new Size(262, 23);
            textBoxEngine.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 229);
            label6.Name = "label6";
            label6.Size = new Size(66, 15);
            label6.TabIndex = 19;
            label6.Text = "Трансмісія";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 273);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 21;
            label7.Text = "Привід";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 317);
            label8.Name = "label8";
            label8.Size = new Size(81, 15);
            label8.TabIndex = 23;
            label8.Text = "Роки випуску";
            // 
            // textBoxYears
            // 
            textBoxYears.Location = new Point(12, 335);
            textBoxYears.MaxLength = 50;
            textBoxYears.Name = "textBoxYears";
            textBoxYears.Size = new Size(262, 23);
            textBoxYears.TabIndex = 22;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(148, 403);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(126, 42);
            buttonAdd.TabIndex = 26;
            buttonAdd.Text = "Додати";
            buttonAdd.UseVisualStyleBackColor = true;
            // 
            // textBoxTransmission
            // 
            textBoxTransmission.Location = new Point(12, 247);
            textBoxTransmission.MaxLength = 75;
            textBoxTransmission.Name = "textBoxTransmission";
            textBoxTransmission.Size = new Size(262, 23);
            textBoxTransmission.TabIndex = 18;
            // 
            // comboBoxDrive
            // 
            comboBoxDrive.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDrive.FormattingEnabled = true;
            comboBoxDrive.Items.AddRange(new object[] { "Передній", "Задній", "Повний" });
            comboBoxDrive.Location = new Point(12, 291);
            comboBoxDrive.Name = "comboBoxDrive";
            comboBoxDrive.Size = new Size(262, 23);
            comboBoxDrive.TabIndex = 27;
            // 
            // FormAddModel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 478);
            Controls.Add(comboBoxDrive);
            Controls.Add(buttonAdd);
            Controls.Add(label8);
            Controls.Add(textBoxYears);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBoxTransmission);
            Controls.Add(label5);
            Controls.Add(textBoxEngine);
            Controls.Add(label4);
            Controls.Add(textBoxBodyshell);
            Controls.Add(label3);
            Controls.Add(textBoxConfiguration);
            Controls.Add(label2);
            Controls.Add(textBoxModel);
            Controls.Add(label1);
            Controls.Add(textBoxBrand);
            Name = "FormAddModel";
            Text = "Додати модель";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxBrand;
        private Label label2;
        private TextBox textBoxModel;
        private Label label3;
        private TextBox textBoxConfiguration;
        private Label label4;
        private TextBox textBoxBodyshell;
        private Label label5;
        private TextBox textBoxEngine;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBoxYears;
        private Button buttonAdd;
        private TextBox textBoxTransmission;
        private ComboBox comboBoxDrive;
    }
}