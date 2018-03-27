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
            SqlConnection con = new SqlConnection(DB_Constants.db_url);
            SqlDataAdapter sd = new SqlDataAdapter("select MAX(Regno) AS Expr1 from Admit", con);

            DataTable dt = new DataTable();
            sd.Fill(dt);

            if (dt.Rows[0][0].ToString() == "")
            {
                txtRegno.Text = "1";
            }
            else
            {
                txtRegno.Text = (Convert.ToInt32(dt.Rows[0][0].ToString()) + 1).ToString();
            }
        }

        private void btnRegisterPatient_Click(object sender, EventArgs e)
        {
            btnSaveRegistration.Enabled = true;
            btnCancelRegistration.Enabled = true;
        }

        private void btnSaveRegistration_Click(object sender, EventArgs e)
        {
            if (txtPatiname.Text.Length == 0)
                MessageBox.Show("enter all field");
            else if(txtAge.Text.Length==0)
                MessageBox.Show("enter all field");
            else if (RtxtAddress.Text.Length == 0)
                MessageBox.Show("enter all field");
            else if (txtphone.Text.Length == 0)
                MessageBox.Show("enter all field");
            else if (txtphone.Text.Length != 10)
                MessageBox.Show("incorrect phone no ");
            else if (DTP_date.Text.Length == 0)
                MessageBox.Show("enter all field");
            else if (DTP_time.Text.Length == 0)
                MessageBox.Show("enter all field");
            else if (txtDisease.Text.Length == 0)
                MessageBox.Show("enter all field");
            else if (CB_Bloodgp.Text.Length == 0)
                MessageBox.Show("enter all field");
            else if (cbDoctor.Text.Length == 0)
                MessageBox.Show("enter all field");
            else if (Rtxt_Remark.Text.Length == 0)
                MessageBox.Show("enter all field");
            else
            {
                SqlConnection con = new SqlConnection(DB_Constants.db_url);
                SqlCommand sc = new SqlCommand("INSERT INTO op  ( name, Age, Address, Phone, Date, Time, Disease, Bloodgroup, Doctor, Remarks)VALUES ('" + txtPatiname.Text + "'," + txtAge.Text + ",'" + RtxtAddress.Text + "'," + txtphone.Text + ",'" + DTP_date.Text + "','" + DTP_time.Text + "','" + txtDisease.Text + "','" + CB_Bloodgp.Text + "','" + cbDoctor.Text + "','" + Rtxt_Remark.Text + "')", con);

                con.Open();
                sc.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(" insertion successfully");
            }
                          
                         
                






        }

       
    }
}
