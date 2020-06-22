namespace FCIS_Class_Room_Management_System
{
    partial class ManageResourcesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageResourcesForm));
            this.Exit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.view_res = new System.Windows.Forms.Button();
            this.add_new = new System.Windows.Forms.Button();
            this.work_panel = new System.Windows.Forms.Panel();
            this.panel_trans = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.minimize = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.panel_trans.SetDecoration(this.Exit, BunifuAnimatorNS.DecorationType.None);
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(583, 4);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(27, 28);
            this.Exit.TabIndex = 6;
            this.Exit.Text = "X";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.minimize);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Exit);
            this.panel_trans.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(619, 36);
            this.panel1.TabIndex = 7;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.panel_trans.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Resources";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.view_res);
            this.panel2.Controls.Add(this.add_new);
            this.panel_trans.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 355);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(619, 49);
            this.panel2.TabIndex = 8;
            // 
            // view_res
            // 
            this.panel_trans.SetDecoration(this.view_res, BunifuAnimatorNS.DecorationType.None);
            this.view_res.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.view_res.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.view_res.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_res.ForeColor = System.Drawing.Color.White;
            this.view_res.Location = new System.Drawing.Point(334, 9);
            this.view_res.Name = "view_res";
            this.view_res.Size = new System.Drawing.Size(104, 31);
            this.view_res.TabIndex = 10;
            this.view_res.Text = "View All";
            this.view_res.UseVisualStyleBackColor = true;
            this.view_res.Click += new System.EventHandler(this.view_res_Click);
            // 
            // add_new
            // 
            this.panel_trans.SetDecoration(this.add_new, BunifuAnimatorNS.DecorationType.None);
            this.add_new.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.add_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_new.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.add_new.ForeColor = System.Drawing.Color.White;
            this.add_new.Location = new System.Drawing.Point(157, 9);
            this.add_new.Name = "add_new";
            this.add_new.Size = new System.Drawing.Size(104, 31);
            this.add_new.TabIndex = 10;
            this.add_new.Text = "Add New";
            this.add_new.UseVisualStyleBackColor = true;
            this.add_new.Click += new System.EventHandler(this.back_home_Click);
            // 
            // work_panel
            // 
            this.work_panel.AutoScroll = true;
            this.work_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_trans.SetDecoration(this.work_panel, BunifuAnimatorNS.DecorationType.None);
            this.work_panel.Location = new System.Drawing.Point(0, 36);
            this.work_panel.Name = "work_panel";
            this.work_panel.Size = new System.Drawing.Size(619, 319);
            this.work_panel.TabIndex = 9;
            this.work_panel.Visible = false;
            // 
            // panel_trans
            // 
            this.panel_trans.AnimationType = BunifuAnimatorNS.AnimationType.VertBlind;
            this.panel_trans.Cursor = null;
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
            this.panel_trans.DefaultAnimation = animation1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel_trans.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 36);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(619, 1);
            this.panel3.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel_trans.SetDecoration(this.panel4, BunifuAnimatorNS.DecorationType.None);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 354);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(619, 1);
            this.panel4.TabIndex = 11;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // minimize
            // 
            this.panel_trans.SetDecoration(this.minimize, BunifuAnimatorNS.DecorationType.None);
            this.minimize.FlatAppearance.BorderSize = 0;
            this.minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minimize.ForeColor = System.Drawing.Color.White;
            this.minimize.Location = new System.Drawing.Point(547, 4);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(30, 28);
            this.minimize.TabIndex = 7;
            this.minimize.Text = "ـــــــــــــ";
            this.minimize.UseVisualStyleBackColor = true;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // ManageResourcesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(619, 404);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.work_panel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.panel_trans.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageResourcesForm";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageResourcesForm";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button view_res;
        private System.Windows.Forms.Button add_new;
        private System.Windows.Forms.Panel work_panel;
        private BunifuAnimatorNS.BunifuTransition panel_trans;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Button minimize;
    }
}