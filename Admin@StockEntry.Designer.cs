namespace VasaviMedicals
{
    partial class Admin_StockEntry
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
            System.Windows.Forms.Label dealer_NameLabel;
            System.Windows.Forms.Label company_NameLabel;
            System.Windows.Forms.Label product_NameLabel;
            System.Windows.Forms.Label batch_NoLabel;
            System.Windows.Forms.Label expiry_DateLabel;
            System.Windows.Forms.Label quantityLabel;
            System.Windows.Forms.Label mRPLabel;
            System.Windows.Forms.Label discountLabel;
            System.Windows.Forms.Label gSTLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_StockEntry));
            System.Windows.Forms.Label priceLabel;
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.medicine_detailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vsmsDataSet = new VasaviMedicals.vsmsDataSet();
            this.dealer_NameTextBox = new System.Windows.Forms.TextBox();
            this.company_NameTextBox = new System.Windows.Forms.TextBox();
            this.product_NameTextBox = new System.Windows.Forms.TextBox();
            this.batch_NoTextBox = new System.Windows.Forms.TextBox();
            this.expiry_DateTextBox = new System.Windows.Forms.TextBox();
            this.quantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.mRPTextBox = new System.Windows.Forms.TextBox();
            this.discountTextBox = new System.Windows.Forms.TextBox();
            this.gSTTextBox = new System.Windows.Forms.TextBox();
            this.medicine_detailsTableAdapter = new VasaviMedicals.vsmsDataSetTableAdapters.Medicine_detailsTableAdapter();
            this.tableAdapterManager = new VasaviMedicals.vsmsDataSetTableAdapters.TableAdapterManager();
            this.avail_stockTableAdapter = new VasaviMedicals.vsmsDataSetTableAdapters.Avail_stockTableAdapter();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.avail_stockDataGridView = new System.Windows.Forms.DataGridView();
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
            this.avail_stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.priceTextBox = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            dealer_NameLabel = new System.Windows.Forms.Label();
            company_NameLabel = new System.Windows.Forms.Label();
            product_NameLabel = new System.Windows.Forms.Label();
            batch_NoLabel = new System.Windows.Forms.Label();
            expiry_DateLabel = new System.Windows.Forms.Label();
            quantityLabel = new System.Windows.Forms.Label();
            mRPLabel = new System.Windows.Forms.Label();
            discountLabel = new System.Windows.Forms.Label();
            gSTLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicine_detailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vsmsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avail_stockDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avail_stockBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.Location = new System.Drawing.Point(24, 29);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(30, 20);
            idLabel.TabIndex = 0;
            idLabel.Text = "Id:";
            // 
            // dealer_NameLabel
            // 
            dealer_NameLabel.AutoSize = true;
            dealer_NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dealer_NameLabel.Location = new System.Drawing.Point(24, 65);
            dealer_NameLabel.Name = "dealer_NameLabel";
            dealer_NameLabel.Size = new System.Drawing.Size(118, 20);
            dealer_NameLabel.TabIndex = 2;
            dealer_NameLabel.Text = "Dealer Name:";
            // 
            // company_NameLabel
            // 
            company_NameLabel.AutoSize = true;
            company_NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            company_NameLabel.Location = new System.Drawing.Point(24, 101);
            company_NameLabel.Name = "company_NameLabel";
            company_NameLabel.Size = new System.Drawing.Size(139, 20);
            company_NameLabel.TabIndex = 4;
            company_NameLabel.Text = "Company Name:";
            // 
            // product_NameLabel
            // 
            product_NameLabel.AutoSize = true;
            product_NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            product_NameLabel.Location = new System.Drawing.Point(24, 137);
            product_NameLabel.Name = "product_NameLabel";
            product_NameLabel.Size = new System.Drawing.Size(127, 20);
            product_NameLabel.TabIndex = 6;
            product_NameLabel.Text = "Product Name:";
            // 
            // batch_NoLabel
            // 
            batch_NoLabel.AutoSize = true;
            batch_NoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            batch_NoLabel.Location = new System.Drawing.Point(24, 173);
            batch_NoLabel.Name = "batch_NoLabel";
            batch_NoLabel.Size = new System.Drawing.Size(88, 20);
            batch_NoLabel.TabIndex = 8;
            batch_NoLabel.Text = "Batch No:";
            // 
            // expiry_DateLabel
            // 
            expiry_DateLabel.AutoSize = true;
            expiry_DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            expiry_DateLabel.Location = new System.Drawing.Point(24, 209);
            expiry_DateLabel.Name = "expiry_DateLabel";
            expiry_DateLabel.Size = new System.Drawing.Size(106, 20);
            expiry_DateLabel.TabIndex = 10;
            expiry_DateLabel.Text = "Expiry Date:";
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            quantityLabel.Location = new System.Drawing.Point(24, 242);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(81, 20);
            quantityLabel.TabIndex = 12;
            quantityLabel.Text = "Quantity:";
            // 
            // mRPLabel
            // 
            mRPLabel.AutoSize = true;
            mRPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mRPLabel.Location = new System.Drawing.Point(24, 281);
            mRPLabel.Name = "mRPLabel";
            mRPLabel.Size = new System.Drawing.Size(52, 20);
            mRPLabel.TabIndex = 14;
            mRPLabel.Text = "MRP:";
            // 
            // discountLabel
            // 
            discountLabel.AutoSize = true;
            discountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            discountLabel.Location = new System.Drawing.Point(24, 316);
            discountLabel.Name = "discountLabel";
            discountLabel.Size = new System.Drawing.Size(85, 20);
            discountLabel.TabIndex = 16;
            discountLabel.Text = "Discount:";
            // 
            // gSTLabel
            // 
            gSTLabel.AutoSize = true;
            gSTLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gSTLabel.Location = new System.Drawing.Point(24, 352);
            gSTLabel.Name = "gSTLabel";
            gSTLabel.Size = new System.Drawing.Size(50, 20);
            gSTLabel.TabIndex = 18;
            gSTLabel.Text = "GST:";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(1192, 71);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 39);
            this.button3.TabIndex = 6;
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
            this.label2.TabIndex = 9;
            this.label2.Text = "Sattenapalli";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Shrikhand", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(452, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 51);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sri Vasavi Medicals";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(50, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 60);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(priceLabel);
            this.groupBox1.Controls.Add(this.priceTextBox);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(idLabel);
            this.groupBox1.Controls.Add(this.idTextBox);
            this.groupBox1.Controls.Add(dealer_NameLabel);
            this.groupBox1.Controls.Add(this.dealer_NameTextBox);
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
            this.groupBox1.Controls.Add(mRPLabel);
            this.groupBox1.Controls.Add(this.mRPTextBox);
            this.groupBox1.Controls.Add(discountLabel);
            this.groupBox1.Controls.Add(this.discountTextBox);
            this.groupBox1.Controls.Add(gSTLabel);
            this.groupBox1.Controls.Add(this.gSTTextBox);
            this.groupBox1.Location = new System.Drawing.Point(50, 199);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 494);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(252, 430);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 30);
            this.button1.TabIndex = 20;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicine_detailsBindingSource, "Id", true));
            this.idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.Location = new System.Drawing.Point(177, 26);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(182, 26);
            this.idTextBox.TabIndex = 1;
            // 
            // medicine_detailsBindingSource
            // 
            this.medicine_detailsBindingSource.DataMember = "Medicine_details";
            this.medicine_detailsBindingSource.DataSource = this.vsmsDataSet;
            // 
            // vsmsDataSet
            // 
            this.vsmsDataSet.DataSetName = "vsmsDataSet";
            this.vsmsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dealer_NameTextBox
            // 
            this.dealer_NameTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.dealer_NameTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.dealer_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicine_detailsBindingSource, "Dealer Name", true));
            this.dealer_NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealer_NameTextBox.Location = new System.Drawing.Point(177, 62);
            this.dealer_NameTextBox.Name = "dealer_NameTextBox";
            this.dealer_NameTextBox.Size = new System.Drawing.Size(182, 26);
            this.dealer_NameTextBox.TabIndex = 3;
            // 
            // company_NameTextBox
            // 
            this.company_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicine_detailsBindingSource, "Company Name", true));
            this.company_NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.company_NameTextBox.Location = new System.Drawing.Point(177, 98);
            this.company_NameTextBox.Name = "company_NameTextBox";
            this.company_NameTextBox.Size = new System.Drawing.Size(182, 26);
            this.company_NameTextBox.TabIndex = 5;
            // 
            // product_NameTextBox
            // 
            this.product_NameTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.product_NameTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.product_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicine_detailsBindingSource, "Product Name", true));
            this.product_NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_NameTextBox.Location = new System.Drawing.Point(177, 134);
            this.product_NameTextBox.Name = "product_NameTextBox";
            this.product_NameTextBox.Size = new System.Drawing.Size(182, 26);
            this.product_NameTextBox.TabIndex = 7;
            // 
            // batch_NoTextBox
            // 
            this.batch_NoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicine_detailsBindingSource, "Batch No", true));
            this.batch_NoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batch_NoTextBox.Location = new System.Drawing.Point(177, 170);
            this.batch_NoTextBox.Name = "batch_NoTextBox";
            this.batch_NoTextBox.Size = new System.Drawing.Size(182, 26);
            this.batch_NoTextBox.TabIndex = 9;
            // 
            // expiry_DateTextBox
            // 
            this.expiry_DateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicine_detailsBindingSource, "Expiry Date", true));
            this.expiry_DateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expiry_DateTextBox.Location = new System.Drawing.Point(177, 206);
            this.expiry_DateTextBox.Name = "expiry_DateTextBox";
            this.expiry_DateTextBox.Size = new System.Drawing.Size(182, 26);
            this.expiry_DateTextBox.TabIndex = 11;
            // 
            // quantityNumericUpDown
            // 
            this.quantityNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.medicine_detailsBindingSource, "Quantity", true));
            this.quantityNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityNumericUpDown.Location = new System.Drawing.Point(177, 242);
            this.quantityNumericUpDown.Name = "quantityNumericUpDown";
            this.quantityNumericUpDown.Size = new System.Drawing.Size(182, 26);
            this.quantityNumericUpDown.TabIndex = 13;
            this.quantityNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // mRPTextBox
            // 
            this.mRPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicine_detailsBindingSource, "MRP", true));
            this.mRPTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mRPTextBox.Location = new System.Drawing.Point(177, 278);
            this.mRPTextBox.Name = "mRPTextBox";
            this.mRPTextBox.Size = new System.Drawing.Size(182, 26);
            this.mRPTextBox.TabIndex = 15;
            // 
            // discountTextBox
            // 
            this.discountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicine_detailsBindingSource, "Discount", true));
            this.discountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountTextBox.Location = new System.Drawing.Point(177, 313);
            this.discountTextBox.Name = "discountTextBox";
            this.discountTextBox.Size = new System.Drawing.Size(182, 26);
            this.discountTextBox.TabIndex = 17;
            // 
            // gSTTextBox
            // 
            this.gSTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicine_detailsBindingSource, "GST", true));
            this.gSTTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gSTTextBox.Location = new System.Drawing.Point(177, 349);
            this.gSTTextBox.Name = "gSTTextBox";
            this.gSTTextBox.Size = new System.Drawing.Size(182, 26);
            this.gSTTextBox.TabIndex = 19;
            // 
            // medicine_detailsTableAdapter
            // 
            this.medicine_detailsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Avail_stockTableAdapter = this.avail_stockTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BalanceAmountTableAdapter = null;
            this.tableAdapterManager.INANDOUTTableAdapter = null;
            this.tableAdapterManager.Login_detailsTableAdapter = null;
            this.tableAdapterManager.Medicine_detailsTableAdapter = this.medicine_detailsTableAdapter;
            this.tableAdapterManager.PrintTableTableAdapter = null;
            this.tableAdapterManager.ReturnDetailsTableAdapter = null;
            this.tableAdapterManager.Sale_dataTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = VasaviMedicals.vsmsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VendorDetailsTableAdapter = null;
            // 
            // avail_stockTableAdapter
            // 
            this.avail_stockTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.avail_stockDataGridView);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox3.Location = new System.Drawing.Point(442, 199);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(889, 446);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            // 
            // avail_stockDataGridView
            // 
            this.avail_stockDataGridView.AllowUserToAddRows = false;
            this.avail_stockDataGridView.AllowUserToDeleteRows = false;
            this.avail_stockDataGridView.AutoGenerateColumns = false;
            this.avail_stockDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.avail_stockDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridViewTextBoxColumn12});
            this.avail_stockDataGridView.DataSource = this.avail_stockBindingSource;
            this.avail_stockDataGridView.Location = new System.Drawing.Point(4, 10);
            this.avail_stockDataGridView.Name = "avail_stockDataGridView";
            this.avail_stockDataGridView.ReadOnly = true;
            this.avail_stockDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.avail_stockDataGridView.Size = new System.Drawing.Size(879, 430);
            this.avail_stockDataGridView.TabIndex = 0;
            this.avail_stockDataGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.medicine_detailsDataGridView_MouseClick);
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Dealer Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Dealer Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Company Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Company Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Product Name";
            this.dataGridViewTextBoxColumn4.HeaderText = "Product Name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Batch No";
            this.dataGridViewTextBoxColumn5.HeaderText = "Batch No";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Expiry Date";
            this.dataGridViewTextBoxColumn6.HeaderText = "Expiry Date";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn7.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "MRP";
            this.dataGridViewTextBoxColumn8.HeaderText = "MRP";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Discount";
            this.dataGridViewTextBoxColumn9.HeaderText = "Discount";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "GST";
            this.dataGridViewTextBoxColumn10.HeaderText = "GST";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn11.HeaderText = "Price";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Total Price";
            this.dataGridViewTextBoxColumn12.HeaderText = "Total Price";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // avail_stockBindingSource
            // 
            this.avail_stockBindingSource.DataMember = "Avail_stock";
            this.avail_stockBindingSource.DataSource = this.vsmsDataSet;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            priceLabel.Location = new System.Drawing.Point(25, 388);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(54, 20);
            priceLabel.TabIndex = 21;
            priceLabel.Text = "Price:";
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicine_detailsBindingSource, "Price", true));
            this.priceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTextBox.Location = new System.Drawing.Point(177, 385);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(182, 26);
            this.priceTextBox.TabIndex = 22;
            // 
            // Admin_StockEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin_StockEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_StockEntry";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Admin_StockEntry_FormClosing);
            this.Load += new System.EventHandler(this.Admin_StockEntry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicine_detailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vsmsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.avail_stockDataGridView)).EndInit();
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
        private vsmsDataSet vsmsDataSet;
        private System.Windows.Forms.BindingSource medicine_detailsBindingSource;
        private vsmsDataSetTableAdapters.Medicine_detailsTableAdapter medicine_detailsTableAdapter;
        private vsmsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox dealer_NameTextBox;
        private System.Windows.Forms.TextBox company_NameTextBox;
        private System.Windows.Forms.TextBox product_NameTextBox;
        private System.Windows.Forms.TextBox batch_NoTextBox;
        private System.Windows.Forms.TextBox expiry_DateTextBox;
        private System.Windows.Forms.NumericUpDown quantityNumericUpDown;
        private System.Windows.Forms.TextBox mRPTextBox;
        private System.Windows.Forms.TextBox discountTextBox;
        private System.Windows.Forms.TextBox gSTTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private vsmsDataSetTableAdapters.Avail_stockTableAdapter avail_stockTableAdapter;
        private System.Windows.Forms.BindingSource avail_stockBindingSource;
        private System.Windows.Forms.DataGridView avail_stockDataGridView;
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
        private System.Windows.Forms.TextBox priceTextBox;
    }
}