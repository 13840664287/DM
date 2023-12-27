namespace DM
{
    partial class Form_AddOrEdit_modules
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
            this.btn_modules_save = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_modules_modulename = new System.Windows.Forms.TextBox();
            this.textBox_modules_modulekey = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBox_modules_modulekey);
            this.panel1.Controls.Add(this.btn_modules_save);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox_modules_modulename);
            this.panel1.Location = new System.Drawing.Point(91, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 240);
            this.panel1.TabIndex = 2;
            // 
            // btn_modules_save
            // 
            this.btn_modules_save.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btn_modules_save.Location = new System.Drawing.Point(292, 159);
            this.btn_modules_save.Name = "btn_modules_save";
            this.btn_modules_save.Size = new System.Drawing.Size(91, 41);
            this.btn_modules_save.TabIndex = 12;
            this.btn_modules_save.Text = "保存";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "功能key:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "功能名:";
            // 
            // textBox_modules_modulename
            // 
            this.textBox_modules_modulename.Location = new System.Drawing.Point(183, 38);
            this.textBox_modules_modulename.Name = "textBox_modules_modulename";
            this.textBox_modules_modulename.Size = new System.Drawing.Size(200, 28);
            this.textBox_modules_modulename.TabIndex = 0;
            // 
            // textBox_modules_modulekey
            // 
            this.textBox_modules_modulekey.Location = new System.Drawing.Point(183, 98);
            this.textBox_modules_modulekey.Name = "textBox_modules_modulekey";
            this.textBox_modules_modulekey.Size = new System.Drawing.Size(200, 28);
            this.textBox_modules_modulekey.TabIndex = 13;
            // 
            // Form_AddOrEdit_modules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 416);
            this.Controls.Add(this.panel1);
            this.Name = "Form_AddOrEdit_modules";
            this.Text = "功能表_新增/编辑";
            this.Load += new System.EventHandler(this.Form_AddOrEdit_modules_Load);
            this.Resize += new System.EventHandler(this.Form_AddOrEdit_modules_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btn_modules_save;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_modules_modulename;
        private System.Windows.Forms.TextBox textBox_modules_modulekey;
    }
}