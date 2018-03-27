namespace hospitalapp
{
    partial class Dischargefrm
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
            this.LV_Discharge = new System.Windows.Forms.ListView();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.DTP_DOD = new System.Windows.Forms.TextBox();
            this.cbDoctor = new System.Windows.Forms.TextBox();
            this.CB_Bloodgp = new System.Windows.Forms.TextBox();
            this.DTP_date = new System.Windows.Forms.TextBox();
            this.CB_Bedno = new System.Windows.Forms.TextBox();
            this.CB_BedCategory = new System.Windows.Forms.TextBox();
            this.RtxtAddress = new System.Windows.Forms.TextBox();
            this.Rtxt_Remark = new System.Windows.Forms.TextBox();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDeleteRegistration = new System.Windows.Forms.Button();
            this.Label14 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.txtBedCharge = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
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
            this.Label11 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.GroupBox5 = new System.Windows.Forms.GroupBox();
            this.btnCustomprint = new System.Windows.Forms.Button();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.GroupBox5.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.LV_Discharge);
            this.GroupBox2.Location = new System.Drawing.Point(16, 520);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(560, 104);
            this.GroupBox2.TabIndex = 12;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Patient List View";
            // 
            // LV_Discharge
            // 
            this.LV_Discharge.FullRowSelect = true;
            this.LV_Discharge.GridLines = true;
            this.LV_Discharge.Location = new System.Drawing.Point(24, 16);
            this.LV_Discharge.Name = "LV_Discharge";
            this.LV_Discharge.Size = new System.Drawing.Size(512, 80);
            this.LV_Discharge.TabIndex = 0;
            this.LV_Discharge.UseCompatibleStateImageBehavior = false;
            this.LV_Discharge.View = System.Windows.Forms.View.Details;
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GroupBox1.Controls.Add(this.DTP_DOD);
            this.GroupBox1.Controls.Add(this.cbDoctor);
            this.GroupBox1.Controls.Add(this.CB_Bloodgp);
            this.GroupBox1.Controls.Add(this.DTP_date);
            this.GroupBox1.Controls.Add(this.CB_Bedno);
            this.GroupBox1.Controls.Add(this.CB_BedCategory);
            this.GroupBox1.Controls.Add(this.RtxtAddress);
            this.GroupBox1.Controls.Add(this.Rtxt_Remark);
            this.GroupBox1.Controls.Add(this.GroupBox3);
            this.GroupBox1.Controls.Add(this.Label14);
            this.GroupBox1.Controls.Add(this.Label13);
            this.GroupBox1.Controls.Add(this.txtBedCharge);
            this.GroupBox1.Controls.Add(this.Label10);
            this.GroupBox1.Controls.Add(this.Label9);
            this.GroupBox1.Controls.Add(this.Label8);
            this.GroupBox1.Controls.Add(this.Label7);
            this.GroupBox1.Controls.Add(this.Label6);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.txtDisease);
            this.GroupBox1.Controls.Add(this.txtphone);
            this.GroupBox1.Controls.Add(this.txtAge);
            this.GroupBox1.Controls.Add(this.txtPatiname);
            this.GroupBox1.Controls.Add(this.txtRegno);
            this.GroupBox1.Controls.Add(this.Label11);
            this.GroupBox1.Controls.Add(this.Label12);
            this.GroupBox1.Location = new System.Drawing.Point(16, 8);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(512, 504);
            this.GroupBox1.TabIndex = 11;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Patient Detail";
            // 
            // DTP_DOD
            // 
            this.DTP_DOD.Location = new System.Drawing.Point(160, 472);
            this.DTP_DOD.Name = "DTP_DOD";
            this.DTP_DOD.ReadOnly = true;
            this.DTP_DOD.Size = new System.Drawing.Size(100, 20);
            this.DTP_DOD.TabIndex = 159;
            // 
            // cbDoctor
            // 
            this.cbDoctor.Location = new System.Drawing.Point(160, 392);
            this.cbDoctor.Name = "cbDoctor";
            this.cbDoctor.ReadOnly = true;
            this.cbDoctor.Size = new System.Drawing.Size(100, 20);
            this.cbDoctor.TabIndex = 158;
            // 
            // CB_Bloodgp
            // 
            this.CB_Bloodgp.Location = new System.Drawing.Point(160, 360);
            this.CB_Bloodgp.Name = "CB_Bloodgp";
            this.CB_Bloodgp.ReadOnly = true;
            this.CB_Bloodgp.Size = new System.Drawing.Size(100, 20);
            this.CB_Bloodgp.TabIndex = 157;
            // 
            // DTP_date
            // 
            this.DTP_date.Location = new System.Drawing.Point(160, 296);
            this.DTP_date.Name = "DTP_date";
            this.DTP_date.ReadOnly = true;
            this.DTP_date.Size = new System.Drawing.Size(100, 20);
            this.DTP_date.TabIndex = 156;
            // 
            // CB_Bedno
            // 
            this.CB_Bedno.Location = new System.Drawing.Point(160, 88);
            this.CB_Bedno.Name = "CB_Bedno";
            this.CB_Bedno.ReadOnly = true;
            this.CB_Bedno.Size = new System.Drawing.Size(100, 20);
            this.CB_Bedno.TabIndex = 155;
            // 
            // CB_BedCategory
            // 
            this.CB_BedCategory.Location = new System.Drawing.Point(160, 56);
            this.CB_BedCategory.Name = "CB_BedCategory";
            this.CB_BedCategory.ReadOnly = true;
            this.CB_BedCategory.Size = new System.Drawing.Size(104, 20);
            this.CB_BedCategory.TabIndex = 154;
            // 
            // RtxtAddress
            // 
            this.RtxtAddress.Location = new System.Drawing.Point(160, 216);
            this.RtxtAddress.Multiline = true;
            this.RtxtAddress.Name = "RtxtAddress";
            this.RtxtAddress.ReadOnly = true;
            this.RtxtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.RtxtAddress.Size = new System.Drawing.Size(104, 40);
            this.RtxtAddress.TabIndex = 7;
            // 
            // Rtxt_Remark
            // 
            this.Rtxt_Remark.Location = new System.Drawing.Point(160, 424);
            this.Rtxt_Remark.Multiline = true;
            this.Rtxt_Remark.Name = "Rtxt_Remark";
            this.Rtxt_Remark.ReadOnly = true;
            this.Rtxt_Remark.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Rtxt_Remark.Size = new System.Drawing.Size(100, 40);
            this.Rtxt_Remark.TabIndex = 13;
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.btnDeleteRegistration);
            this.GroupBox3.Location = new System.Drawing.Point(320, 32);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(176, 96);
            this.GroupBox3.TabIndex = 153;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Transaction";
            // 
            // btnDeleteRegistration
            // 
            this.btnDeleteRegistration.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDeleteRegistration.Location = new System.Drawing.Point(32, 40);
            this.btnDeleteRegistration.Name = "btnDeleteRegistration";
            this.btnDeleteRegistration.Size = new System.Drawing.Size(112, 32);
            this.btnDeleteRegistration.TabIndex = 15;
            this.btnDeleteRegistration.Text = "Delete";
            // 
            // Label14
            // 
            this.Label14.Location = new System.Drawing.Point(40, 472);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(100, 23);
            this.Label14.TabIndex = 151;
            this.Label14.Text = "Discharge Date";
            // 
            // Label13
            // 
            this.Label13.Location = new System.Drawing.Point(40, 120);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(100, 23);
            this.Label13.TabIndex = 150;
            this.Label13.Text = "Bed Charge/Day";
            // 
            // txtBedCharge
            // 
            this.txtBedCharge.Location = new System.Drawing.Point(160, 120);
            this.txtBedCharge.Name = "txtBedCharge";
            this.txtBedCharge.ReadOnly = true;
            this.txtBedCharge.Size = new System.Drawing.Size(104, 20);
            this.txtBedCharge.TabIndex = 4;
            // 
            // Label10
            // 
            this.Label10.Location = new System.Drawing.Point(40, 432);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(100, 23);
            this.Label10.TabIndex = 144;
            this.Label10.Text = "Remarks";
            // 
            // Label9
            // 
            this.Label9.Location = new System.Drawing.Point(40, 360);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(100, 23);
            this.Label9.TabIndex = 143;
            this.Label9.Text = "Blood Group";
            // 
            // Label8
            // 
            this.Label8.Location = new System.Drawing.Point(40, 392);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(100, 23);
            this.Label8.TabIndex = 140;
            this.Label8.Text = "Doctor";
            // 
            // Label7
            // 
            this.Label7.Location = new System.Drawing.Point(40, 328);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(100, 23);
            this.Label7.TabIndex = 139;
            this.Label7.Text = "Disease";
            // 
            // Label6
            // 
            this.Label6.Location = new System.Drawing.Point(40, 296);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(100, 23);
            this.Label6.TabIndex = 138;
            this.Label6.Text = "Date";
            // 
            // Label5
            // 
            this.Label5.Location = new System.Drawing.Point(40, 264);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(100, 23);
            this.Label5.TabIndex = 137;
            this.Label5.Text = "Phone No";
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(40, 216);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(100, 23);
            this.Label4.TabIndex = 136;
            this.Label4.Text = "Address";
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(40, 184);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(100, 23);
            this.Label3.TabIndex = 135;
            this.Label3.Text = "Age";
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(40, 152);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(100, 23);
            this.Label2.TabIndex = 134;
            this.Label2.Text = "Patient Name";
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(40, 24);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(100, 23);
            this.Label1.TabIndex = 133;
            this.Label1.Text = "Registration No";
            // 
            // txtDisease
            // 
            this.txtDisease.Location = new System.Drawing.Point(160, 328);
            this.txtDisease.Name = "txtDisease";
            this.txtDisease.ReadOnly = true;
            this.txtDisease.Size = new System.Drawing.Size(104, 20);
            this.txtDisease.TabIndex = 10;
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(160, 264);
            this.txtphone.Name = "txtphone";
            this.txtphone.ReadOnly = true;
            this.txtphone.Size = new System.Drawing.Size(104, 20);
            this.txtphone.TabIndex = 8;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(160, 184);
            this.txtAge.Name = "txtAge";
            this.txtAge.ReadOnly = true;
            this.txtAge.Size = new System.Drawing.Size(104, 20);
            this.txtAge.TabIndex = 6;
            // 
            // txtPatiname
            // 
            this.txtPatiname.Location = new System.Drawing.Point(160, 152);
            this.txtPatiname.Name = "txtPatiname";
            this.txtPatiname.ReadOnly = true;
            this.txtPatiname.Size = new System.Drawing.Size(104, 20);
            this.txtPatiname.TabIndex = 5;
            // 
            // txtRegno
            // 
            this.txtRegno.Location = new System.Drawing.Point(160, 24);
            this.txtRegno.Name = "txtRegno";
            this.txtRegno.ReadOnly = true;
            this.txtRegno.Size = new System.Drawing.Size(104, 20);
            this.txtRegno.TabIndex = 1;
            // 
            // Label11
            // 
            this.Label11.Location = new System.Drawing.Point(40, 56);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(80, 23);
            this.Label11.TabIndex = 125;
            this.Label11.Text = "Bed Type";
            // 
            // Label12
            // 
            this.Label12.Location = new System.Drawing.Point(40, 88);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(80, 24);
            this.Label12.TabIndex = 147;
            this.Label12.Text = "Bed No";
            // 
            // GroupBox5
            // 
            this.GroupBox5.Controls.Add(this.btnCustomprint);
            this.GroupBox5.Location = new System.Drawing.Point(544, 80);
            this.GroupBox5.Name = "GroupBox5";
            this.GroupBox5.Size = new System.Drawing.Size(136, 104);
            this.GroupBox5.TabIndex = 13;
            this.GroupBox5.TabStop = false;
            this.GroupBox5.Text = "Print";
            // 
            // btnCustomprint
            // 
            this.btnCustomprint.BackColor = System.Drawing.Color.LightGray;
            this.btnCustomprint.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCustomprint.Location = new System.Drawing.Point(32, 40);
            this.btnCustomprint.Name = "btnCustomprint";
            this.btnCustomprint.Size = new System.Drawing.Size(72, 32);
            this.btnCustomprint.TabIndex = 16;
            this.btnCustomprint.Text = "List";
            this.btnCustomprint.UseVisualStyleBackColor = false;
            // 
            // GroupBox4
            // 
            this.GroupBox4.Controls.Add(this.btnSearch);
            this.GroupBox4.Controls.Add(this.btnExcel);
            this.GroupBox4.Location = new System.Drawing.Point(544, 232);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new System.Drawing.Size(136, 128);
            this.GroupBox4.TabIndex = 14;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "Search/Export";
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSearch.Location = new System.Drawing.Point(32, 32);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 32);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "Search";
            // 
            // btnExcel
            // 
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExcel.Location = new System.Drawing.Point(32, 80);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(75, 32);
            this.btnExcel.TabIndex = 18;
            this.btnExcel.Text = "Excel";
            // 
            // Dischargefrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.GroupBox5);
            this.Controls.Add(this.GroupBox4);
            this.Name = "Dischargefrm";
            this.Size = new System.Drawing.Size(696, 632);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox5.ResumeLayout(false);
            this.GroupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.ListView LV_Discharge;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TextBox DTP_DOD;
        internal System.Windows.Forms.TextBox cbDoctor;
        internal System.Windows.Forms.TextBox CB_Bloodgp;
        internal System.Windows.Forms.TextBox DTP_date;
        internal System.Windows.Forms.TextBox CB_Bedno;
        internal System.Windows.Forms.TextBox CB_BedCategory;
        internal System.Windows.Forms.TextBox RtxtAddress;
        internal System.Windows.Forms.TextBox Rtxt_Remark;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.Button btnDeleteRegistration;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.TextBox txtBedCharge;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label9;
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
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.GroupBox GroupBox5;
        internal System.Windows.Forms.Button btnCustomprint;
        internal System.Windows.Forms.GroupBox GroupBox4;
        internal System.Windows.Forms.Button btnSearch;
        internal System.Windows.Forms.Button btnExcel;
    }
}
