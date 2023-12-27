namespace DM
{
    partial class ProductsAdd
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
            this.textBoxScanorder = new System.Windows.Forms.TextBox();
            this.labelScanorder = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxProductname = new System.Windows.Forms.TextBox();
            this.textBoxNotes = new System.Windows.Forms.TextBox();
            this.labelNotes = new System.Windows.Forms.Label();
            this.labelProductname = new System.Windows.Forms.Label();
            this.groupBoxGlobalpars.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxGlobalpars
            // 
            this.groupBoxGlobalpars.Controls.Add(this.textBoxScanorder);
            this.groupBoxGlobalpars.Controls.Add(this.labelScanorder);
            this.groupBoxGlobalpars.Controls.Add(this.buttonSave);
            this.groupBoxGlobalpars.Controls.Add(this.textBoxProductname);
            this.groupBoxGlobalpars.Controls.Add(this.textBoxNotes);
            this.groupBoxGlobalpars.Controls.Add(this.labelNotes);
            this.groupBoxGlobalpars.Controls.Add(this.labelProductname);
            this.groupBoxGlobalpars.Location = new System.Drawing.Point(23, 12);
            this.groupBoxGlobalpars.Name = "groupBoxGlobalpars";
            this.groupBoxGlobalpars.Size = new System.Drawing.Size(246, 163);
            this.groupBoxGlobalpars.TabIndex = 13;
            this.groupBoxGlobalpars.TabStop = false;
            // 
            // textBoxScanorder
            // 
            this.textBoxScanorder.Location = new System.Drawing.Point(110, 50);
            this.textBoxScanorder.Name = "textBoxScanorder";
            this.textBoxScanorder.Size = new System.Drawing.Size(100, 21);
            this.textBoxScanorder.TabIndex = 22;
            // 
            // labelScanorder
            // 
            this.labelScanorder.AutoSize = true;
            this.labelScanorder.Location = new System.Drawing.Point(40, 50);
            this.labelScanorder.Name = "labelScanorder";
            this.labelScanorder.Size = new System.Drawing.Size(53, 12);
            this.labelScanorder.TabIndex = 12;
            this.labelScanorder.Text = "扫查顺序";
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
            // textBoxProductname
            // 
            this.textBoxProductname.Location = new System.Drawing.Point(110, 20);
            this.textBoxProductname.Name = "textBoxProductname";
            this.textBoxProductname.Size = new System.Drawing.Size(100, 21);
            this.textBoxProductname.TabIndex = 9;
            // 
            // textBoxNotes
            // 
            this.textBoxNotes.Location = new System.Drawing.Point(110, 80);
            this.textBoxNotes.Name = "textBoxNotes";
            this.textBoxNotes.Size = new System.Drawing.Size(100, 21);
            this.textBoxNotes.TabIndex = 4;
            // 
            // labelNotes
            // 
            this.labelNotes.AutoSize = true;
            this.labelNotes.Location = new System.Drawing.Point(40, 80);
            this.labelNotes.Name = "labelNotes";
            this.labelNotes.Size = new System.Drawing.Size(29, 12);
            this.labelNotes.TabIndex = 7;
            this.labelNotes.Text = "备注";
            // 
            // labelProductname
            // 
            this.labelProductname.AutoSize = true;
            this.labelProductname.Location = new System.Drawing.Point(40, 20);
            this.labelProductname.Name = "labelProductname";
            this.labelProductname.Size = new System.Drawing.Size(29, 12);
            this.labelProductname.TabIndex = 2;
            this.labelProductname.Text = "名称";
            // 
            // ProductsAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 193);
            this.Controls.Add(this.groupBoxGlobalpars);
            this.Name = "ProductsAdd";
            this.Text = "产品信息";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProductsAdd_FormClosed);
            this.Load += new System.EventHandler(this.ProductlinesAdd_Load);
            this.groupBoxGlobalpars.ResumeLayout(false);
            this.groupBoxGlobalpars.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxGlobalpars;
        private System.Windows.Forms.TextBox textBoxScanorder;
        private System.Windows.Forms.Label labelScanorder;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxProductname;
        private System.Windows.Forms.TextBox textBoxNotes;
        private System.Windows.Forms.Label labelNotes;
        private System.Windows.Forms.Label labelProductname;
    }
}