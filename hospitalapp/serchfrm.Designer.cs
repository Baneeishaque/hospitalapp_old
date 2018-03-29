namespace hospitalapp
{
    partial class serchfrm
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
            this.btnPrint = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnRestore = new System.Windows.Forms.Button();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.cBoxParamets = new System.Windows.Forms.ComboBox();
            this.dGrid = new System.Windows.Forms.DataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.dGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnPrint.Location = new System.Drawing.Point(336, 68);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(80, 32);
            this.btnPrint.TabIndex = 15;
            this.btnPrint.Text = "Print";
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(24, 60);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(80, 24);
            this.Label2.TabIndex = 14;
            this.Label2.Text = "Enter input";
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(24, 20);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(88, 24);
            this.Label1.TabIndex = 13;
            this.Label1.Text = "Select Category";
            // 
            // btnRestore
            // 
            this.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnRestore.Location = new System.Drawing.Point(336, 20);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(80, 32);
            this.btnRestore.TabIndex = 12;
            this.btnRestore.Text = "Restore";
            // 
            // searchTxt
            // 
            this.searchTxt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.searchTxt.Location = new System.Drawing.Point(112, 60);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(120, 20);
            this.searchTxt.TabIndex = 11;
            // 
            // cBoxParamets
            // 
            this.cBoxParamets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxParamets.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.cBoxParamets.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cBoxParamets.Location = new System.Drawing.Point(112, 20);
            this.cBoxParamets.Name = "cBoxParamets";
            this.cBoxParamets.Size = new System.Drawing.Size(120, 21);
            this.cBoxParamets.TabIndex = 10;
            // 
            // dGrid
            // 
            this.dGrid.AccessibleRole = System.Windows.Forms.AccessibleRole.ColumnHeader;
            this.dGrid.AllowSorting = false;
            this.dGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dGrid.DataMember = "";
            this.dGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dGrid.Location = new System.Drawing.Point(0, 202);
            this.dGrid.Name = "dGrid";
            this.dGrid.ReadOnly = true;
            this.dGrid.Size = new System.Drawing.Size(598, 232);
            this.dGrid.TabIndex = 9;
            // 
            // serchfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.searchTxt);
            this.Controls.Add(this.cBoxParamets);
            this.Controls.Add(this.dGrid);
            this.Name = "serchfrm";
            this.Size = new System.Drawing.Size(598, 434);
            ((System.ComponentModel.ISupportInitialize)(this.dGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnPrint;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.ComboBox cBoxParamets;
        private System.Windows.Forms.DataGrid dGrid;
    }
}
