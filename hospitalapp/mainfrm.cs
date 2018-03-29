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
    public partial class mainfrm : Form
    {
        Control current_form = null;
        DBhandler db = new DBhandler();

        public mainfrm()
        {
            InitializeComponent();
            if (db.check_beds())
            {
                Bedfrm o = new Bedfrm();
                if (current_form != null)
                {
                    pnlMain.Controls.Remove(current_form);
                }
                current_form = o;
                pnlMain.Controls.Add(o);
                o.BringToFront();
            }
        }

        private void btnRoutineCheckup_Click(object sender, EventArgs e)
        {
            opfrm o = new opfrm();
            if (current_form != null)
            {
                pnlMain.Controls.Remove(current_form);
            }
            current_form = o;
            pnlMain.Controls.Add(o);
            o.BringToFront();
        }

        private void btnAdmitpatient_Click_1(object sender, EventArgs e)
        {
            Patientfrm p = new Patientfrm();
            if (current_form != null)
            {
                pnlMain.Controls.Remove(current_form);
            }
            current_form = p;
            pnlMain.Controls.Add(p);
            p.BringToFront();
        }

        private void btnAddDoctor_Click(object sender, EventArgs e)
        {
            Doctorfrm d = new Doctorfrm();
            if (current_form != null)
            {
                pnlMain.Controls.Remove(current_form);
            }
            current_form = d;
            pnlMain.Controls.Add(d);
            d.BringToFront();
        }

        private void btnAddsisboy_Click(object sender, EventArgs e)
        {
            SisterWardboyfrm s = new SisterWardboyfrm();
            if (current_form != null)
            {
                pnlMain.Controls.Remove(current_form);
            }
            current_form = s;
            pnlMain.Controls.Add(s);
            s.BringToFront();
        }

        private void btnDischargePatient_Click(object sender, EventArgs e)
        {
            Dischargefrm di = new Dischargefrm();
            if (current_form != null)
            {
                pnlMain.Controls.Remove(current_form);
            }
            current_form = di;
            pnlMain.Controls.Add(di);
            di.BringToFront();
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            Billfrm b = new Billfrm();
            if (current_form != null)
            {
                pnlMain.Controls.Remove(current_form);
            }
            current_form = b;
            pnlMain.Controls.Add(b);
            b.BringToFront();
        }

        private void btnBed_Click(object sender, EventArgs e)
        {
            Bedfrm be = new Bedfrm();
            if (current_form != null)
            {
                pnlMain.Controls.Remove(current_form);
            }
            current_form = be;
            pnlMain.Controls.Add(be);
            be.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(db.GetValue("SELECT General FROM Bedtype"));
            //MessageBox.Show(count.ToString());
            for (int i = 1; i <= count; i++)
            {
                string tmp = db.GetValue("SELECT Bedno FROM Admit WHERE Bedno=" + i + " AND Bedcategory='General' AND (discharge_date IS NULL)");
                //MessageBox.Show(tmp);
                if (!tmp.Equals("0"))
                {
                    count--;
                }
            }
            int count2 = Convert.ToInt32(db.GetValue("SELECT special FROM Bedtype"));
            //MessageBox.Show(count.ToString());
            for (int i = 1; i <= count2; i++)
            {
                string tmp = db.GetValue("SELECT Bedno FROM Admit WHERE Bedno=" + i + " AND Bedcategory='Special' AND (discharge_date IS NULL)");
                //MessageBox.Show(tmp);
                if (!tmp.Equals("0"))
                {
                    count2--;
                }
            }
            MessageBox.Show(count + " Beds Available in General Category\n" + count2 + " Beds Available in Special Category", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\WINDOWS\system32\calc");
        }

        private void btnNotepad_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\WINDOWS\notepad");
        }

        private void mainfrm_Load(object sender, EventArgs e)
        {

        }


    }
}
