namespace DM
{
    partial class Form_AddOrEdit_roles
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_roles_notes = new System.Windows.Forms.TextBox();
            this.textBox_roles_rolename = new System.Windows.Forms.TextBox();
            this.btn_roles_save = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_roles_save);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox_roles_notes);
            this.panel1.Controls.Add(this.textBox_roles_rolename);
            this.panel1.Location = new System.Drawing.Point(52, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 388);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "备注";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "角色名:";
            // 
            // textBox_roles_notes
            // 
            this.textBox_roles_notes.Location = new System.Drawing.Point(183, 98);
            this.textBox_roles_notes.Multiline = true;
            this.textBox_roles_notes.Name = "textBox_roles_notes";
            this.textBox_roles_notes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_roles_notes.Size = new System.Drawing.Size(200, 180);
            this.textBox_roles_notes.TabIndex = 1;
            // 
            // textBox_roles_rolename
            // 
            this.textBox_roles_rolename.Location = new System.Drawing.Point(183, 38);
            this.textBox_roles_rolename.Name = "textBox_roles_rolename";
            this.textBox_roles_rolename.Size = new System.Drawing.Size(200, 28);
            this.textBox_roles_rolename.TabIndex = 0;
            // 
            // btn_roles_save
            // 
            this.btn_roles_save.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btn_roles_save.Location = new System.Drawing.Point(292, 319);
            this.btn_roles_save.Name = "btn_roles_save";
            this.btn_roles_save.Size = new System.Drawing.Size(91, 41);
            this.btn_roles_save.TabIndex = 12;
            this.btn_roles_save.Text = "保存";
            // 
            // Form_AddOrEdit_roles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 512);
            this.Controls.Add(this.panel1);
            this.Name = "Form_AddOrEdit_roles";
            this.Text = "角色表_新增/编辑";
            this.Load += new System.EventHandler(this.Form_AddOrEdit_roles_Load);
            this.Resize += new System.EventHandler(this.Form_AddOrEdit_roles_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_roles_notes;
        private System.Windows.Forms.TextBox textBox_roles_rolename;
        private DevExpress.XtraEditors.SimpleButton btn_roles_save;
    }
}