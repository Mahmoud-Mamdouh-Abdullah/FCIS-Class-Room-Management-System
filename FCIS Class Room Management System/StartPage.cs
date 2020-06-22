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
    public partial class StartPage : Form
    {
        int mov;
        int movX;
        int movY;
        public StartPage()
        {
            InitializeComponent();
        }

       

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        

        private void SignIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm Register = new RegisterForm();
            Register.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm Register = new RegisterForm();
            Register.Show();
        }

        private void ToolBar_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void ToolBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
        }

        private void ToolBar_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;
            }
            else if(this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }


      
       
    
    }
}
