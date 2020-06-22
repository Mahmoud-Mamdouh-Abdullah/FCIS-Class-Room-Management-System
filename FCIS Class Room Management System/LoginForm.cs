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
using Oracle.DataAccess;
namespace FCIS_Class_Room_Management_System
{
    public partial class LoginForm : Form
    {
        DataBaseModel classRoom = new DataBaseModel();
        int mov;
        int movX;
        int movY;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_home_Click(object sender, EventArgs e)
        {
            StartPage home = new StartPage();
            this.Hide();
            home.Show();
        }
        private void sign_in_Click(object sender, EventArgs e)
        {
            login_process();
            
        }
        private void login_process()
        {
            string Email = email.Text.ToLower();
            string Pass = pass.Text;
            user LoggedUser = classRoom.signIn(Email, Pass);
            if (LoggedUser.user_kind == "1")
            {
                if (LoggedUser.user_type == 1)
                {
                    InstMainPage main = new InstMainPage(LoggedUser);
                    this.Hide();
                    main.Show();
                }
                else if (LoggedUser.user_type == 2)
                {
                    StdMainPage main = new StdMainPage(LoggedUser);
                    this.Hide();
                    main.Show();
                }
            }
            else if (LoggedUser.user_kind == "-2")
            {
                MessageBox.Show("Sorry the Password is not Correct :(", "LogIn", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Sorry this Email is not Exist, Please Register and Login again :(", "LogIn", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void email_MouseClick(object sender, MouseEventArgs e)
        {
            if (email.ForeColor != Color.White)
            {
                email.Text = "";
                email.ForeColor = Color.White;
            }
        }

        private void pass_MouseClick(object sender, MouseEventArgs e)
        {
            if (pass.ForeColor != Color.White)
            {
                pass.Text = "";
                pass.ForeColor = Color.White;
            }
        }

        private void repass_check_CheckedChanged(object sender, EventArgs e)
        {
            if (pass_check.Checked)
                pass.isPassword = false;
            else
                pass.isPassword = true;
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
