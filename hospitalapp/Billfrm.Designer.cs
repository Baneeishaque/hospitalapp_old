namespace hospitalapp
{
    partial class Billfrm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Billfrm));
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCustomprint = new System.Windows.Forms.Button();
            this.GrpBox_Patibill = new System.Windows.Forms.GroupBox();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEditRegistration = new System.Windows.Forms.Button();
            this.txtBedCategory = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtTotalbill = new System.Windows.Forms.TextBox();
            this.txtOthercharge = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtTotBedcharge = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.txtBedCharge = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtPatiname = new System.Windows.Forms.TextBox();
            this.txtRegno = new System.Windows.Forms.TextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.DTP_date = new System.Windows.Forms.TextBox();
            this.DTP_DOD = new System.Windows.Forms.TextBox();
            this.GB_PatientBillView = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.GrpBox_Patibill.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.GB_PatientBillView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.btnSearch);
            this.GroupBox2.Controls.Add(this.btnExcel);
            this.GroupBox2.Location = new System.Drawing.Point(520, 244);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(120, 136);
            this.GroupBox2.TabIndex = 13;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Search/Export";
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSearch.Location = new System.Drawing.Point(24, 32);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(72, 32);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExcel.Location = new System.Drawing.Point(24, 80);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(72, 32);
            this.btnExcel.TabIndex = 6;
            this.btnExcel.Text = "Excel";
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.btnCustomprint);
            this.GroupBox1.Location = new System.Drawing.Point(520, 44);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(120, 112);
            this.GroupBox1.TabIndex = 12;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Print";
            // 
            // btnCustomprint
            // 
            this.btnCustomprint.BackColor = System.Drawing.Color.LightGray;
            this.btnCustomprint.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCustomprint.Location = new System.Drawing.Point(24, 40);
            this.btnCustomprint.Name = "btnCustomprint";
            this.btnCustomprint.Size = new System.Drawing.Size(72, 32);
            this.btnCustomprint.TabIndex = 4;
            this.btnCustomprint.Text = "List";
            this.btnCustomprint.UseVisualStyleBackColor = false;
            this.btnCustomprint.Click += new System.EventHandler(this.btnCustomprint_Click);
            // 
            // GrpBox_Patibill
            // 
            this.GrpBox_Patibill.Controls.Add(this.GroupBox3);
            this.GrpBox_Patibill.Controls.Add(this.txtBedCategory);
            this.GrpBox_Patibill.Controls.Add(this.Label7);
            this.GrpBox_Patibill.Controls.Add(this.txtTotalbill);
            this.GrpBox_Patibill.Controls.Add(this.txtOthercharge);
            this.GrpBox_Patibill.Controls.Add(this.Label5);
            this.GrpBox_Patibill.Controls.Add(this.txtTotBedcharge);
            this.GrpBox_Patibill.Controls.Add(this.Label4);
            this.GrpBox_Patibill.Controls.Add(this.Label3);
            this.GrpBox_Patibill.Controls.Add(this.Label13);
            this.GrpBox_Patibill.Controls.Add(this.txtBedCharge);
            this.GrpBox_Patibill.Controls.Add(this.Label6);
            this.GrpBox_Patibill.Controls.Add(this.Label2);
            this.GrpBox_Patibill.Controls.Add(this.Label1);
            this.GrpBox_Patibill.Controls.Add(this.txtPatiname);
            this.GrpBox_Patibill.Controls.Add(this.txtRegno);
            this.GrpBox_Patibill.Controls.Add(this.Label11);
            this.GrpBox_Patibill.Controls.Add(this.DTP_date);
            this.GrpBox_Patibill.Controls.Add(this.DTP_DOD);
            this.GrpBox_Patibill.Location = new System.Drawing.Point(24, 12);
            this.GrpBox_Patibill.Name = "GrpBox_Patibill";
            this.GrpBox_Patibill.Size = new System.Drawing.Size(456, 368);
            this.GrpBox_Patibill.TabIndex = 10;
            this.GrpBox_Patibill.TabStop = false;
            this.GrpBox_Patibill.Text = "Patient Bill Detail";
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.btnDelete);
            this.GroupBox3.Controls.Add(this.btnEditRegistration);
            this.GroupBox3.Location = new System.Drawing.Point(296, 32);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(136, 152);
            this.GroupBox3.TabIndex = 78;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Transaction";
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDelete.Location = new System.Drawing.Point(24, 104);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 32);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEditRegistration
            // 
            this.btnEditRegistration.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEditRegistration.Location = new System.Drawing.Point(24, 40);
            this.btnEditRegistration.Name = "btnEditRegistration";
            this.btnEditRegistration.Size = new System.Drawing.Size(88, 32);
            this.btnEditRegistration.TabIndex = 2;
            this.btnEditRegistration.Text = "Save";
            this.btnEditRegistration.Click += new System.EventHandler(this.btnEditRegistration_Click);
            // 
            // txtBedCategory
            // 
            this.txtBedCategory.Location = new System.Drawing.Point(144, 160);
            this.txtBedCategory.Name = "txtBedCategory";
            this.txtBedCategory.ReadOnly = true;
            this.txtBedCategory.Size = new System.Drawing.Size(100, 20);
            this.txtBedCategory.TabIndex = 5;
            // 
            // Label7
            // 
            this.Label7.Location = new System.Drawing.Point(24, 288);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(100, 23);
            this.Label7.TabIndex = 76;
            this.Label7.Text = "Total Bill";
            // 
            // txtTotalbill
            // 
            this.txtTotalbill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalbill.Location = new System.Drawing.Point(144, 288);
            this.txtTotalbill.Name = "txtTotalbill";
            this.txtTotalbill.ReadOnly = true;
            this.txtTotalbill.Size = new System.Drawing.Size(100, 21);
            this.txtTotalbill.TabIndex = 8;
            // 
            // txtOthercharge
            // 
            this.txtOthercharge.Location = new System.Drawing.Point(144, 256);
            this.txtOthercharge.Name = "txtOthercharge";
            this.txtOthercharge.Size = new System.Drawing.Size(100, 20);
            this.txtOthercharge.TabIndex = 1;
            this.txtOthercharge.TextChanged += new System.EventHandler(this.txtOthercharge_TextChanged);
            // 
            // Label5
            // 
            this.Label5.Location = new System.Drawing.Point(24, 256);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(100, 23);
            this.Label5.TabIndex = 73;
            this.Label5.Text = "Other Charge";
            // 
            // txtTotBedcharge
            // 
            this.txtTotBedcharge.Location = new System.Drawing.Point(144, 224);
            this.txtTotBedcharge.Name = "txtTotBedcharge";
            this.txtTotBedcharge.ReadOnly = true;
            this.txtTotBedcharge.Size = new System.Drawing.Size(100, 20);
            this.txtTotBedcharge.TabIndex = 7;
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(24, 224);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(100, 23);
            this.Label4.TabIndex = 71;
            this.Label4.Text = "Total Bed Charge";
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(24, 128);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(100, 23);
            this.Label3.TabIndex = 69;
            this.Label3.Text = "Discharge Date";
            // 
            // Label13
            // 
            this.Label13.Location = new System.Drawing.Point(24, 192);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(100, 23);
            this.Label13.TabIndex = 68;
            this.Label13.Text = "Bed Charge/Day";
            // 
            // txtBedCharge
            // 
            this.txtBedCharge.Location = new System.Drawing.Point(144, 192);
            this.txtBedCharge.Name = "txtBedCharge";
            this.txtBedCharge.ReadOnly = true;
            this.txtBedCharge.Size = new System.Drawing.Size(104, 20);
            this.txtBedCharge.TabIndex = 6;
            // 
            // Label6
            // 
            this.Label6.Location = new System.Drawing.Point(24, 96);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(100, 23);
            this.Label6.TabIndex = 19;
            this.Label6.Text = "Admit Date";
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(24, 64);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(100, 23);
            this.Label2.TabIndex = 15;
            this.Label2.Text = "Patient Name";
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(24, 32);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(100, 23);
            this.Label1.TabIndex = 14;
            this.Label1.Text = "Registration No";
            // 
            // txtPatiname
            // 
            this.txtPatiname.Location = new System.Drawing.Point(144, 64);
            this.txtPatiname.Name = "txtPatiname";
            this.txtPatiname.ReadOnly = true;
            this.txtPatiname.Size = new System.Drawing.Size(104, 20);
            this.txtPatiname.TabIndex = 2;
            // 
            // txtRegno
            // 
            this.txtRegno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegno.Location = new System.Drawing.Point(144, 32);
            this.txtRegno.Name = "txtRegno";
            this.txtRegno.ReadOnly = true;
            this.txtRegno.Size = new System.Drawing.Size(104, 22);
            this.txtRegno.TabIndex = 1;
            // 
            // Label11
            // 
            this.Label11.Location = new System.Drawing.Point(24, 160);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(80, 23);
            this.Label11.TabIndex = 0;
            this.Label11.Text = "Bed Type";
            // 
            // DTP_date
            // 
            this.DTP_date.Location = new System.Drawing.Point(144, 96);
            this.DTP_date.Name = "DTP_date";
            this.DTP_date.ReadOnly = true;
            this.DTP_date.Size = new System.Drawing.Size(100, 20);
            this.DTP_date.TabIndex = 4;
            // 
            // DTP_DOD
            // 
            this.DTP_DOD.Location = new System.Drawing.Point(144, 128);
            this.DTP_DOD.Name = "DTP_DOD";
            this.DTP_DOD.ReadOnly = true;
            this.DTP_DOD.Size = new System.Drawing.Size(100, 20);
            this.DTP_DOD.TabIndex = 4;
            // 
            // GB_PatientBillView
            // 
            this.GB_PatientBillView.Controls.Add(this.dataGridView1);
            this.GB_PatientBillView.Location = new System.Drawing.Point(24, 396);
            this.GB_PatientBillView.Name = "GB_PatientBillView";
            this.GB_PatientBillView.Size = new System.Drawing.Size(648, 224);
            this.GB_PatientBillView.TabIndex = 11;
            this.GB_PatientBillView.TabStop = false;
            this.GB_PatientBillView.Text = "Patient Bill View";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(642, 205);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Billfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.GrpBox_Patibill);
            this.Controls.Add(this.GB_PatientBillView);
            this.Name = "Billfrm";
            this.Size = new System.Drawing.Size(696, 632);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GrpBox_Patibill.ResumeLayout(false);
            this.GrpBox_Patibill.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GB_PatientBillView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Button btnSearch;
        internal System.Windows.Forms.Button btnExcel;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Button btnCustomprint;
        internal System.Windows.Forms.GroupBox GrpBox_Patibill;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.Button btnEditRegistration;
        internal System.Windows.Forms.TextBox txtBedCategory;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox txtTotalbill;
        internal System.Windows.Forms.TextBox txtOthercharge;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txtTotBedcharge;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.TextBox txtBedCharge;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtPatiname;
        internal System.Windows.Forms.TextBox txtRegno;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.TextBox DTP_date;
        internal System.Windows.Forms.TextBox DTP_DOD;
        internal System.Windows.Forms.GroupBox GB_PatientBillView;
        private System.Windows.Forms.DataGridView dataGridView1;
        internal System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}
