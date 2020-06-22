namespace FCIS_Class_Room_Management_System
{
    partial class AddCourseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCourseForm));
            this.confirm = new System.Windows.Forms.Button();
            this.course_sub = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.course_name = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // confirm
            // 
            this.confirm.BackColor = System.Drawing.Color.Black;
            this.confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm.ForeColor = System.Drawing.Color.White;
            this.confirm.Location = new System.Drawing.Point(293, 373);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(189, 40);
            this.confirm.TabIndex = 19;
            this.confirm.Text = "Confirm";
            this.confirm.UseVisualStyleBackColor = false;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // course_sub
            // 
            this.course_sub.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.course_sub.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.course_sub.ForeColor = System.Drawing.Color.White;
            this.course_sub.HintForeColor = System.Drawing.Color.Silver;
            this.course_sub.HintText = "Type Course Subject";
            this.course_sub.isPassword = false;
            this.course_sub.LineFocusedColor = System.Drawing.Color.Silver;
            this.course_sub.LineIdleColor = System.Drawing.Color.Gray;
            this.course_sub.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.course_sub.LineThickness = 4;
            this.course_sub.Location = new System.Drawing.Point(293, 284);
            this.course_sub.Margin = new System.Windows.Forms.Padding(4);
            this.course_sub.Name = "course_sub";
            this.course_sub.Size = new System.Drawing.Size(290, 44);
            this.course_sub.TabIndex = 17;
            this.course_sub.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(155, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Course Subject";
            // 
            // course_name
            // 
            this.course_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.course_name.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.course_name.ForeColor = System.Drawing.Color.White;
            this.course_name.HintForeColor = System.Drawing.Color.Silver;
            this.course_name.HintText = "Type Course Name";
            this.course_name.isPassword = false;
            this.course_name.LineFocusedColor = System.Drawing.Color.Silver;
            this.course_name.LineIdleColor = System.Drawing.Color.Gray;
            this.course_name.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.course_name.LineThickness = 4;
            this.course_name.Location = new System.Drawing.Point(293, 185);
            this.course_name.Margin = new System.Windows.Forms.Padding(4);
            this.course_name.Name = "course_name";
            this.course_name.Size = new System.Drawing.Size(290, 40);
            this.course_name.TabIndex = 18;
            this.course_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(155, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "Course Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(249, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(269, 28);
            this.label4.TabIndex = 14;
            this.label4.Text = "Adding a New Course";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(155, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "Enter your Course Info";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(432, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "All fields are required";
            // 
            // AddCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(739, 459);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.course_sub);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.course_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddCourseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCourseForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button confirm;
        private Bunifu.Framework.UI.BunifuMaterialTextbox course_sub;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox course_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
    }
}