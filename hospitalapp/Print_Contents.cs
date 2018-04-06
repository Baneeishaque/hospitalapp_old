using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace hospitalapp
{
    public partial class Print_Contents : Form
    {
        DBhandler db = new DBhandler();
        String current_table_name;

        public Print_Contents(String table_name)
        {
            InitializeComponent();
            current_table_name = table_name;

            DataTable dt;
            if (current_table_name == "Discharge")
            {
                dt = db.GetTable("SELECT * FROM Admit WHERE (discharge_date IS NULL)");
            }
            else if (current_table_name == "Bill")
            {
                dt = db.GetTable("SELECT * FROM Admit WHERE (discharge_date IS NOT NULL) AND (bill_status IS NULL)");
            }
            else
            {
                dt = db.GetTable("SELECT " + table_name + ".* FROM " + table_name + "");
            }

            for (int i = 0; i < dt.Columns.Count; i++)
            {
                checkedListBox1.Items.Add(dt.Columns[i].Caption);
            }
        }

        private void btnSelectall_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, true);
            }
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)(() => check_items()));
        }

        private void check_items()
        {
            if (checkedListBox1.CheckedItems.Count == 0)
            {
                MessageBox.Show("You Must Check atleast One Item...", "HMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                checkedListBox1.SetItemChecked(0, true);
                fill_dg();
                btnPrint.Enabled = true;
            }
            else
            {
                fill_dg();
                btnPrint.Enabled = true;
            }
        }

        private void fill_dg()
        {
            String query = "SELECT ";
            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {

                if (i == 0)
                {
                    query = query + checkedListBox1.CheckedItems[i].ToString();
                }
                else
                {
                    query = query + ", " + checkedListBox1.CheckedItems[i].ToString();
                }

            }
            

            if (current_table_name == "Discharge")
            {
                query = query + " FROM Admit WHERE (discharge_date IS NULL)";
            }
            else if (current_table_name == "Bill")
            {
                query = query + " FROM Admit WHERE (discharge_date IS NOT NULL) AND (bill_status IS NULL)";
            }
            else
            {
                query = query + " FROM " + current_table_name;
            }
            //MessageBox.Show(query);
            dataGridView1.DataSource = db.GetTable(query);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
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
            g.DrawString(current_table_name, this.Font, Brushes.Black, 0, 0);

            // custom draws the grid from the data

            int columnPosition = 0;
            int rowPosition = 25;

            // draw headers
            DrawHeader(boldFont, g, ref columnPosition, ref rowPosition);

            rowPosition += 65;

            // draw each row
            DrawGridBody(g, ref columnPosition, ref rowPosition);
        }

        private int DrawHeader(Font boldFont, Graphics g, ref int columnPosition, ref int rowPosition)
        {
            foreach (DataGridViewColumn dc in dataGridView1.Columns)
            {
                g.DrawString(dc.HeaderText, boldFont, Brushes.Black, (float)columnPosition, (float)rowPosition);
                columnPosition += dc.Width + 5;
            }
            return columnPosition;
        }

        private void DrawGridBody(Graphics g, ref int columnPosition, ref int rowPosition)
        {

            //MessageBox.Show(dataGridView1.Rows[0].Cells[0].Value.ToString());

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                columnPosition = 0;

                // draw a line to separate the rows

                g.DrawLine(Pens.Black, new Point(0, rowPosition), new Point(this.Width, rowPosition));

                // loop through each column in the row, and
                // draw the individual data item
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    // just draw string in the column
                    string text = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    if (dataGridView1.Columns[j].DefaultCellStyle.Font != null)
                    {
                        g.DrawString(text, dataGridView1.Columns[j].DefaultCellStyle.Font, Brushes.Black, (float)columnPosition, (float)rowPosition + 20f);
                    }
                    else
                    {
                        g.DrawString(text, this.Font, Brushes.Black, (float)columnPosition, (float)rowPosition + 20f);
                    }

                    // go to the next column position
                    columnPosition += dataGridView1.Columns[j].Width + 5;
                }

                // go to the next row position
                rowPosition = rowPosition + 65;

            }

        }


    }
}
