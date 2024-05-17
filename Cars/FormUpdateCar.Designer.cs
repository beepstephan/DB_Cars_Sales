namespace DB_Cars_Sales.Cars
{
    partial class FormUpdateCar
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
            comboBoxDealership = new ComboBox();
            label12 = new Label();
            comboBoxConfiguration = new ComboBox();
            label11 = new Label();
            label10 = new Label();
            textBoxDescription = new TextBox();
            label9 = new Label();
            textBoxVIN = new TextBox();
            label8 = new Label();
            textBoxCondition = new TextBox();
            label7 = new Label();
            textBoxPrice = new TextBox();
            label6 = new Label();
            textBoxMileage = new TextBox();
            label5 = new Label();
            textBoxColor = new TextBox();
            numericUpDownYear = new NumericUpDown();
            label3 = new Label();
            comboBoxBrand = new ComboBox();
            comboBoxModel = new ComboBox();
            label4 = new Label();
            textBoxBodyshell = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownYear).BeginInit();
            SuspendLayout();
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(306, 554);
            buttonUpdate.Margin = new Padding(3, 4, 3, 4);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(144, 56);
            buttonUpdate.TabIndex = 80;
            buttonUpdate.Text = "Оновити";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // comboBoxDealership
            // 
            comboBoxDealership.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDealership.FormattingEnabled = true;
            comboBoxDealership.Items.AddRange(new object[] { "Автосалон Audi", "Автосалон Volkswagen", "Автосалон Skoda", "Автосалон \"Бомбейський Пантеон\"", "Автосалон \"Вторинний Рай\"" });
            comboBoxDealership.Location = new Point(439, 342);
            comboBoxDealership.Margin = new Padding(3, 4, 3, 4);
            comboBoxDealership.Name = "comboBoxDealership";
            comboBoxDealership.Size = new Size(299, 28);
            comboBoxDealership.TabIndex = 79;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(439, 318);
            label12.Name = "label12";
            label12.Size = new Size(275, 20);
            label12.TabIndex = 78;
            label12.Text = "Автосалон, який володіє автомобілем";
            // 
            // comboBoxConfiguration
            // 
            comboBoxConfiguration.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxConfiguration.FormattingEnabled = true;
            comboBoxConfiguration.Location = new Point(439, 285);
            comboBoxConfiguration.Margin = new Padding(3, 4, 3, 4);
            comboBoxConfiguration.Name = "comboBoxConfiguration";
            comboBoxConfiguration.Size = new Size(299, 28);
            comboBoxConfiguration.TabIndex = 77;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(439, 261);
            label11.Name = "label11";
            label11.Size = new Size(141, 20);
            label11.TabIndex = 76;
            label11.Text = "Назва конфігурації";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(439, 202);
            label10.Name = "label10";
            label10.Size = new Size(45, 20);
            label10.TabIndex = 75;
            label10.Text = "Опис";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(439, 226);
            textBoxDescription.Margin = new Padding(3, 4, 3, 4);
            textBoxDescription.MaxLength = 50;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(299, 27);
            textBoxDescription.TabIndex = 74;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(439, 142);
            label9.Name = "label9";
            label9.Size = new Size(33, 20);
            label9.TabIndex = 73;
            label9.Text = "VIN";
            // 
            // textBoxVIN
            // 
            textBoxVIN.Enabled = false;
            textBoxVIN.Location = new Point(439, 166);
            textBoxVIN.Margin = new Padding(3, 4, 3, 4);
            textBoxVIN.MaxLength = 50;
            textBoxVIN.Name = "textBoxVIN";
            textBoxVIN.Size = new Size(299, 27);
            textBoxVIN.TabIndex = 72;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(439, 85);
            label8.Name = "label8";
            label8.Size = new Size(41, 20);
            label8.TabIndex = 71;
            label8.Text = "Стан";
            // 
            // textBoxCondition
            // 
            textBoxCondition.Location = new Point(439, 109);
            textBoxCondition.Margin = new Padding(3, 4, 3, 4);
            textBoxCondition.MaxLength = 50;
            textBoxCondition.Name = "textBoxCondition";
            textBoxCondition.Size = new Size(299, 27);
            textBoxCondition.TabIndex = 70;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(439, 26);
            label7.Name = "label7";
            label7.Size = new Size(56, 20);
            label7.TabIndex = 69;
            label7.Text = "Ціна, ₴";
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(439, 50);
            textBoxPrice.Margin = new Padding(3, 4, 3, 4);
            textBoxPrice.MaxLength = 50;
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(299, 27);
            textBoxPrice.TabIndex = 68;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 318);
            label6.Name = "label6";
            label6.Size = new Size(57, 20);
            label6.TabIndex = 67;
            label6.Text = "Пробіг";
            // 
            // textBoxMileage
            // 
            textBoxMileage.Location = new Point(15, 342);
            textBoxMileage.Margin = new Padding(3, 4, 3, 4);
            textBoxMileage.MaxLength = 50;
            textBoxMileage.Name = "textBoxMileage";
            textBoxMileage.Size = new Size(299, 27);
            textBoxMileage.TabIndex = 66;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 261);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 65;
            label5.Text = "Колір";
            // 
            // textBoxColor
            // 
            textBoxColor.Location = new Point(15, 285);
            textBoxColor.Margin = new Padding(3, 4, 3, 4);
            textBoxColor.MaxLength = 50;
            textBoxColor.Name = "textBoxColor";
            textBoxColor.Size = new Size(299, 27);
            textBoxColor.TabIndex = 64;
            // 
            // numericUpDownYear
            // 
            numericUpDownYear.Location = new Point(15, 167);
            numericUpDownYear.Margin = new Padding(3, 4, 3, 4);
            numericUpDownYear.Maximum = new decimal(new int[] { 2024, 0, 0, 0 });
            numericUpDownYear.Minimum = new decimal(new int[] { 1885, 0, 0, 0 });
            numericUpDownYear.Name = "numericUpDownYear";
            numericUpDownYear.Size = new Size(298, 27);
            numericUpDownYear.TabIndex = 63;
            numericUpDownYear.Value = new decimal(new int[] { 2014, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 143);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 62;
            label3.Text = "Рік випуску";
            // 
            // comboBoxBrand
            // 
            comboBoxBrand.FormattingEnabled = true;
            comboBoxBrand.Location = new Point(14, 50);
            comboBoxBrand.Margin = new Padding(3, 4, 3, 4);
            comboBoxBrand.Name = "comboBoxBrand";
            comboBoxBrand.Size = new Size(299, 28);
            comboBoxBrand.TabIndex = 61;
            comboBoxBrand.SelectedIndexChanged += comboBoxBrand_SelectedIndexChanged;
            comboBoxBrand.TextUpdate += comboBoxBrand_TextUpdate;
            // 
            // comboBoxModel
            // 
            comboBoxModel.FormattingEnabled = true;
            comboBoxModel.Location = new Point(14, 109);
            comboBoxModel.Margin = new Padding(3, 4, 3, 4);
            comboBoxModel.Name = "comboBoxModel";
            comboBoxModel.Size = new Size(299, 28);
            comboBoxModel.TabIndex = 60;
            comboBoxModel.SelectedIndexChanged += comboBoxModel_SelectedIndexChanged;
            comboBoxModel.TextUpdate += comboBoxModel_TextUpdate;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 202);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 59;
            label4.Text = "Тип кузова";
            // 
            // textBoxBodyshell
            // 
            textBoxBodyshell.Location = new Point(14, 226);
            textBoxBodyshell.Margin = new Padding(3, 4, 3, 4);
            textBoxBodyshell.MaxLength = 50;
            textBoxBodyshell.Name = "textBoxBodyshell";
            textBoxBodyshell.Size = new Size(299, 27);
            textBoxBodyshell.TabIndex = 58;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 85);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 57;
            label2.Text = "Назва моделі";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 26);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 56;
            label1.Text = "Назва бренду";
            // 
            // FormUpdateCar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 637);
            Controls.Add(buttonUpdate);
            Controls.Add(comboBoxDealership);
            Controls.Add(label12);
            Controls.Add(comboBoxConfiguration);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(textBoxDescription);
            Controls.Add(label9);
            Controls.Add(textBoxVIN);
            Controls.Add(label8);
            Controls.Add(textBoxCondition);
            Controls.Add(label7);
            Controls.Add(textBoxPrice);
            Controls.Add(label6);
            Controls.Add(textBoxMileage);
            Controls.Add(label5);
            Controls.Add(textBoxColor);
            Controls.Add(numericUpDownYear);
            Controls.Add(label3);
            Controls.Add(comboBoxBrand);
            Controls.Add(comboBoxModel);
            Controls.Add(label4);
            Controls.Add(textBoxBodyshell);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormUpdateCar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Оновити дані";
            ((System.ComponentModel.ISupportInitialize)numericUpDownYear).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonUpdate;
        private ComboBox comboBoxDealership;
        private Label label12;
        private ComboBox comboBoxConfiguration;
        private Label label11;
        private Label label10;
        private TextBox textBoxDescription;
        private Label label9;
        private TextBox textBoxVIN;
        private Label label8;
        private TextBox textBoxCondition;
        private Label label7;
        private TextBox textBoxPrice;
        private Label label6;
        private TextBox textBoxMileage;
        private Label label5;
        private TextBox textBoxColor;
        private NumericUpDown numericUpDownYear;
        private Label label3;
        private ComboBox comboBoxBrand;
        private ComboBox comboBoxModel;
        private Label label4;
        private TextBox textBoxBodyshell;
        private Label label2;
        private Label label1;
    }
}