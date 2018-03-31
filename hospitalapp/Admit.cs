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
    public partial class Admit : Form
    {
        DBhandler db = new DBhandler();
        int population_flag = 0;
        String reg;

        public Admit(String r,String p, String age, String add, String pho, String date, String ti, String dis, String bloo, String doc, String rem)
        {
            InitializeComponent();
            dataGridView1.DataSource = db.GetTable("SELECT Regno As [Reg. No.], name As Name, Age, Address, Phone, Doctor FROM Admit WHERE (discharge_date IS NULL)");
            txtRegno.Text = db.get_max_reg_admit();

            cbDoctor.DataSource = db.GetTable("SELECT ID AS Expr1, Name AS Expr2 FROM Doctor");
            cbDoctor.DisplayMember = "Expr2";
            cbDoctor.ValueMember = "Expr2";

            DTP_date.Value = DateTime.Today;
            //DTP_time.Format = DateTimePickerFormat.Time;
            //DTP_time.ShowUpDown = true;

            txtPatiname.Text = p;
            txtAge.Text = age;
            RtxtAddress.Text = add;
            txtphone.Text = pho;
            txtDisease.Text = dis;
            CB_Bloodgp.SelectedItem = bloo;
            cbDoctor.SelectedItem = doc;
            RtxtAddress.Text = rem;

            reg = r;
        }

        private void btnCancelRegistration_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSaveRegistration_Click(object sender, EventArgs e)
        {
            if (txtRegno.Text.Length == 0)
            {
                MessageBox.Show("No register Number");
            }
            else
            {
                db.Ins_Up_Del("DELETE FROM op WHERE Reg=" + reg);

                SqlConnection con = new SqlConnection(DB_Constants.db_url);
                String query = "INSERT INTO Admit (Regno, Bedcategory, Bedno, Charge, Name, Age, Address, Phone, Admitdatetime, Disease, Bloodgroup, Doctor, Remarks) VALUES (" + txtRegno.Text + ",'" + CB_BedCategory.SelectedItem.ToString() + "','" + CB_Bedno.SelectedItem.ToString() + "'," + txtBedCharge.Text + ",'" + txtPatiname.Text + "'," + txtAge.Text + ",'" + RtxtAddress.Text + "','" + txtphone.Text + "','" + DTP_date.Value + "','" + txtDisease.Text + "','" + CB_Bloodgp.Text + "','" + cbDoctor.Text + "','" + Rtxt_Remark.Text + "')";
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
    }
}
