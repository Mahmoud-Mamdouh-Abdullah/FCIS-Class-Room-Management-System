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
    public partial class RegisterForm : Form
    {
        int mov;
        int movX;
        int movY;
        // string ordp = ;
        OracleConnection conn = new OracleConnection("Data source=orcl;User Id=scott; Password=tiger;");
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void back_home_Click(object sender, EventArgs e)
        {
            StartPage home = new StartPage();
            this.Hide();
            home.Show();
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

        private void name_MouseClick(object sender, MouseEventArgs e)
        {
            if(name.ForeColor != Color.White)
            {
                name.ForeColor = Color.White;
                name.Text = "";
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

        private void re_pass_MouseClick(object sender, MouseEventArgs e)
        {
            if (re_pass.ForeColor != Color.White)
            {
                re_pass.ForeColor = Color.White;
                re_pass.Text = "";
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

        private void pass_check_CheckedChanged(object sender, EventArgs e)
        {
            if (pass_check.Checked)
            {
                pass.isPassword = false;
            }
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

        private void register_btn_Click(object sender, EventArgs e)
        {
            Registeration_process();
        }

        private void Registeration_process()
        {
            string FullName = name.Text;
            string Pass = pass.Text;
            string Re_Pass = re_pass.Text;
            string Email = email.Text.ToLower();
            string Gender = gender.SelectedItem.ToString();
            string Type = type.SelectedItem.ToString();
            DataBaseModel classroom = new DataBaseModel();
            int ans = classroom.Registeration(FullName, Pass, Re_Pass, Email, Gender, Type);

            if (ans == -1)
            {
                pass.Text = "";
                re_pass.Text = "";
                MessageBox.Show("Re-Enter your Password Again","Registerarion",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if (ans == 1)
            {
                MessageBox.Show("Registeration Successfully", "Registerarion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                name.Text = "";
                pass.Text = "";
                re_pass.Text = "";
                email.Text = "";
            }
            else
            {
                MessageBox.Show("This E-mail is Already Exist !!", "Registerarion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                email.Text = "";
            }
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
