using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
namespace FCIS_Class_Room_Management_System
{
    public partial class InstMainPage : Form
    {
        int mov;
        int movX;
        int movY;

        user User_LoggedIn;
        public InstMainPage(user User)
        {
            InitializeComponent();
            User_LoggedIn = User;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (panel4.Visible == false)
                menu_trans.ShowSync(panel4);
            else
                menu_trans.HideSync(panel4);
        }

        private void back_home_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            this.Hide();
            login.Show();
        }

        private void setting_Click(object sender, EventArgs e)
        {
            ProfileForm profile = new ProfileForm(User_LoggedIn);
            this.Hide();
            profile.Show();
        }

        private void add_course_Click(object sender, EventArgs e)
        {

            if (ShowMenuPanel.Visible == false)
            {
                OpenViewCourses(new AddCourseForm(User_LoggedIn));
                panel_trans.ShowSync(ShowMenuPanel);
            }
            else
                panel_trans.HideSync(ShowMenuPanel);
        }
        private void view_all_Click(object sender, EventArgs e)
        {
            if (ShowMenuPanel.Visible == false)
            {
                OpenViewCourses(new InstViewCourses(User_LoggedIn.user_id));
                panel_trans.ShowSync(ShowMenuPanel);
            }
            else
                panel_trans.HideSync(ShowMenuPanel);

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
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
            ShowMenuPanel.Controls.Add(childForm);
            ShowMenuPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void quick_view_Click(object sender, EventArgs e)
        {
            Report3Form report = new Report3Form(User_LoggedIn.user_id);
            report.Show();
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
