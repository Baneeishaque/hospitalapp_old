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

            comboBox_doctor.DataSource = db.GetTable("SELECT ID AS Expr1, Name AS Expr2 FROM Doctor");
            comboBox_doctor.DisplayMember= "Expr2";
            comboBox_doctor.ValueMember = "Expr2";

            comboBox_doctor.Enabled = false;
            button_submit.Enabled = false;
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

        private void textBox_phone_TextChanged(object sender, EventArgs e)
        {
            comboBox_doctor.Enabled = true;
        }

        private void comboBox_doctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_doctor.SelectedIndex != 0)
            {
                
                DataTable dt = db.GetTable("SELECT MAX(token_number) AS Expr1 FROM token WHERE (doctor = '" + comboBox_doctor.SelectedItem.ToString() + "') AND (token_date = '" + DateTime.Today.ToString("dd-MM-yyyy") + "')");
               
                if (dt.Rows[0][0].ToString() == "")
                {
                    label_token.Text = "1";
                }
                else
                {
                    label_token.Text = (Convert.ToInt32(dt.Rows[0][0].ToString()) + 1).ToString();
                }
                button_submit.Enabled = true;
            }
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            db.Ins_Up_Del("INSERT INTO token (token_number, doctor, phone_number, token_date) VALUES(" + label_token.Text + ",'" + comboBox_doctor.Text + "','" + textBox_phone.Text + "','" + DateTime.Today.ToString("dd-MM-yyyy") + "')");
            MessageBox.Show("Token Inserted Successfully");
            this.Dispose();
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
    }
}
