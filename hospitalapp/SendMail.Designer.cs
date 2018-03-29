namespace hospitalapp
{
    partial class SendMail
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
            this.btnSend = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstAttachment = new System.Windows.Forms.ListBox();
            this.txtFromDisplayName = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSend.Location = new System.Drawing.Point(415, 421);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(104, 32);
            this.btnSend.TabIndex = 36;
            this.btnSend.Text = "Send";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(159, 317);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMessage.Size = new System.Drawing.Size(240, 144);
            this.txtMessage.TabIndex = 35;
            // 
            // Label10
            // 
            this.Label10.Location = new System.Drawing.Point(39, 317);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(104, 16);
            this.Label10.TabIndex = 34;
            this.Label10.Text = "Message";
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(159, 285);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(232, 20);
            this.txtSubject.TabIndex = 33;
            // 
            // Label9
            // 
            this.Label9.Location = new System.Drawing.Point(39, 285);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(104, 16);
            this.Label9.TabIndex = 32;
            this.Label9.Text = "Subject";
            // 
            // Label8
            // 
            this.Label8.Location = new System.Drawing.Point(39, 189);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(72, 32);
            this.Label8.TabIndex = 31;
            this.Label8.Text = "Attachments";
            // 
            // btnRemove
            // 
            this.btnRemove.Enabled = false;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRemove.Location = new System.Drawing.Point(407, 237);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(120, 32);
            this.btnRemove.TabIndex = 30;
            this.btnRemove.Text = "Remove attachment";
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAdd.Location = new System.Drawing.Point(407, 189);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 32);
            this.btnAdd.TabIndex = 29;
            this.btnAdd.Text = "Add attachment";
            // 
            // lstAttachment
            // 
            this.lstAttachment.Location = new System.Drawing.Point(159, 189);
            this.lstAttachment.Name = "lstAttachment";
            this.lstAttachment.Size = new System.Drawing.Size(232, 82);
            this.lstAttachment.TabIndex = 28;
            // 
            // txtFromDisplayName
            // 
            this.txtFromDisplayName.Location = new System.Drawing.Point(159, 93);
            this.txtFromDisplayName.Name = "txtFromDisplayName";
            this.txtFromDisplayName.Size = new System.Drawing.Size(232, 20);
            this.txtFromDisplayName.TabIndex = 25;
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(39, 93);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(104, 32);
            this.Label3.TabIndex = 24;
            this.Label3.Text = "From Display name";
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(159, 61);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(232, 20);
            this.txtFrom.TabIndex = 22;
            // 
            // OFD
            // 
            this.OFD.DefaultExt = "*.*";
            this.OFD.InitialDirectory = "c:\\";
            this.OFD.Multiselect = true;
            // 
            // Label7
            // 
            this.Label7.Location = new System.Drawing.Point(39, 125);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(72, 16);
            this.Label7.TabIndex = 26;
            this.Label7.Text = "To";
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(159, 125);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(232, 20);
            this.txtTo.TabIndex = 27;
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(39, 61);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(72, 16);
            this.Label2.TabIndex = 21;
            this.Label2.Text = "From";
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(47, 93);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(104, 32);
            this.Label4.TabIndex = 23;
            this.Label4.Text = "From Display name";
            // 
            // SendMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstAttachment);
            this.Controls.Add(this.txtFromDisplayName);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label4);
            this.Name = "SendMail";
            this.Size = new System.Drawing.Size(566, 522);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnSend;
        internal System.Windows.Forms.TextBox txtMessage;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.TextBox txtSubject;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Button btnRemove;
        internal System.Windows.Forms.Button btnAdd;
        internal System.Windows.Forms.ListBox lstAttachment;
        internal System.Windows.Forms.TextBox txtFromDisplayName;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtFrom;
        internal System.Windows.Forms.OpenFileDialog OFD;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox txtTo;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label4;
    }
}
