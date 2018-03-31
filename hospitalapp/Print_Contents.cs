using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
            DataTable dt = db.GetTable("SELECT " + table_name + ".* FROM " + table_name + "");
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
            query = query + " FROM " + current_table_name;
            //MessageBox.Show(query);
            dataGridView1.DataSource = db.GetTable(query);
        }

    }
}
