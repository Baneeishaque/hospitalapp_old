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
    public partial class frmInsertIntoCare : UserControl
    {
        DBhandler db = new DBhandler();
        public frmInsertIntoCare(String p,String age,String add,String pho,String date,String ti,String dis,String bloo,String doc,String rem)
        {
            InitializeComponent();

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
        }
    }
}
