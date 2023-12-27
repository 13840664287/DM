namespace DM
{
    partial class LayoutsAdd
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
            this.groupBoxLayouts = new System.Windows.Forms.GroupBox();
            this.textBoxRows = new System.Windows.Forms.TextBox();
            this.labelRows = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxLayoutname = new System.Windows.Forms.TextBox();
            this.textBoxCols = new System.Windows.Forms.TextBox();
            this.labelCols = new System.Windows.Forms.Label();
            this.labelLayoutname = new System.Windows.Forms.Label();
            this.groupBoxLayouts.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxLayouts
            // 
            this.groupBoxLayouts.Controls.Add(this.textBoxRows);
            this.groupBoxLayouts.Controls.Add(this.labelRows);
            this.groupBoxLayouts.Controls.Add(this.buttonSave);
            this.groupBoxLayouts.Controls.Add(this.textBoxLayoutname);
            this.groupBoxLayouts.Controls.Add(this.textBoxCols);
            this.groupBoxLayouts.Controls.Add(this.labelCols);
            this.groupBoxLayouts.Controls.Add(this.labelLayoutname);
            this.groupBoxLayouts.Location = new System.Drawing.Point(31, 27);
            this.groupBoxLayouts.Name = "groupBoxLayouts";
            this.groupBoxLayouts.Size = new System.Drawing.Size(246, 163);
            this.groupBoxLayouts.TabIndex = 13;
            this.groupBoxLayouts.TabStop = false;
            // 
            // textBoxRows
            // 
            this.textBoxRows.Location = new System.Drawing.Point(110, 50);
            this.textBoxRows.Name = "textBoxRows";
            this.textBoxRows.Size = new System.Drawing.Size(100, 21);
            this.textBoxRows.TabIndex = 22;
            // 
            // labelRows
            // 
            this.labelRows.AutoSize = true;
            this.labelRows.Location = new System.Drawing.Point(40, 50);
            this.labelRows.Name = "labelRows";
            this.labelRows.Size = new System.Drawing.Size(29, 12);
            this.labelRows.TabIndex = 12;
            this.labelRows.Text = "行数";
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
            // textBoxLayoutname
            // 
            this.textBoxLayoutname.Location = new System.Drawing.Point(110, 20);
            this.textBoxLayoutname.Name = "textBoxLayoutname";
            this.textBoxLayoutname.Size = new System.Drawing.Size(100, 21);
            this.textBoxLayoutname.TabIndex = 9;
            // 
            // textBoxCols
            // 
            this.textBoxCols.Location = new System.Drawing.Point(110, 80);
            this.textBoxCols.Name = "textBoxCols";
            this.textBoxCols.Size = new System.Drawing.Size(100, 21);
            this.textBoxCols.TabIndex = 4;
            // 
            // labelCols
            // 
            this.labelCols.AutoSize = true;
            this.labelCols.Location = new System.Drawing.Point(40, 80);
            this.labelCols.Name = "labelCols";
            this.labelCols.Size = new System.Drawing.Size(29, 12);
            this.labelCols.TabIndex = 7;
            this.labelCols.Text = "列数";
            // 
            // labelLayoutname
            // 
            this.labelLayoutname.AutoSize = true;
            this.labelLayoutname.Location = new System.Drawing.Point(40, 20);
            this.labelLayoutname.Name = "labelLayoutname";
            this.labelLayoutname.Size = new System.Drawing.Size(29, 12);
            this.labelLayoutname.TabIndex = 2;
            this.labelLayoutname.Text = "名称";
            // 
            // LayoutsAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 551);
            this.Controls.Add(this.groupBoxLayouts);
            this.Name = "LayoutsAdd";
            this.Text = "工位布局";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LayoutsAdd_FormClosed);
            this.Load += new System.EventHandler(this.LayoutsAdd_Load);
            this.groupBoxLayouts.ResumeLayout(false);
            this.groupBoxLayouts.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxLayouts;
        private System.Windows.Forms.TextBox textBoxRows;
        private System.Windows.Forms.Label labelRows;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxLayoutname;
        private System.Windows.Forms.TextBox textBoxCols;
        private System.Windows.Forms.Label labelCols;
        private System.Windows.Forms.Label labelLayoutname;
    }
}