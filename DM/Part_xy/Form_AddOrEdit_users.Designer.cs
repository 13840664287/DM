namespace DM
{
    partial class Form_AddOrEdit_users
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
            this.btn_users_save = new DevExpress.XtraEditors.SimpleButton();
            this.btn_users_pic_select = new DevExpress.XtraEditors.SimpleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox_users_photo = new System.Windows.Forms.PictureBox();
            this.comboBox_users_idt_role = new System.Windows.Forms.ComboBox();
            this.textBox_users_realname = new System.Windows.Forms.TextBox();
            this.textBox_users_userpwd = new System.Windows.Forms.TextBox();
            this.textBox_users_username = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_users_photo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_users_save);
            this.panel1.Controls.Add(this.btn_users_pic_select);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox_users_photo);
            this.panel1.Controls.Add(this.comboBox_users_idt_role);
            this.panel1.Controls.Add(this.textBox_users_realname);
            this.panel1.Controls.Add(this.textBox_users_userpwd);
            this.panel1.Controls.Add(this.textBox_users_username);
            this.panel1.Location = new System.Drawing.Point(116, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 570);
            this.panel1.TabIndex = 0;
            // 
            // btn_users_save
            // 
            this.btn_users_save.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btn_users_save.Location = new System.Drawing.Point(292, 514);
            this.btn_users_save.Name = "btn_users_save";
            this.btn_users_save.Size = new System.Drawing.Size(91, 41);
            this.btn_users_save.TabIndex = 12;
            this.btn_users_save.Text = "保存";
            // 
            // btn_users_pic_select
            // 
            this.btn_users_pic_select.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btn_users_pic_select.Location = new System.Drawing.Point(389, 308);
            this.btn_users_pic_select.Name = "btn_users_pic_select";
            this.btn_users_pic_select.Size = new System.Drawing.Size(75, 31);
            this.btn_users_pic_select.TabIndex = 11;
            this.btn_users_pic_select.Text = "选择";
            this.btn_users_pic_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "头像:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "角色:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "真实姓名:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "密码:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "用户名:";
            // 
            // pictureBox_users_photo
            // 
            this.pictureBox_users_photo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_users_photo.Location = new System.Drawing.Point(183, 296);
            this.pictureBox_users_photo.MaximumSize = new System.Drawing.Size(200, 200);
            this.pictureBox_users_photo.Name = "pictureBox_users_photo";
            this.pictureBox_users_photo.Size = new System.Drawing.Size(200, 200);
            this.pictureBox_users_photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_users_photo.TabIndex = 4;
            this.pictureBox_users_photo.TabStop = false;
            // 
            // comboBox_users_idt_role
            // 
            this.comboBox_users_idt_role.FormattingEnabled = true;
            this.comboBox_users_idt_role.Location = new System.Drawing.Point(183, 224);
            this.comboBox_users_idt_role.Name = "comboBox_users_idt_role";
            this.comboBox_users_idt_role.Size = new System.Drawing.Size(200, 26);
            this.comboBox_users_idt_role.TabIndex = 3;
            // 
            // textBox_users_realname
            // 
            this.textBox_users_realname.Location = new System.Drawing.Point(183, 161);
            this.textBox_users_realname.Name = "textBox_users_realname";
            this.textBox_users_realname.Size = new System.Drawing.Size(200, 28);
            this.textBox_users_realname.TabIndex = 2;
            // 
            // textBox_users_userpwd
            // 
            this.textBox_users_userpwd.Location = new System.Drawing.Point(183, 98);
            this.textBox_users_userpwd.Name = "textBox_users_userpwd";
            this.textBox_users_userpwd.Size = new System.Drawing.Size(200, 28);
            this.textBox_users_userpwd.TabIndex = 1;
            // 
            // textBox_users_username
            // 
            this.textBox_users_username.Location = new System.Drawing.Point(183, 38);
            this.textBox_users_username.Name = "textBox_users_username";
            this.textBox_users_username.Size = new System.Drawing.Size(200, 28);
            this.textBox_users_username.TabIndex = 0;
            // 
            // Form_AddOrEdit_users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 679);
            this.Controls.Add(this.panel1);
            this.Name = "Form_AddOrEdit_users";
            this.Text = "用户表_新增/编辑";
            this.Load += new System.EventHandler(this.Form_AddOrEdit_users_Load);
            this.Resize += new System.EventHandler(this.Form_AddOrEdit_users_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_users_photo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox_users_photo;
        private System.Windows.Forms.ComboBox comboBox_users_idt_role;
        private System.Windows.Forms.TextBox textBox_users_realname;
        private System.Windows.Forms.TextBox textBox_users_userpwd;
        private System.Windows.Forms.TextBox textBox_users_username;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btn_users_save;
        private DevExpress.XtraEditors.SimpleButton btn_users_pic_select;
    }
}