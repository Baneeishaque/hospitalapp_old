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
        DBhandler db = new DBhandler();
        public Doctorfrm()
        {
            InitializeComponent();
            btnUpdateDoctor.Enabled = false;
            btnDeleteDoctor.Enabled = false;
            btnSaveDoctor.Enabled = false;
            btnCancel.Enabled = false;

           
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

            dataGridView1.DataSource = db.GetTable("SELECT ID, Name, Address, Phone, JoiningDate FROM Doctor");
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
                this.Dispose();
            }
        }

        private void btnAddDoctor_Click(object sender, EventArgs e)
        {
            btnSaveDoctor.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                txtID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                RtxtAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtPhone.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                DTP_DOJ.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
                
                btnDeleteDoctor.Enabled = true;
                btnUpdateDoctor.Enabled = true;
                btnAddDoctor.Enabled = false;
                btnSaveDoctor.Enabled = false;
                btnCancel.Enabled = false;
            }
        }

        private void btnCustomprint_Click(object sender, EventArgs e)
        {
            Print_Contents cb = new Print_Contents("Doctor");
            cb.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search s = new Search("Admit");
            s.Show();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            sfd.FileName = "export.xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                //ToCsV(dataGridView1, @"c:\export.xls");
                Excel_Utils eutils = new Excel_Utils();
                eutils.ToCsV(dataGridView1, sfd.FileName); // Here dataGridview1 is your grid view name
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnSaveDoctor.Enabled = false;
            btnAddDoctor.Enabled = true;
            btnCancel.Enabled = false;
        }

        private void btnUpdateDoctor_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteDoctor_Click(object sender, EventArgs e)
        {

        }


        

        
    }
}
