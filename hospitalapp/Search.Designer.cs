namespace hospitalapp
{
    partial class Search
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
            this.btnPrint = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnRestore = new System.Windows.Forms.Button();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.cBoxParamets = new System.Windows.Forms.ComboBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnPrint.Location = new System.Drawing.Point(342, 73);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(80, 32);
            this.btnPrint.TabIndex = 22;
            this.btnPrint.Text = "Print";
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(30, 65);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(80, 24);
            this.Label2.TabIndex = 21;
            this.Label2.Text = "Enter input";
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(30, 25);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(88, 24);
            this.Label1.TabIndex = 20;
            this.Label1.Text = "Select Category";
            // 
            // btnRestore
            // 
            this.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnRestore.Location = new System.Drawing.Point(342, 25);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(80, 32);
            this.btnRestore.TabIndex = 19;
            this.btnRestore.Text = "Restore";
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // searchTxt
            // 
            this.searchTxt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.searchTxt.Location = new System.Drawing.Point(118, 65);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(120, 20);
            this.searchTxt.TabIndex = 18;
            this.searchTxt.TextChanged += new System.EventHandler(this.searchTxt_TextChanged);
            // 
            // cBoxParamets
            // 
            this.cBoxParamets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxParamets.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.cBoxParamets.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cBoxParamets.Location = new System.Drawing.Point(118, 25);
            this.cBoxParamets.Name = "cBoxParamets";
            this.cBoxParamets.Size = new System.Drawing.Size(120, 21);
            this.cBoxParamets.TabIndex = 17;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.dataGridView1);
            this.GroupBox1.Location = new System.Drawing.Point(12, 120);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(558, 264);
            this.GroupBox1.TabIndex = 23;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "View";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(546, 239);
            this.dataGridView1.TabIndex = 0;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 396);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.searchTxt);
            this.Controls.Add(this.cBoxParamets);
            this.Name = "Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search";
            this.GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        internal System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}