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
    public partial class Billfrm : UserControl
    {
        DBhandler db = new DBhandler();
        public Billfrm()
        {
            InitializeComponent();
            dataGridView1.DataSource = db.GetTable("SELECT Regno As [Reg. No.], name As Name, Age, Address, Phone, Doctor FROM Admit WHERE (discharge_date IS NOT NULL) AND (bill_status IS NULL)");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                txtRegno.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtPatiname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

                DataTable dt = db.GetTable("SELECT Bedcategory, Charge, Admitdatetime,discharge_date FROM Admit WHERE Regno=" + txtRegno.Text);

                txtBedCategory.Text = dt.Rows[0][0].ToString();
                txtBedCharge.Text = dt.Rows[0][1].ToString();

                DTP_date.Text = dt.Rows[0][2].ToString();
                DTP_DOD.Text = dt.Rows[0][3].ToString();

                txtTotBedcharge.Text = (Convert.ToInt32((Convert.ToDateTime(dt.Rows[0][3].ToString()) - Convert.ToDateTime(dt.Rows[0][2].ToString())).TotalDays) * Convert.ToDouble(dt.Rows[0][1].ToString())).ToString();

                if(txtTotBedcharge.Text.Equals("0"))
                {
                    txtTotBedcharge.Text=dt.Rows[0][1].ToString();
                }

            }
        }

        private void txtOthercharge_TextChanged(object sender, EventArgs e)
        {
            if (txtOthercharge.Text.Length > 0)
            {
                txtTotalbill.Text = (Convert.ToDouble(txtTotBedcharge.Text) + Convert.ToDouble(txtOthercharge.Text)).ToString();
            }
        }

        private void btnEditRegistration_Click(object sender, EventArgs e)
        {
            db.Ins_Up_Del("UPDATE Admit SET bill_status=1 WHERE Regno=" + txtRegno.Text);
            MessageBox.Show("Billing Success...");
            this.Dispose();
        }
    }
}
