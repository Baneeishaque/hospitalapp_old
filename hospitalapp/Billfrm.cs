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

        private void btnCustomprint_Click(object sender, EventArgs e)
        {
            Print_Contents cb = new Print_Contents("Bill");
            cb.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search s = new Search("Bill");
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

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font boldFont = new Font(this.Font, FontStyle.Bold);
            Graphics g = e.Graphics;

            DrawDataGridView(boldFont, g);
        }

        private void DrawDataGridView(Font boldFont, Graphics g)
        {

            // Print the data and time
            g.DrawString("Bill", this.Font, Brushes.Black, 0, 0);

            // custom draws the grid from the data

            int columnPosition = 0;
            int rowPosition = 25;

            // draw headers
            //DrawHeader(boldFont, g, ref columnPosition, ref rowPosition);

            rowPosition += 65;

            // draw each row
            DrawGridBody(g, ref columnPosition, ref rowPosition);
        }

        //private int DrawHeader(Font boldFont, Graphics g, ref int columnPosition, ref int rowPosition)
        //{
        //    foreach (DataGridViewColumn dc in dataGridView1.Columns)
        //    {
        //        g.DrawString(dc.HeaderText, boldFont, Brushes.Black, (float)columnPosition, (float)rowPosition);
        //        columnPosition += dc.Width + 5;
        //    }
        //    return columnPosition;
        //}

        private void DrawGridBody(Graphics g, ref int columnPosition, ref int rowPosition)
        {

            //MessageBox.Show(dataGridView1.Rows[0].Cells[0].Value.ToString());

            //g.DrawString(text, this.Font, Brushes.Black, (float)columnPosition, (float)rowPosition + 20f);
            rowPosition = rowPosition + 65;

            //for (int i = 0; i < dataGridView1.Rows.Count; i++)
            //{
            //    columnPosition = 0;

            //    // draw a line to separate the rows

            //    g.DrawLine(Pens.Black, new Point(0, rowPosition), new Point(this.Width, rowPosition));

            //    // loop through each column in the row, and
            //    // draw the individual data item
            //    for (int j = 0; j < dataGridView1.ColumnCount; j++)
            //    {
            //        // just draw string in the column
            //        string text = dataGridView1.Rows[i].Cells[j].Value.ToString();
            //        if (dataGridView1.Columns[j].DefaultCellStyle.Font != null)
            //        {
            //            g.DrawString(text, dataGridView1.Columns[j].DefaultCellStyle.Font, Brushes.Black, (float)columnPosition, (float)rowPosition + 20f);
            //        }
            //        else
            //        {
            //            g.DrawString(text, this.Font, Brushes.Black, (float)columnPosition, (float)rowPosition + 20f);
            //        }

            //        // go to the next column position
            //        columnPosition += dataGridView1.Columns[j].Width + 5;
            //    }

            //    // go to the next row position
            //    rowPosition = rowPosition + 65;

            //}

        }

       

        
    }
}
