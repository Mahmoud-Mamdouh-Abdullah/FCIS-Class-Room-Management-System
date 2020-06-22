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
    public partial class StdViewRes : Form
    {
        int mov;
        int movX;
        int movY;

        DataBaseModel classRoom;
        private int numOfRes;
        private List<Resource> ResItems;
        int course_id;
        public StdViewRes(int id)
        {
            InitializeComponent();
            course_id = id;
            classRoom = new DataBaseModel();
            ResItems = classRoom.View_Resource(course_id);

            numOfRes = ResItems.Count;
        }

        private void viewRes(int N, List<Resource> resources)
        {
            if (flowLayoutPanel1.Controls.Count > 0)
                flowLayoutPanel1.Controls.Clear();
            
            for (int i = 0; i < N; i++)
            {
                StdResLayout Res = new StdResLayout();
                Res.ResID = resources[i].Res_id;
                Res.ResName = resources[i].Res_Name;
                Res.ResLink = resources[i].Res_Link;
                Res.Course_ID = resources[i].Course_id;

                flowLayoutPanel1.Controls.Add(Res);
            }
        }

        private void StdViewRes_Load(object sender, EventArgs e)
        {
            viewRes(numOfRes, ResItems);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
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
