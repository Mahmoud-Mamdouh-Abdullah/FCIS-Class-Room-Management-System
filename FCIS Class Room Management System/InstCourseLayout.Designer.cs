namespace FCIS_Class_Room_Management_System
{
    partial class InstCourseLayout
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.manageBTN = new System.Windows.Forms.Button();
            this.deleteBTN = new System.Windows.Forms.Button();
            this.subjectNamelbl = new System.Windows.Forms.Label();
            this.Course_ID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.courseNamelbl = new System.Windows.Forms.Label();
            this.report = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.report);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.manageBTN);
            this.panel1.Controls.Add(this.deleteBTN);
            this.panel1.Controls.Add(this.subjectNamelbl);
            this.panel1.Controls.Add(this.Course_ID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.courseNamelbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 80);
            this.panel1.TabIndex = 0;
            this.panel1.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            this.panel1.MouseHover += new System.EventHandler(this.panel1_MouseHover);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(42, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 80);
            this.panel3.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 79);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(700, 1);
            this.panel2.TabIndex = 8;
            // 
            // manageBTN
            // 
            this.manageBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.manageBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageBTN.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageBTN.ForeColor = System.Drawing.Color.White;
            this.manageBTN.Location = new System.Drawing.Point(566, 26);
            this.manageBTN.Name = "manageBTN";
            this.manageBTN.Size = new System.Drawing.Size(126, 30);
            this.manageBTN.TabIndex = 5;
            this.manageBTN.Text = "Manage Resources";
            this.manageBTN.UseVisualStyleBackColor = false;
            this.manageBTN.Click += new System.EventHandler(this.manageBTN_Click);
            this.manageBTN.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // deleteBTN
            // 
            this.deleteBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.deleteBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBTN.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBTN.ForeColor = System.Drawing.Color.White;
            this.deleteBTN.Location = new System.Drawing.Point(477, 26);
            this.deleteBTN.Name = "deleteBTN";
            this.deleteBTN.Size = new System.Drawing.Size(83, 30);
            this.deleteBTN.TabIndex = 6;
            this.deleteBTN.Text = "Delete";
            this.deleteBTN.UseVisualStyleBackColor = false;
            this.deleteBTN.Click += new System.EventHandler(this.deleteBTN_Click);
            this.deleteBTN.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // subjectNamelbl
            // 
            this.subjectNamelbl.AutoSize = true;
            this.subjectNamelbl.BackColor = System.Drawing.Color.Transparent;
            this.subjectNamelbl.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectNamelbl.Location = new System.Drawing.Point(132, 48);
            this.subjectNamelbl.Name = "subjectNamelbl";
            this.subjectNamelbl.Size = new System.Drawing.Size(138, 19);
            this.subjectNamelbl.TabIndex = 2;
            this.subjectNamelbl.Text = "Computer Science";
            this.subjectNamelbl.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // Course_ID
            // 
            this.Course_ID.AutoSize = true;
            this.Course_ID.BackColor = System.Drawing.Color.Transparent;
            this.Course_ID.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Course_ID.Location = new System.Drawing.Point(4, 21);
            this.Course_ID.Name = "Course_ID";
            this.Course_ID.Size = new System.Drawing.Size(39, 30);
            this.Course_ID.TabIndex = 3;
            this.Course_ID.Text = "01";
            this.Course_ID.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Subject : ";
            this.label2.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // courseNamelbl
            // 
            this.courseNamelbl.AutoSize = true;
            this.courseNamelbl.BackColor = System.Drawing.Color.Transparent;
            this.courseNamelbl.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseNamelbl.Location = new System.Drawing.Point(56, 14);
            this.courseNamelbl.Name = "courseNamelbl";
            this.courseNamelbl.Size = new System.Drawing.Size(313, 23);
            this.courseNamelbl.TabIndex = 4;
            this.courseNamelbl.Text = "Algorithms analysis and Design";
            this.courseNamelbl.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // report
            // 
            this.report.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.report.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.report.ForeColor = System.Drawing.Color.White;
            this.report.Location = new System.Drawing.Point(405, 26);
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(66, 30);
            this.report.TabIndex = 14;
            this.report.Text = "Report";
            this.report.UseVisualStyleBackColor = false;
            this.report.Click += new System.EventHandler(this.report_Click);
            // 
            // InstCourseLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Name = "InstCourseLayout";
            this.Size = new System.Drawing.Size(700, 80);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button manageBTN;
        private System.Windows.Forms.Button deleteBTN;
        private System.Windows.Forms.Label subjectNamelbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label courseNamelbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Course_ID;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button report;
    }
}
