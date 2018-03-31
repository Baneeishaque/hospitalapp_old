namespace hospitalapp
{
    partial class Book
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
            this.btnCustomprint = new System.Windows.Forms.Button();
            this.GB_PatientView = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.GroupBox2.SuspendLayout();
            this.GB_PatientView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.btnSearch);
            this.GroupBox2.Controls.Add(this.btnExcel);
            this.GroupBox2.Location = new System.Drawing.Point(541, 243);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(136, 128);
            this.GroupBox2.TabIndex = 15;
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
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.btnCustomprint.Click += new System.EventHandler(this.btnCustomprint_Click);
            // 
            // GB_PatientView
            // 
            this.GB_PatientView.Controls.Add(this.dataGridView1);
            this.GB_PatientView.Location = new System.Drawing.Point(19, 30);
            this.GB_PatientView.Name = "GB_PatientView";
            this.GB_PatientView.Size = new System.Drawing.Size(493, 577);
            this.GB_PatientView.TabIndex = 13;
            this.GB_PatientView.TabStop = false;
            this.GB_PatientView.Text = "Bookings";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(487, 558);
            this.dataGridView1.TabIndex = 0;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.btnCustomprint);
            this.GroupBox1.Location = new System.Drawing.Point(541, 43);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(136, 104);
            this.GroupBox1.TabIndex = 14;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Print";
            // 
            // Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GB_PatientView);
            this.Controls.Add(this.GroupBox1);
            this.Name = "Book";
            this.Size = new System.Drawing.Size(696, 636);
            this.GroupBox2.ResumeLayout(false);
            this.GB_PatientView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Button btnSearch;
        internal System.Windows.Forms.Button btnExcel;
        internal System.Windows.Forms.Button btnCustomprint;
        internal System.Windows.Forms.GroupBox GB_PatientView;
        private System.Windows.Forms.DataGridView dataGridView1;
        internal System.Windows.Forms.GroupBox GroupBox1;
    }
}
