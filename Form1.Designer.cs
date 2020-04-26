namespace VasaviMedicals
{
    partial class Login
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
            System.Windows.Forms.Label unameLabel;
            System.Windows.Forms.Label upassLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Unametb = new System.Windows.Forms.TextBox();
            this.login_detailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vsmsDataSet = new VasaviMedicals.vsmsDataSet();
            this.Passtb = new System.Windows.Forms.TextBox();
            this.login_detailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.login_detailsTableAdapter1 = new VasaviMedicals.vsmsDataSetTableAdapters.Login_detailsTableAdapter();
            this.tableAdapterManager1 = new VasaviMedicals.vsmsDataSetTableAdapters.TableAdapterManager();
            unameLabel = new System.Windows.Forms.Label();
            upassLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.login_detailsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vsmsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.login_detailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // unameLabel
            // 
            unameLabel.AutoSize = true;
            unameLabel.Location = new System.Drawing.Point(21, 47);
            unameLabel.Name = "unameLabel";
            unameLabel.Size = new System.Drawing.Size(125, 25);
            unameLabel.TabIndex = 4;
            unameLabel.Text = "Username:";
            // 
            // upassLabel
            // 
            upassLabel.AutoSize = true;
            upassLabel.Location = new System.Drawing.Point(21, 81);
            upassLabel.Name = "upassLabel";
            upassLabel.Size = new System.Drawing.Size(121, 25);
            upassLabel.TabIndex = 6;
            upassLabel.Text = "Password:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(50, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 60);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Shrikhand", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(452, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sri Vasavi Medicals";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(750, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sattenapalli";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Controls.Add(unameLabel);
            this.groupBox1.Controls.Add(this.Unametb);
            this.groupBox1.Controls.Add(upassLabel);
            this.groupBox1.Controls.Add(this.Passtb);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Location = new System.Drawing.Point(450, 300);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 190);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(282, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 33);
            this.button1.TabIndex = 8;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.tologin_Click);
            // 
            // Unametb
            // 
            this.Unametb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.login_detailsBindingSource1, "Uname", true));
            this.Unametb.Location = new System.Drawing.Point(156, 44);
            this.Unametb.Name = "Unametb";
            this.Unametb.Size = new System.Drawing.Size(163, 31);
            this.Unametb.TabIndex = 5;
            // 
            // login_detailsBindingSource1
            // 
            this.login_detailsBindingSource1.DataMember = "Login_details";
            this.login_detailsBindingSource1.DataSource = this.vsmsDataSet;
            // 
            // vsmsDataSet
            // 
            this.vsmsDataSet.DataSetName = "vsmsDataSet";
            this.vsmsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Passtb
            // 
            this.Passtb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.login_detailsBindingSource1, "Upass", true));
            this.Passtb.Location = new System.Drawing.Point(156, 81);
            this.Passtb.Name = "Passtb";
            this.Passtb.Size = new System.Drawing.Size(163, 31);
            this.Passtb.TabIndex = 7;
            this.Passtb.UseSystemPasswordChar = true;
            // 
            // login_detailsBindingSource
            // 
            this.login_detailsBindingSource.DataMember = "Login_details";
            // 
            // login_detailsTableAdapter1
            // 
            this.login_detailsTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.Avail_stockTableAdapter = null;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.BalanceAmountTableAdapter = null;
            this.tableAdapterManager1.INANDOUTTableAdapter = null;
            this.tableAdapterManager1.Login_detailsTableAdapter = this.login_detailsTableAdapter1;
            this.tableAdapterManager1.Medicine_detailsTableAdapter = null;
            this.tableAdapterManager1.PrintTableTableAdapter = null;
            this.tableAdapterManager1.ReturnDetailsTableAdapter = null;
            this.tableAdapterManager1.Sale_dataTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = VasaviMedicals.vsmsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.VendorDetailsTableAdapter = null;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.login_detailsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vsmsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.login_detailsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource login_detailsBindingSource;
        private vsmsDataSet vsmsDataSet;
        private System.Windows.Forms.BindingSource login_detailsBindingSource1;
        private vsmsDataSetTableAdapters.Login_detailsTableAdapter login_detailsTableAdapter1;
        private vsmsDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.TextBox Unametb;
        private System.Windows.Forms.TextBox Passtb;
        private System.Windows.Forms.Button button1;
    }
}

