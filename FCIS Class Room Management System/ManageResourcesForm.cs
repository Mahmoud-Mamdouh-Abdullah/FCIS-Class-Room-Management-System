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
    public partial class ManageResourcesForm : Form
    {
        int mov;
        int movX;
        int movY;
        int id;
        public ManageResourcesForm(int course_id)
        {
            InitializeComponent();
            id = course_id;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private Form activeForm = null;
        private void OpenViewCourses(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Bottom;
            work_panel.Controls.Add(childForm);
            work_panel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void back_home_Click(object sender, EventArgs e)
        {
            if (work_panel.Visible == false)
            {
                OpenViewCourses(new AddResourceForm(id));
                panel_trans.ShowSync(work_panel);
            }
            else
                panel_trans.HideSync(work_panel);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void view_res_Click(object sender, EventArgs e)
        {
            if (work_panel.Visible == false)
            {
                OpenViewCourses(new InstViewResourcesForm(id));
                panel_trans.ShowSync(work_panel);
            }
            else
                panel_trans.HideSync(work_panel);
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
