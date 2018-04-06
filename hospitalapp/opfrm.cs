using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace hospitalapp
{
    public partial class opfrm : UserControl
    {
        DBhandler db = new DBhandler();
        public opfrm()
        {
            InitializeComponent();
            btnEditRegistration.Enabled = false;
            btnDeleteRegistration.Enabled = false;
            btnCancelRegistration.Enabled = false;
            btnSaveRegistration.Enabled = false;
            button_admit.Enabled = false;


            txtRegno.Text = db.get_max_reg_op();

            cbDoctor.DataSource = db.GetTable("SELECT ID AS Expr1, Name AS Expr2 FROM Doctor");
            cbDoctor.DisplayMember = "Expr2";
            cbDoctor.ValueMember = "Expr2";

            dataGridView1.DataSource = db.GetTable("SELECT Reg As [Reg. No.], name As Name, Age, Address, Phone, Doctor FROM op");

            DTP_date.Value = DateTime.Today;
            DTP_time.Format = DateTimePickerFormat.Time;
            DTP_time.ShowUpDown = true;

        }

        private void btnRegisterPatient_Click(object sender, EventArgs e)
        {
            btnSaveRegistration.Enabled = true;
            btnCancelRegistration.Enabled = true;
            btnRegisterPatient.Enabled = false;
        }

        private void btnSaveRegistration_Click(object sender, EventArgs e)
        {
            if (txtPatiname.Text.Length == 0)
                MessageBox.Show("enter all field");
            else if (txtAge.Text.Length == 0)
                MessageBox.Show("enter all field");
            else if (RtxtAddress.Text.Length == 0)
                MessageBox.Show("enter all field");
            else if (txtphone.Text.Length == 0)
                MessageBox.Show("enter all field");
            else if (txtphone.Text.Length != 10)
                MessageBox.Show("incorrect phone no ");
            else if (DTP_date.Text.Length == 0)
                MessageBox.Show("enter all field");
            else if (DTP_time.Text.Length == 0)
                MessageBox.Show("enter all field");
            else if (txtDisease.Text.Length == 0)
                MessageBox.Show("enter all field");
            else if (CB_Bloodgp.Text.Length == 0)
                MessageBox.Show("enter all field");
            else if (cbDoctor.Text.Length == 0)
                MessageBox.Show("enter all field");
            else if (Rtxt_Remark.Text.Length == 0)
                MessageBox.Show("enter all field");
            else
            {
                SqlConnection con = new SqlConnection(DB_Constants.db_url);
                String query = "INSERT INTO op (Reg, name, Age, Address, Phone, Date, Time, Disease, Bloodgroup, Doctor, Remarks)VALUES (" + txtRegno.Text + ",'" + txtPatiname.Text + "'," + txtAge.Text + ",'" + RtxtAddress.Text + "','" + txtphone.Text + "','" + DTP_date.Text + "','" + DTP_time.Text + "','" + txtDisease.Text + "','" + CB_Bloodgp.Text + "','" + cbDoctor.Text + "','" + Rtxt_Remark.Text + "')";
                //MessageBox.Show(query);
                SqlCommand sc = new SqlCommand(query, con);
                con.Open();
                sc.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Insertion Success...");
                dataGridView1.DataSource = db.GetTable("SELECT Reg As [Reg. No.], name As Name, Age, Address, Phone, Doctor FROM op");
                this.Dispose();
            }


        }

        private void btnCancelRegistration_Click(object sender, EventArgs e)
        {
            btnRegisterPatient.Enabled = true;
            btnDeleteRegistration.Enabled = false;
            btnSaveRegistration.Enabled = false;
            btnCancelRegistration.Enabled = false;
        }

        private void btnCustomprint_Click(object sender, EventArgs e)
        {
            Print_Contents cb = new Print_Contents("op");
            cb.Show();
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

        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                txtRegno.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtPatiname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtAge.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                RtxtAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtphone.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                cbDoctor.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

                DataTable dt = db.GetTable("SELECT Date, Time, Disease, Bloodgroup, Remarks FROM op WHERE Reg=" + txtRegno.Text);
                DTP_date.Value = Convert.ToDateTime(dt.Rows[0][0].ToString());
                DTP_time.Value = Convert.ToDateTime(dt.Rows[0][1].ToString());
                txtDisease.Text = dt.Rows[0][2].ToString();
                CB_Bloodgp.SelectedItem = dt.Rows[0][3].ToString();
                Rtxt_Remark.Text = dt.Rows[0][4].ToString();

                btnDeleteRegistration.Enabled = true;
                btnEditRegistration.Enabled = true;
                btnRegisterPatient.Enabled = false;
                btnSaveRegistration.Enabled = false;
                button_admit.Enabled = true;
                btnCancelRegistration.Enabled = false;
            }
        }

        private void btnDeleteRegistration_Click(object sender, EventArgs e)
        {
            db.Ins_Up_Del("DELETE FROM op WHERE Reg=" + txtRegno.Text);
            MessageBox.Show("Deletion Success...");
            dataGridView1.DataSource = db.GetTable("SELECT Reg As [Reg. No.], name As Name, Age, Address, Phone, Doctor FROM op");
            this.Dispose();
        }

        private void btnEditRegistration_Click(object sender, EventArgs e)
        {
            db.Ins_Up_Del("UPDATE op SET name ='" + txtPatiname.Text + "', Age ='" + txtAge.Text + "', Address ='" + RtxtAddress.Text + "', Phone ='" + txtphone.Text + "', Date ='" + DTP_date.Value + "', Time ='" + DTP_time.Value + "', Disease ='" + txtDisease.Text + "', Bloodgroup ='" + CB_Bloodgp.SelectedItem.ToString() + "', Doctor ='" + cbDoctor.SelectedValue + "', Remarks ='" + Rtxt_Remark.Text + "'  WHERE Reg=" + txtRegno.Text);
            MessageBox.Show("Updation Success...");
            dataGridView1.DataSource = db.GetTable("SELECT Reg As [Reg. No.], name As Name, Age, Address, Phone, Doctor FROM op");
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admit f = new Admit(txtRegno.Text, txtPatiname.Text, txtAge.Text, RtxtAddress.Text, txtphone.Text, DTP_date.Text, DTP_time.Text, txtDisease.Text, CB_Bloodgp.Text, cbDoctor.Text, Rtxt_Remark.Text);
            f.ShowDialog();
            this.Dispose();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search s = new Search("op");
            s.Show();
        }

        private void dataGridView1_CellBorderStyleChanged(object sender, EventArgs e)
        {

        }


    }
}
