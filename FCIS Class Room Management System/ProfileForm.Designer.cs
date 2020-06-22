namespace FCIS_Class_Room_Management_System
{
    partial class ProfileForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.back_mainpage = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.data_update = new System.Windows.Forms.Button();
            this.pass_check = new System.Windows.Forms.CheckBox();
            this.repass_check = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.name = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.email = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.pass = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.re_pass = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.old_check = new System.Windows.Forms.CheckBox();
            this.old_pass = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.minimize = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.panel2.Controls.Add(this.minimize);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.back_mainpage);
            this.panel2.Controls.Add(this.logout);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 65);
            this.panel2.TabIndex = 3;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(8, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Management System.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(6, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 23);
            this.label7.TabIndex = 9;
            this.label7.Text = "FCIS Class Room ْ";
            // 
            // back_mainpage
            // 
            this.back_mainpage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.back_mainpage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_mainpage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_mainpage.ForeColor = System.Drawing.Color.White;
            this.back_mainpage.Location = new System.Drawing.Point(688, 11);
            this.back_mainpage.Name = "back_mainpage";
            this.back_mainpage.Size = new System.Drawing.Size(136, 42);
            this.back_mainpage.TabIndex = 7;
            this.back_mainpage.Text = "Back to MainPage";
            this.back_mainpage.UseVisualStyleBackColor = true;
            this.back_mainpage.Click += new System.EventHandler(this.back_mainpage_Click);
            // 
            // logout
            // 
            this.logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.Color.White;
            this.logout.Location = new System.Drawing.Point(832, 11);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(104, 42);
            this.logout.TabIndex = 7;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Full name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 2);
            this.panel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(29, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(597, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enter your new password";
            // 
            // data_update
            // 
            this.data_update.BackColor = System.Drawing.Color.Black;
            this.data_update.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.data_update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.data_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.data_update.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_update.ForeColor = System.Drawing.Color.White;
            this.data_update.Location = new System.Drawing.Point(860, 498);
            this.data_update.Name = "data_update";
            this.data_update.Size = new System.Drawing.Size(95, 46);
            this.data_update.TabIndex = 8;
            this.data_update.Text = "Save";
            this.data_update.UseVisualStyleBackColor = false;
            this.data_update.Click += new System.EventHandler(this.data_update_Click);
            // 
            // pass_check
            // 
            this.pass_check.AutoSize = true;
            this.pass_check.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_check.ForeColor = System.Drawing.Color.White;
            this.pass_check.Location = new System.Drawing.Point(915, 305);
            this.pass_check.Name = "pass_check";
            this.pass_check.Size = new System.Drawing.Size(57, 20);
            this.pass_check.TabIndex = 24;
            this.pass_check.Text = "Show";
            this.pass_check.UseVisualStyleBackColor = true;
            this.pass_check.CheckedChanged += new System.EventHandler(this.pass_check_CheckedChanged);
            // 
            // repass_check
            // 
            this.repass_check.AutoSize = true;
            this.repass_check.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repass_check.ForeColor = System.Drawing.Color.White;
            this.repass_check.Location = new System.Drawing.Point(915, 421);
            this.repass_check.Name = "repass_check";
            this.repass_check.Size = new System.Drawing.Size(57, 20);
            this.repass_check.TabIndex = 25;
            this.repass_check.Text = "Show";
            this.repass_check.UseVisualStyleBackColor = true;
            this.repass_check.CheckedChanged += new System.EventHandler(this.repass_check_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(597, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Comfirm your password";
            // 
            // name
            // 
            this.name.BorderColorFocused = System.Drawing.Color.Silver;
            this.name.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.name.BorderColorMouseHover = System.Drawing.Color.Silver;
            this.name.BorderThickness = 3;
            this.name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.name.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.name.ForeColor = System.Drawing.Color.Silver;
            this.name.isPassword = false;
            this.name.Location = new System.Drawing.Point(33, 180);
            this.name.Margin = new System.Windows.Forms.Padding(4);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(324, 44);
            this.name.TabIndex = 28;
            this.name.Text = "Edit your name";
            this.name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.name.MouseClick += new System.Windows.Forms.MouseEventHandler(this.name_MouseClick);
            // 
            // email
            // 
            this.email.BorderColorFocused = System.Drawing.Color.Silver;
            this.email.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.email.BorderColorMouseHover = System.Drawing.Color.Silver;
            this.email.BorderThickness = 3;
            this.email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.email.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.email.ForeColor = System.Drawing.Color.Silver;
            this.email.isPassword = false;
            this.email.Location = new System.Drawing.Point(33, 360);
            this.email.Margin = new System.Windows.Forms.Padding(4);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(324, 44);
            this.email.TabIndex = 28;
            this.email.Text = "Type your New Email";
            this.email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.email.MouseClick += new System.Windows.Forms.MouseEventHandler(this.email_MouseClick);
            // 
            // pass
            // 
            this.pass.BorderColorFocused = System.Drawing.Color.Silver;
            this.pass.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pass.BorderColorMouseHover = System.Drawing.Color.Silver;
            this.pass.BorderThickness = 3;
            this.pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.pass.ForeColor = System.Drawing.Color.Silver;
            this.pass.isPassword = true;
            this.pass.Location = new System.Drawing.Point(601, 289);
            this.pass.Margin = new System.Windows.Forms.Padding(4);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(276, 44);
            this.pass.TabIndex = 29;
            this.pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.pass.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pass_MouseClick);
            // 
            // re_pass
            // 
            this.re_pass.BorderColorFocused = System.Drawing.Color.Silver;
            this.re_pass.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.re_pass.BorderColorMouseHover = System.Drawing.Color.Silver;
            this.re_pass.BorderThickness = 3;
            this.re_pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.re_pass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.re_pass.ForeColor = System.Drawing.Color.Silver;
            this.re_pass.isPassword = true;
            this.re_pass.Location = new System.Drawing.Point(601, 406);
            this.re_pass.Margin = new System.Windows.Forms.Padding(4);
            this.re_pass.Name = "re_pass";
            this.re_pass.Size = new System.Drawing.Size(276, 44);
            this.re_pass.TabIndex = 29;
            this.re_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.re_pass.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.re_pass_MouseDoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(597, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Old password";
            // 
            // old_check
            // 
            this.old_check.AutoSize = true;
            this.old_check.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.old_check.ForeColor = System.Drawing.Color.White;
            this.old_check.Location = new System.Drawing.Point(915, 194);
            this.old_check.Name = "old_check";
            this.old_check.Size = new System.Drawing.Size(57, 20);
            this.old_check.TabIndex = 24;
            this.old_check.Text = "Show";
            this.old_check.UseVisualStyleBackColor = true;
            this.old_check.CheckedChanged += new System.EventHandler(this.old_check_CheckedChanged);
            // 
            // old_pass
            // 
            this.old_pass.BorderColorFocused = System.Drawing.Color.Silver;
            this.old_pass.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.old_pass.BorderColorMouseHover = System.Drawing.Color.Silver;
            this.old_pass.BorderThickness = 3;
            this.old_pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.old_pass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.old_pass.ForeColor = System.Drawing.Color.Silver;
            this.old_pass.isPassword = true;
            this.old_pass.Location = new System.Drawing.Point(601, 178);
            this.old_pass.Margin = new System.Windows.Forms.Padding(4);
            this.old_pass.Name = "old_pass";
            this.old_pass.Size = new System.Drawing.Size(276, 44);
            this.old_pass.TabIndex = 29;
            this.old_pass.Text = "12345678";
            this.old_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.old_pass.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pass_MouseClick);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // minimize
            // 
            this.minimize.FlatAppearance.BorderSize = 0;
            this.minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minimize.ForeColor = System.Drawing.Color.White;
            this.minimize.Location = new System.Drawing.Point(942, 19);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(30, 28);
            this.minimize.TabIndex = 10;
            this.minimize.Text = "ـــــــــــــ";
            this.minimize.UseVisualStyleBackColor = true;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(984, 566);
            this.Controls.Add(this.re_pass);
            this.Controls.Add(this.old_pass);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.email);
            this.Controls.Add(this.name);
            this.Controls.Add(this.repass_check);
            this.Controls.Add(this.old_check);
            this.Controls.Add(this.pass_check);
            this.Controls.Add(this.data_update);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProfileForm";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProfileForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button back_mainpage;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button data_update;
        private System.Windows.Forms.CheckBox pass_check;
        private System.Windows.Forms.CheckBox repass_check;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMetroTextbox name;
        private Bunifu.Framework.UI.BunifuMetroTextbox email;
        private Bunifu.Framework.UI.BunifuMetroTextbox pass;
        private Bunifu.Framework.UI.BunifuMetroTextbox re_pass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox old_check;
        private Bunifu.Framework.UI.BunifuMetroTextbox old_pass;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Button minimize;
    }
}