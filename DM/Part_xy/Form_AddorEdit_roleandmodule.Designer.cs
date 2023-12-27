namespace DM
{
    partial class Form_AddOrEdit_roleandmodule
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
            this.textBox_roleandmodule_idt_modules = new System.Windows.Forms.TextBox();
            this.btn_roleandmodule_save = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_roleandmodule_idt_roles = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBox_roleandmodule_idt_modules);
            this.panel1.Controls.Add(this.btn_roleandmodule_save);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox_roleandmodule_idt_roles);
            this.panel1.Location = new System.Drawing.Point(68, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 240);
            this.panel1.TabIndex = 3;
            // 
            // textBox_roleandmodule_idt_modules
            // 
            this.textBox_roleandmodule_idt_modules.Location = new System.Drawing.Point(183, 98);
            this.textBox_roleandmodule_idt_modules.Name = "textBox_roleandmodule_idt_modules";
            this.textBox_roleandmodule_idt_modules.Size = new System.Drawing.Size(200, 28);
            this.textBox_roleandmodule_idt_modules.TabIndex = 13;
            // 
            // btn_roleandmodule_save
            // 
            this.btn_roleandmodule_save.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btn_roleandmodule_save.Location = new System.Drawing.Point(292, 159);
            this.btn_roleandmodule_save.Name = "btn_roleandmodule_save";
            this.btn_roleandmodule_save.Size = new System.Drawing.Size(91, 41);
            this.btn_roleandmodule_save.TabIndex = 12;
            this.btn_roleandmodule_save.Text = "保存";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "功能id:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "角色id:";
            // 
            // textBox_roleandmodule_idt_roles
            // 
            this.textBox_roleandmodule_idt_roles.Location = new System.Drawing.Point(183, 38);
            this.textBox_roleandmodule_idt_roles.Name = "textBox_roleandmodule_idt_roles";
            this.textBox_roleandmodule_idt_roles.Size = new System.Drawing.Size(200, 28);
            this.textBox_roleandmodule_idt_roles.TabIndex = 0;
            // 
            // Form_AddOrEdit_roleandmodule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 442);
            this.Controls.Add(this.panel1);
            this.Name = "Form_AddOrEdit_roleandmodule";
            this.Text = "角色-功能授权表_新增/编辑";
            this.Load += new System.EventHandler(this.Form_AddorEdit_roleandmodule_Load);
            this.Resize += new System.EventHandler(this.Form_AddorEdit_roleandmodule_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_roleandmodule_idt_modules;
        private DevExpress.XtraEditors.SimpleButton btn_roleandmodule_save;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_roleandmodule_idt_roles;
    }
}