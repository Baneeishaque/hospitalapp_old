using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace hospitalapp
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(DB_Constants.db_url);
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from login where username='" + txt_Username.Text +"' and password='" + txt_Password.Text +"'",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {

                this.Hide();
                mainfrm ss = new mainfrm();
                ss.Visible = true;
            }
            else
            {
                MessageBox.Show("piese check you usename and password");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
