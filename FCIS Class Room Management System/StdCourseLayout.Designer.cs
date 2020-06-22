namespace FCIS_Class_Room_Management_System
{
    partial class StdCourseLayout
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Course_ID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.course_name = new System.Windows.Forms.Label();
            this.sub_name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inst_name = new System.Windows.Forms.Label();
            this.show_res = new System.Windows.Forms.Button();
            this.enroll_btn = new System.Windows.Forms.Button();
            this.report = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Course ID";
            // 
            // Course_ID
            // 
            this.Course_ID.AutoSize = true;
            this.Course_ID.BackColor = System.Drawing.Color.Transparent;
            this.Course_ID.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Course_ID.Location = new System.Drawing.Point(15, 37);
            this.Course_ID.Name = "Course_ID";
            this.Course_ID.Size = new System.Drawing.Size(39, 30);
            this.Course_ID.TabIndex = 7;
            this.Course_ID.Text = "01";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(76, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 87);
            this.panel1.TabIndex = 8;
            // 
            // course_name
            // 
            this.course_name.AutoSize = true;
            this.course_name.BackColor = System.Drawing.Color.Transparent;
            this.course_name.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.course_name.Location = new System.Drawing.Point(94, 12);
            this.course_name.Name = "course_name";
            this.course_name.Size = new System.Drawing.Size(313, 23);
            this.course_name.TabIndex = 9;
            this.course_name.Text = "Algorithms analysis and Design";
            // 
            // sub_name
            // 
            this.sub_name.AutoSize = true;
            this.sub_name.BackColor = System.Drawing.Color.Transparent;
            this.sub_name.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub_name.Location = new System.Drawing.Point(170, 37);
            this.sub_name.Name = "sub_name";
            this.sub_name.Size = new System.Drawing.Size(138, 19);
            this.sub_name.TabIndex = 10;
            this.sub_name.Text = "Computer Science";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Subject : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(96, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Instructor : ";
            // 
            // inst_name
            // 
            this.inst_name.AutoSize = true;
            this.inst_name.BackColor = System.Drawing.Color.Transparent;
            this.inst_name.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inst_name.Location = new System.Drawing.Point(179, 60);
            this.inst_name.Name = "inst_name";
            this.inst_name.Size = new System.Drawing.Size(99, 17);
            this.inst_name.TabIndex = 10;
            this.inst_name.Text = "Ahmed Salah";
            // 
            // show_res
            // 
            this.show_res.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.show_res.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.show_res.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_res.ForeColor = System.Drawing.Color.White;
            this.show_res.Location = new System.Drawing.Point(578, 31);
            this.show_res.Name = "show_res";
            this.show_res.Size = new System.Drawing.Size(111, 30);
            this.show_res.TabIndex = 12;
            this.show_res.Text = "Show Resources";
            this.show_res.UseVisualStyleBackColor = false;
            this.show_res.Click += new System.EventHandler(this.show_res_Click);
            // 
            // enroll_btn
            // 
            this.enroll_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.enroll_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enroll_btn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enroll_btn.ForeColor = System.Drawing.Color.White;
            this.enroll_btn.Location = new System.Drawing.Point(496, 31);
            this.enroll_btn.Name = "enroll_btn";
            this.enroll_btn.Size = new System.Drawing.Size(76, 30);
            this.enroll_btn.TabIndex = 13;
            this.enroll_btn.Text = "Enroll In";
            this.enroll_btn.UseVisualStyleBackColor = false;
            this.enroll_btn.Click += new System.EventHandler(this.enroll_Click);
            // 
            // report
            // 
            this.report.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.report.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.report.ForeColor = System.Drawing.Color.White;
            this.report.Location = new System.Drawing.Point(424, 31);
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(66, 30);
            this.report.TabIndex = 13;
            this.report.Text = "Report";
            this.report.UseVisualStyleBackColor = false;
            this.report.Visible = false;
            this.report.Click += new System.EventHandler(this.report_Click);
            // 
            // StdCourseLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.show_res);
            this.Controls.Add(this.report);
            this.Controls.Add(this.enroll_btn);
            this.Controls.Add(this.inst_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sub_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.course_name);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Course_ID);
            this.Controls.Add(this.label1);
            this.Name = "StdCourseLayout";
            this.Size = new System.Drawing.Size(700, 87);
            this.Load += new System.EventHandler(this.StdCourseLayout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Course_ID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label course_name;
        private System.Windows.Forms.Label sub_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label inst_name;
        private System.Windows.Forms.Button show_res;
        private System.Windows.Forms.Button enroll_btn;
        private System.Windows.Forms.Button report;
    }
}
