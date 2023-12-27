namespace DM
{
    partial class Form_auth_roleandmodule
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
            this.gc_roleandmodule = new DevExpress.XtraGrid.GridControl();
            this.r_roleandmodule = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gc_roleandmodule_modulename = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_roleandmodule_modulekey = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_roleandmodule_select = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_roleandmodule_btn_check = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_auth_rolename = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gc_roleandmodule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r_roleandmodule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_roleandmodule_btn_check)).BeginInit();
            this.SuspendLayout();
            // 
            // gc_roleandmodule
            // 
            this.gc_roleandmodule.AccessibleName = "";
            this.gc_roleandmodule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_roleandmodule.Location = new System.Drawing.Point(0, 80);
            this.gc_roleandmodule.MainView = this.r_roleandmodule;
            this.gc_roleandmodule.Margin = new System.Windows.Forms.Padding(0);
            this.gc_roleandmodule.Name = "gc_roleandmodule";
            this.gc_roleandmodule.Padding = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.gc_roleandmodule.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.gc_roleandmodule_btn_check});
            this.gc_roleandmodule.Size = new System.Drawing.Size(785, 605);
            this.gc_roleandmodule.TabIndex = 2;
            this.gc_roleandmodule.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.r_roleandmodule});
            // 
            // r_roleandmodule
            // 
            this.r_roleandmodule.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gc_roleandmodule_modulename,
            this.gc_roleandmodule_modulekey,
            this.gc_roleandmodule_select});
            this.r_roleandmodule.GridControl = this.gc_roleandmodule;
            this.r_roleandmodule.IndicatorWidth = 60;
            this.r_roleandmodule.Name = "r_roleandmodule";
            this.r_roleandmodule.OptionsBehavior.ReadOnly = true;
            this.r_roleandmodule.OptionsView.ShowGroupPanel = false;
            this.r_roleandmodule.ViewCaption = "角色-功能授权表";
            this.r_roleandmodule.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.r_roleandmodule_CustomDrawRowIndicator);
            // 
            // gc_roleandmodule_modulename
            // 
            this.gc_roleandmodule_modulename.Caption = "功能名";
            this.gc_roleandmodule_modulename.Name = "gc_roleandmodule_modulename";
            this.gc_roleandmodule_modulename.Visible = true;
            this.gc_roleandmodule_modulename.VisibleIndex = 1;
            // 
            // gc_roleandmodule_modulekey
            // 
            this.gc_roleandmodule_modulekey.Caption = "功能key";
            this.gc_roleandmodule_modulekey.Name = "gc_roleandmodule_modulekey";
            this.gc_roleandmodule_modulekey.Visible = true;
            this.gc_roleandmodule_modulekey.VisibleIndex = 2;
            // 
            // gc_roleandmodule_select
            // 
            this.gc_roleandmodule_select.Caption = "选择";
            this.gc_roleandmodule_select.ColumnEdit = this.gc_roleandmodule_btn_check;
            this.gc_roleandmodule_select.MaxWidth = 50;
            this.gc_roleandmodule_select.MinWidth = 50;
            this.gc_roleandmodule_select.Name = "gc_roleandmodule_select";
            this.gc_roleandmodule_select.Visible = true;
            this.gc_roleandmodule_select.VisibleIndex = 0;
            this.gc_roleandmodule_select.Width = 50;
            // 
            // gc_roleandmodule_btn_check
            // 
            this.gc_roleandmodule_btn_check.AutoHeight = false;
            this.gc_roleandmodule_btn_check.Name = "gc_roleandmodule_btn_check";
            this.gc_roleandmodule_btn_check.Click += new System.EventHandler(this.gc_roleandmodule_btn_check_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "角色名:";
            // 
            // textBox_auth_rolename
            // 
            this.textBox_auth_rolename.Location = new System.Drawing.Point(101, 28);
            this.textBox_auth_rolename.Name = "textBox_auth_rolename";
            this.textBox_auth_rolename.ReadOnly = true;
            this.textBox_auth_rolename.Size = new System.Drawing.Size(150, 28);
            this.textBox_auth_rolename.TabIndex = 4;
            // 
            // Form_auth_roleandmodule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 685);
            this.Controls.Add(this.textBox_auth_rolename);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gc_roleandmodule);
            this.Name = "Form_auth_roleandmodule";
            this.Padding = new System.Windows.Forms.Padding(0, 80, 0, 0);
            this.Text = "功能表";
            this.Load += new System.EventHandler(this.Form_auth_roleandmodule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gc_roleandmodule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r_roleandmodule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_roleandmodule_btn_check)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_roleandmodule;
        private DevExpress.XtraGrid.Views.Grid.GridView r_roleandmodule;
        private DevExpress.XtraGrid.Columns.GridColumn gc_roleandmodule_modulename;
        private DevExpress.XtraGrid.Columns.GridColumn gc_roleandmodule_modulekey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_auth_rolename;
        private DevExpress.XtraGrid.Columns.GridColumn gc_roleandmodule_select;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit gc_roleandmodule_btn_check;
    }
}