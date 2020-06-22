using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FCIS_Class_Room_Management_System
{
    public partial class InstCourseLayout : UserControl
    {
        DataBaseModel classRoom = new DataBaseModel();
        public InstCourseLayout()
        {
            InitializeComponent();
        }

        #region properties
        private string _courseName;
        private string _subjectName;
        private int _courseID;
        private Color _color;
        [Category("custom prop")]
        public string courseName
        {
            get { return _courseName; }
            set { _courseName = value; courseNamelbl.Text = value; }
        }
        [Category("custom prop")]
        public int courseID
        {
            get { return _courseID; }
            set
            {
                _courseID = value;
                if (value < 10)
                {
                    Course_ID.Text = "0";
                    Course_ID.Text += value.ToString();
                }
                else
                    Course_ID.Text = value.ToString();
            }
        }
        [Category("custom prop")]
        public Color color
        {
            get { return _color; }
            set { _color = value;  panel1.BackColor= value; }
        }

        [Category("custom prop")]
        public string subjectName
        {
            get { return _subjectName; }
            set { _subjectName = value; subjectNamelbl.Text = value; }
        }
        #endregion

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.White;
        }

        private void manageBTN_Click(object sender, EventArgs e)
        {
            int course_id = Convert.ToInt32(Course_ID.Text);
            ManageResourcesForm manage_form = new ManageResourcesForm(course_id);
            manage_form.Show();
            //display_over();
        }
        //private void display_over()
        //{
        //    Form Res_form = new Form();
        //    int course_id = Convert.ToInt32(Course_ID.Text);
        //    try
        //    {
        //        using (ManageResourcesForm MRF = new ManageResourcesForm(course_id))
        //        {
        //            Res_form.StartPosition = FormStartPosition.CenterScreen;
        //            Res_form.FormBorderStyle = FormBorderStyle.None;
        //            Res_form.Opacity = .70d;
        //            Res_form.BackColor = Color.Black;
        //            Res_form.WindowState = FormWindowState.Maximized;
        //            Res_form.TopMost = true;
        //            Res_form.Location = this.Location;
        //            Res_form.ShowInTaskbar = false;
        //            Res_form.Show();

        //            MRF.Owner = Res_form;
        //            MRF.ShowDialog();

        //            Res_form.Dispose();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    finally
        //    {
        //        Res_form.Dispose();
        //    }
        //}
        private void deleteBTN_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Course_ID.Text);
            int ans = classRoom.deleteCourse(id);
            if(ans != 1)
            {
                MessageBox.Show("Something Wrong Happened When Deleting The Course", "Delete Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("The Course is Deleted Successfully", "Delete Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Silver;
        }

        private void report_Click(object sender, EventArgs e)
        {
            Report4Form report = new Report4Form(Course_ID.Text);
            report.Show();
        }

     
    }
}
