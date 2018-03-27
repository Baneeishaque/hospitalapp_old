using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hospitalapp
{
    public partial class opfrm : UserControl
    {
        public opfrm()
        {
            InitializeComponent();
            btnEditRegistration.Enabled = false;
            btnDeleteRegistration.Enabled = false;
            btnCancelRegistration.Enabled = false;
            btnSaveRegistration.Enabled = false;
            btnAdmit.Enabled = false;
        }

        private void btnRegisterPatient_Click(object sender, EventArgs e)
        {
            btnSaveRegistration.Enabled = true;
            btnCancelRegistration.Enabled = true;
        }

       
    }
}
