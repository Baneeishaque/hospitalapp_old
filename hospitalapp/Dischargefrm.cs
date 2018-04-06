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
    public partial class Dischargefrm : UserControl
    {
        DBhandler db = new DBhandler();
        public Dischargefrm()
        {
            InitializeComponent();
            dataGridView1.DataSource = db.GetTable("SELECT Regno As [Reg. No.], name As Name, Age, Address, Phone, Doctor FROM Admit WHERE (discharge_date IS NULL)");

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                txtRegno.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtPatiname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtAge.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                RtxtAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtphone.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                cbDoctor.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                
                DataTable dt = db.GetTable("SELECT Bedcategory, Bedno, Charge, Admitdatetime, Disease, Bloodgroup, Remarks FROM Admit WHERE Regno=" + txtRegno.Text);
               
                CB_BedCategory.Text = dt.Rows[0][0].ToString();
                
                //MessageBox.Show(dt.Rows[0][1].ToString());
                CB_Bedno.Text= dt.Rows[0][1].ToString();
                txtBedCharge.Text = dt.Rows[0][2].ToString();
                DTP_date.Text = dt.Rows[0][3].ToString();
                txtDisease.Text = dt.Rows[0][4].ToString();
                CB_Bloodgp.Text = dt.Rows[0][5].ToString();
                Rtxt_Remark.Text = dt.Rows[0][6].ToString();

             
            }
        }

        private void btnDeleteRegistration_Click(object sender, EventArgs e)
        {
            db.Ins_Up_Del("UPDATE Admit SET discharge_date='"+dateTimePicker1.Value+"' WHERE Regno=" + txtRegno.Text);
            MessageBox.Show("Discharge Success...");
            this.Dispose();
        }

        private void btnCustomprint_Click(object sender, EventArgs e)
        {
            Print_Contents cb = new Print_Contents("Discharge");
            cb.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search s = new Search("Discharge");
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
