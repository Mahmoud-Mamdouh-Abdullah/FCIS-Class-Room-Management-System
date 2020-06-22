namespace FCIS_Class_Room_Management_System
{
    partial class AddResourceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddResourceForm));
            this.label4 = new System.Windows.Forms.Label();
            this.confirm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.res_name = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.res_link = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(179, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 23);
            this.label4.TabIndex = 15;
            this.label4.Text = "Adding a New Course";
            // 
            // confirm
            // 
            this.confirm.BackColor = System.Drawing.Color.Black;
            this.confirm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm.ForeColor = System.Drawing.Color.White;
            this.confirm.Location = new System.Drawing.Point(222, 273);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(154, 40);
            this.confirm.TabIndex = 20;
            this.confirm.Text = "Confirm";
            this.confirm.UseVisualStyleBackColor = false;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "Resource Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(150, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Resource Link";
            // 
            // res_name
            // 
            this.res_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.res_name.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.res_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.res_name.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.res_name.HintText = "Type the Resource Name";
            this.res_name.isPassword = false;
            this.res_name.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.res_name.LineIdleColor = System.Drawing.Color.Black;
            this.res_name.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.res_name.LineThickness = 3;
            this.res_name.Location = new System.Drawing.Point(153, 110);
            this.res_name.Margin = new System.Windows.Forms.Padding(4);
            this.res_name.Name = "res_name";
            this.res_name.Size = new System.Drawing.Size(297, 41);
            this.res_name.TabIndex = 22;
            this.res_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // res_link
            // 
            this.res_link.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.res_link.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.res_link.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.res_link.HintForeColor = System.Drawing.Color.Empty;
            this.res_link.HintText = "Type the Resource Link";
            this.res_link.isPassword = false;
            this.res_link.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.res_link.LineIdleColor = System.Drawing.Color.Black;
            this.res_link.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.res_link.LineThickness = 3;
            this.res_link.Location = new System.Drawing.Point(153, 209);
            this.res_link.Margin = new System.Windows.Forms.Padding(4);
            this.res_link.Name = "res_link";
            this.res_link.Size = new System.Drawing.Size(297, 40);
            this.res_link.TabIndex = 23;
            this.res_link.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // AddResourceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(619, 325);
            this.Controls.Add(this.res_link);
            this.Controls.Add(this.res_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddResourceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddResourceForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox res_name;
        private Bunifu.Framework.UI.BunifuMaterialTextbox res_link;
    }
}