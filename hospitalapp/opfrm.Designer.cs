namespace hospitalapp
{
    partial class opfrm
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
            this.Label11 = new System.Windows.Forms.Label();
            this.DTP_time = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.DTP_date = new System.Windows.Forms.DateTimePicker();
            this.GrpBox_PatiInfo = new System.Windows.Forms.GroupBox();
            this.Rtxt_Remark = new System.Windows.Forms.TextBox();
            this.RtxtAddress = new System.Windows.Forms.TextBox();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.button_admit = new System.Windows.Forms.Button();
            this.btnDeleteRegistration = new System.Windows.Forms.Button();
            this.btnRegisterPatient = new System.Windows.Forms.Button();
            this.btnSaveRegistration = new System.Windows.Forms.Button();
            this.btnEditRegistration = new System.Windows.Forms.Button();
            this.btnCancelRegistration = new System.Windows.Forms.Button();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.cbDoctor = new System.Windows.Forms.ComboBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtDisease = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtPatiname = new System.Windows.Forms.TextBox();
            this.txtRegno = new System.Windows.Forms.TextBox();
            this.CB_Bloodgp = new System.Windows.Forms.ComboBox();
            this.btnCustomprint = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.GB_PatientView = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.GrpBox_PatiInfo.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.GB_PatientView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label11
            // 
            this.Label11.Location = new System.Drawing.Point(24, 240);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(100, 23);
            this.Label11.TabIndex = 63;
            this.Label11.Text = "Time";
            // 
            // DTP_time
            // 
            this.DTP_time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DTP_time.Location = new System.Drawing.Point(144, 240);
            this.DTP_time.Name = "DTP_time";
            this.DTP_time.Size = new System.Drawing.Size(104, 20);
            this.DTP_time.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSearch.Location = new System.Drawing.Point(32, 32);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 32);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // DTP_date
            // 
            this.DTP_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_date.Location = new System.Drawing.Point(144, 208);
            this.DTP_date.Name = "DTP_date";
            this.DTP_date.Size = new System.Drawing.Size(104, 20);
            this.DTP_date.TabIndex = 5;
            this.DTP_date.Value = new System.DateTime(2008, 1, 1, 0, 0, 0, 0);
            // 
            // GrpBox_PatiInfo
            // 
            this.GrpBox_PatiInfo.Controls.Add(this.Rtxt_Remark);
            this.GrpBox_PatiInfo.Controls.Add(this.RtxtAddress);
            this.GrpBox_PatiInfo.Controls.Add(this.GroupBox3);
            this.GrpBox_PatiInfo.Controls.Add(this.Label11);
            this.GrpBox_PatiInfo.Controls.Add(this.DTP_time);
            this.GrpBox_PatiInfo.Controls.Add(this.DTP_date);
            this.GrpBox_PatiInfo.Controls.Add(this.Label10);
            this.GrpBox_PatiInfo.Controls.Add(this.Label9);
            this.GrpBox_PatiInfo.Controls.Add(this.cbDoctor);
            this.GrpBox_PatiInfo.Controls.Add(this.Label8);
            this.GrpBox_PatiInfo.Controls.Add(this.Label7);
            this.GrpBox_PatiInfo.Controls.Add(this.Label6);
            this.GrpBox_PatiInfo.Controls.Add(this.Label5);
            this.GrpBox_PatiInfo.Controls.Add(this.Label4);
            this.GrpBox_PatiInfo.Controls.Add(this.Label3);
            this.GrpBox_PatiInfo.Controls.Add(this.Label2);
            this.GrpBox_PatiInfo.Controls.Add(this.Label1);
            this.GrpBox_PatiInfo.Controls.Add(this.txtDisease);
            this.GrpBox_PatiInfo.Controls.Add(this.txtphone);
            this.GrpBox_PatiInfo.Controls.Add(this.txtAge);
            this.GrpBox_PatiInfo.Controls.Add(this.txtPatiname);
            this.GrpBox_PatiInfo.Controls.Add(this.txtRegno);
            this.GrpBox_PatiInfo.Controls.Add(this.CB_Bloodgp);
            this.GrpBox_PatiInfo.Location = new System.Drawing.Point(16, 8);
            this.GrpBox_PatiInfo.Name = "GrpBox_PatiInfo";
            this.GrpBox_PatiInfo.Size = new System.Drawing.Size(512, 424);
            this.GrpBox_PatiInfo.TabIndex = 8;
            this.GrpBox_PatiInfo.TabStop = false;
            this.GrpBox_PatiInfo.Text = "Patient Detail";
            // 
            // Rtxt_Remark
            // 
            this.Rtxt_Remark.Location = new System.Drawing.Point(144, 368);
            this.Rtxt_Remark.Multiline = true;
            this.Rtxt_Remark.Name = "Rtxt_Remark";
            this.Rtxt_Remark.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Rtxt_Remark.Size = new System.Drawing.Size(100, 40);
            this.Rtxt_Remark.TabIndex = 10;
            // 
            // RtxtAddress
            // 
            this.RtxtAddress.Location = new System.Drawing.Point(144, 128);
            this.RtxtAddress.Multiline = true;
            this.RtxtAddress.Name = "RtxtAddress";
            this.RtxtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.RtxtAddress.Size = new System.Drawing.Size(104, 40);
            this.RtxtAddress.TabIndex = 3;
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.button_admit);
            this.GroupBox3.Controls.Add(this.btnDeleteRegistration);
            this.GroupBox3.Controls.Add(this.btnRegisterPatient);
            this.GroupBox3.Controls.Add(this.btnSaveRegistration);
            this.GroupBox3.Controls.Add(this.btnEditRegistration);
            this.GroupBox3.Controls.Add(this.btnCancelRegistration);
            this.GroupBox3.Location = new System.Drawing.Point(304, 32);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(176, 328);
            this.GroupBox3.TabIndex = 64;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Transaction";
            // 
            // button_admit
            // 
            this.button_admit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_admit.Location = new System.Drawing.Point(32, 272);
            this.button_admit.Name = "button_admit";
            this.button_admit.Size = new System.Drawing.Size(112, 32);
            this.button_admit.TabIndex = 16;
            this.button_admit.Text = "Admit";
            this.button_admit.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDeleteRegistration
            // 
            this.btnDeleteRegistration.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDeleteRegistration.Location = new System.Drawing.Point(32, 136);
            this.btnDeleteRegistration.Name = "btnDeleteRegistration";
            this.btnDeleteRegistration.Size = new System.Drawing.Size(112, 32);
            this.btnDeleteRegistration.TabIndex = 13;
            this.btnDeleteRegistration.Text = "Delete  Registration";
            this.btnDeleteRegistration.Click += new System.EventHandler(this.btnDeleteRegistration_Click);
            // 
            // btnRegisterPatient
            // 
            this.btnRegisterPatient.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRegisterPatient.Location = new System.Drawing.Point(32, 40);
            this.btnRegisterPatient.Name = "btnRegisterPatient";
            this.btnRegisterPatient.Size = new System.Drawing.Size(112, 32);
            this.btnRegisterPatient.TabIndex = 11;
            this.btnRegisterPatient.Text = "Register Patient";
            this.btnRegisterPatient.Click += new System.EventHandler(this.btnRegisterPatient_Click);
            // 
            // btnSaveRegistration
            // 
            this.btnSaveRegistration.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSaveRegistration.Location = new System.Drawing.Point(32, 184);
            this.btnSaveRegistration.Name = "btnSaveRegistration";
            this.btnSaveRegistration.Size = new System.Drawing.Size(112, 32);
            this.btnSaveRegistration.TabIndex = 14;
            this.btnSaveRegistration.Text = "Save  Registration";
            this.btnSaveRegistration.Click += new System.EventHandler(this.btnSaveRegistration_Click);
            // 
            // btnEditRegistration
            // 
            this.btnEditRegistration.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEditRegistration.Location = new System.Drawing.Point(32, 88);
            this.btnEditRegistration.Name = "btnEditRegistration";
            this.btnEditRegistration.Size = new System.Drawing.Size(112, 32);
            this.btnEditRegistration.TabIndex = 12;
            this.btnEditRegistration.Text = "Edit Registration";
            this.btnEditRegistration.Click += new System.EventHandler(this.btnEditRegistration_Click);
            // 
            // btnCancelRegistration
            // 
            this.btnCancelRegistration.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancelRegistration.Location = new System.Drawing.Point(32, 232);
            this.btnCancelRegistration.Name = "btnCancelRegistration";
            this.btnCancelRegistration.Size = new System.Drawing.Size(112, 32);
            this.btnCancelRegistration.TabIndex = 15;
            this.btnCancelRegistration.Text = "Cancel  Registration";
            this.btnCancelRegistration.Click += new System.EventHandler(this.btnCancelRegistration_Click);
            // 
            // Label10
            // 
            this.Label10.Location = new System.Drawing.Point(24, 368);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(100, 23);
            this.Label10.TabIndex = 59;
            this.Label10.Text = "Remarks";
            // 
            // Label9
            // 
            this.Label9.Location = new System.Drawing.Point(24, 304);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(100, 23);
            this.Label9.TabIndex = 58;
            this.Label9.Text = "Blood Group";
            // 
            // cbDoctor
            // 
            this.cbDoctor.DisplayMember = "Name";
            this.cbDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDoctor.Location = new System.Drawing.Point(144, 336);
            this.cbDoctor.Name = "cbDoctor";
            this.cbDoctor.Size = new System.Drawing.Size(104, 21);
            this.cbDoctor.TabIndex = 9;
            // 
            // Label8
            // 
            this.Label8.Location = new System.Drawing.Point(24, 336);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(100, 23);
            this.Label8.TabIndex = 21;
            this.Label8.Text = "Doctor";
            // 
            // Label7
            // 
            this.Label7.Location = new System.Drawing.Point(24, 272);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(100, 23);
            this.Label7.TabIndex = 20;
            this.Label7.Text = "Disease";
            // 
            // Label6
            // 
            this.Label6.Location = new System.Drawing.Point(24, 208);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(100, 23);
            this.Label6.TabIndex = 19;
            this.Label6.Text = "Date";
            // 
            // Label5
            // 
            this.Label5.Location = new System.Drawing.Point(24, 176);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(100, 23);
            this.Label5.TabIndex = 18;
            this.Label5.Text = "Phone No";
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(24, 128);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(100, 23);
            this.Label4.TabIndex = 17;
            this.Label4.Text = "Address";
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(24, 96);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(100, 23);
            this.Label3.TabIndex = 16;
            this.Label3.Text = "Age";
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
            // txtDisease
            // 
            this.txtDisease.Location = new System.Drawing.Point(144, 272);
            this.txtDisease.Name = "txtDisease";
            this.txtDisease.Size = new System.Drawing.Size(104, 20);
            this.txtDisease.TabIndex = 7;
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(144, 176);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(104, 20);
            this.txtphone.TabIndex = 4;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(144, 96);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(104, 20);
            this.txtAge.TabIndex = 2;
            // 
            // txtPatiname
            // 
            this.txtPatiname.Location = new System.Drawing.Point(144, 64);
            this.txtPatiname.Name = "txtPatiname";
            this.txtPatiname.Size = new System.Drawing.Size(104, 20);
            this.txtPatiname.TabIndex = 1;
            // 
            // txtRegno
            // 
            this.txtRegno.Enabled = false;
            this.txtRegno.Location = new System.Drawing.Point(144, 32);
            this.txtRegno.Name = "txtRegno";
            this.txtRegno.ReadOnly = true;
            this.txtRegno.Size = new System.Drawing.Size(104, 20);
            this.txtRegno.TabIndex = 7;
            // 
            // CB_Bloodgp
            // 
            this.CB_Bloodgp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Bloodgp.Items.AddRange(new object[] {
            "A+",
            "B+",
            "AB+",
            "O+",
            "A-",
            "B-",
            "AB-",
            "O-"});
            this.CB_Bloodgp.Location = new System.Drawing.Point(144, 304);
            this.CB_Bloodgp.Name = "CB_Bloodgp";
            this.CB_Bloodgp.Size = new System.Drawing.Size(104, 21);
            this.CB_Bloodgp.TabIndex = 8;
            // 
            // btnCustomprint
            // 
            this.btnCustomprint.BackColor = System.Drawing.Color.LightGray;
            this.btnCustomprint.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCustomprint.Location = new System.Drawing.Point(32, 32);
            this.btnCustomprint.Name = "btnCustomprint";
            this.btnCustomprint.Size = new System.Drawing.Size(72, 32);
            this.btnCustomprint.TabIndex = 16;
            this.btnCustomprint.Text = "List";
            this.btnCustomprint.UseVisualStyleBackColor = false;
            this.btnCustomprint.Click += new System.EventHandler(this.btnCustomprint_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExcel.Location = new System.Drawing.Point(32, 80);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(75, 32);
            this.btnExcel.TabIndex = 18;
            this.btnExcel.Text = "Excel";
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.btnCustomprint);
            this.GroupBox1.Location = new System.Drawing.Point(544, 40);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(136, 96);
            this.GroupBox1.TabIndex = 10;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Print";
            // 
            // GB_PatientView
            // 
            this.GB_PatientView.Controls.Add(this.dataGridView1);
            this.GB_PatientView.Location = new System.Drawing.Point(16, 448);
            this.GB_PatientView.Name = "GB_PatientView";
            this.GB_PatientView.Size = new System.Drawing.Size(664, 176);
            this.GB_PatientView.TabIndex = 9;
            this.GB_PatientView.TabStop = false;
            this.GB_PatientView.Text = "Patient List View";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(650, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellBorderStyleChanged += new System.EventHandler(this.dataGridView1_CellBorderStyleChanged);
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.btnSearch);
            this.GroupBox2.Controls.Add(this.btnExcel);
            this.GroupBox2.Location = new System.Drawing.Point(544, 200);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(136, 128);
            this.GroupBox2.TabIndex = 11;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Search/Export";
            // 
            // opfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.GrpBox_PatiInfo);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.GB_PatientView);
            this.Controls.Add(this.GroupBox2);
            this.Name = "opfrm";
            this.Size = new System.Drawing.Size(696, 632);
            this.GrpBox_PatiInfo.ResumeLayout(false);
            this.GrpBox_PatiInfo.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GB_PatientView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.GroupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.DateTimePicker DTP_time;
        internal System.Windows.Forms.Button btnSearch;
        internal System.Windows.Forms.DateTimePicker DTP_date;
        internal System.Windows.Forms.GroupBox GrpBox_PatiInfo;
        internal System.Windows.Forms.TextBox Rtxt_Remark;
        internal System.Windows.Forms.TextBox RtxtAddress;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.Button btnDeleteRegistration;
        internal System.Windows.Forms.Button btnRegisterPatient;
        internal System.Windows.Forms.Button btnSaveRegistration;
        internal System.Windows.Forms.Button btnEditRegistration;
        internal System.Windows.Forms.Button btnCancelRegistration;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.ComboBox cbDoctor;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtDisease;
        internal System.Windows.Forms.TextBox txtphone;
        internal System.Windows.Forms.TextBox txtAge;
        internal System.Windows.Forms.TextBox txtPatiname;
        internal System.Windows.Forms.TextBox txtRegno;
        internal System.Windows.Forms.ComboBox CB_Bloodgp;
        internal System.Windows.Forms.Button btnCustomprint;
        internal System.Windows.Forms.Button btnExcel;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.GroupBox GB_PatientView;
        internal System.Windows.Forms.GroupBox GroupBox2;
    
        private System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.DataGridViewTextBoxColumn regDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloodgroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorDataGridViewTextBoxColumn;
        internal System.Windows.Forms.Button button_admit;

    }
}
