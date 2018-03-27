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
    public partial class Doctorfrm : UserControl
    {
        public Doctorfrm()
        {
            InitializeComponent();
            btnUpdateDoctor.Enabled = false;
            btnDeleteDoctor.Enabled = false;
            btnSaveDoctor.Enabled = false;
            btnCancel.Enabled = false;

            try
            {
                this.doctorTableAdapter.Fill(this.hospitaldataDataSet.Doctor);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            SqlConnection con = new SqlConnection(DB_Constants.db_url);
            SqlDataAdapter sda = new SqlDataAdapter("select MAX(ID) AS Expr1 from Doctor", con);
        
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "")
            {
                txtID.Text = "1";
            }
            else
            {
                txtID.Text = (Convert.ToInt32(dt.Rows[0][0].ToString()) + 1).ToString();
            }
        }

        private void btnSaveDoctor_Click(object sender, EventArgs e)
        {

            if (txtName.Text.Length == 0)
            {
                MessageBox.Show("enter doctor name");
            }
            else if (RtxtAddress.Text.Length==0)
            {
                MessageBox.Show("enter doctor address");
            }
            else if (txtPhone.Text.Length == 0)
            {
                
                MessageBox.Show("enter doctor phone no ");
            }
            else if (txtPhone.Text.Length != 10)
            {
                MessageBox.Show("incorrect phone no ");
            }
            else
            {
                SqlConnection con = new SqlConnection(DB_Constants.db_url);
                SqlCommand sc = new SqlCommand("INSERT INTO Doctor (Name, Address, Phone, JoiningDate)VALUES('"+txtName.Text+"','"+RtxtAddress.Text+"','"+txtPhone.Text+"','"+DTP_DOJ.Value+"')", con);
                con.Open();
                sc.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(" insertion successfully");
            }
        }

        private void btnAddDoctor_Click(object sender, EventArgs e)
        {
            btnSaveDoctor.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //txtID.Text = e.RowIndex;
        }


        

        
    }
}
