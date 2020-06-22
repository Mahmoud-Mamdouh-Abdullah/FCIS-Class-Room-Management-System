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
    public partial class InstViewResourcesForm : Form
    {
        DataBaseModel classRomm = new DataBaseModel();
        private int numOfRes;
        private List<Resource> ResItems;
        int id;
        public InstViewResourcesForm(int course_id)
        {
            InitializeComponent();
            id = course_id;
            ResItems = classRomm.View_Resource(id);   
            numOfRes = ResItems.Count;
        }

        private void viewRes(int N,List<Resource> resources)
        {
            if (flowLayoutPanel1.Controls.Count > 0)
                flowLayoutPanel1.Controls.Clear();
            InstResLayout[] Res = new InstResLayout[N];
            for (int i = 0; i < N; i++)
            {
                Res[i] = new InstResLayout();
                Res[i].ResID = resources[i].Res_id;
                Res[i].ResName = resources[i].Res_Name;
                Res[i].ResLink = resources[i].Res_Link;
                Res[i].Course_ID = resources[i].Course_id;

                flowLayoutPanel1.Controls.Add(Res[i]);

            }
        }

        private void ViewResourcesForm_Load(object sender, EventArgs e)
        {
           viewRes(numOfRes, ResItems);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
