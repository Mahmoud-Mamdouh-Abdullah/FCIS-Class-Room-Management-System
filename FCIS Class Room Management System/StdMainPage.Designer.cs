namespace FCIS_Class_Room_Management_System
{
    partial class StdMainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StdMainPage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.setting = new System.Windows.Forms.Button();
            this.menu_btn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.gen_rep2 = new System.Windows.Forms.Button();
            this.view_id = new System.Windows.Forms.Button();
            this.view_my = new System.Windows.Forms.Button();
            this.view_all = new System.Windows.Forms.Button();
            this.menu_trans = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.ShowMenuPanel = new System.Windows.Forms.Panel();
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
            this.panel1.Controls.Add(this.menu_btn);
            this.panel1.Controls.Add(this.panel3);
            this.menu_trans.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(51, 566);
            this.panel1.TabIndex = 1;
            // 
            // setting
            // 
            this.menu_trans.SetDecoration(this.setting, BunifuAnimatorNS.DecorationType.None);
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
            // menu_btn
            // 
            this.menu_trans.SetDecoration(this.menu_btn, BunifuAnimatorNS.DecorationType.None);
            this.menu_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu_btn.FlatAppearance.BorderSize = 0;
            this.menu_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu_btn.Image = ((System.Drawing.Image)(resources.GetObject("menu_btn.Image")));
            this.menu_btn.Location = new System.Drawing.Point(0, 65);
            this.menu_btn.Name = "menu_btn";
            this.menu_btn.Size = new System.Drawing.Size(51, 38);
            this.menu_btn.TabIndex = 2;
            this.menu_btn.UseVisualStyleBackColor = true;
            this.menu_btn.Click += new System.EventHandler(this.menu_btn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
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
            this.panel2.Controls.Add(this.logout);
            this.menu_trans.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(51, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(933, 65);
            this.panel2.TabIndex = 2;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.menu_trans.SetDecoration(this.label6, BunifuAnimatorNS.DecorationType.None);
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
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(6, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 23);
            this.label7.TabIndex = 9;
            this.label7.Text = "FCIS Class Room ْ";
            // 
            // logout
            // 
            this.menu_trans.SetDecoration(this.logout, BunifuAnimatorNS.DecorationType.None);
            this.logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.Color.White;
            this.logout.Location = new System.Drawing.Point(781, 12);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(104, 42);
            this.logout.TabIndex = 7;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.gen_rep2);
            this.panel4.Controls.Add(this.view_id);
            this.panel4.Controls.Add(this.view_my);
            this.panel4.Controls.Add(this.view_all);
            this.menu_trans.SetDecoration(this.panel4, BunifuAnimatorNS.DecorationType.None);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(51, 65);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(182, 501);
            this.panel4.TabIndex = 3;
            this.panel4.Visible = false;
            // 
            // button2
            // 
            this.menu_trans.SetDecoration(this.button2, BunifuAnimatorNS.DecorationType.None);
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 204);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 51);
            this.button2.TabIndex = 7;
            this.button2.Text = "Help";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // gen_rep2
            // 
            this.menu_trans.SetDecoration(this.gen_rep2, BunifuAnimatorNS.DecorationType.None);
            this.gen_rep2.Dock = System.Windows.Forms.DockStyle.Top;
            this.gen_rep2.FlatAppearance.BorderSize = 0;
            this.gen_rep2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gen_rep2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gen_rep2.ForeColor = System.Drawing.Color.White;
            this.gen_rep2.Location = new System.Drawing.Point(0, 153);
            this.gen_rep2.Name = "gen_rep2";
            this.gen_rep2.Size = new System.Drawing.Size(182, 51);
            this.gen_rep2.TabIndex = 7;
            this.gen_rep2.Text = "Generate Instructors Report";
            this.gen_rep2.UseVisualStyleBackColor = true;
            this.gen_rep2.Click += new System.EventHandler(this.gen_rep2_Click);
            // 
            // view_id
            // 
            this.menu_trans.SetDecoration(this.view_id, BunifuAnimatorNS.DecorationType.None);
            this.view_id.Dock = System.Windows.Forms.DockStyle.Top;
            this.view_id.FlatAppearance.BorderSize = 0;
            this.view_id.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.view_id.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_id.ForeColor = System.Drawing.Color.White;
            this.view_id.Location = new System.Drawing.Point(0, 102);
            this.view_id.Name = "view_id";
            this.view_id.Size = new System.Drawing.Size(182, 51);
            this.view_id.TabIndex = 7;
            this.view_id.Text = "View By ID";
            this.view_id.UseVisualStyleBackColor = true;
            this.view_id.Click += new System.EventHandler(this.view_id_Click);
            // 
            // view_my
            // 
            this.menu_trans.SetDecoration(this.view_my, BunifuAnimatorNS.DecorationType.None);
            this.view_my.Dock = System.Windows.Forms.DockStyle.Top;
            this.view_my.FlatAppearance.BorderSize = 0;
            this.view_my.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.view_my.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_my.ForeColor = System.Drawing.Color.White;
            this.view_my.Location = new System.Drawing.Point(0, 51);
            this.view_my.Name = "view_my";
            this.view_my.Size = new System.Drawing.Size(182, 51);
            this.view_my.TabIndex = 5;
            this.view_my.Text = "View My Courses";
            this.view_my.UseVisualStyleBackColor = true;
            this.view_my.Click += new System.EventHandler(this.view_my_Click);
            // 
            // view_all
            // 
            this.menu_trans.SetDecoration(this.view_all, BunifuAnimatorNS.DecorationType.None);
            this.view_all.Dock = System.Windows.Forms.DockStyle.Top;
            this.view_all.FlatAppearance.BorderSize = 0;
            this.view_all.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.view_all.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_all.ForeColor = System.Drawing.Color.White;
            this.view_all.Location = new System.Drawing.Point(0, 0);
            this.view_all.Name = "view_all";
            this.view_all.Size = new System.Drawing.Size(182, 51);
            this.view_all.TabIndex = 3;
            this.view_all.Text = "View All Courses";
            this.view_all.UseVisualStyleBackColor = true;
            this.view_all.Click += new System.EventHandler(this.view_all_Click);
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
            this.menu_trans.SetDecoration(this.panel5, BunifuAnimatorNS.DecorationType.None);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(233, 65);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(751, 2);
            this.panel5.TabIndex = 4;
            // 
            // ShowMenuPanel
            // 
            this.ShowMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.menu_trans.SetDecoration(this.ShowMenuPanel, BunifuAnimatorNS.DecorationType.None);
            this.ShowMenuPanel.Location = new System.Drawing.Point(233, 68);
            this.ShowMenuPanel.Name = "ShowMenuPanel";
            this.ShowMenuPanel.Size = new System.Drawing.Size(751, 500);
            this.ShowMenuPanel.TabIndex = 5;
            this.ShowMenuPanel.Visible = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // minimize
            // 
            this.menu_trans.SetDecoration(this.minimize, BunifuAnimatorNS.DecorationType.None);
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
            // StdMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(984, 566);
            this.Controls.Add(this.ShowMenuPanel);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.menu_trans.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StdMainPage";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StdMainPage";
            this.Load += new System.EventHandler(this.StdMainPage_Load);
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
        private System.Windows.Forms.Button setting;
        private System.Windows.Forms.Button menu_btn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button view_id;
        private System.Windows.Forms.Button view_my;
        private System.Windows.Forms.Button view_all;
        private BunifuAnimatorNS.BunifuTransition menu_trans;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel ShowMenuPanel;
        private System.Windows.Forms.Button gen_rep2;
        private System.Windows.Forms.Button button2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Button minimize;

    }
}