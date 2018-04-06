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
    public partial class SisterWardboyfrm : UserControl
    {
        DBhandler db = new DBhandler();
        public SisterWardboyfrm()
        {
            InitializeComponent();

            txtID.Text = db.get_max_reg_nurse();
            DTP_DOJ.Value = DateTime.Today;

            dataGridView1.DataSource = db.GetTable("SELECT * FROM nurse");
        }

        private void btnAddS_W_Click(object sender, EventArgs e)
        {
            btnSaveS_W.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void btnUpdateS_W_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteS_W_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveS_W_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Length == 0)
            {
                MessageBox.Show("No register Number");
            }
            else
            {
                SqlConnection con = new SqlConnection(DB_Constants.db_url);
                String query = "INSERT INTO nurse (id,name, address, category, phone, join_date)VALUES(" + txtID.Text + ",'" + txtName.Text + "','" + RtxtAddress.Text + "','" + CB_Category.SelectedItem.ToString() + "','" + txtPhone.Text + "','" + DTP_DOJ.Value + "')";
                //MessageBox.Show(query);
                SqlCommand sc = new SqlCommand(query, con);
                con.Open();
                sc.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Insertion Success...");
                dataGridView1.DataSource = db.GetTable("SELECT * FROM nurse");
                this.Dispose();
            }
        }

        private void btnCustomprint_Click(object sender, EventArgs e)
        {
            Print_Contents cb = new Print_Contents("nurse");
            cb.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search s = new Search("nurse");
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
    }
}
