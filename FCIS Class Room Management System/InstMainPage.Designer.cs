namespace FCIS_Class_Room_Management_System
{
    partial class InstMainPage
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstMainPage));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.panel1 = new System.Windows.Forms.Panel();
            this.setting = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.back_home = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.quick_view = new System.Windows.Forms.Button();
            this.view_all = new System.Windows.Forms.Button();
            this.add_course = new System.Windows.Forms.Button();
            this.menu_trans = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.ShowMenuPanel = new System.Windows.Forms.Panel();
            this.panel_trans = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.minimize = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.panel1.Controls.Add(this.setting);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel3);
            this.panel_trans.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.menu_trans.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(51, 566);
            this.panel1.TabIndex = 0;
            // 
            // setting
            // 
            this.menu_trans.SetDecoration(this.setting, BunifuAnimatorNS.DecorationType.None);
            this.panel_trans.SetDecoration(this.setting, BunifuAnimatorNS.DecorationType.None);
            this.setting.FlatAppearance.BorderSize = 0;
            this.setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setting.Image = ((System.Drawing.Image)(resources.GetObject("setting.Image")));
            this.setting.Location = new System.Drawing.Point(0, 112);
            this.setting.Name = "setting";
            this.setting.Size = new System.Drawing.Size(51, 38);
            this.setting.TabIndex = 3;
            this.setting.UseVisualStyleBackColor = true;
            this.setting.Click += new System.EventHandler(this.setting_Click);
            // 
            // button1
            // 
            this.menu_trans.SetDecoration(this.button1, BunifuAnimatorNS.DecorationType.None);
            this.panel_trans.SetDecoration(this.button1, BunifuAnimatorNS.DecorationType.None);
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(0, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 38);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel_trans.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.menu_trans.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(51, 65);
            this.panel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.menu_trans.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.panel_trans.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.panel2.Controls.Add(this.minimize);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.back_home);
            this.panel_trans.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.menu_trans.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(51, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(933, 65);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.menu_trans.SetDecoration(this.label6, BunifuAnimatorNS.DecorationType.None);
            this.panel_trans.SetDecoration(this.label6, BunifuAnimatorNS.DecorationType.None);
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
            this.menu_trans.SetDecoration(this.label7, BunifuAnimatorNS.DecorationType.None);
            this.panel_trans.SetDecoration(this.label7, BunifuAnimatorNS.DecorationType.None);
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(6, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 23);
            this.label7.TabIndex = 9;
            this.label7.Text = "FCIS Class Room ْ";
            // 
            // back_home
            // 
            this.menu_trans.SetDecoration(this.back_home, BunifuAnimatorNS.DecorationType.None);
            this.panel_trans.SetDecoration(this.back_home, BunifuAnimatorNS.DecorationType.None);
            this.back_home.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.back_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_home.ForeColor = System.Drawing.Color.White;
            this.back_home.Location = new System.Drawing.Point(781, 11);
            this.back_home.Name = "back_home";
            this.back_home.Size = new System.Drawing.Size(104, 42);
            this.back_home.TabIndex = 7;
            this.back_home.Text = "Logout";
            this.back_home.UseVisualStyleBackColor = true;
            this.back_home.Click += new System.EventHandler(this.back_home_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel4.Controls.Add(this.button5);
            this.panel4.Controls.Add(this.quick_view);
            this.panel4.Controls.Add(this.view_all);
            this.panel4.Controls.Add(this.add_course);
            this.panel_trans.SetDecoration(this.panel4, BunifuAnimatorNS.DecorationType.None);
            this.menu_trans.SetDecoration(this.panel4, BunifuAnimatorNS.DecorationType.None);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(51, 65);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(182, 501);
            this.panel4.TabIndex = 2;
            this.panel4.Visible = false;
            // 
            // button5
            // 
            this.menu_trans.SetDecoration(this.button5, BunifuAnimatorNS.DecorationType.None);
            this.panel_trans.SetDecoration(this.button5, BunifuAnimatorNS.DecorationType.None);
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(0, 153);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(182, 51);
            this.button5.TabIndex = 7;
            this.button5.Text = "Help";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // quick_view
            // 
            this.menu_trans.SetDecoration(this.quick_view, BunifuAnimatorNS.DecorationType.None);
            this.panel_trans.SetDecoration(this.quick_view, BunifuAnimatorNS.DecorationType.None);
            this.quick_view.Dock = System.Windows.Forms.DockStyle.Top;
            this.quick_view.FlatAppearance.BorderSize = 0;
            this.quick_view.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quick_view.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quick_view.ForeColor = System.Drawing.Color.White;
            this.quick_view.Location = new System.Drawing.Point(0, 102);
            this.quick_view.Name = "quick_view";
            this.quick_view.Size = new System.Drawing.Size(182, 51);
            this.quick_view.TabIndex = 6;
            this.quick_view.Text = "Quick View";
            this.quick_view.UseVisualStyleBackColor = true;
            this.quick_view.Click += new System.EventHandler(this.quick_view_Click);
            // 
            // view_all
            // 
            this.menu_trans.SetDecoration(this.view_all, BunifuAnimatorNS.DecorationType.None);
            this.panel_trans.SetDecoration(this.view_all, BunifuAnimatorNS.DecorationType.None);
            this.view_all.Dock = System.Windows.Forms.DockStyle.Top;
            this.view_all.FlatAppearance.BorderSize = 0;
            this.view_all.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.view_all.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_all.ForeColor = System.Drawing.Color.White;
            this.view_all.Location = new System.Drawing.Point(0, 51);
            this.view_all.Name = "view_all";
            this.view_all.Size = new System.Drawing.Size(182, 51);
            this.view_all.TabIndex = 5;
            this.view_all.Text = "View My Courses";
            this.view_all.UseVisualStyleBackColor = true;
            this.view_all.Click += new System.EventHandler(this.view_all_Click);
            // 
            // add_course
            // 
            this.menu_trans.SetDecoration(this.add_course, BunifuAnimatorNS.DecorationType.None);
            this.panel_trans.SetDecoration(this.add_course, BunifuAnimatorNS.DecorationType.None);
            this.add_course.Dock = System.Windows.Forms.DockStyle.Top;
            this.add_course.FlatAppearance.BorderSize = 0;
            this.add_course.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_course.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_course.ForeColor = System.Drawing.Color.White;
            this.add_course.Location = new System.Drawing.Point(0, 0);
            this.add_course.Name = "add_course";
            this.add_course.Size = new System.Drawing.Size(182, 51);
            this.add_course.TabIndex = 3;
            this.add_course.Text = "Add New Course";
            this.add_course.UseVisualStyleBackColor = true;
            this.add_course.Click += new System.EventHandler(this.add_course_Click);
            // 
            // menu_trans
            // 
            this.menu_trans.AnimationType = BunifuAnimatorNS.AnimationType.HorizBlind;
            this.menu_trans.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.menu_trans.DefaultAnimation = animation1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel_trans.SetDecoration(this.panel5, BunifuAnimatorNS.DecorationType.None);
            this.menu_trans.SetDecoration(this.panel5, BunifuAnimatorNS.DecorationType.None);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(233, 65);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(751, 2);
            this.panel5.TabIndex = 7;
            // 
            // ShowMenuPanel
            // 
            this.ShowMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.panel_trans.SetDecoration(this.ShowMenuPanel, BunifuAnimatorNS.DecorationType.None);
            this.menu_trans.SetDecoration(this.ShowMenuPanel, BunifuAnimatorNS.DecorationType.None);
            this.ShowMenuPanel.Location = new System.Drawing.Point(229, 65);
            this.ShowMenuPanel.Name = "ShowMenuPanel";
            this.ShowMenuPanel.Size = new System.Drawing.Size(755, 501);
            this.ShowMenuPanel.TabIndex = 3;
            this.ShowMenuPanel.Visible = false;
            // 
            // panel_trans
            // 
            this.panel_trans.AnimationType = BunifuAnimatorNS.AnimationType.HorizBlind;
            this.panel_trans.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.panel_trans.DefaultAnimation = animation2;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // minimize
            // 
            this.menu_trans.SetDecoration(this.minimize, BunifuAnimatorNS.DecorationType.None);
            this.panel_trans.SetDecoration(this.minimize, BunifuAnimatorNS.DecorationType.None);
            this.minimize.FlatAppearance.BorderSize = 0;
            this.minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minimize.ForeColor = System.Drawing.Color.White;
            this.minimize.Location = new System.Drawing.Point(891, 19);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(30, 28);
            this.minimize.TabIndex = 10;
            this.minimize.Text = "ـــــــــــــ";
            this.minimize.UseVisualStyleBackColor = true;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // InstMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(984, 566);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.ShowMenuPanel);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.menu_trans.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.panel_trans.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InstMainPage";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPage";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button back_home;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button quick_view;
        private System.Windows.Forms.Button view_all;
        private System.Windows.Forms.Button add_course;
        private BunifuAnimatorNS.BunifuTransition menu_trans;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button setting;
        private System.Windows.Forms.Panel panel5;
        private BunifuAnimatorNS.BunifuTransition panel_trans;
        private System.Windows.Forms.Panel ShowMenuPanel;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Button minimize;
    }
}