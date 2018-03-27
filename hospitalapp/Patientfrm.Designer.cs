namespace hospitalapp
{
    partial class Patientfrm
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
            this.components = new System.ComponentModel.Container();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCustomprint = new System.Windows.Forms.Button();
            this.GrpBox_PatiInfo = new System.Windows.Forms.GroupBox();
            this.Rtxt_Remark = new System.Windows.Forms.TextBox();
            this.RtxtAddress = new System.Windows.Forms.TextBox();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDischarge = new System.Windows.Forms.Button();
            this.btnSaveRegistration = new System.Windows.Forms.Button();
            this.btnCancelRegistration = new System.Windows.Forms.Button();
            this.btnEditRegistration = new System.Windows.Forms.Button();
            this.btnRegisterPatient = new System.Windows.Forms.Button();
            this.Label13 = new System.Windows.Forms.Label();
            this.txtBedCharge = new System.Windows.Forms.TextBox();
            this.DTP_date = new System.Windows.Forms.DateTimePicker();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.cbDoctor = new System.Windows.Forms.ComboBox();
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitaldataDataSet = new hospitalapp.hospitaldataDataSet();
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
            this.Label11 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.CB_BedCategory = new System.Windows.Forms.ComboBox();
            this.CB_Bedno = new System.Windows.Forms.ComboBox();
            this.GB_PatientView = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hospitaldataDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitaldataDataSet3 = new hospitalapp.hospitaldataDataSet3();
            this.admitBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hospitaldataDataSet2 = new hospitalapp.hospitaldataDataSet2();
            this.doctorTableAdapter = new hospitalapp.hospitaldataDataSetTableAdapters.DoctorTableAdapter();
            this.admitTableAdapter1 = new hospitalapp.hospitaldataDataSet2TableAdapters.AdmitTableAdapter();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.GrpBox_PatiInfo.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitaldataDataSet)).BeginInit();
            this.GB_PatientView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitaldataDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitaldataDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.admitBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitaldataDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.btnSearch);
            this.GroupBox2.Controls.Add(this.btnExcel);
            this.GroupBox2.Location = new System.Drawing.Point(544, 248);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(136, 128);
            this.GroupBox2.TabIndex = 12;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Search/Export";
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSearch.Location = new System.Drawing.Point(32, 32);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 32);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "Search";
            // 
            // btnExcel
            // 
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExcel.Location = new System.Drawing.Point(32, 80);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(75, 32);
            this.btnExcel.TabIndex = 21;
            this.btnExcel.Text = "Excel";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.btnCustomprint);
            this.GroupBox1.Location = new System.Drawing.Point(544, 48);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(136, 104);
            this.GroupBox1.TabIndex = 11;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Print";
            // 
            // btnCustomprint
            // 
            this.btnCustomprint.BackColor = System.Drawing.Color.LightGray;
            this.btnCustomprint.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCustomprint.Location = new System.Drawing.Point(32, 40);
            this.btnCustomprint.Name = "btnCustomprint";
            this.btnCustomprint.Size = new System.Drawing.Size(72, 32);
            this.btnCustomprint.TabIndex = 19;
            this.btnCustomprint.Text = "List";
            this.btnCustomprint.UseVisualStyleBackColor = false;
            // 
            // GrpBox_PatiInfo
            // 
            this.GrpBox_PatiInfo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GrpBox_PatiInfo.Controls.Add(this.Rtxt_Remark);
            this.GrpBox_PatiInfo.Controls.Add(this.RtxtAddress);
            this.GrpBox_PatiInfo.Controls.Add(this.GroupBox3);
            this.GrpBox_PatiInfo.Controls.Add(this.Label13);
            this.GrpBox_PatiInfo.Controls.Add(this.txtBedCharge);
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
            this.GrpBox_PatiInfo.Controls.Add(this.Label11);
            this.GrpBox_PatiInfo.Controls.Add(this.Label12);
            this.GrpBox_PatiInfo.Controls.Add(this.CB_BedCategory);
            this.GrpBox_PatiInfo.Controls.Add(this.CB_Bedno);
            this.GrpBox_PatiInfo.Location = new System.Drawing.Point(16, 8);
            this.GrpBox_PatiInfo.Name = "GrpBox_PatiInfo";
            this.GrpBox_PatiInfo.Size = new System.Drawing.Size(516, 492);
            this.GrpBox_PatiInfo.TabIndex = 9;
            this.GrpBox_PatiInfo.TabStop = false;
            this.GrpBox_PatiInfo.Text = "Patient Detail";
            // 
            // Rtxt_Remark
            // 
            this.Rtxt_Remark.Location = new System.Drawing.Point(144, 432);
            this.Rtxt_Remark.Multiline = true;
            this.Rtxt_Remark.Name = "Rtxt_Remark";
            this.Rtxt_Remark.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Rtxt_Remark.Size = new System.Drawing.Size(100, 40);
            this.Rtxt_Remark.TabIndex = 12;
            // 
            // RtxtAddress
            // 
            this.RtxtAddress.Location = new System.Drawing.Point(144, 224);
            this.RtxtAddress.Multiline = true;
            this.RtxtAddress.Name = "RtxtAddress";
            this.RtxtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.RtxtAddress.Size = new System.Drawing.Size(104, 40);
            this.RtxtAddress.TabIndex = 6;
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.btnDischarge);
            this.GroupBox3.Controls.Add(this.btnSaveRegistration);
            this.GroupBox3.Controls.Add(this.btnCancelRegistration);
            this.GroupBox3.Controls.Add(this.btnEditRegistration);
            this.GroupBox3.Controls.Add(this.btnRegisterPatient);
            this.GroupBox3.Location = new System.Drawing.Point(320, 40);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(176, 280);
            this.GroupBox3.TabIndex = 69;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Transaction";
            // 
            // btnDischarge
            // 
            this.btnDischarge.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDischarge.Location = new System.Drawing.Point(32, 224);
            this.btnDischarge.Name = "btnDischarge";
            this.btnDischarge.Size = new System.Drawing.Size(112, 32);
            this.btnDischarge.TabIndex = 18;
            this.btnDischarge.Text = "Discharge Patient";
            // 
            // btnSaveRegistration
            // 
            this.btnSaveRegistration.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSaveRegistration.Location = new System.Drawing.Point(32, 128);
            this.btnSaveRegistration.Name = "btnSaveRegistration";
            this.btnSaveRegistration.Size = new System.Drawing.Size(112, 32);
            this.btnSaveRegistration.TabIndex = 16;
            this.btnSaveRegistration.Text = "Save  Registration";
            this.btnSaveRegistration.Click += new System.EventHandler(this.btnSaveRegistration_Click);
            // 
            // btnCancelRegistration
            // 
            this.btnCancelRegistration.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancelRegistration.Location = new System.Drawing.Point(32, 176);
            this.btnCancelRegistration.Name = "btnCancelRegistration";
            this.btnCancelRegistration.Size = new System.Drawing.Size(112, 32);
            this.btnCancelRegistration.TabIndex = 17;
            this.btnCancelRegistration.Text = "Cancel  Registration";
            // 
            // btnEditRegistration
            // 
            this.btnEditRegistration.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEditRegistration.Location = new System.Drawing.Point(32, 80);
            this.btnEditRegistration.Name = "btnEditRegistration";
            this.btnEditRegistration.Size = new System.Drawing.Size(112, 32);
            this.btnEditRegistration.TabIndex = 14;
            this.btnEditRegistration.Text = "Edit Registration";
            // 
            // btnRegisterPatient
            // 
            this.btnRegisterPatient.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRegisterPatient.Location = new System.Drawing.Point(32, 24);
            this.btnRegisterPatient.Name = "btnRegisterPatient";
            this.btnRegisterPatient.Size = new System.Drawing.Size(112, 32);
            this.btnRegisterPatient.TabIndex = 13;
            this.btnRegisterPatient.Text = "Register Patient";
            this.btnRegisterPatient.Click += new System.EventHandler(this.btnRegisterPatient_Click);
            // 
            // Label13
            // 
            this.Label13.Location = new System.Drawing.Point(24, 128);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(100, 23);
            this.Label13.TabIndex = 68;
            this.Label13.Text = "Bed Charge/Day";
            // 
            // txtBedCharge
            // 
            this.txtBedCharge.Location = new System.Drawing.Point(144, 128);
            this.txtBedCharge.Name = "txtBedCharge";
            this.txtBedCharge.Size = new System.Drawing.Size(104, 20);
            this.txtBedCharge.TabIndex = 3;
            // 
            // DTP_date
            // 
            this.DTP_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_date.Location = new System.Drawing.Point(144, 304);
            this.DTP_date.Name = "DTP_date";
            this.DTP_date.Size = new System.Drawing.Size(104, 20);
            this.DTP_date.TabIndex = 8;
            this.DTP_date.Value = new System.DateTime(2008, 1, 1, 0, 0, 0, 0);
            // 
            // Label10
            // 
            this.Label10.Location = new System.Drawing.Point(24, 440);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(100, 23);
            this.Label10.TabIndex = 59;
            this.Label10.Text = "Remarks";
            // 
            // Label9
            // 
            this.Label9.Location = new System.Drawing.Point(24, 368);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(100, 23);
            this.Label9.TabIndex = 58;
            this.Label9.Text = "Blood Group";
            // 
            // cbDoctor
            // 
            this.cbDoctor.DataSource = this.doctorBindingSource;
            this.cbDoctor.DisplayMember = "Name";
            this.cbDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDoctor.Location = new System.Drawing.Point(144, 400);
            this.cbDoctor.Name = "cbDoctor";
            this.cbDoctor.Size = new System.Drawing.Size(104, 21);
            this.cbDoctor.TabIndex = 11;
            this.cbDoctor.ValueMember = "ID";
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataMember = "Doctor";
            this.doctorBindingSource.DataSource = this.hospitaldataDataSet;
            // 
            // hospitaldataDataSet
            // 
            this.hospitaldataDataSet.DataSetName = "hospitaldataDataSet";
            this.hospitaldataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Label8
            // 
            this.Label8.Location = new System.Drawing.Point(24, 400);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(100, 23);
            this.Label8.TabIndex = 21;
            this.Label8.Text = "Doctor";
            // 
            // Label7
            // 
            this.Label7.Location = new System.Drawing.Point(24, 336);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(100, 23);
            this.Label7.TabIndex = 20;
            this.Label7.Text = "Disease";
            // 
            // Label6
            // 
            this.Label6.Location = new System.Drawing.Point(24, 304);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(100, 23);
            this.Label6.TabIndex = 19;
            this.Label6.Text = "Date";
            // 
            // Label5
            // 
            this.Label5.Location = new System.Drawing.Point(24, 272);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(100, 23);
            this.Label5.TabIndex = 18;
            this.Label5.Text = "Phone No";
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(24, 224);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(100, 23);
            this.Label4.TabIndex = 17;
            this.Label4.Text = "Address";
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(24, 192);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(100, 23);
            this.Label3.TabIndex = 16;
            this.Label3.Text = "Age";
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(24, 160);
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
            this.txtDisease.Location = new System.Drawing.Point(144, 336);
            this.txtDisease.Name = "txtDisease";
            this.txtDisease.Size = new System.Drawing.Size(104, 20);
            this.txtDisease.TabIndex = 9;
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(144, 272);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(104, 20);
            this.txtphone.TabIndex = 7;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(144, 192);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(104, 20);
            this.txtAge.TabIndex = 5;
            // 
            // txtPatiname
            // 
            this.txtPatiname.Location = new System.Drawing.Point(144, 160);
            this.txtPatiname.Name = "txtPatiname";
            this.txtPatiname.Size = new System.Drawing.Size(104, 20);
            this.txtPatiname.TabIndex = 4;
            // 
            // txtRegno
            // 
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
            this.CB_Bloodgp.Location = new System.Drawing.Point(144, 368);
            this.CB_Bloodgp.Name = "CB_Bloodgp";
            this.CB_Bloodgp.Size = new System.Drawing.Size(104, 21);
            this.CB_Bloodgp.TabIndex = 10;
            // 
            // Label11
            // 
            this.Label11.Location = new System.Drawing.Point(24, 64);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(80, 23);
            this.Label11.TabIndex = 0;
            this.Label11.Text = "Bed Type";
            // 
            // Label12
            // 
            this.Label12.Location = new System.Drawing.Point(24, 96);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(80, 24);
            this.Label12.TabIndex = 64;
            this.Label12.Text = "Bed No";
            // 
            // CB_BedCategory
            // 
            this.CB_BedCategory.Items.AddRange(new object[] {
            "General",
            "Special"});
            this.CB_BedCategory.Location = new System.Drawing.Point(144, 64);
            this.CB_BedCategory.Name = "CB_BedCategory";
            this.CB_BedCategory.Size = new System.Drawing.Size(104, 21);
            this.CB_BedCategory.TabIndex = 1;
            // 
            // CB_Bedno
            // 
            this.CB_Bedno.Enabled = false;
            this.CB_Bedno.Location = new System.Drawing.Point(144, 96);
            this.CB_Bedno.Name = "CB_Bedno";
            this.CB_Bedno.Size = new System.Drawing.Size(104, 21);
            this.CB_Bedno.TabIndex = 2;
            // 
            // GB_PatientView
            // 
            this.GB_PatientView.Controls.Add(this.dataGridView1);
            this.GB_PatientView.Location = new System.Drawing.Point(16, 506);
            this.GB_PatientView.Name = "GB_PatientView";
            this.GB_PatientView.Size = new System.Drawing.Size(664, 117);
            this.GB_PatientView.TabIndex = 10;
            this.GB_PatientView.TabStop = false;
            this.GB_PatientView.Text = "Patient List View";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.hospitaldataDataSet3BindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(658, 98);
            this.dataGridView1.TabIndex = 0;
            // 
            // hospitaldataDataSet3BindingSource
            // 
            this.hospitaldataDataSet3BindingSource.DataSource = this.hospitaldataDataSet3;
            this.hospitaldataDataSet3BindingSource.Position = 0;
            // 
            // hospitaldataDataSet3
            // 
            this.hospitaldataDataSet3.DataSetName = "hospitaldataDataSet3";
            this.hospitaldataDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // admitBindingSource1
            // 
            this.admitBindingSource1.DataMember = "Admit";
            this.admitBindingSource1.DataSource = this.hospitaldataDataSet2;
            // 
            // hospitaldataDataSet2
            // 
            this.hospitaldataDataSet2.DataSetName = "hospitaldataDataSet2";
            this.hospitaldataDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doctorTableAdapter
            // 
            this.doctorTableAdapter.ClearBeforeFill = true;
            // 
            // admitTableAdapter1
            // 
            this.admitTableAdapter1.ClearBeforeFill = true;
            // 
            // Patientfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.GrpBox_PatiInfo);
            this.Controls.Add(this.GB_PatientView);
            this.Name = "Patientfrm";
            this.Size = new System.Drawing.Size(696, 636);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GrpBox_PatiInfo.ResumeLayout(false);
            this.GrpBox_PatiInfo.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitaldataDataSet)).EndInit();
            this.GB_PatientView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitaldataDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitaldataDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.admitBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitaldataDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Button btnSearch;
        internal System.Windows.Forms.Button btnExcel;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Button btnCustomprint;
        internal System.Windows.Forms.GroupBox GrpBox_PatiInfo;
        internal System.Windows.Forms.TextBox Rtxt_Remark;
        internal System.Windows.Forms.TextBox RtxtAddress;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.Button btnDischarge;
        internal System.Windows.Forms.Button btnSaveRegistration;
        internal System.Windows.Forms.Button btnCancelRegistration;
        internal System.Windows.Forms.Button btnEditRegistration;
        internal System.Windows.Forms.Button btnRegisterPatient;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.TextBox txtBedCharge;
        internal System.Windows.Forms.DateTimePicker DTP_date;
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
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.ComboBox CB_BedCategory;
        internal System.Windows.Forms.ComboBox CB_Bedno;
        internal System.Windows.Forms.GroupBox GB_PatientView;
        private System.Windows.Forms.BindingSource doctorBindingSource;
        private hospitaldataDataSet hospitaldataDataSet;
        private hospitalapp.hospitaldataDataSetTableAdapters.DoctorTableAdapter doctorTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource admitBindingSource1;
        private hospitaldataDataSet2 hospitaldataDataSet2;
        private hospitalapp.hospitaldataDataSet2TableAdapters.AdmitTableAdapter admitTableAdapter1;
        private System.Windows.Forms.BindingSource hospitaldataDataSet3BindingSource;
        private hospitaldataDataSet3 hospitaldataDataSet3;
    }
}
