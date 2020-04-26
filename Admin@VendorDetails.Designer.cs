namespace VasaviMedicals
{
    partial class Admin_VendorDetails
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
            System.Windows.Forms.Label vendor_NameLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label phone_NumberLabel;
            System.Windows.Forms.Label gST_NumberLabel;
            System.Windows.Forms.Label pAN_NumberLabel;
            System.Windows.Forms.Label addressLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_VendorDetails));
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.vendor_NameTextBox = new System.Windows.Forms.TextBox();
            this.vendorDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vsmsDataSet = new VasaviMedicals.vsmsDataSet();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.phone_NumberTextBox = new System.Windows.Forms.TextBox();
            this.gST_NumberTextBox = new System.Windows.Forms.TextBox();
            this.pAN_NumberTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.vendorDetailsTableAdapter = new VasaviMedicals.vsmsDataSetTableAdapters.VendorDetailsTableAdapter();
            this.tableAdapterManager = new VasaviMedicals.vsmsDataSetTableAdapters.TableAdapterManager();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.vendorDetailsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            vendor_NameLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            phone_NumberLabel = new System.Windows.Forms.Label();
            gST_NumberLabel = new System.Windows.Forms.Label();
            pAN_NumberLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendorDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vsmsDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendorDetailsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // vendor_NameLabel
            // 
            vendor_NameLabel.AutoSize = true;
            vendor_NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            vendor_NameLabel.Location = new System.Drawing.Point(159, 22);
            vendor_NameLabel.Name = "vendor_NameLabel";
            vendor_NameLabel.Size = new System.Drawing.Size(123, 20);
            vendor_NameLabel.TabIndex = 2;
            vendor_NameLabel.Text = "Vendor Name:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cityLabel.Location = new System.Drawing.Point(159, 55);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(44, 20);
            cityLabel.TabIndex = 4;
            cityLabel.Text = "City:";
            // 
            // phone_NumberLabel
            // 
            phone_NumberLabel.AutoSize = true;
            phone_NumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            phone_NumberLabel.Location = new System.Drawing.Point(159, 88);
            phone_NumberLabel.Name = "phone_NumberLabel";
            phone_NumberLabel.Size = new System.Drawing.Size(132, 20);
            phone_NumberLabel.TabIndex = 6;
            phone_NumberLabel.Text = "Phone Number:";
            // 
            // gST_NumberLabel
            // 
            gST_NumberLabel.AutoSize = true;
            gST_NumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gST_NumberLabel.Location = new System.Drawing.Point(159, 121);
            gST_NumberLabel.Name = "gST_NumberLabel";
            gST_NumberLabel.Size = new System.Drawing.Size(117, 20);
            gST_NumberLabel.TabIndex = 8;
            gST_NumberLabel.Text = "GST Number:";
            // 
            // pAN_NumberLabel
            // 
            pAN_NumberLabel.AutoSize = true;
            pAN_NumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pAN_NumberLabel.Location = new System.Drawing.Point(159, 155);
            pAN_NumberLabel.Name = "pAN_NumberLabel";
            pAN_NumberLabel.Size = new System.Drawing.Size(116, 20);
            pAN_NumberLabel.TabIndex = 10;
            pAN_NumberLabel.Text = "PAN Number:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            addressLabel.Location = new System.Drawing.Point(159, 188);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(80, 20);
            addressLabel.TabIndex = 12;
            addressLabel.Text = "Address:";
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
            this.groupBox1.Controls.Add(vendor_NameLabel);
            this.groupBox1.Controls.Add(this.vendor_NameTextBox);
            this.groupBox1.Controls.Add(cityLabel);
            this.groupBox1.Controls.Add(this.cityTextBox);
            this.groupBox1.Controls.Add(phone_NumberLabel);
            this.groupBox1.Controls.Add(this.phone_NumberTextBox);
            this.groupBox1.Controls.Add(gST_NumberLabel);
            this.groupBox1.Controls.Add(this.gST_NumberTextBox);
            this.groupBox1.Controls.Add(pAN_NumberLabel);
            this.groupBox1.Controls.Add(this.pAN_NumberTextBox);
            this.groupBox1.Controls.Add(addressLabel);
            this.groupBox1.Controls.Add(this.addressTextBox);
            this.groupBox1.Location = new System.Drawing.Point(312, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(664, 261);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(445, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 31);
            this.button1.TabIndex = 14;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // vendor_NameTextBox
            // 
            this.vendor_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorDetailsBindingSource, "Vendor Name", true));
            this.vendor_NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendor_NameTextBox.Location = new System.Drawing.Point(323, 19);
            this.vendor_NameTextBox.Name = "vendor_NameTextBox";
            this.vendor_NameTextBox.Size = new System.Drawing.Size(175, 26);
            this.vendor_NameTextBox.TabIndex = 3;
            // 
            // vendorDetailsBindingSource
            // 
            this.vendorDetailsBindingSource.DataMember = "VendorDetails";
            this.vendorDetailsBindingSource.DataSource = this.vsmsDataSet;
            // 
            // vsmsDataSet
            // 
            this.vsmsDataSet.DataSetName = "vsmsDataSet";
            this.vsmsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorDetailsBindingSource, "City", true));
            this.cityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityTextBox.Location = new System.Drawing.Point(323, 52);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(175, 26);
            this.cityTextBox.TabIndex = 5;
            // 
            // phone_NumberTextBox
            // 
            this.phone_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorDetailsBindingSource, "Phone Number", true));
            this.phone_NumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_NumberTextBox.Location = new System.Drawing.Point(323, 85);
            this.phone_NumberTextBox.Name = "phone_NumberTextBox";
            this.phone_NumberTextBox.Size = new System.Drawing.Size(175, 26);
            this.phone_NumberTextBox.TabIndex = 7;
            // 
            // gST_NumberTextBox
            // 
            this.gST_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorDetailsBindingSource, "GST Number", true));
            this.gST_NumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gST_NumberTextBox.Location = new System.Drawing.Point(323, 118);
            this.gST_NumberTextBox.Name = "gST_NumberTextBox";
            this.gST_NumberTextBox.Size = new System.Drawing.Size(175, 26);
            this.gST_NumberTextBox.TabIndex = 9;
            // 
            // pAN_NumberTextBox
            // 
            this.pAN_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorDetailsBindingSource, "PAN Number", true));
            this.pAN_NumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pAN_NumberTextBox.Location = new System.Drawing.Point(323, 152);
            this.pAN_NumberTextBox.Name = "pAN_NumberTextBox";
            this.pAN_NumberTextBox.Size = new System.Drawing.Size(175, 26);
            this.pAN_NumberTextBox.TabIndex = 11;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorDetailsBindingSource, "Address", true));
            this.addressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTextBox.Location = new System.Drawing.Point(323, 185);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(175, 26);
            this.addressTextBox.TabIndex = 13;
            // 
            // vendorDetailsTableAdapter
            // 
            this.vendorDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Avail_stockTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BalanceAmountTableAdapter = null;
            this.tableAdapterManager.INANDOUTTableAdapter = null;
            this.tableAdapterManager.Login_detailsTableAdapter = null;
            this.tableAdapterManager.Medicine_detailsTableAdapter = null;
            this.tableAdapterManager.PrintTableTableAdapter = null;
            this.tableAdapterManager.ReturnDetailsTableAdapter = null;
            this.tableAdapterManager.Sale_dataTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = VasaviMedicals.vsmsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VendorDetailsTableAdapter = this.vendorDetailsTableAdapter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.vendorDetailsDataGridView);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(214, 408);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(850, 317);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // vendorDetailsDataGridView
            // 
            this.vendorDetailsDataGridView.AllowUserToAddRows = false;
            this.vendorDetailsDataGridView.AllowUserToDeleteRows = false;
            this.vendorDetailsDataGridView.AutoGenerateColumns = false;
            this.vendorDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vendorDetailsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.vendorDetailsDataGridView.DataSource = this.vendorDetailsBindingSource;
            this.vendorDetailsDataGridView.Location = new System.Drawing.Point(3, 9);
            this.vendorDetailsDataGridView.Name = "vendorDetailsDataGridView";
            this.vendorDetailsDataGridView.ReadOnly = true;
            this.vendorDetailsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.vendorDetailsDataGridView.Size = new System.Drawing.Size(843, 302);
            this.vendorDetailsDataGridView.TabIndex = 0;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Vendor Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Vendor Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "City";
            this.dataGridViewTextBoxColumn3.HeaderText = "City";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Phone Number";
            this.dataGridViewTextBoxColumn4.HeaderText = "Phone Number";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "GST Number";
            this.dataGridViewTextBoxColumn5.HeaderText = "GST Number";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "PAN Number";
            this.dataGridViewTextBoxColumn6.HeaderText = "PAN Number";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn7.HeaderText = "Address";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Pending Balance";
            this.dataGridViewTextBoxColumn8.HeaderText = "Pending Balance";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // Admin_VendorDetails
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
            this.Name = "Admin_VendorDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_VendorDetails";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Admin_VendorDetails_FormClosing);
            this.Load += new System.EventHandler(this.Admin_VendorDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendorDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vsmsDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vendorDetailsDataGridView)).EndInit();
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
        private System.Windows.Forms.BindingSource vendorDetailsBindingSource;
        private vsmsDataSetTableAdapters.VendorDetailsTableAdapter vendorDetailsTableAdapter;
        private vsmsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox vendor_NameTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox phone_NumberTextBox;
        private System.Windows.Forms.TextBox gST_NumberTextBox;
        private System.Windows.Forms.TextBox pAN_NumberTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView vendorDetailsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}