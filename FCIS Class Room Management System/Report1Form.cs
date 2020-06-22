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
    public partial class Report1Form : Form
    {
        int mov;
        int movX;
        int movY;

        CrystalReport1 Cr;
        string CourseID;
        public Report1Form(string id)
        {
            InitializeComponent();
            CourseID = id;
        }

        private void generate_Click(object sender, EventArgs e)
        {
            Cr.SetParameterValue(0, Convert.ToInt32(CourseID));
            crystalReportViewer1.ReportSource = Cr;
        }

        private void Report1Form_Load(object sender, EventArgs e)
        {
            course_id.Text = CourseID;
            Cr = new CrystalReport1();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Report1Form_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void Report1Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
        }

        private void Report1Form_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
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
