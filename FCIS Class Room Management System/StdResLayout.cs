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
    public partial class StdResLayout : UserControl
    {
        int id;
        public StdResLayout()
        {
            InitializeComponent();
        }
        #region properties
        private string _ResName;
        private string _ResLink;
        private int _courseID;
        private int _resID;
        [Category("custom prop")]
        public string ResName
        {
            get { return _ResName; }
            set { _ResName = value; res_name.Text = value; }
        }
        [Category("custom prop")]
        public string ResLink
        {
            get { return _ResLink; }
            set { _ResLink = value; res_link.Text = value; }
        }
        [Category("custom prop")]
        public int ResID
        {
            get { return _resID; }
            set { _resID = value; id = value; }
        }
        public int Course_ID
        {
            get { return _courseID; }
            set { _courseID = value; course_id.Text = value.ToString(); }
        }
        #endregion

        private void open_link_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(res_link.Text);
        }
    }
}
