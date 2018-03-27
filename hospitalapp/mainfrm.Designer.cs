namespace hospitalapp
{
    partial class mainfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainfrm));
            this.SB_Main = new System.Windows.Forms.StatusBar();
            this.SBP1_Status = new System.Windows.Forms.StatusBarPanel();
            this.SBP2_Today = new System.Windows.Forms.StatusBarPanel();
            this.SBP3_Date = new System.Windows.Forms.StatusBarPanel();
            this.SBP4_Time = new System.Windows.Forms.StatusBarPanel();
            this.SBP5_Showtime = new System.Windows.Forms.StatusBarPanel();
            this.pnlShowlist = new System.Windows.Forms.Panel();
            this.btnEmail = new System.Windows.Forms.Button();
            this.btnNotepad = new System.Windows.Forms.Button();
            this.btnCalculator = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBill = new System.Windows.Forms.Button();
            this.btnDischargePatient = new System.Windows.Forms.Button();
            this.btnAddsisboy = new System.Windows.Forms.Button();
            this.btnAddDoctor = new System.Windows.Forms.Button();
            this.btnAdmitpatient = new System.Windows.Forms.Button();
            this.btnRoutineCheckup = new System.Windows.Forms.Button();
            this.lblDetails = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.SBP1_Status)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SBP2_Today)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SBP3_Date)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SBP4_Time)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SBP5_Showtime)).BeginInit();
            this.pnlShowlist.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // SB_Main
            // 
            this.SB_Main.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SB_Main.Location = new System.Drawing.Point(0, 654);
            this.SB_Main.Name = "SB_Main";
            this.SB_Main.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.SBP1_Status,
            this.SBP2_Today,
            this.SBP3_Date,
            this.SBP4_Time,
            this.SBP5_Showtime});
            this.SB_Main.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SB_Main.ShowPanels = true;
            this.SB_Main.Size = new System.Drawing.Size(872, 32);
            this.SB_Main.TabIndex = 9;
            // 
            // SBP1_Status
            // 
            this.SBP1_Status.Name = "SBP1_Status";
            this.SBP1_Status.Text = "Status : ";
            this.SBP1_Status.Width = 450;
            // 
            // SBP2_Today
            // 
            this.SBP2_Today.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.SBP2_Today.Name = "SBP2_Today";
            this.SBP2_Today.Text = "Today";
            this.SBP2_Today.Width = 60;
            // 
            // SBP3_Date
            // 
            this.SBP3_Date.Icon = ((System.Drawing.Icon)(resources.GetObject("SBP3_Date.Icon")));
            this.SBP3_Date.Name = "SBP3_Date";
            // 
            // SBP4_Time
            // 
            this.SBP4_Time.Alignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.SBP4_Time.Name = "SBP4_Time";
            this.SBP4_Time.Text = "Time";
            this.SBP4_Time.Width = 60;
            // 
            // SBP5_Showtime
            // 
            this.SBP5_Showtime.Name = "SBP5_Showtime";
            // 
            // pnlShowlist
            // 
            this.pnlShowlist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlShowlist.Controls.Add(this.btnEmail);
            this.pnlShowlist.Controls.Add(this.btnNotepad);
            this.pnlShowlist.Controls.Add(this.btnCalculator);
            this.pnlShowlist.Controls.Add(this.Label1);
            this.pnlShowlist.Location = new System.Drawing.Point(8, 420);
            this.pnlShowlist.Name = "pnlShowlist";
            this.pnlShowlist.Size = new System.Drawing.Size(152, 208);
            this.pnlShowlist.TabIndex = 8;
            // 
            // btnEmail
            // 
            this.btnEmail.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEmail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmail.Location = new System.Drawing.Point(24, 160);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(104, 32);
            this.btnEmail.TabIndex = 10;
            this.btnEmail.Text = "Email";
            // 
            // btnNotepad
            // 
            this.btnNotepad.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNotepad.Location = new System.Drawing.Point(24, 112);
            this.btnNotepad.Name = "btnNotepad";
            this.btnNotepad.Size = new System.Drawing.Size(104, 32);
            this.btnNotepad.TabIndex = 9;
            this.btnNotepad.Text = "Notepad";
            // 
            // btnCalculator
            // 
            this.btnCalculator.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCalculator.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculator.Location = new System.Drawing.Point(24, 64);
            this.btnCalculator.Name = "btnCalculator";
            this.btnCalculator.Size = new System.Drawing.Size(104, 32);
            this.btnCalculator.TabIndex = 8;
            this.btnCalculator.Text = "Calculator";
            // 
            // Label1
            // 
            this.Label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.Label1.ForeColor = System.Drawing.Color.Blue;
            this.Label1.Location = new System.Drawing.Point(16, 16);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(120, 32);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Tools";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlContent
            // 
            this.pnlContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContent.Controls.Add(this.button1);
            this.pnlContent.Controls.Add(this.btnBill);
            this.pnlContent.Controls.Add(this.btnDischargePatient);
            this.pnlContent.Controls.Add(this.btnAddsisboy);
            this.pnlContent.Controls.Add(this.btnAddDoctor);
            this.pnlContent.Controls.Add(this.btnAdmitpatient);
            this.pnlContent.Controls.Add(this.btnRoutineCheckup);
            this.pnlContent.Controls.Add(this.lblDetails);
            this.pnlContent.Location = new System.Drawing.Point(8, 4);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(152, 410);
            this.pnlContent.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(21, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 32);
            this.button1.TabIndex = 8;
            this.button1.Text = "Booking";
            // 
            // btnBill
            // 
            this.btnBill.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBill.Location = new System.Drawing.Point(21, 286);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(104, 32);
            this.btnBill.TabIndex = 6;
            this.btnBill.Text = "Bill";
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // btnDischargePatient
            // 
            this.btnDischargePatient.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDischargePatient.Location = new System.Drawing.Point(21, 234);
            this.btnDischargePatient.Name = "btnDischargePatient";
            this.btnDischargePatient.Size = new System.Drawing.Size(104, 32);
            this.btnDischargePatient.TabIndex = 5;
            this.btnDischargePatient.Text = "Discharge Patient";
            this.btnDischargePatient.Click += new System.EventHandler(this.btnDischargePatient_Click);
            // 
            // btnAddsisboy
            // 
            this.btnAddsisboy.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAddsisboy.Location = new System.Drawing.Point(21, 182);
            this.btnAddsisboy.Name = "btnAddsisboy";
            this.btnAddsisboy.Size = new System.Drawing.Size(104, 32);
            this.btnAddsisboy.TabIndex = 4;
            this.btnAddsisboy.Text = "Add Sister/Wardboy";
            this.btnAddsisboy.Click += new System.EventHandler(this.btnAddsisboy_Click);
            // 
            // btnAddDoctor
            // 
            this.btnAddDoctor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAddDoctor.Location = new System.Drawing.Point(21, 127);
            this.btnAddDoctor.Name = "btnAddDoctor";
            this.btnAddDoctor.Size = new System.Drawing.Size(104, 32);
            this.btnAddDoctor.TabIndex = 3;
            this.btnAddDoctor.Text = "Add Doctor";
            this.btnAddDoctor.Click += new System.EventHandler(this.btnAddDoctor_Click);
            // 
            // btnAdmitpatient
            // 
            this.btnAdmitpatient.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAdmitpatient.Location = new System.Drawing.Point(21, 79);
            this.btnAdmitpatient.Name = "btnAdmitpatient";
            this.btnAdmitpatient.Size = new System.Drawing.Size(104, 32);
            this.btnAdmitpatient.TabIndex = 2;
            this.btnAdmitpatient.Text = "Admit Patient";
            this.btnAdmitpatient.Click += new System.EventHandler(this.btnAdmitpatient_Click_1);
            // 
            // btnRoutineCheckup
            // 
            this.btnRoutineCheckup.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRoutineCheckup.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRoutineCheckup.Location = new System.Drawing.Point(21, 31);
            this.btnRoutineCheckup.Name = "btnRoutineCheckup";
            this.btnRoutineCheckup.Size = new System.Drawing.Size(104, 32);
            this.btnRoutineCheckup.TabIndex = 1;
            this.btnRoutineCheckup.Text = "Routine Checkup";
            this.btnRoutineCheckup.Click += new System.EventHandler(this.btnRoutineCheckup_Click);
            // 
            // lblDetails
            // 
            this.lblDetails.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblDetails.ForeColor = System.Drawing.Color.Blue;
            this.lblDetails.Location = new System.Drawing.Point(13, -9);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(120, 32);
            this.lblDetails.TabIndex = 7;
            this.lblDetails.Text = "Records";
            this.lblDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMain
            // 
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Location = new System.Drawing.Point(168, 4);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(704, 624);
            this.pnlMain.TabIndex = 6;
            // 
            // mainfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(872, 686);
            this.Controls.Add(this.SB_Main);
            this.Controls.Add(this.pnlShowlist);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlMain);
            this.Name = "mainfrm";
            this.Text = "mainfrm";
            ((System.ComponentModel.ISupportInitialize)(this.SBP1_Status)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SBP2_Today)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SBP3_Date)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SBP4_Time)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SBP5_Showtime)).EndInit();
            this.pnlShowlist.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.StatusBar SB_Main;
        internal System.Windows.Forms.StatusBarPanel SBP1_Status;
        internal System.Windows.Forms.StatusBarPanel SBP2_Today;
        internal System.Windows.Forms.StatusBarPanel SBP3_Date;
        internal System.Windows.Forms.StatusBarPanel SBP4_Time;
        internal System.Windows.Forms.StatusBarPanel SBP5_Showtime;
        internal System.Windows.Forms.Panel pnlShowlist;
        internal System.Windows.Forms.Button btnEmail;
        internal System.Windows.Forms.Button btnNotepad;
        internal System.Windows.Forms.Button btnCalculator;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Panel pnlContent;
        internal System.Windows.Forms.Button btnBill;
        internal System.Windows.Forms.Button btnDischargePatient;
        internal System.Windows.Forms.Button btnAddsisboy;
        internal System.Windows.Forms.Button btnAddDoctor;
        internal System.Windows.Forms.Button btnAdmitpatient;
        internal System.Windows.Forms.Button btnRoutineCheckup;
        internal System.Windows.Forms.Label lblDetails;
        internal System.Windows.Forms.Panel pnlMain;
        internal System.Windows.Forms.Button button1;

    }
}