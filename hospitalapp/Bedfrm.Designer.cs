namespace hospitalapp
{
    partial class Bedfrm
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
            this.btnOK = new System.Windows.Forms.Button();
            this.txtGeneralWard = new System.Windows.Forms.TextBox();
            this.txtSpecialWard = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOK.Location = new System.Drawing.Point(134, 143);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(72, 32);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtGeneralWard
            // 
            this.txtGeneralWard.Location = new System.Drawing.Point(214, 79);
            this.txtGeneralWard.Name = "txtGeneralWard";
            this.txtGeneralWard.Size = new System.Drawing.Size(100, 20);
            this.txtGeneralWard.TabIndex = 8;
            // 
            // txtSpecialWard
            // 
            this.txtSpecialWard.Location = new System.Drawing.Point(214, 31);
            this.txtSpecialWard.Name = "txtSpecialWard";
            this.txtSpecialWard.Size = new System.Drawing.Size(100, 20);
            this.txtSpecialWard.TabIndex = 7;
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(38, 87);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(160, 24);
            this.Label2.TabIndex = 11;
            this.Label2.Text = "Enter beds  for General ward ";
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(38, 31);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(152, 32);
            this.Label1.TabIndex = 10;
            this.Label1.Text = "Enter beds  for Special ward ";
            // 
            // Bedfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtGeneralWard);
            this.Controls.Add(this.txtSpecialWard);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Name = "Bedfrm";
            this.Size = new System.Drawing.Size(352, 206);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnOK;
        internal System.Windows.Forms.TextBox txtGeneralWard;
        internal System.Windows.Forms.TextBox txtSpecialWard;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
    }
}
