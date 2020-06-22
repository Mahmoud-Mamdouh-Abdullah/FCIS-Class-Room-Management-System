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
    public partial class InstViewCourses : Form
    {
        private int numberOfItems;
        List<course> courses;
        DataBaseModel classRoom;
        public InstViewCourses(int UserLoggedIn)
        {
            InitializeComponent();
            courses = new List<course>();
            classRoom = new DataBaseModel();
            courses = classRoom.viewCourses(UserLoggedIn);

            numberOfItems = courses.Count;
            
        }

        private void testForm_Load(object sender, EventArgs e)
        {
            viewItems(numberOfItems, courses);
        }

        private void viewItems(int N, List<course> courses)
        {
            if (flowLayoutPanel1.Controls.Count > 0)
                flowLayoutPanel1.Controls.Clear();
            
            InstCourseLayout[] items = new InstCourseLayout[N];
            for (int i = 0; i < N; i++)
            {
                items[i] = new InstCourseLayout();

                items[i].courseName = courses[i].courseName;
                items[i].subjectName = courses[i].subjectName;
                items[i].courseID = courses[i].courseId;
                flowLayoutPanel1.Controls.Add(items[i]); 
            }
        }


        private void Exit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_home_Click(object sender, EventArgs e)
        {
            InstMainPage main = new InstMainPage(null);
            this.Hide();
            main.ShowDialog();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
