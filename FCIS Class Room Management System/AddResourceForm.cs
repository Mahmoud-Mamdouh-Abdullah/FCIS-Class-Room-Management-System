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
    public partial class AddResourceForm : Form
    {
        DataBaseModel classRomm = new DataBaseModel();
        int course_id;
        public AddResourceForm(int id)
        {
            InitializeComponent();
            course_id = id;
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            string name = res_name.Text;
            string link = res_link.Text;
            int ans = classRomm.add_Resource(name, link, course_id);
            if(ans == 1)
            {
                MessageBox.Show("The Resource is Added Successfully","ADD Resource",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Something Wrong is Happened When Adding The Resource", "ADD Resource", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
