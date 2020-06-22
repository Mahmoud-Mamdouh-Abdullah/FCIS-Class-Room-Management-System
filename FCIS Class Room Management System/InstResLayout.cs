using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace FCIS_Class_Room_Management_System
{

    public partial class InstResLayout : UserControl
    {
        DataBaseModel dataModel;
        int id;
        public InstResLayout()
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

        private void delete_res_Click(object sender, EventArgs e)
        {
            dataModel = new DataBaseModel();
            int x = dataModel.delete_Resource(id);
            if (x == 1)
            {
                MessageBox.Show("The Resources is Deleted Successfully", "Delete Resource", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Something Wrong Happened When Deleting The Resource", "Delete Resource", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void update_res_Click(object sender, EventArgs e)
        {
            update_res_progress();
        }

        private void update_res_progress()
        {
            dataModel = new DataBaseModel();
            if (update_res.Text == "Update")
            {
                new_link.Visible = true;
                update_res.Text = "Submit";
                res_link.Visible = false;
            }
            else
            {
                if (new_link.Text != "")
                {
                    string link = new_link.Text;
                    int ans = dataModel.update_resource(_resID,link);
                    if(ans == 1)
                    {
                        update_res.Text = "Update";
                        new_link.Visible = false;
                        res_link.Text = link;
                        res_link.Visible = true;
                        MessageBox.Show("The Link is Updated Successfully.", "Update Resource", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Something Wrong was Happend, Please try again.", "Update Resource", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                }
                else
                {
                    MessageBox.Show("Please, Enter the New Link and Submit.", "Update Resource", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void new_link_MouseClick(object sender, MouseEventArgs e)
        {
            if(new_link.ForeColor != Color.White)
            {
                new_link.ForeColor = Color.White;
                new_link.Text = "";
            }
        }
    }
}
