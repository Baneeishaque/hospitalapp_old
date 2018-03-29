namespace hospitalapp
{
    partial class Print_Contents
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
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.frmcheck_DG = new System.Windows.Forms.DataGrid();
            this.btnSelectall = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frmcheck_DG)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.frmcheck_DG);
            this.GroupBox1.Location = new System.Drawing.Point(3, 250);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(608, 264);
            this.GroupBox1.TabIndex = 13;
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
            this.btnSelectall.Location = new System.Drawing.Point(323, 50);
            this.btnSelectall.Name = "btnSelectall";
            this.btnSelectall.Size = new System.Drawing.Size(104, 32);
            this.btnSelectall.TabIndex = 12;
            this.btnSelectall.Text = "Select All";
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnPrint.Location = new System.Drawing.Point(323, 98);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(104, 32);
            this.btnPrint.TabIndex = 11;
            this.btnPrint.Text = "Print";
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.Location = new System.Drawing.Point(23, 33);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(257, 191);
            this.listView1.TabIndex = 14;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Print_Contents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 524);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.btnSelectall);
            this.Controls.Add(this.btnPrint);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Print_Contents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print Contents";
            this.GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.frmcheck_DG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.DataGrid frmcheck_DG;
        internal System.Windows.Forms.Button btnSelectall;
        internal System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.ListView listView1;
    }
}