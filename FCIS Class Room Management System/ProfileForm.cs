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
    public partial class ProfileForm : Form
    {
        int mov;
        int movX;
        int movY;


        DataBaseModel classRoom;
        user user_loggedin;
        public ProfileForm(user user)
        {
            InitializeComponent();
            name.Text = user.user_name;
            email.Text = user.user_email;
            old_pass.Text = user.user_pass;
            old_pass.isPassword = false;
            old_check.Checked = true;
            user_loggedin = user;
        }

        private void pass_check_CheckedChanged(object sender, EventArgs e)
        {
            if (pass_check.Checked)
                pass.isPassword = false;
            else
                pass.isPassword = true;
        }

        private void repass_check_CheckedChanged(object sender, EventArgs e)
        {
            if (repass_check.Checked)
                re_pass.isPassword = false;
            else
                re_pass.isPassword = true;
        }

        private void logout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            this.Hide();
            login.Show();
        }

        private void name_MouseClick(object sender, MouseEventArgs e)
        {
            if(name.ForeColor != Color.White)
            {
                name.ForeColor = Color.White;
                name.Text = "";
            }
        }

        private void email_MouseClick(object sender, MouseEventArgs e)
        {
            if (email.ForeColor != Color.White)
            {
                email.ForeColor = Color.White;
                email.Text = "";
            }
        }

        private void pass_MouseClick(object sender, MouseEventArgs e)
        {
            if (pass.ForeColor != Color.White)
            {
                pass.ForeColor = Color.White;
                pass.Text = "";
            }
        }

        private void re_pass_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (re_pass.ForeColor != Color.White)
            {
                re_pass.ForeColor = Color.White;
                re_pass.Text = "";
            }
        }

        private void old_check_CheckedChanged(object sender, EventArgs e)
        {
            if (old_check.Checked)
                old_pass.isPassword = false;
            else
                old_pass.isPassword = true;
        }

        private void back_mainpage_Click(object sender, EventArgs e)
        {
            if(user_loggedin.user_type == 1)
            {
                InstMainPage main = new InstMainPage(user_loggedin);
                this.Hide();
                main.ShowDialog();
            }
            else
            {
                StdMainPage main = new StdMainPage(user_loggedin);
                this.Hide();
                main.ShowDialog();
            }
        }

        private void data_update_Click(object sender, EventArgs e)
        {
            update_acc();
        }
        public void update_acc()
        {
            classRoom = new DataBaseModel();

            string new_name = user_loggedin.user_name;
            string new_pass = user_loggedin.user_pass;
            string new_email = user_loggedin.user_email;
            if (name.Text != new_name)
                new_name = name.Text;
            if (email.Text != new_email)
                new_email = email.Text;
            if (pass.Text != "" && re_pass.Text != "")
            {
                if (pass.Text == re_pass.Text)
                {
                    new_pass = pass.Text;
                    user_loggedin.user_name = new_name;
                    user_loggedin.user_email = new_email;
                    user_loggedin.user_pass = new_pass;
                    int ans = classRoom.update_user(user_loggedin);
                    if (ans == 1)
                    {
                        MessageBox.Show("your Data Updated Successfully :)", "Update Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        name.Text = user_loggedin.user_name;
                        email.Text = user_loggedin.user_email;
                        old_pass.Text = user_loggedin.user_pass;
                    }
                    else
                        MessageBox.Show("Sorry Something Wrong was Happend :(", "Update Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Sorry the Password doesn't match :(", "Update Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {

                user_loggedin.user_name = new_name;
                user_loggedin.user_email = new_email;
                user_loggedin.user_pass = new_pass;
                int ans = classRoom.update_user(user_loggedin);
                if (ans == 1)
                {
                    MessageBox.Show("your Data Updated Successfully :)", "Update Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    name.Text = user_loggedin.user_name;
                    email.Text = user_loggedin.user_email;
                    old_pass.Text = user_loggedin.user_pass;
                }
                else
                    MessageBox.Show("Sorry Something Wrong was Happend :(", "Update Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
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
