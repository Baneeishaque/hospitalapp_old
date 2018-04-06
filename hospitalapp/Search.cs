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
    public partial class Search : Form
    {
        DBhandler db = new DBhandler();
        String current_table_name;

        public Search(String table_name)
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
                cBoxParamets.Items.Add(dt.Columns[i].Caption);
            }

            fill_dg();

        }

        private void fill_dg()
        {
            if (current_table_name == "Discharge")
            {
                dataGridView1.DataSource = db.GetTable("SELECT * FROM Admit WHERE (discharge_date IS NULL)");
            }
            else if (current_table_name == "Bill")
            {
                dataGridView1.DataSource = db.GetTable("SELECT * FROM Admit WHERE (discharge_date IS NOT NULL) AND (bill_status IS NULL)");
            }
            else
            {
                dataGridView1.DataSource = db.GetTable("SELECT " + current_table_name + ".* FROM " + current_table_name + "");
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            fill_dg();
        }

        private void searchTxt_TextChanged(object sender, EventArgs e)
        {
            if (current_table_name == "Discharge")
            {
                if (searchTxt.Text.Length > 0)
                {
                    dataGridView1.DataSource = db.GetTable("SELECT * FROM Admit WHERE " + cBoxParamets.SelectedItem.ToString() + " ='" + searchTxt.Text + "' AND (discharge_date IS NULL)");
                }
            }
            else if (current_table_name == "Bill")
            {
                if (searchTxt.Text.Length > 0)
                {
                    dataGridView1.DataSource = db.GetTable("SELECT * FROM Admit WHERE " + cBoxParamets.SelectedItem.ToString() + " ='" + searchTxt.Text + "' AND (discharge_date IS NOT NULL) AND (bill_status IS NULL)");
                }
            }
            else
            {
                if (searchTxt.Text.Length > 0)
                {
                    dataGridView1.DataSource = db.GetTable("SELECT " + current_table_name + ".* FROM " + current_table_name + " WHERE " + cBoxParamets.SelectedItem.ToString() + " ='" + searchTxt.Text + "'");
                }
            }
        }
    }
}
