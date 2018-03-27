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
        Control current_form;

        public mainfrm()
        {
            InitializeComponent();
        }

        private void btnRoutineCheckup_Click(object sender, EventArgs e)
        {
            opfrm o = new opfrm();
            current_form = o;
            pnlMain.Controls.Add(o);
            o.BringToFront();
        }

        

        private void btnAdmitpatient_Click_1(object sender, EventArgs e)
        {
            Patientfrm p = new Patientfrm();
            pnlMain.Controls.Add(p);
            p.BringToFront();
        }

        private void btnAddDoctor_Click(object sender, EventArgs e)
        {
            Doctorfrm d = new Doctorfrm();
            pnlMain.Controls.Add(d);
            d.BringToFront();
        }

        private void btnAddsisboy_Click(object sender, EventArgs e)
        {
            SisterWardboyfrm s = new SisterWardboyfrm();
            pnlMain.Controls.Add(s);
            s.BringToFront();
        }

        private void btnDischargePatient_Click(object sender, EventArgs e)
        {
            Dischargefrm di = new Dischargefrm();
            pnlMain.Controls.Add(di);
            di.BringToFront();
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            Billfrm b = new Billfrm();
            pnlMain.Controls.Add(b);
            b.BringToFront();
        }

        private void btnBed_Click(object sender, EventArgs e)
        {
            Bedfrm be = new Bedfrm();
            pnlMain.Controls.Remove(current_form);
            pnlMain.Controls.Add(be);
            be.BringToFront();

           
        }
            
        
    }
}
