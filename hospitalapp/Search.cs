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

            DataTable dt = db.GetTable("SELECT " + table_name + ".* FROM " + table_name + "");
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                cBoxParamets.Items.Add(dt.Columns[i].Caption);
            }

            dataGridView1.DataSource = db.GetTable("SELECT " + table_name + ".* FROM " + table_name + "");
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.GetTable("SELECT " + current_table_name + ".* FROM " + current_table_name + "");
        }

        private void searchTxt_TextChanged(object sender, EventArgs e)
        {
            if (searchTxt.Text.Length > 0)
            {
                dataGridView1.DataSource = db.GetTable("SELECT " + current_table_name + ".* FROM " + current_table_name + " WHERE "+cBoxParamets.SelectedItem.ToString()+" ='"+searchTxt.Text+"'");
            }
        }
    }
}
