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
    public partial class AddCourseForm : Form
    {
        user user_loggedin;
        public AddCourseForm(user user)
        {
            InitializeComponent();
            user_loggedin = user;
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            DataBaseModel classRoom = new DataBaseModel();
            string Course_Name = course_name.Text;
            string Subject = course_sub.Text;
            int User_id = user_loggedin.user_id;
            course inserted_course = new course(1, Course_Name, Subject, User_id);
            
            int ans = classRoom.insertCourse(inserted_course,user_loggedin.user_name);
            MessageBox.Show("Course Successfully Added");
        }
    }
}
