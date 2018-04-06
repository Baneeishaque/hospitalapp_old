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
    public partial class Patientfrm : UserControl
    {
        DBhandler db = new DBhandler();
        int population_flag = 0;

        public Patientfrm()
        {
            InitializeComponent();

            btnCancelRegistration.Enabled = false;
            btnEditRegistration.Enabled = false;
            btnSaveRegistration.Enabled = false;

            txtRegno.Text = db.get_max_reg_admit();

            comboBox1.DataSource = db.GetTable("SELECT ID AS Expr1, Name AS Expr2 FROM Doctor");
            comboBox1.DisplayMember = "Expr2";
            comboBox1.ValueMember = "Expr2";

            dataGridView1.DataSource = db.GetTable("SELECT Regno As [Reg. No.], name As Name, Age, Address, Phone, Doctor FROM Admit WHERE (discharge_date IS NULL)");
            DTP_date.Value = DateTime.Today;
        }

        private void btnRegisterPatient_Click(object sender, EventArgs e)
        {
            btnCancelRegistration.Enabled = true;

            btnSaveRegistration.Enabled = true;

        }

        private void btnSaveRegistration_Click(object sender, EventArgs e)
        {
            if (txtRegno.Text.Length == 0)
            {
                MessageBox.Show("No register Number");
            }
            else
            {
                SqlConnection con = new SqlConnection(DB_Constants.db_url);
                String query = "INSERT INTO Admit (Regno, Bedcategory, Bedno, Charge, Name, Age, Address, Phone, Admitdatetime, Disease, Bloodgroup, Doctor, Remarks) VALUES (" + txtRegno.Text + ",'" + CB_BedCategory.SelectedItem.ToString() + "','" + CB_Bedno.SelectedItem.ToString() + "'," + txtBedCharge.Text + ",'" + txtPatiname.Text + "'," + txtAge.Text + ",'" + RtxtAddress.Text + "','" + txtphone.Text + "','" + DTP_date.Value + "','" + txtDisease.Text + "','" + CB_Bloodgp.Text + "','" + comboBox1.Text + "','" + Rtxt_Remark.Text + "')";
                //MessageBox.Show(query);
                SqlCommand sc = new SqlCommand(query, con);
                con.Open();
                sc.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Insertion Success...");
                dataGridView1.DataSource = db.GetTable("SELECT Regno As [Reg. No.], name As Name, Age, Address, Phone, Doctor FROM Admit WHERE (discharge_date IS NULL)");
                this.Dispose();
            }
        }

        private void CB_BedCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (population_flag == 0)
            {
                while (CB_Bedno.Items.Count != 0)
                {
                    CB_Bedno.Items.RemoveAt(0);
                }

                if (CB_BedCategory.SelectedItem.ToString().Equals("General"))
                {
                    int count = Convert.ToInt32(db.GetValue("SELECT General FROM Bedtype"));
                    //MessageBox.Show(count.ToString());
                    for (int i = 1; i <= count; i++)
                    {
                        string tmp = db.GetValue("SELECT Bedno FROM Admit WHERE Bedno=" + i + " AND Bedcategory='General' AND (discharge_date IS NULL)");
                        //MessageBox.Show(tmp);
                        if (tmp.Equals("0"))
                        {
                            CB_Bedno.Items.Add(i);
                        }
                    }
                }
                else if (CB_BedCategory.SelectedItem.ToString().Equals("Special"))
                {
                    int count = Convert.ToInt32(db.GetValue("SELECT special FROM Bedtype"));
                    //MessageBox.Show(count.ToString());
                    for (int i = 1; i <= count; i++)
                    {
                        string tmp = db.GetValue("SELECT Bedno FROM Admit WHERE Bedno=" + i + " AND Bedcategory='Special' AND (discharge_date IS NULL)");
                        //MessageBox.Show(tmp);
                        if (tmp.Equals("0"))
                        {
                            CB_Bedno.Items.Add(i);
                        }
                    }
                }
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
                comboBox1.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

                while (CB_Bedno.Items.Count != 0)
                {
                    CB_Bedno.Items.RemoveAt(0);
                }

                DataTable dt = db.GetTable("SELECT Bedcategory, Bedno, Charge, Admitdatetime, Disease, Bloodgroup, Remarks FROM Admit WHERE Regno=" + txtRegno.Text);
                
                population_flag = 1;
                CB_BedCategory.SelectedItem = dt.Rows[0][0].ToString();

                if (CB_BedCategory.SelectedItem.ToString().Equals("General"))
                {
                    int count = Convert.ToInt32(db.GetValue("SELECT General FROM Bedtype"));
                    //MessageBox.Show(count.ToString());
                    for (int i = 1; i <= count; i++)
                    {
                        string tmp = db.GetValue("SELECT Bedno FROM Admit WHERE Bedno=" + i + " AND Bedcategory='General' AND (discharge_date IS NULL)");
                        //MessageBox.Show(tmp);
                        if (tmp.Equals("0"))
                        {
                            CB_Bedno.Items.Add(i);
                        }
                    }
                }
                else if (CB_BedCategory.SelectedItem.ToString().Equals("Special"))
                {
                    int count = Convert.ToInt32(db.GetValue("SELECT special FROM Bedtype"));
                    //MessageBox.Show(count.ToString());
                    for (int i = 1; i <= count; i++)
                    {
                        string tmp = db.GetValue("SELECT Bedno FROM Admit WHERE Bedno=" + i + " AND Bedcategory='Special' AND (discharge_date IS NULL)");
                        //MessageBox.Show(tmp);
                        if (tmp.Equals("0"))
                        {
                            CB_Bedno.Items.Add(i);
                        }
                    }
                }

                population_flag = 0;

                //MessageBox.Show(dt.Rows[0][1].ToString());
                CB_Bedno.Items.Insert(0, dt.Rows[0][1].ToString());
                CB_Bedno.SelectedIndex = 0;

                txtBedCharge.Text = dt.Rows[0][2].ToString();
                DTP_date.Value = Convert.ToDateTime(dt.Rows[0][3].ToString());
                txtDisease.Text = dt.Rows[0][4].ToString();
                CB_Bloodgp.SelectedItem = dt.Rows[0][5].ToString();
                Rtxt_Remark.Text = dt.Rows[0][6].ToString();

                btnEditRegistration.Enabled = true;
                btnRegisterPatient.Enabled = false;
                btnSaveRegistration.Enabled = false;
            }
        }

        private void btnEditRegistration_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(DB_Constants.db_url);
            String query = "UPDATE Admit SET Bedcategory='" + CB_BedCategory.SelectedItem.ToString() + "',Bedno=" + CB_Bedno.SelectedItem.ToString() + ",Charge=" + txtBedCharge.Text + ",Name='" + txtPatiname.Text + "',Age=" + txtAge.Text + ",Address='" + RtxtAddress.Text + "',Phone='" + txtphone.Text + "',Admitdatetime='" + DTP_date.Value + "',Disease='" + txtDisease.Text + "',Bloodgroup='" + CB_Bloodgp.Text + "',Doctor='" + comboBox1.SelectedValue + "',Remarks='" + Rtxt_Remark.Text + "' WHERE Regno=" + txtRegno.Text;
            //MessageBox.Show(query);
            SqlCommand sc = new SqlCommand(query, con);
            con.Open();
            sc.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updation Success...");
            dataGridView1.DataSource = db.GetTable("SELECT Regno As [Reg. No.], name As Name, Age, Address, Phone, Doctor FROM Admit WHERE (discharge_date IS NULL)");
            this.Dispose();
        }

        private void btnCustomprint_Click(object sender, EventArgs e)
        {
            Print_Contents cb = new Print_Contents("Admit");
            cb.Show();
        }

        private void btnCancelRegistration_Click(object sender, EventArgs e)
        {
            btnEditRegistration.Enabled = false;
            btnSaveRegistration.Enabled = false;
            btnCancelRegistration.Enabled = false;
            btnRegisterPatient.Enabled = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search s = new Search("Admit");
            s.Show();
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
