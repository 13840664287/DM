namespace DM
{
    partial class GlobalparsAdd
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
            this.groupBoxGlobalpars = new System.Windows.Forms.GroupBox();
            this.textBoxParvalue = new System.Windows.Forms.TextBox();
            this.labelParvalue = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxParname = new System.Windows.Forms.TextBox();
            this.textBoxDispname = new System.Windows.Forms.TextBox();
            this.labelDispname = new System.Windows.Forms.Label();
            this.labelParname = new System.Windows.Forms.Label();
            this.groupBoxGlobalpars.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxGlobalpars
            // 
            this.groupBoxGlobalpars.Controls.Add(this.textBoxParvalue);
            this.groupBoxGlobalpars.Controls.Add(this.labelParvalue);
            this.groupBoxGlobalpars.Controls.Add(this.buttonSave);
            this.groupBoxGlobalpars.Controls.Add(this.textBoxParname);
            this.groupBoxGlobalpars.Controls.Add(this.textBoxDispname);
            this.groupBoxGlobalpars.Controls.Add(this.labelDispname);
            this.groupBoxGlobalpars.Controls.Add(this.labelParname);
            this.groupBoxGlobalpars.Location = new System.Drawing.Point(12, 12);
            this.groupBoxGlobalpars.Name = "groupBoxGlobalpars";
            this.groupBoxGlobalpars.Size = new System.Drawing.Size(246, 163);
            this.groupBoxGlobalpars.TabIndex = 12;
            this.groupBoxGlobalpars.TabStop = false;
            // 
            // textBoxParvalue
            // 
            this.textBoxParvalue.Location = new System.Drawing.Point(110, 50);
            this.textBoxParvalue.Name = "textBoxParvalue";
            this.textBoxParvalue.Size = new System.Drawing.Size(100, 21);
            this.textBoxParvalue.TabIndex = 22;
            // 
            // labelParvalue
            // 
            this.labelParvalue.AutoSize = true;
            this.labelParvalue.Location = new System.Drawing.Point(40, 50);
            this.labelParvalue.Name = "labelParvalue";
            this.labelParvalue.Size = new System.Drawing.Size(41, 12);
            this.labelParvalue.TabIndex = 12;
            this.labelParvalue.Text = "参数值";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(73, 116);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.Text = "保存";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxParname
            // 
            this.textBoxParname.Location = new System.Drawing.Point(110, 20);
            this.textBoxParname.Name = "textBoxParname";
            this.textBoxParname.Size = new System.Drawing.Size(100, 21);
            this.textBoxParname.TabIndex = 9;
            // 
            // textBoxDispname
            // 
            this.textBoxDispname.Location = new System.Drawing.Point(110, 80);
            this.textBoxDispname.Name = "textBoxDispname";
            this.textBoxDispname.Size = new System.Drawing.Size(100, 21);
            this.textBoxDispname.TabIndex = 4;
            // 
            // labelDispname
            // 
            this.labelDispname.AutoSize = true;
            this.labelDispname.Location = new System.Drawing.Point(40, 80);
            this.labelDispname.Name = "labelDispname";
            this.labelDispname.Size = new System.Drawing.Size(53, 12);
            this.labelDispname.TabIndex = 7;
            this.labelDispname.Text = "参数含义";
            // 
            // labelParname
            // 
            this.labelParname.AutoSize = true;
            this.labelParname.Location = new System.Drawing.Point(40, 20);
            this.labelParname.Name = "labelParname";
            this.labelParname.Size = new System.Drawing.Size(53, 12);
            this.labelParname.TabIndex = 2;
            this.labelParname.Text = "参数名称";
            // 
            // GlobalparsAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 182);
            this.Controls.Add(this.groupBoxGlobalpars);
            this.Name = "GlobalparsAdd";
            this.Text = "系统参数";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GlobalparsAdd_FormClosed);
            this.Load += new System.EventHandler(this.ProductlinesAdd_Load);
            this.groupBoxGlobalpars.ResumeLayout(false);
            this.groupBoxGlobalpars.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxGlobalpars;
        private System.Windows.Forms.TextBox textBoxParvalue;
        private System.Windows.Forms.Label labelParvalue;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxParname;
        private System.Windows.Forms.TextBox textBoxDispname;
        private System.Windows.Forms.Label labelDispname;
        private System.Windows.Forms.Label labelParname;
    }
}