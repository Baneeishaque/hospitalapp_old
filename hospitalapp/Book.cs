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
    public partial class Book : UserControl
    {
        DBhandler db = new DBhandler();
        public Book()
        {
            InitializeComponent();
            dataGridView1.DataSource = db.GetTable("SELECT token_date, token_number, phone_number, doctor FROM token");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search s = new Search("token");
            s.Show();
        }

        private void btnCustomprint_Click(object sender, EventArgs e)
        {
            Print_Contents cb = new Print_Contents("token");
            cb.Show();
        }
    }
}
