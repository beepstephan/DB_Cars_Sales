namespace DB_Cars_Sales.Cars
{
    partial class FormAddCar
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
            this.comboBoxBrand = new System.Windows.Forms.ComboBox();
            this.comboBoxModel = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxBodyshell = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownYear = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxColor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxMileage = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxCondition = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxVIN = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.comboBoxConfiguration = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxDealership = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxBrand
            // 
            this.comboBoxBrand.FormattingEnabled = true;
            this.comboBoxBrand.Items.AddRange(new object[] {
            "Передній",
            "Задній",
            "Повний"});
            this.comboBoxBrand.Location = new System.Drawing.Point(12, 30);
            this.comboBoxBrand.Name = "comboBoxBrand";
            this.comboBoxBrand.Size = new System.Drawing.Size(262, 23);
            this.comboBoxBrand.TabIndex = 35;
            this.comboBoxBrand.SelectedIndexChanged += new System.EventHandler(this.comboBoxBrand_SelectedIndexChanged);
            this.comboBoxBrand.TextUpdate += new System.EventHandler(this.comboBoxBrand_TextUpdate);
            // 
            // comboBoxModel
            // 
            this.comboBoxModel.FormattingEnabled = true;
            this.comboBoxModel.Location = new System.Drawing.Point(12, 74);
            this.comboBoxModel.Name = "comboBoxModel";
            this.comboBoxModel.Size = new System.Drawing.Size(262, 23);
            this.comboBoxModel.TabIndex = 34;
            this.comboBoxModel.SelectedIndexChanged += new System.EventHandler(this.comboBoxModel_SelectedIndexChanged);
            this.comboBoxModel.TextUpdate += new System.EventHandler(this.comboBoxModel_TextUpdate);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 33;
            this.label4.Text = "Тип кузова";
            // 
            // textBoxBodyshell
            // 
            this.textBoxBodyshell.Location = new System.Drawing.Point(12, 162);
            this.textBoxBodyshell.MaxLength = 50;
            this.textBoxBodyshell.Name = "textBoxBodyshell";
            this.textBoxBodyshell.Size = new System.Drawing.Size(262, 23);
            this.textBoxBodyshell.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 31;
            this.label2.Text = "Назва моделі";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 30;
            this.label1.Text = "Назва бренду";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 36;
            this.label3.Text = "Рік випуску";
            // 
            // numericUpDownYear
            // 
            this.numericUpDownYear.Location = new System.Drawing.Point(13, 118);
            this.numericUpDownYear.Maximum = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            this.numericUpDownYear.Minimum = new decimal(new int[] {
            1885,
            0,
            0,
            0});
            this.numericUpDownYear.Name = "numericUpDownYear";
            this.numericUpDownYear.Size = new System.Drawing.Size(261, 23);
            this.numericUpDownYear.TabIndex = 37;
            this.numericUpDownYear.Value = new decimal(new int[] {
            2014,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 39;
            this.label5.Text = "Колір";
            // 
            // textBoxColor
            // 
            this.textBoxColor.Location = new System.Drawing.Point(13, 206);
            this.textBoxColor.MaxLength = 50;
            this.textBoxColor.Name = "textBoxColor";
            this.textBoxColor.Size = new System.Drawing.Size(262, 23);
            this.textBoxColor.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 15);
            this.label6.TabIndex = 41;
            this.label6.Text = "Пробіг";
            // 
            // textBoxMileage
            // 
            this.textBoxMileage.Location = new System.Drawing.Point(13, 249);
            this.textBoxMileage.MaxLength = 50;
            this.textBoxMileage.Name = "textBoxMileage";
            this.textBoxMileage.Size = new System.Drawing.Size(262, 23);
            this.textBoxMileage.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(384, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 15);
            this.label7.TabIndex = 43;
            this.label7.Text = "Ціна, ₴";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(384, 30);
            this.textBoxPrice.MaxLength = 50;
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(262, 23);
            this.textBoxPrice.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(384, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 15);
            this.label8.TabIndex = 45;
            this.label8.Text = "Стан";
            // 
            // textBoxCondition
            // 
            this.textBoxCondition.Location = new System.Drawing.Point(384, 74);
            this.textBoxCondition.MaxLength = 50;
            this.textBoxCondition.Name = "textBoxCondition";
            this.textBoxCondition.Size = new System.Drawing.Size(262, 23);
            this.textBoxCondition.TabIndex = 44;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(384, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 15);
            this.label9.TabIndex = 47;
            this.label9.Text = "VIN";
            // 
            // textBoxVIN
            // 
            this.textBoxVIN.Location = new System.Drawing.Point(384, 117);
            this.textBoxVIN.MaxLength = 50;
            this.textBoxVIN.Name = "textBoxVIN";
            this.textBoxVIN.Size = new System.Drawing.Size(262, 23);
            this.textBoxVIN.TabIndex = 46;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(384, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 15);
            this.label10.TabIndex = 49;
            this.label10.Text = "Опис";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(384, 162);
            this.textBoxDescription.MaxLength = 50;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(262, 23);
            this.textBoxDescription.TabIndex = 48;
            // 
            // comboBoxConfiguration
            // 
            this.comboBoxConfiguration.FormattingEnabled = true;
            this.comboBoxConfiguration.Location = new System.Drawing.Point(384, 206);
            this.comboBoxConfiguration.Name = "comboBoxConfiguration";
            this.comboBoxConfiguration.Size = new System.Drawing.Size(262, 23);
            this.comboBoxConfiguration.TabIndex = 51;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(384, 188);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 15);
            this.label11.TabIndex = 50;
            this.label11.Text = "Назва конфігурації";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(384, 231);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(218, 15);
            this.label12.TabIndex = 53;
            this.label12.Text = "Автосалон, який володіє автомобілем";
            // 
            // comboBoxDealership
            // 
            this.comboBoxDealership.FormattingEnabled = true;
            this.comboBoxDealership.Items.AddRange(new object[] {
            "Автосалон Audi",
            "Автосалон Volkswagen",
            "Автосалон Skoda",
            "Автосалон \"Бомбейський Пантеон\"",
            "Автосалон \"Вторинний Рай\""});
            this.comboBoxDealership.Location = new System.Drawing.Point(384, 249);
            this.comboBoxDealership.Name = "comboBoxDealership";
            this.comboBoxDealership.Size = new System.Drawing.Size(262, 23);
            this.comboBoxDealership.TabIndex = 54;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(268, 408);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(126, 42);
            this.buttonAdd.TabIndex = 55;
            this.buttonAdd.Text = "Додати";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // FormAddCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 478);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.comboBoxDealership);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboBoxConfiguration);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxVIN);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxCondition);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxMileage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxColor);
            this.Controls.Add(this.numericUpDownYear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxBrand);
            this.Controls.Add(this.comboBoxModel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxBodyshell);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAddCar";
            this.Text = "Додати машину";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBoxBrand;
        private ComboBox comboBoxModel;
        private Label label4;
        private TextBox textBoxBodyshell;
        private Label label2;
        private Label label1;
        private Label label3;
        private NumericUpDown numericUpDownYear;
        private Label label5;
        private TextBox textBoxColor;
        private Label label6;
        private TextBox textBoxMileage;
        private Label label7;
        private TextBox textBoxPrice;
        private Label label8;
        private TextBox textBoxCondition;
        private Label label9;
        private TextBox textBoxVIN;
        private Label label10;
        private TextBox textBoxDescription;
        private ComboBox comboBoxConfiguration;
        private Label label11;
        private Label label12;
        private ComboBox comboBoxDealership;
        private Button buttonAdd;
    }
}