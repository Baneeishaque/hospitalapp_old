namespace hospitalapp
{
    partial class Doctorfrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCustomprint = new System.Windows.Forms.Button();
            this.GB_DoctorView = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GB_Doctor = new System.Windows.Forms.GroupBox();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveDoctor = new System.Windows.Forms.Button();
            this.btnDeleteDoctor = new System.Windows.Forms.Button();
            this.btnUpdateDoctor = new System.Windows.Forms.Button();
            this.btnAddDoctor = new System.Windows.Forms.Button();
            this.DTP_DOJ = new System.Windows.Forms.DateTimePicker();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.RtxtAddress = new System.Windows.Forms.TextBox();
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
            this.GroupBox2.Controls.Add(this.btnSearch);
            this.GroupBox2.Controls.Add(this.btnExcel);
            this.GroupBox2.Location = new System.Drawing.Point(548, 200);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(120, 112);
            this.GroupBox2.TabIndex = 7;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Seaech/Export";
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSearch.Location = new System.Drawing.Point(24, 32);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            // 
            // btnExcel
            // 
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExcel.Location = new System.Drawing.Point(24, 72);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(75, 23);
            this.btnExcel.TabIndex = 12;
            this.btnExcel.Text = "Excel";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.btnCustomprint);
            this.GroupBox1.Location = new System.Drawing.Point(548, 64);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(120, 112);
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
            this.btnCustomprint.TabIndex = 10;
            this.btnCustomprint.Text = "List";
            this.btnCustomprint.UseVisualStyleBackColor = false;
            // 
            // GB_DoctorView
            // 
            this.GB_DoctorView.Controls.Add(this.dataGridView1);
            this.GB_DoctorView.Location = new System.Drawing.Point(28, 336);
            this.GB_DoctorView.Name = "GB_DoctorView";
            this.GB_DoctorView.Size = new System.Drawing.Size(660, 280);
            this.GB_DoctorView.TabIndex = 5;
            this.GB_DoctorView.TabStop = false;
            this.GB_DoctorView.Text = "Doctor View";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(625, 219);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // GB_Doctor
            // 
            this.GB_Doctor.Controls.Add(this.GroupBox3);
            this.GB_Doctor.Controls.Add(this.DTP_DOJ);
            this.GB_Doctor.Controls.Add(this.txtPhone);
            this.GB_Doctor.Controls.Add(this.txtName);
            this.GB_Doctor.Controls.Add(this.txtID);
            this.GB_Doctor.Controls.Add(this.Label5);
            this.GB_Doctor.Controls.Add(this.Label4);
            this.GB_Doctor.Controls.Add(this.Label3);
            this.GB_Doctor.Controls.Add(this.Label2);
            this.GB_Doctor.Controls.Add(this.Label1);
            this.GB_Doctor.Controls.Add(this.RtxtAddress);
            this.GB_Doctor.Location = new System.Drawing.Point(20, 16);
            this.GB_Doctor.Name = "GB_Doctor";
            this.GB_Doctor.Size = new System.Drawing.Size(504, 296);
            this.GB_Doctor.TabIndex = 4;
            this.GB_Doctor.TabStop = false;
            this.GB_Doctor.Text = "Doctor Detail";
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.btnCancel);
            this.GroupBox3.Controls.Add(this.btnSaveDoctor);
            this.GroupBox3.Controls.Add(this.btnDeleteDoctor);
            this.GroupBox3.Controls.Add(this.btnUpdateDoctor);
            this.GroupBox3.Controls.Add(this.btnAddDoctor);
            this.GroupBox3.Location = new System.Drawing.Point(328, 48);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(136, 208);
            this.GroupBox3.TabIndex = 31;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Transaction";
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancel.Location = new System.Drawing.Point(24, 160);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            // 
            // btnSaveDoctor
            // 
            this.btnSaveDoctor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSaveDoctor.Location = new System.Drawing.Point(24, 128);
            this.btnSaveDoctor.Name = "btnSaveDoctor";
            this.btnSaveDoctor.Size = new System.Drawing.Size(88, 23);
            this.btnSaveDoctor.TabIndex = 8;
            this.btnSaveDoctor.Text = "Save Doctor";
            this.btnSaveDoctor.Click += new System.EventHandler(this.btnSaveDoctor_Click);
            // 
            // btnDeleteDoctor
            // 
            this.btnDeleteDoctor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDeleteDoctor.Location = new System.Drawing.Point(24, 96);
            this.btnDeleteDoctor.Name = "btnDeleteDoctor";
            this.btnDeleteDoctor.Size = new System.Drawing.Size(88, 23);
            this.btnDeleteDoctor.TabIndex = 7;
            this.btnDeleteDoctor.Text = "Delete Doctor";
            // 
            // btnUpdateDoctor
            // 
            this.btnUpdateDoctor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnUpdateDoctor.Location = new System.Drawing.Point(24, 64);
            this.btnUpdateDoctor.Name = "btnUpdateDoctor";
            this.btnUpdateDoctor.Size = new System.Drawing.Size(88, 23);
            this.btnUpdateDoctor.TabIndex = 6;
            this.btnUpdateDoctor.Text = "Edit Doctor";
            // 
            // btnAddDoctor
            // 
            this.btnAddDoctor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAddDoctor.Location = new System.Drawing.Point(24, 29);
            this.btnAddDoctor.Name = "btnAddDoctor";
            this.btnAddDoctor.Size = new System.Drawing.Size(88, 23);
            this.btnAddDoctor.TabIndex = 5;
            this.btnAddDoctor.Text = "Add Doctor";
            this.btnAddDoctor.Click += new System.EventHandler(this.btnAddDoctor_Click);
            // 
            // DTP_DOJ
            // 
            this.DTP_DOJ.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_DOJ.Location = new System.Drawing.Point(168, 240);
            this.DTP_DOJ.Name = "DTP_DOJ";
            this.DTP_DOJ.Size = new System.Drawing.Size(104, 20);
            this.DTP_DOJ.TabIndex = 4;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(168, 200);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 3;
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
            this.Label5.Location = new System.Drawing.Point(48, 240);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(100, 23);
            this.Label5.TabIndex = 19;
            this.Label5.Text = "Date of joining";
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(48, 200);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(100, 23);
            this.Label4.TabIndex = 18;
            this.Label4.Text = "Phone";
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(48, 128);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(100, 23);
            this.Label3.TabIndex = 17;
            this.Label3.Text = "Address";
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(48, 88);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(100, 23);
            this.Label2.TabIndex = 16;
            this.Label2.Text = "Name";
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(48, 48);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(100, 23);
            this.Label1.TabIndex = 15;
            this.Label1.Text = "ID";
            // 
            // RtxtAddress
            // 
            this.RtxtAddress.Location = new System.Drawing.Point(168, 120);
            this.RtxtAddress.Multiline = true;
            this.RtxtAddress.Name = "RtxtAddress";
            this.RtxtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.RtxtAddress.Size = new System.Drawing.Size(100, 56);
            this.RtxtAddress.TabIndex = 2;
            // 
            // Doctorfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.GB_DoctorView);
            this.Controls.Add(this.GB_Doctor);
            this.Name = "Doctorfrm";
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
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.Button btnSaveDoctor;
        internal System.Windows.Forms.Button btnDeleteDoctor;
        internal System.Windows.Forms.Button btnUpdateDoctor;
        internal System.Windows.Forms.Button btnAddDoctor;
        internal System.Windows.Forms.DateTimePicker DTP_DOJ;
        internal System.Windows.Forms.TextBox txtPhone;
        internal System.Windows.Forms.TextBox txtName;
        internal System.Windows.Forms.TextBox txtID;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox RtxtAddress;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn joiningDateDataGridViewTextBoxColumn;
        
    }
}
