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
        
        public Patientfrm()
        {
            InitializeComponent();

            btnCancelRegistration.Enabled = false;
            btnEditRegistration.Enabled = false;
            btnSaveRegistration.Enabled = false;
            btnDischarge.Enabled = false;


            SqlConnection con = new SqlConnection(DB_Constants.db_url);
            SqlDataAdapter sda = new SqlDataAdapter("select MAX(Regno) AS Expr1 from Admit", con);
           
            DataTable dt = new DataTable();
            sda.Fill(dt);
            
            if (dt.Rows[0][0].ToString() == "")
            {
                txtRegno.Text = "1";
            }
            else
            {
                txtRegno.Text = (Convert.ToInt32(dt.Rows[0][0].ToString()) + 1).ToString();
            }

            //try
            //{
            //    this.doctorTableAdapter.Fill(this.hospitaldataDataSet.Doctor);
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}
            
            try
            {
                this.admitTableAdapter1.Fill(this.hospitaldataDataSet2.Admit);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            try
            {
                this.doctorTableAdapter.Fill(this.hospitaldataDataSet.Doctor);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
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
