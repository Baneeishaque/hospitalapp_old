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
    public partial class Bedfrm : UserControl
    {
        public Bedfrm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtSpecialWard.Text.Length == 0 && txtGeneralWard.Text.Length == 0)
            {
                MessageBox.Show("enter any field");

            }
            else
            {
                SqlConnection con = new SqlConnection(DB_Constants.db_url);
                SqlCommand bed = new SqlCommand("INSERT INTO Bedtype (General,special)VALUES('" + txtGeneralWard.Text + "','" + txtSpecialWard.Text + "')", con);
                con.Open();
                bed.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
