namespace hospitalapp
{
    partial class CheckBox
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
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.frmcheck_DG = new System.Windows.Forms.DataGrid();
            this.btnSelectall = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.clbforcolumn = new System.Windows.Forms.CheckedListBox();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frmcheck_DG)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.frmcheck_DG);
            this.GroupBox1.Location = new System.Drawing.Point(11, 269);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(608, 264);
            this.GroupBox1.TabIndex = 9;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "View";
            // 
            // frmcheck_DG
            // 
            this.frmcheck_DG.DataMember = "";
            this.frmcheck_DG.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.frmcheck_DG.Location = new System.Drawing.Point(20, 32);
            this.frmcheck_DG.Name = "frmcheck_DG";
            this.frmcheck_DG.Size = new System.Drawing.Size(568, 216);
            this.frmcheck_DG.TabIndex = 3;
            // 
            // btnSelectall
            // 
            this.btnSelectall.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSelectall.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnSelectall.Location = new System.Drawing.Point(331, 69);
            this.btnSelectall.Name = "btnSelectall";
            this.btnSelectall.Size = new System.Drawing.Size(104, 32);
            this.btnSelectall.TabIndex = 8;
            this.btnSelectall.Text = "Select All";
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnPrint.Location = new System.Drawing.Point(331, 117);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(104, 32);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "Print";
            // 
            // clbforcolumn
            // 
            this.clbforcolumn.CheckOnClick = true;
            this.clbforcolumn.Location = new System.Drawing.Point(19, 29);
            this.clbforcolumn.Name = "clbforcolumn";
            this.clbforcolumn.Size = new System.Drawing.Size(160, 214);
            this.clbforcolumn.TabIndex = 6;
            // 
            // CheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.btnSelectall);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.clbforcolumn);
            this.Name = "CheckBox";
            this.Size = new System.Drawing.Size(630, 562);
            this.GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.frmcheck_DG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.DataGrid frmcheck_DG;
        internal System.Windows.Forms.Button btnSelectall;
        internal System.Windows.Forms.Button btnPrint;
        internal System.Windows.Forms.CheckedListBox clbforcolumn;
    }
}
