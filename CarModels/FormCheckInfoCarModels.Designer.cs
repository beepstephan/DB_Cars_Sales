namespace DB_Cars_Sales.CarModels
{
    partial class FormCheckInfoCarModels
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
            labelGearboxType = new Label();
            labelCylindersNum = new Label();
            labelAccelerationTo100 = new Label();
            labelMaxSpeed = new Label();
            labelPower = new Label();
            labelEngineCapacity = new Label();
            labelConfiguration = new Label();
            labelFuelConsumption = new Label();
            labelGearsNum = new Label();
            SuspendLayout();
            // 
            // labelGearboxType
            // 
            labelGearboxType.AutoSize = true;
            labelGearboxType.Location = new Point(12, 262);
            labelGearboxType.Name = "labelGearboxType";
            labelGearboxType.Size = new Size(131, 15);
            labelGearboxType.TabIndex = 13;
            labelGearboxType.Text = "Тип коробки передач: ";
            // 
            // labelCylindersNum
            // 
            labelCylindersNum.AutoSize = true;
            labelCylindersNum.Location = new Point(12, 102);
            labelCylindersNum.Name = "labelCylindersNum";
            labelCylindersNum.Size = new Size(118, 15);
            labelCylindersNum.TabIndex = 12;
            labelCylindersNum.Text = "Кількість циліндрів: ";
            // 
            // labelAccelerationTo100
            // 
            labelAccelerationTo100.AutoSize = true;
            labelAccelerationTo100.Location = new Point(12, 222);
            labelAccelerationTo100.Name = "labelAccelerationTo100";
            labelAccelerationTo100.Size = new Size(137, 15);
            labelAccelerationTo100.TabIndex = 11;
            labelAccelerationTo100.Text = "Розгін до 100 км/год, с: ";
            // 
            // labelMaxSpeed
            // 
            labelMaxSpeed.AutoSize = true;
            labelMaxSpeed.Location = new Point(12, 182);
            labelMaxSpeed.Name = "labelMaxSpeed";
            labelMaxSpeed.Size = new Size(190, 15);
            labelMaxSpeed.TabIndex = 10;
            labelMaxSpeed.Text = "Максимальна швидкість км/год: ";
            // 
            // labelPower
            // 
            labelPower.AutoSize = true;
            labelPower.Location = new Point(12, 142);
            labelPower.Name = "labelPower";
            labelPower.Size = new Size(76, 15);
            labelPower.TabIndex = 9;
            labelPower.Text = "Потужність: ";
            // 
            // labelEngineCapacity
            // 
            labelEngineCapacity.AutoSize = true;
            labelEngineCapacity.Location = new Point(12, 62);
            labelEngineCapacity.Name = "labelEngineCapacity";
            labelEngineCapacity.Size = new Size(106, 15);
            labelEngineCapacity.TabIndex = 8;
            labelEngineCapacity.Text = "Об'єм двигуна, л: ";
            // 
            // labelConfiguration
            // 
            labelConfiguration.AutoSize = true;
            labelConfiguration.Location = new Point(12, 22);
            labelConfiguration.Name = "labelConfiguration";
            labelConfiguration.Size = new Size(86, 15);
            labelConfiguration.TabIndex = 7;
            labelConfiguration.Text = "Конфігурація: ";
            // 
            // labelFuelConsumption
            // 
            labelFuelConsumption.AutoSize = true;
            labelFuelConsumption.Location = new Point(12, 343);
            labelFuelConsumption.Name = "labelFuelConsumption";
            labelFuelConsumption.Size = new Size(125, 15);
            labelFuelConsumption.TabIndex = 15;
            labelFuelConsumption.Text = "Витрати пального, л: ";
            // 
            // labelGearsNum
            // 
            labelGearsNum.AutoSize = true;
            labelGearsNum.Location = new Point(12, 303);
            labelGearsNum.Name = "labelGearsNum";
            labelGearsNum.Size = new Size(110, 15);
            labelGearsNum.TabIndex = 14;
            labelGearsNum.Text = "Кількість передач: ";
            // 
            // FormCheckInfoCarModels
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(491, 413);
            Controls.Add(labelFuelConsumption);
            Controls.Add(labelGearsNum);
            Controls.Add(labelGearboxType);
            Controls.Add(labelCylindersNum);
            Controls.Add(labelAccelerationTo100);
            Controls.Add(labelMaxSpeed);
            Controls.Add(labelPower);
            Controls.Add(labelEngineCapacity);
            Controls.Add(labelConfiguration);
            Name = "FormCheckInfoCarModels";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Інформація про модель";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelGearboxType;
        private Label labelCylindersNum;
        private Label labelAccelerationTo100;
        private Label labelMaxSpeed;
        private Label labelPower;
        private Label labelEngineCapacity;
        private Label labelConfiguration;
        private Label labelFuelConsumption;
        private Label labelGearsNum;
    }
}