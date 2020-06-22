using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;

namespace FCIS_Class_Room_Management_System
{
    public partial class Report2Form : Form
    {
        int mov;
        int movX;
        int movY;

        CrystalReport2 Cr;
        public Report2Form()
        {
            InitializeComponent();
        }

        private void Report2Form_Load(object sender, EventArgs e)
        {
            Cr = new CrystalReport2();

            foreach (ParameterDiscreteValue v in Cr.ParameterFields[0].DefaultValues)
                inst_names.Items.Add(v.Value);
        }

        private void generate_Click(object sender, EventArgs e)
        {
            Cr.SetParameterValue(0, inst_names.Text);
            crystalReportViewer2.ReportSource = Cr;
        }

        private void Report2Form_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void Report2Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
        }

        private void Report2Form_MouseUp(object sender, MouseEventArgs e)
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
