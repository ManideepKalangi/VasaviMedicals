namespace VasaviMedicals
{
    partial class Admin_SaleEntry
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label customer_NameLabel;
            System.Windows.Forms.Label phone_NumberLabel;
            System.Windows.Forms.Label company_NameLabel;
            System.Windows.Forms.Label product_NameLabel;
            System.Windows.Forms.Label batch_NoLabel;
            System.Windows.Forms.Label expiry_DateLabel;
            System.Windows.Forms.Label quantityLabel;
            System.Windows.Forms.Label sale_DateLabel;
            System.Windows.Forms.Label mRPLabel;
            System.Windows.Forms.Label discountLabel;
            System.Windows.Forms.Label priceLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_SaleEntry));
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.sale_dataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vsmsDataSet = new VasaviMedicals.vsmsDataSet();
            this.customer_NameTextBox = new System.Windows.Forms.TextBox();
            this.phone_NumberTextBox = new System.Windows.Forms.TextBox();
            this.company_NameTextBox = new System.Windows.Forms.TextBox();
            this.product_NameTextBox = new System.Windows.Forms.TextBox();
            this.batch_NoTextBox = new System.Windows.Forms.TextBox();
            this.expiry_DateTextBox = new System.Windows.Forms.TextBox();
            this.quantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.sale_DateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.mRPTextBox = new System.Windows.Forms.TextBox();
            this.discountTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sale_dataDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sale_dataTableAdapter = new VasaviMedicals.vsmsDataSetTableAdapters.Sale_dataTableAdapter();
            this.tableAdapterManager = new VasaviMedicals.vsmsDataSetTableAdapters.TableAdapterManager();
            this.avail_stockTableAdapter = new VasaviMedicals.vsmsDataSetTableAdapters.Avail_stockTableAdapter();
            this.avail_stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            idLabel = new System.Windows.Forms.Label();
            customer_NameLabel = new System.Windows.Forms.Label();
            phone_NumberLabel = new System.Windows.Forms.Label();
            company_NameLabel = new System.Windows.Forms.Label();
            product_NameLabel = new System.Windows.Forms.Label();
            batch_NoLabel = new System.Windows.Forms.Label();
            expiry_DateLabel = new System.Windows.Forms.Label();
            quantityLabel = new System.Windows.Forms.Label();
            sale_DateLabel = new System.Windows.Forms.Label();
            mRPLabel = new System.Windows.Forms.Label();
            discountLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sale_dataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vsmsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sale_dataDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avail_stockBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.Location = new System.Drawing.Point(122, 35);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(30, 20);
            idLabel.TabIndex = 0;
            idLabel.Text = "Id:";
            // 
            // customer_NameLabel
            // 
            customer_NameLabel.AutoSize = true;
            customer_NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            customer_NameLabel.Location = new System.Drawing.Point(122, 66);
            customer_NameLabel.Name = "customer_NameLabel";
            customer_NameLabel.Size = new System.Drawing.Size(142, 20);
            customer_NameLabel.TabIndex = 2;
            customer_NameLabel.Text = "Customer Name:";
            // 
            // phone_NumberLabel
            // 
            phone_NumberLabel.AutoSize = true;
            phone_NumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            phone_NumberLabel.Location = new System.Drawing.Point(122, 97);
            phone_NumberLabel.Name = "phone_NumberLabel";
            phone_NumberLabel.Size = new System.Drawing.Size(132, 20);
            phone_NumberLabel.TabIndex = 4;
            phone_NumberLabel.Text = "Phone Number:";
            // 
            // company_NameLabel
            // 
            company_NameLabel.AutoSize = true;
            company_NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            company_NameLabel.Location = new System.Drawing.Point(122, 128);
            company_NameLabel.Name = "company_NameLabel";
            company_NameLabel.Size = new System.Drawing.Size(139, 20);
            company_NameLabel.TabIndex = 6;
            company_NameLabel.Text = "Company Name:";
            // 
            // product_NameLabel
            // 
            product_NameLabel.AutoSize = true;
            product_NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            product_NameLabel.Location = new System.Drawing.Point(122, 159);
            product_NameLabel.Name = "product_NameLabel";
            product_NameLabel.Size = new System.Drawing.Size(127, 20);
            product_NameLabel.TabIndex = 8;
            product_NameLabel.Text = "Product Name:";
            // 
            // batch_NoLabel
            // 
            batch_NoLabel.AutoSize = true;
            batch_NoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            batch_NoLabel.Location = new System.Drawing.Point(122, 190);
            batch_NoLabel.Name = "batch_NoLabel";
            batch_NoLabel.Size = new System.Drawing.Size(88, 20);
            batch_NoLabel.TabIndex = 10;
            batch_NoLabel.Text = "Batch No:";
            // 
            // expiry_DateLabel
            // 
            expiry_DateLabel.AutoSize = true;
            expiry_DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            expiry_DateLabel.Location = new System.Drawing.Point(603, 35);
            expiry_DateLabel.Name = "expiry_DateLabel";
            expiry_DateLabel.Size = new System.Drawing.Size(106, 20);
            expiry_DateLabel.TabIndex = 12;
            expiry_DateLabel.Text = "Expiry Date:";
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            quantityLabel.Location = new System.Drawing.Point(603, 63);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(81, 20);
            quantityLabel.TabIndex = 14;
            quantityLabel.Text = "Quantity:";
            // 
            // sale_DateLabel
            // 
            sale_DateLabel.AutoSize = true;
            sale_DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sale_DateLabel.Location = new System.Drawing.Point(603, 98);
            sale_DateLabel.Name = "sale_DateLabel";
            sale_DateLabel.Size = new System.Drawing.Size(94, 20);
            sale_DateLabel.TabIndex = 16;
            sale_DateLabel.Text = "Sale Date:";
            // 
            // mRPLabel
            // 
            mRPLabel.AutoSize = true;
            mRPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mRPLabel.Location = new System.Drawing.Point(603, 128);
            mRPLabel.Name = "mRPLabel";
            mRPLabel.Size = new System.Drawing.Size(52, 20);
            mRPLabel.TabIndex = 18;
            mRPLabel.Text = "MRP:";
            // 
            // discountLabel
            // 
            discountLabel.AutoSize = true;
            discountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            discountLabel.Location = new System.Drawing.Point(603, 159);
            discountLabel.Name = "discountLabel";
            discountLabel.Size = new System.Drawing.Size(85, 20);
            discountLabel.TabIndex = 20;
            discountLabel.Text = "Discount:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            priceLabel.Location = new System.Drawing.Point(603, 190);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(54, 20);
            priceLabel.TabIndex = 22;
            priceLabel.Text = "Price:";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(1192, 71);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 39);
            this.button3.TabIndex = 10;
            this.button3.Text = "Home";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(750, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Sattenapalli";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Shrikhand", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(452, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 51);
            this.label1.TabIndex = 12;
            this.label1.Text = "Sri Vasavi Medicals";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(50, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 60);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(idLabel);
            this.groupBox1.Controls.Add(this.idTextBox);
            this.groupBox1.Controls.Add(customer_NameLabel);
            this.groupBox1.Controls.Add(this.customer_NameTextBox);
            this.groupBox1.Controls.Add(phone_NumberLabel);
            this.groupBox1.Controls.Add(this.phone_NumberTextBox);
            this.groupBox1.Controls.Add(company_NameLabel);
            this.groupBox1.Controls.Add(this.company_NameTextBox);
            this.groupBox1.Controls.Add(product_NameLabel);
            this.groupBox1.Controls.Add(this.product_NameTextBox);
            this.groupBox1.Controls.Add(batch_NoLabel);
            this.groupBox1.Controls.Add(this.batch_NoTextBox);
            this.groupBox1.Controls.Add(expiry_DateLabel);
            this.groupBox1.Controls.Add(this.expiry_DateTextBox);
            this.groupBox1.Controls.Add(quantityLabel);
            this.groupBox1.Controls.Add(this.quantityNumericUpDown);
            this.groupBox1.Controls.Add(sale_DateLabel);
            this.groupBox1.Controls.Add(this.sale_DateDateTimePicker);
            this.groupBox1.Controls.Add(mRPLabel);
            this.groupBox1.Controls.Add(this.mRPTextBox);
            this.groupBox1.Controls.Add(discountLabel);
            this.groupBox1.Controls.Add(this.discountTextBox);
            this.groupBox1.Controls.Add(priceLabel);
            this.groupBox1.Controls.Add(this.priceTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(90, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1191, 240);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(1017, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 35);
            this.button1.TabIndex = 24;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sale_dataBindingSource, "Id", true));
            this.idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.Location = new System.Drawing.Point(307, 32);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(200, 26);
            this.idTextBox.TabIndex = 1;
            // 
            // sale_dataBindingSource
            // 
            this.sale_dataBindingSource.DataMember = "Sale_data";
            this.sale_dataBindingSource.DataSource = this.vsmsDataSet;
            // 
            // vsmsDataSet
            // 
            this.vsmsDataSet.DataSetName = "vsmsDataSet";
            this.vsmsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customer_NameTextBox
            // 
            this.customer_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sale_dataBindingSource, "Customer Name", true));
            this.customer_NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_NameTextBox.Location = new System.Drawing.Point(307, 63);
            this.customer_NameTextBox.Name = "customer_NameTextBox";
            this.customer_NameTextBox.Size = new System.Drawing.Size(200, 26);
            this.customer_NameTextBox.TabIndex = 3;
            // 
            // phone_NumberTextBox
            // 
            this.phone_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sale_dataBindingSource, "Phone Number", true));
            this.phone_NumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_NumberTextBox.Location = new System.Drawing.Point(307, 94);
            this.phone_NumberTextBox.Name = "phone_NumberTextBox";
            this.phone_NumberTextBox.Size = new System.Drawing.Size(200, 26);
            this.phone_NumberTextBox.TabIndex = 5;
            // 
            // company_NameTextBox
            // 
            this.company_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sale_dataBindingSource, "Company Name", true));
            this.company_NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.company_NameTextBox.Location = new System.Drawing.Point(307, 125);
            this.company_NameTextBox.Name = "company_NameTextBox";
            this.company_NameTextBox.Size = new System.Drawing.Size(200, 26);
            this.company_NameTextBox.TabIndex = 7;
            // 
            // product_NameTextBox
            // 
            this.product_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sale_dataBindingSource, "Product Name", true));
            this.product_NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_NameTextBox.Location = new System.Drawing.Point(307, 156);
            this.product_NameTextBox.Name = "product_NameTextBox";
            this.product_NameTextBox.Size = new System.Drawing.Size(200, 26);
            this.product_NameTextBox.TabIndex = 9;
            // 
            // batch_NoTextBox
            // 
            this.batch_NoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sale_dataBindingSource, "Batch No", true));
            this.batch_NoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batch_NoTextBox.Location = new System.Drawing.Point(307, 187);
            this.batch_NoTextBox.Name = "batch_NoTextBox";
            this.batch_NoTextBox.Size = new System.Drawing.Size(200, 26);
            this.batch_NoTextBox.TabIndex = 11;
            // 
            // expiry_DateTextBox
            // 
            this.expiry_DateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sale_dataBindingSource, "Expiry Date", true));
            this.expiry_DateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expiry_DateTextBox.Location = new System.Drawing.Point(720, 32);
            this.expiry_DateTextBox.Name = "expiry_DateTextBox";
            this.expiry_DateTextBox.Size = new System.Drawing.Size(200, 26);
            this.expiry_DateTextBox.TabIndex = 13;
            // 
            // quantityNumericUpDown
            // 
            this.quantityNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.sale_dataBindingSource, "Quantity", true));
            this.quantityNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityNumericUpDown.Location = new System.Drawing.Point(720, 63);
            this.quantityNumericUpDown.Name = "quantityNumericUpDown";
            this.quantityNumericUpDown.Size = new System.Drawing.Size(200, 26);
            this.quantityNumericUpDown.TabIndex = 15;
            this.quantityNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // sale_DateDateTimePicker
            // 
            this.sale_DateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.sale_dataBindingSource, "Sale Date", true));
            this.sale_DateDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sale_DateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.sale_DateDateTimePicker.Location = new System.Drawing.Point(720, 94);
            this.sale_DateDateTimePicker.Name = "sale_DateDateTimePicker";
            this.sale_DateDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.sale_DateDateTimePicker.TabIndex = 17;
            // 
            // mRPTextBox
            // 
            this.mRPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sale_dataBindingSource, "MRP", true));
            this.mRPTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mRPTextBox.Location = new System.Drawing.Point(720, 125);
            this.mRPTextBox.Name = "mRPTextBox";
            this.mRPTextBox.Size = new System.Drawing.Size(200, 26);
            this.mRPTextBox.TabIndex = 19;
            // 
            // discountTextBox
            // 
            this.discountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sale_dataBindingSource, "Discount", true));
            this.discountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountTextBox.Location = new System.Drawing.Point(720, 156);
            this.discountTextBox.Name = "discountTextBox";
            this.discountTextBox.Size = new System.Drawing.Size(200, 26);
            this.discountTextBox.TabIndex = 21;
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sale_dataBindingSource, "Price", true));
            this.priceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTextBox.Location = new System.Drawing.Point(720, 187);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(200, 26);
            this.priceTextBox.TabIndex = 23;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sale_dataDataGridView);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(90, 380);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1191, 316);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // sale_dataDataGridView
            // 
            this.sale_dataDataGridView.AllowUserToAddRows = false;
            this.sale_dataDataGridView.AllowUserToDeleteRows = false;
            this.sale_dataDataGridView.AutoGenerateColumns = false;
            this.sale_dataDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sale_dataDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.sale_dataDataGridView.DataSource = this.sale_dataBindingSource;
            this.sale_dataDataGridView.Location = new System.Drawing.Point(3, 9);
            this.sale_dataDataGridView.Name = "sale_dataDataGridView";
            this.sale_dataDataGridView.ReadOnly = true;
            this.sale_dataDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sale_dataDataGridView.Size = new System.Drawing.Size(1182, 301);
            this.sale_dataDataGridView.TabIndex = 0;
            this.sale_dataDataGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.sale_dataDataGridView_MouseClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Customer Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Customer Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Phone Number";
            this.dataGridViewTextBoxColumn3.HeaderText = "Phone Number";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Company Name";
            this.dataGridViewTextBoxColumn4.HeaderText = "Company Name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Product Name";
            this.dataGridViewTextBoxColumn5.HeaderText = "Product Name";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Batch No";
            this.dataGridViewTextBoxColumn6.HeaderText = "Batch No";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Expiry Date";
            this.dataGridViewTextBoxColumn7.HeaderText = "Expiry Date";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn8.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Sale Date";
            this.dataGridViewTextBoxColumn9.HeaderText = "Sale Date";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "MRP";
            this.dataGridViewTextBoxColumn10.HeaderText = "MRP";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Discount";
            this.dataGridViewTextBoxColumn11.HeaderText = "Discount";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn12.HeaderText = "Price";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Total Price";
            this.dataGridViewTextBoxColumn13.HeaderText = "Total Price";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // sale_dataTableAdapter
            // 
            this.sale_dataTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Avail_stockTableAdapter = this.avail_stockTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BalanceAmountTableAdapter = null;
            this.tableAdapterManager.INANDOUTTableAdapter = null;
            this.tableAdapterManager.Login_detailsTableAdapter = null;
            this.tableAdapterManager.Medicine_detailsTableAdapter = null;
            this.tableAdapterManager.PrintTableTableAdapter = null;
            this.tableAdapterManager.ReturnDetailsTableAdapter = null;
            this.tableAdapterManager.Sale_dataTableAdapter = this.sale_dataTableAdapter;
            this.tableAdapterManager.UpdateOrder = VasaviMedicals.vsmsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VendorDetailsTableAdapter = null;
            // 
            // avail_stockTableAdapter
            // 
            this.avail_stockTableAdapter.ClearBeforeFill = true;
            // 
            // avail_stockBindingSource
            // 
            this.avail_stockBindingSource.DataMember = "Avail_stock";
            this.avail_stockBindingSource.DataSource = this.vsmsDataSet;
            // 
            // Admin_SaleEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin_SaleEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_SaleEntry";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Admin_SaleEntry_FormClosing);
            this.Load += new System.EventHandler(this.Admin_SaleEntry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sale_dataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vsmsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sale_dataDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avail_stockBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private vsmsDataSet vsmsDataSet;
        private System.Windows.Forms.BindingSource sale_dataBindingSource;
        private vsmsDataSetTableAdapters.Sale_dataTableAdapter sale_dataTableAdapter;
        private vsmsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox customer_NameTextBox;
        private System.Windows.Forms.TextBox phone_NumberTextBox;
        private System.Windows.Forms.TextBox company_NameTextBox;
        private System.Windows.Forms.TextBox product_NameTextBox;
        private System.Windows.Forms.TextBox batch_NoTextBox;
        private System.Windows.Forms.TextBox expiry_DateTextBox;
        private System.Windows.Forms.NumericUpDown quantityNumericUpDown;
        private System.Windows.Forms.DateTimePicker sale_DateDateTimePicker;
        private System.Windows.Forms.TextBox mRPTextBox;
        private System.Windows.Forms.TextBox discountTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Button button1;
        private vsmsDataSetTableAdapters.Avail_stockTableAdapter avail_stockTableAdapter;
        private System.Windows.Forms.BindingSource avail_stockBindingSource;
        private System.Windows.Forms.DataGridView sale_dataDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
    }
}