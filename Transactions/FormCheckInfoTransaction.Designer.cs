namespace DB_Cars_Sales.Transactions
{
    partial class FormCheckInfoTransaction
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
            this.labelBrand = new System.Windows.Forms.Label();
            this.labelModel = new System.Windows.Forms.Label();
            this.labelCustomerName = new System.Windows.Forms.Label();
            this.labelEmployeeName = new System.Windows.Forms.Label();
            this.labelDealershipName = new System.Windows.Forms.Label();
            this.labelЗPrice = new System.Windows.Forms.Label();
            this.labelService = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelBrand
            // 
            this.labelBrand.AutoSize = true;
            this.labelBrand.Location = new System.Drawing.Point(12, 9);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(73, 15);
            this.labelBrand.TabIndex = 0;
            this.labelBrand.Text = "Марка авто:";
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Location = new System.Drawing.Point(12, 49);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(83, 15);
            this.labelModel.TabIndex = 1;
            this.labelModel.Text = "Модель авто: ";
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.AutoSize = true;
            this.labelCustomerName.Location = new System.Drawing.Point(12, 129);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(94, 15);
            this.labelCustomerName.TabIndex = 2;
            this.labelCustomerName.Text = "Покупець авто: ";
            // 
            // labelEmployeeName
            // 
            this.labelEmployeeName.AutoSize = true;
            this.labelEmployeeName.Location = new System.Drawing.Point(12, 169);
            this.labelEmployeeName.Name = "labelEmployeeName";
            this.labelEmployeeName.Size = new System.Drawing.Size(100, 15);
            this.labelEmployeeName.TabIndex = 3;
            this.labelEmployeeName.Text = "Продавець авто: ";
            // 
            // labelDealershipName
            // 
            this.labelDealershipName.AutoSize = true;
            this.labelDealershipName.Location = new System.Drawing.Point(12, 209);
            this.labelDealershipName.Name = "labelDealershipName";
            this.labelDealershipName.Size = new System.Drawing.Size(173, 15);
            this.labelDealershipName.TabIndex = 4;
            this.labelDealershipName.Text = "Автосалон, який продав авто: ";
            // 
            // labelЗPrice
            // 
            this.labelЗPrice.AutoSize = true;
            this.labelЗPrice.Location = new System.Drawing.Point(12, 89);
            this.labelЗPrice.Name = "labelЗPrice";
            this.labelЗPrice.Size = new System.Drawing.Size(65, 15);
            this.labelЗPrice.TabIndex = 5;
            this.labelЗPrice.Text = "Ціна авто: ";
            // 
            // labelService
            // 
            this.labelService.AutoSize = true;
            this.labelService.Location = new System.Drawing.Point(12, 249);
            this.labelService.Name = "labelService";
            this.labelService.Size = new System.Drawing.Size(118, 15);
            this.labelService.TabIndex = 6;
            this.labelService.Text = "Деталі сервісу авто: ";
            // 
            // FormCheckInfoTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelService);
            this.Controls.Add(this.labelЗPrice);
            this.Controls.Add(this.labelDealershipName);
            this.Controls.Add(this.labelEmployeeName);
            this.Controls.Add(this.labelCustomerName);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.labelBrand);
            this.Name = "FormCheckInfoTransaction";
            this.Text = "Деталі транзакції";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelBrand;
        private Label labelModel;
        private Label labelCustomerName;
        private Label labelEmployeeName;
        private Label labelDealershipName;
        private Label labelЗPrice;
        private Label labelService;
    }
}