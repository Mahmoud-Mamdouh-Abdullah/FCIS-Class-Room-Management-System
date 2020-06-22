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
    public partial class StdMainPage : Form
    {
        int mov;
        int movX;
        int movY;

        user LoggedInUser;
        DataBaseModel classRoom;
        public StdMainPage(user user)
        {
            InitializeComponent();
            LoggedInUser = user;
        }

        private void setting_Click(object sender, EventArgs e)
        {
            ProfileForm profile = new ProfileForm(LoggedInUser);
            this.Hide();
            profile.Show();
        }

        private Form activeForm = null;
        private void OpenView(Form childForm)
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

        private void view_all_Click(object sender, EventArgs e)
        {
            int enroll = 0;
            classRoom = new DataBaseModel();
            if (ShowMenuPanel.Visible == false)
            {
                List<StdCourse> courses = classRoom.selectAllCourses();
                OpenView(new StdViewCourses(courses,LoggedInUser,enroll));
                menu_trans.ShowSync(ShowMenuPanel);
            }
            else
                menu_trans.HideSync(ShowMenuPanel);
        }

        private void logout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            this.Hide();
            login.Show();
        }

        private void menu_btn_Click(object sender, EventArgs e)
        {
            if (panel4.Visible == false)
                menu_trans.ShowSync(panel4);
            else
                menu_trans.HideSync(panel4);
        }
        private void view_id_Click(object sender, EventArgs e)
        {
            int enroll = 0;
            if (ShowMenuPanel.Visible == false)
            {
                try
                {
                    classRoom = new DataBaseModel();
                    int id;
                    id = Convert.ToInt32(Prompt.ShowDialog("Enter Course ID you Want to Show", "Search by ID"));
                    List<StdCourse> courses = new List<StdCourse>();
                    StdCourse course = classRoom.selectOneCourses(id);
                    courses.Add(course);
                    OpenView(new StdViewCourses(courses,LoggedInUser,enroll));
                    menu_trans.ShowSync(ShowMenuPanel);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
                menu_trans.HideSync(ShowMenuPanel);
        }

        private void view_my_Click(object sender, EventArgs e)
        {
            int enroll = 1;
            classRoom = new DataBaseModel();
            if (ShowMenuPanel.Visible == false)
            {
                List<StdCourse> courses = classRoom.selectStudentCourses(LoggedInUser.user_id);
                OpenView(new StdViewCourses(courses,LoggedInUser,enroll));
                menu_trans.ShowSync(ShowMenuPanel);
            }
            else
                menu_trans.HideSync(ShowMenuPanel);
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

        private void gen_rep2_Click(object sender, EventArgs e)
        {
            /*if(ShowMenuPanel.Visible == false)
            {
                OpenView(new Report2Form());
                menu_trans.ShowSync(ShowMenuPanel);
            }
            else
                menu_trans.HideSync(ShowMenuPanel);*/
            Report2Form report = new Report2Form();
            report.Show();
        }

        private void StdMainPage_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
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
