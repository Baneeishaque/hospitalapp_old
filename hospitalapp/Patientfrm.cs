using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace hospitalapp
{
    public partial class Patientfrm : UserControl
    {
        DBhandler db = new DBhandler();
        public Patientfrm()
        {
            InitializeComponent();

            btnCancelRegistration.Enabled = false;
            btnEditRegistration.Enabled = false;
            btnSaveRegistration.Enabled = false;
            btnDischarge.Enabled = false;

            txtRegno.Text = db.get_max_reg_admit();

            //comboBox1.DataSource = db.GetTable("SELECT ID AS Expr1, Name AS Expr2 FROM Doctor");
            //comboBox1.DisplayMember = "Expr2";
            //comboBox1.ValueMember = "Expr1";

        }

        private void btnRegisterPatient_Click(object sender, EventArgs e)
        {
            btnCancelRegistration.Enabled = true;

            btnSaveRegistration.Enabled = true;

        }

        private void btnSaveRegistration_Click(object sender, EventArgs e)
        {
            if (txtRegno.Text.Length == 0)
            {
                MessageBox.Show("No register Number");
            }
        }

       







    }
}
