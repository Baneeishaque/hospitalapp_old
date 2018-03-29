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
        int counter = 3;
        public login()
        {
            InitializeComponent();
            SB_Login.Text = "Ateempt : " + counter;
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
                MessageBox.Show("Please check your credentials");
                counter--;
                SB_Login.Text = "Ateempt : " + counter;
                if (counter == 0)
                {
                    btnOK.Enabled = false;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
