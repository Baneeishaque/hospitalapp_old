namespace hospitalapp
{
    partial class SisterWardboyfrm
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
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCustomprint = new System.Windows.Forms.Button();
            this.GB_DoctorView = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GB_Doctor = new System.Windows.Forms.GroupBox();
            this.RtxtAddress = new System.Windows.Forms.TextBox();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveS_W = new System.Windows.Forms.Button();
            this.btnDeleteS_W = new System.Windows.Forms.Button();
            this.btnUpdateS_W = new System.Windows.Forms.Button();
            this.btnAddS_W = new System.Windows.Forms.Button();
            this.CB_Category = new System.Windows.Forms.ComboBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.DTP_DOJ = new System.Windows.Forms.DateTimePicker();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.GB_DoctorView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.GB_Doctor.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox2
            // 
            this.GroupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GroupBox2.Controls.Add(this.btnSearch);
            this.GroupBox2.Controls.Add(this.btnExcel);
            this.GroupBox2.Location = new System.Drawing.Point(548, 220);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(120, 120);
            this.GroupBox2.TabIndex = 7;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Search/Export";
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSearch.Location = new System.Drawing.Point(24, 32);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(72, 23);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExcel.Location = new System.Drawing.Point(24, 72);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(72, 23);
            this.btnExcel.TabIndex = 13;
            this.btnExcel.Text = "Excel";
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GroupBox1.Controls.Add(this.btnCustomprint);
            this.GroupBox1.Location = new System.Drawing.Point(548, 60);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(120, 120);
            this.GroupBox1.TabIndex = 6;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Print";
            // 
            // btnCustomprint
            // 
            this.btnCustomprint.BackColor = System.Drawing.Color.LightGray;
            this.btnCustomprint.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCustomprint.Location = new System.Drawing.Point(24, 48);
            this.btnCustomprint.Name = "btnCustomprint";
            this.btnCustomprint.Size = new System.Drawing.Size(72, 24);
            this.btnCustomprint.TabIndex = 11;
            this.btnCustomprint.Text = "List";
            this.btnCustomprint.UseVisualStyleBackColor = false;
            this.btnCustomprint.Click += new System.EventHandler(this.btnCustomprint_Click);
            // 
            // GB_DoctorView
            // 
            this.GB_DoctorView.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GB_DoctorView.Controls.Add(this.dataGridView1);
            this.GB_DoctorView.Location = new System.Drawing.Point(20, 372);
            this.GB_DoctorView.Name = "GB_DoctorView";
            this.GB_DoctorView.Size = new System.Drawing.Size(656, 248);
            this.GB_DoctorView.TabIndex = 5;
            this.GB_DoctorView.TabStop = false;
            this.GB_DoctorView.Text = "Sister/Wardboy View";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(631, 223);
            this.dataGridView1.TabIndex = 1;
            // 
            // GB_Doctor
            // 
            this.GB_Doctor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GB_Doctor.Controls.Add(this.RtxtAddress);
            this.GB_Doctor.Controls.Add(this.GroupBox3);
            this.GB_Doctor.Controls.Add(this.CB_Category);
            this.GB_Doctor.Controls.Add(this.Label6);
            this.GB_Doctor.Controls.Add(this.DTP_DOJ);
            this.GB_Doctor.Controls.Add(this.txtPhone);
            this.GB_Doctor.Controls.Add(this.txtName);
            this.GB_Doctor.Controls.Add(this.txtID);
            this.GB_Doctor.Controls.Add(this.Label5);
            this.GB_Doctor.Controls.Add(this.Label4);
            this.GB_Doctor.Controls.Add(this.Label3);
            this.GB_Doctor.Controls.Add(this.Label2);
            this.GB_Doctor.Controls.Add(this.Label1);
            this.GB_Doctor.Location = new System.Drawing.Point(20, 12);
            this.GB_Doctor.Name = "GB_Doctor";
            this.GB_Doctor.Size = new System.Drawing.Size(496, 328);
            this.GB_Doctor.TabIndex = 4;
            this.GB_Doctor.TabStop = false;
            this.GB_Doctor.Text = "Sister/Wardboy Detail";
            // 
            // RtxtAddress
            // 
            this.RtxtAddress.Location = new System.Drawing.Point(168, 120);
            this.RtxtAddress.Multiline = true;
            this.RtxtAddress.Name = "RtxtAddress";
            this.RtxtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.RtxtAddress.Size = new System.Drawing.Size(100, 64);
            this.RtxtAddress.TabIndex = 2;
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.btnCancel);
            this.GroupBox3.Controls.Add(this.btnSaveS_W);
            this.GroupBox3.Controls.Add(this.btnDeleteS_W);
            this.GroupBox3.Controls.Add(this.btnUpdateS_W);
            this.GroupBox3.Controls.Add(this.btnAddS_W);
            this.GroupBox3.Location = new System.Drawing.Point(320, 48);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(144, 248);
            this.GroupBox3.TabIndex = 33;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Transaction";
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancel.Location = new System.Drawing.Point(32, 192);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            // 
            // btnSaveS_W
            // 
            this.btnSaveS_W.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSaveS_W.Location = new System.Drawing.Point(32, 152);
            this.btnSaveS_W.Name = "btnSaveS_W";
            this.btnSaveS_W.Size = new System.Drawing.Size(88, 23);
            this.btnSaveS_W.TabIndex = 9;
            this.btnSaveS_W.Text = "Save S/W";
            this.btnSaveS_W.Click += new System.EventHandler(this.btnSaveS_W_Click);
            // 
            // btnDeleteS_W
            // 
            this.btnDeleteS_W.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDeleteS_W.Location = new System.Drawing.Point(32, 112);
            this.btnDeleteS_W.Name = "btnDeleteS_W";
            this.btnDeleteS_W.Size = new System.Drawing.Size(88, 23);
            this.btnDeleteS_W.TabIndex = 8;
            this.btnDeleteS_W.Text = "Delete S/W";
            this.btnDeleteS_W.Click += new System.EventHandler(this.btnDeleteS_W_Click);
            // 
            // btnUpdateS_W
            // 
            this.btnUpdateS_W.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnUpdateS_W.Location = new System.Drawing.Point(32, 72);
            this.btnUpdateS_W.Name = "btnUpdateS_W";
            this.btnUpdateS_W.Size = new System.Drawing.Size(88, 23);
            this.btnUpdateS_W.TabIndex = 7;
            this.btnUpdateS_W.Text = "Edit S/W";
            this.btnUpdateS_W.Click += new System.EventHandler(this.btnUpdateS_W_Click);
            // 
            // btnAddS_W
            // 
            this.btnAddS_W.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAddS_W.Location = new System.Drawing.Point(32, 32);
            this.btnAddS_W.Name = "btnAddS_W";
            this.btnAddS_W.Size = new System.Drawing.Size(88, 23);
            this.btnAddS_W.TabIndex = 6;
            this.btnAddS_W.Text = "Add S/W";
            this.btnAddS_W.Click += new System.EventHandler(this.btnAddS_W_Click);
            // 
            // CB_Category
            // 
            this.CB_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Category.Items.AddRange(new object[] {
            "Sister",
            "Wardboy"});
            this.CB_Category.Location = new System.Drawing.Point(168, 200);
            this.CB_Category.Name = "CB_Category";
            this.CB_Category.Size = new System.Drawing.Size(104, 21);
            this.CB_Category.TabIndex = 3;
            // 
            // Label6
            // 
            this.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Label6.Location = new System.Drawing.Point(48, 200);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(100, 23);
            this.Label6.TabIndex = 31;
            this.Label6.Text = "Category";
            // 
            // DTP_DOJ
            // 
            this.DTP_DOJ.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_DOJ.Location = new System.Drawing.Point(168, 280);
            this.DTP_DOJ.Name = "DTP_DOJ";
            this.DTP_DOJ.Size = new System.Drawing.Size(104, 20);
            this.DTP_DOJ.TabIndex = 5;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(168, 240);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(168, 88);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(168, 48);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 20;
            // 
            // Label5
            // 
            this.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Label5.Location = new System.Drawing.Point(48, 280);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(100, 23);
            this.Label5.TabIndex = 19;
            this.Label5.Text = "Date of joining";
            // 
            // Label4
            // 
            this.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Label4.Location = new System.Drawing.Point(48, 240);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(100, 23);
            this.Label4.TabIndex = 18;
            this.Label4.Text = "Phone";
            // 
            // Label3
            // 
            this.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Label3.Location = new System.Drawing.Point(48, 128);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(100, 23);
            this.Label3.TabIndex = 17;
            this.Label3.Text = "Address";
            // 
            // Label2
            // 
            this.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Label2.Location = new System.Drawing.Point(48, 88);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(100, 23);
            this.Label2.TabIndex = 16;
            this.Label2.Text = "Name";
            // 
            // Label1
            // 
            this.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Label1.Location = new System.Drawing.Point(48, 48);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(100, 23);
            this.Label1.TabIndex = 15;
            this.Label1.Text = "ID";
            // 
            // SisterWardboyfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.GB_DoctorView);
            this.Controls.Add(this.GB_Doctor);
            this.Name = "SisterWardboyfrm";
            this.Size = new System.Drawing.Size(696, 632);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GB_DoctorView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.GB_Doctor.ResumeLayout(false);
            this.GB_Doctor.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Button btnSearch;
        internal System.Windows.Forms.Button btnExcel;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Button btnCustomprint;
        internal System.Windows.Forms.GroupBox GB_DoctorView;
        internal System.Windows.Forms.GroupBox GB_Doctor;
        internal System.Windows.Forms.TextBox RtxtAddress;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.Button btnSaveS_W;
        internal System.Windows.Forms.Button btnDeleteS_W;
        internal System.Windows.Forms.Button btnUpdateS_W;
        internal System.Windows.Forms.Button btnAddS_W;
        internal System.Windows.Forms.ComboBox CB_Category;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.DateTimePicker DTP_DOJ;
        internal System.Windows.Forms.TextBox txtPhone;
        internal System.Windows.Forms.TextBox txtName;
        internal System.Windows.Forms.TextBox txtID;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
