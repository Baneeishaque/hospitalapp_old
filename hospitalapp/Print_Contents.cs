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
        public Print_Contents(String table_name)
        {
            InitializeComponent();
            DataTable dt = db.GetTable("SELECT " + table_name + ".* FROM " + table_name + "");
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                listView1.Items.Add(dt.Columns[i].Caption);
            }
        }
    }
}
