using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FCIS_Class_Room_Management_System
{
    public partial class Report4Form : Form
    {
        int mov;
        int movX;
        int movY;

        CrystalReport4 Cr;
        string id;
        public Report4Form(string cid)
        {
            InitializeComponent();
            id = cid;
        }

        private void Report3Form_Load(object sender, EventArgs e)
        {
            Cr = new CrystalReport4();
            label2.Text = id;
        }

        private void generate_Click(object sender, EventArgs e)
        {
            Cr.SetParameterValue(0, Convert.ToInt32(id));
            crystalReportViewer1.ReportSource = Cr;
        }

        private void Report3Form_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void Report3Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
        }

        private void Report3Form_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;
            }
            else if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }
    }
}
