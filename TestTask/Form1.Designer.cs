namespace TestTask
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgv_provider = new System.Windows.Forms.DataGridView();
            this.but_providers = new System.Windows.Forms.Button();
            this.dgv_product = new System.Windows.Forms.DataGridView();
            this.dgv_receipt = new System.Windows.Forms.DataGridView();
            this.dtp_receipt = new System.Windows.Forms.DateTimePicker();
            this.tb_number_kg = new System.Windows.Forms.TextBox();
            this.but_accept_receipt = new System.Windows.Forms.Button();
            this.make_report = new System.Windows.Forms.Button();
            this.to = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.period = new System.Windows.Forms.Label();
            this.dgv_report = new System.Windows.Forms.DataGridView();
            this.but_products = new System.Windows.Forms.Button();
            this.but_receipt = new System.Windows.Forms.Button();
            this.tb_name_provider = new System.Windows.Forms.TextBox();
            this.make_provider = new System.Windows.Forms.Button();
            this.tb_price_per_kg = new System.Windows.Forms.TextBox();
            this.tb_variety = new System.Windows.Forms.TextBox();
            this.make_product = new System.Windows.Forms.Button();
            this.cb_provider = new System.Windows.Forms.ComboBox();
            this.cb_product = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_provider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_receipt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_report)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(715, 273);
            this.tabControl1.TabIndex = 19;
            this.tabControl1.Click += new System.EventHandler(this.but_providers_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tb_name_provider);
            this.tabPage1.Controls.Add(this.make_provider);
            this.tabPage1.Controls.Add(this.dgv_provider);
            this.tabPage1.Controls.Add(this.but_providers);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(707, 247);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Поставщики";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tb_price_per_kg);
            this.tabPage2.Controls.Add(this.tb_variety);
            this.tabPage2.Controls.Add(this.make_product);
            this.tabPage2.Controls.Add(this.but_products);
            this.tabPage2.Controls.Add(this.dgv_product);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(707, 247);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Продукты";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.cb_product);
            this.tabPage3.Controls.Add(this.cb_provider);
            this.tabPage3.Controls.Add(this.but_receipt);
            this.tabPage3.Controls.Add(this.dtp_receipt);
            this.tabPage3.Controls.Add(this.tb_number_kg);
            this.tabPage3.Controls.Add(this.but_accept_receipt);
            this.tabPage3.Controls.Add(this.dgv_receipt);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(707, 247);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Поставки";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dgv_report);
            this.tabPage4.Controls.Add(this.make_report);
            this.tabPage4.Controls.Add(this.to);
            this.tabPage4.Controls.Add(this.dateTimePicker2);
            this.tabPage4.Controls.Add(this.dateTimePicker1);
            this.tabPage4.Controls.Add(this.period);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(707, 247);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Отчет";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgv_provider
            // 
            this.dgv_provider.AllowUserToAddRows = false;
            this.dgv_provider.AllowUserToDeleteRows = false;
            this.dgv_provider.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_provider.Location = new System.Drawing.Point(143, 1);
            this.dgv_provider.Name = "dgv_provider";
            this.dgv_provider.ReadOnly = true;
            this.dgv_provider.Size = new System.Drawing.Size(546, 173);
            this.dgv_provider.TabIndex = 23;
            // 
            // but_providers
            // 
            this.but_providers.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.but_providers.Location = new System.Drawing.Point(18, 28);
            this.but_providers.Name = "but_providers";
            this.but_providers.Size = new System.Drawing.Size(93, 46);
            this.but_providers.TabIndex = 19;
            this.but_providers.Text = "Показать поставщиков";
            this.but_providers.UseVisualStyleBackColor = false;
            this.but_providers.Click += new System.EventHandler(this.but_providers_Click);
            // 
            // dgv_product
            // 
            this.dgv_product.AllowUserToAddRows = false;
            this.dgv_product.AllowUserToDeleteRows = false;
            this.dgv_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_product.Location = new System.Drawing.Point(153, 6);
            this.dgv_product.Name = "dgv_product";
            this.dgv_product.ReadOnly = true;
            this.dgv_product.Size = new System.Drawing.Size(546, 173);
            this.dgv_product.TabIndex = 24;
            // 
            // dgv_receipt
            // 
            this.dgv_receipt.AllowUserToAddRows = false;
            this.dgv_receipt.AllowUserToDeleteRows = false;
            this.dgv_receipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_receipt.Location = new System.Drawing.Point(136, 6);
            this.dgv_receipt.Name = "dgv_receipt";
            this.dgv_receipt.ReadOnly = true;
            this.dgv_receipt.Size = new System.Drawing.Size(546, 173);
            this.dgv_receipt.TabIndex = 24;
            // 
            // dtp_receipt
            // 
            this.dtp_receipt.Location = new System.Drawing.Point(224, 187);
            this.dtp_receipt.Name = "dtp_receipt";
            this.dtp_receipt.Size = new System.Drawing.Size(138, 20);
            this.dtp_receipt.TabIndex = 37;
            // 
            // tb_number_kg
            // 
            this.tb_number_kg.Location = new System.Drawing.Point(469, 188);
            this.tb_number_kg.Name = "tb_number_kg";
            this.tb_number_kg.Size = new System.Drawing.Size(100, 20);
            this.tb_number_kg.TabIndex = 36;
            this.tb_number_kg.Text = "число кг";
            // 
            // but_accept_receipt
            // 
            this.but_accept_receipt.BackColor = System.Drawing.SystemColors.Highlight;
            this.but_accept_receipt.Location = new System.Drawing.Point(576, 185);
            this.but_accept_receipt.Name = "but_accept_receipt";
            this.but_accept_receipt.Size = new System.Drawing.Size(106, 24);
            this.but_accept_receipt.TabIndex = 33;
            this.but_accept_receipt.Text = "Принять товары";
            this.but_accept_receipt.UseVisualStyleBackColor = false;
            this.but_accept_receipt.Click += new System.EventHandler(this.but_accept_receipt_Click);
            // 
            // make_report
            // 
            this.make_report.BackColor = System.Drawing.SystemColors.Info;
            this.make_report.Location = new System.Drawing.Point(529, 7);
            this.make_report.Name = "make_report";
            this.make_report.Size = new System.Drawing.Size(101, 23);
            this.make_report.TabIndex = 32;
            this.make_report.Text = "Составить отчет";
            this.make_report.UseVisualStyleBackColor = false;
            this.make_report.Click += new System.EventHandler(this.make_report_Click);
            // 
            // to
            // 
            this.to.AutoSize = true;
            this.to.Location = new System.Drawing.Point(324, 12);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(22, 13);
            this.to.TabIndex = 31;
            this.to.Text = "по:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(352, 6);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(143, 20);
            this.dateTimePicker2.TabIndex = 30;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(180, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(138, 20);
            this.dateTimePicker1.TabIndex = 29;
            // 
            // period
            // 
            this.period.AutoSize = true;
            this.period.Location = new System.Drawing.Point(114, 12);
            this.period.Name = "period";
            this.period.Size = new System.Drawing.Size(60, 13);
            this.period.TabIndex = 28;
            this.period.Text = " Период с:";
            // 
            // dgv_report
            // 
            this.dgv_report.AllowUserToAddRows = false;
            this.dgv_report.AllowUserToDeleteRows = false;
            this.dgv_report.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_report.Location = new System.Drawing.Point(84, 36);
            this.dgv_report.Name = "dgv_report";
            this.dgv_report.ReadOnly = true;
            this.dgv_report.Size = new System.Drawing.Size(546, 173);
            this.dgv_report.TabIndex = 33;
            // 
            // but_products
            // 
            this.but_products.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.but_products.Location = new System.Drawing.Point(20, 28);
            this.but_products.Name = "but_products";
            this.but_products.Size = new System.Drawing.Size(93, 38);
            this.but_products.TabIndex = 25;
            this.but_products.Text = "Показать продукты";
            this.but_products.UseVisualStyleBackColor = false;
            this.but_products.Click += new System.EventHandler(this.but_products_Click);
            // 
            // but_receipt
            // 
            this.but_receipt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.but_receipt.Location = new System.Drawing.Point(23, 30);
            this.but_receipt.Name = "but_receipt";
            this.but_receipt.Size = new System.Drawing.Size(93, 38);
            this.but_receipt.TabIndex = 38;
            this.but_receipt.Text = "Показать товары";
            this.but_receipt.UseVisualStyleBackColor = false;
            this.but_receipt.Click += new System.EventHandler(this.but_receipt_Click);
            // 
            // tb_name_provider
            // 
            this.tb_name_provider.Location = new System.Drawing.Point(443, 192);
            this.tb_name_provider.Name = "tb_name_provider";
            this.tb_name_provider.Size = new System.Drawing.Size(100, 20);
            this.tb_name_provider.TabIndex = 41;
            this.tb_name_provider.Text = "Имя поставщика";
            // 
            // make_provider
            // 
            this.make_provider.BackColor = System.Drawing.SystemColors.Highlight;
            this.make_provider.Location = new System.Drawing.Point(549, 189);
            this.make_provider.Name = "make_provider";
            this.make_provider.Size = new System.Drawing.Size(138, 24);
            this.make_provider.TabIndex = 38;
            this.make_provider.Text = "Добавить поставщика";
            this.make_provider.UseVisualStyleBackColor = false;
            this.make_provider.Click += new System.EventHandler(this.make_provider_Click);
            // 
            // tb_price_per_kg
            // 
            this.tb_price_per_kg.Location = new System.Drawing.Point(474, 200);
            this.tb_price_per_kg.Name = "tb_price_per_kg";
            this.tb_price_per_kg.Size = new System.Drawing.Size(100, 20);
            this.tb_price_per_kg.TabIndex = 41;
            this.tb_price_per_kg.Text = "цена за кг";
            // 
            // tb_variety
            // 
            this.tb_variety.Location = new System.Drawing.Point(368, 200);
            this.tb_variety.Name = "tb_variety";
            this.tb_variety.Size = new System.Drawing.Size(100, 20);
            this.tb_variety.TabIndex = 40;
            this.tb_variety.Text = "сорт продукта";
            // 
            // make_product
            // 
            this.make_product.BackColor = System.Drawing.SystemColors.Highlight;
            this.make_product.Location = new System.Drawing.Point(580, 197);
            this.make_product.Name = "make_product";
            this.make_product.Size = new System.Drawing.Size(119, 24);
            this.make_product.TabIndex = 38;
            this.make_product.Text = "Добавить продукт";
            this.make_product.UseVisualStyleBackColor = false;
            this.make_product.Click += new System.EventHandler(this.make_product_Click);
            // 
            // cb_provider
            // 
            this.cb_provider.FormattingEnabled = true;
            this.cb_provider.Location = new System.Drawing.Point(136, 187);
            this.cb_provider.Name = "cb_provider";
            this.cb_provider.Size = new System.Drawing.Size(82, 21);
            this.cb_provider.TabIndex = 39;
            // 
            // cb_product
            // 
            this.cb_product.FormattingEnabled = true;
            this.cb_product.Location = new System.Drawing.Point(368, 187);
            this.cb_product.Name = "cb_product";
            this.cb_product.Size = new System.Drawing.Size(95, 21);
            this.cb_product.TabIndex = 40;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 266);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Интерфейс приема товаров";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_provider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_receipt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_report)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dgv_provider;
        private System.Windows.Forms.Button but_providers;
        private System.Windows.Forms.DataGridView dgv_product;
        private System.Windows.Forms.DateTimePicker dtp_receipt;
        private System.Windows.Forms.TextBox tb_number_kg;
        private System.Windows.Forms.Button but_accept_receipt;
        private System.Windows.Forms.DataGridView dgv_receipt;
        private System.Windows.Forms.DataGridView dgv_report;
        private System.Windows.Forms.Button make_report;
        private System.Windows.Forms.Label to;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label period;
        private System.Windows.Forms.Button but_products;
        private System.Windows.Forms.Button but_receipt;
        private System.Windows.Forms.TextBox tb_name_provider;
        private System.Windows.Forms.Button make_provider;
        private System.Windows.Forms.TextBox tb_price_per_kg;
        private System.Windows.Forms.TextBox tb_variety;
        private System.Windows.Forms.Button make_product;
        private System.Windows.Forms.ComboBox cb_product;
        private System.Windows.Forms.ComboBox cb_provider;
    }
}

