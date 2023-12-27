namespace DM
{
    partial class Form_roles
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gc_roles = new DevExpress.XtraGrid.GridControl();
            this.t_roles = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gc_roles_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_roles_rolename = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_roles_notes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_roles_delete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_roles_btn_delete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gc_roles_edit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_roles_btn_edit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gc_roles_auth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_roles_btn_auth = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btn_roles_import = new DevExpress.XtraEditors.SimpleButton();
            this.btn_roles_add = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gc_roles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_roles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_roles_btn_delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_roles_btn_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_roles_btn_auth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gc_roles
            // 
            this.gc_roles.AccessibleName = "";
            this.gc_roles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_roles.Location = new System.Drawing.Point(0, 80);
            this.gc_roles.MainView = this.t_roles;
            this.gc_roles.Margin = new System.Windows.Forms.Padding(0);
            this.gc_roles.Name = "gc_roles";
            this.gc_roles.Padding = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.gc_roles.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.gc_roles_btn_edit,
            this.gc_roles_btn_delete,
            this.gc_roles_btn_auth});
            this.gc_roles.Size = new System.Drawing.Size(1083, 628);
            this.gc_roles.TabIndex = 2;
            this.gc_roles.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.t_roles,
            this.gridView1});
            // 
            // t_roles
            // 
            this.t_roles.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gc_roles_id,
            this.gc_roles_rolename,
            this.gc_roles_notes,
            this.gc_roles_delete,
            this.gc_roles_edit,
            this.gc_roles_auth});
            this.t_roles.GridControl = this.gc_roles;
            this.t_roles.IndicatorWidth = 60;
            this.t_roles.Name = "t_roles";
            this.t_roles.OptionsBehavior.ReadOnly = true;
            this.t_roles.OptionsView.ShowGroupPanel = false;
            this.t_roles.ViewCaption = "用户表";
            this.t_roles.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.t_roles_CustomDrawRowIndicator);
            // 
            // gc_roles_id
            // 
            this.gc_roles_id.Caption = "ID";
            this.gc_roles_id.Name = "gc_roles_id";
            // 
            // gc_roles_rolename
            // 
            this.gc_roles_rolename.Caption = "角色名";
            this.gc_roles_rolename.Name = "gc_roles_rolename";
            this.gc_roles_rolename.Visible = true;
            this.gc_roles_rolename.VisibleIndex = 0;
            this.gc_roles_rolename.Width = 277;
            // 
            // gc_roles_notes
            // 
            this.gc_roles_notes.Caption = "备注";
            this.gc_roles_notes.Name = "gc_roles_notes";
            this.gc_roles_notes.Visible = true;
            this.gc_roles_notes.VisibleIndex = 1;
            this.gc_roles_notes.Width = 277;
            // 
            // gc_roles_delete
            // 
            this.gc_roles_delete.Caption = "操作";
            this.gc_roles_delete.ColumnEdit = this.gc_roles_btn_delete;
            this.gc_roles_delete.Name = "gc_roles_delete";
            this.gc_roles_delete.Visible = true;
            this.gc_roles_delete.VisibleIndex = 2;
            this.gc_roles_delete.Width = 80;
            // 
            // gc_roles_btn_delete
            // 
            this.gc_roles_btn_delete.AutoHeight = false;
            this.gc_roles_btn_delete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "删除", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.gc_roles_btn_delete.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.gc_roles_btn_delete.Name = "gc_roles_btn_delete";
            this.gc_roles_btn_delete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.gc_roles_btn_delete.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btn_roles_delete_ButtonClick);
            // 
            // gc_roles_edit
            // 
            this.gc_roles_edit.Caption = "操作";
            this.gc_roles_edit.ColumnEdit = this.gc_roles_btn_edit;
            this.gc_roles_edit.Name = "gc_roles_edit";
            this.gc_roles_edit.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.gc_roles_edit.Visible = true;
            this.gc_roles_edit.VisibleIndex = 3;
            this.gc_roles_edit.Width = 80;
            // 
            // gc_roles_btn_edit
            // 
            this.gc_roles_btn_edit.AutoHeight = false;
            this.gc_roles_btn_edit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "编辑", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.gc_roles_btn_edit.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.gc_roles_btn_edit.Name = "gc_roles_btn_edit";
            this.gc_roles_btn_edit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.gc_roles_btn_edit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btn_roles_edit_ButtonClick);
            // 
            // gc_roles_auth
            // 
            this.gc_roles_auth.Caption = "操作";
            this.gc_roles_auth.ColumnEdit = this.gc_roles_btn_auth;
            this.gc_roles_auth.Name = "gc_roles_auth";
            this.gc_roles_auth.Visible = true;
            this.gc_roles_auth.VisibleIndex = 4;
            this.gc_roles_auth.Width = 80;
            // 
            // gc_roles_btn_auth
            // 
            this.gc_roles_btn_auth.AutoHeight = false;
            this.gc_roles_btn_auth.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "授权", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", null, null, true)});
            this.gc_roles_btn_auth.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.gc_roles_btn_auth.Name = "gc_roles_btn_auth";
            this.gc_roles_btn_auth.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.gc_roles_btn_auth.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.gc_roles_btn_auth_ButtonClick);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gc_roles;
            this.gridView1.Name = "gridView1";
            // 
            // btn_roles_import
            // 
            this.btn_roles_import.Location = new System.Drawing.Point(940, 21);
            this.btn_roles_import.Name = "btn_roles_import";
            this.btn_roles_import.Size = new System.Drawing.Size(100, 40);
            this.btn_roles_import.TabIndex = 4;
            this.btn_roles_import.Text = "导入";
            this.btn_roles_import.Click += new System.EventHandler(this.btn_roles_import_Click);
            // 
            // btn_roles_add
            // 
            this.btn_roles_add.Location = new System.Drawing.Point(801, 21);
            this.btn_roles_add.Name = "btn_roles_add";
            this.btn_roles_add.Size = new System.Drawing.Size(100, 40);
            this.btn_roles_add.TabIndex = 5;
            this.btn_roles_add.Text = "增加";
            this.btn_roles_add.Click += new System.EventHandler(this.btn_roles_add_Click);
            // 
            // Form_roles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 708);
            this.Controls.Add(this.btn_roles_add);
            this.Controls.Add(this.btn_roles_import);
            this.Controls.Add(this.gc_roles);
            this.Name = "Form_roles";
            this.Padding = new System.Windows.Forms.Padding(0, 80, 0, 0);
            this.Text = "角色表";
            this.Load += new System.EventHandler(this.Form_roles_Load);
            this.Resize += new System.EventHandler(this.Form_roles_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.gc_roles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_roles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_roles_btn_delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_roles_btn_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_roles_btn_auth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_roles;
        private DevExpress.XtraGrid.Views.Grid.GridView t_roles;
        private DevExpress.XtraGrid.Columns.GridColumn gc_roles_id;
        private DevExpress.XtraGrid.Columns.GridColumn gc_roles_rolename;
        private DevExpress.XtraGrid.Columns.GridColumn gc_roles_notes;
        private DevExpress.XtraGrid.Columns.GridColumn gc_roles_delete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit gc_roles_btn_delete;
        private DevExpress.XtraGrid.Columns.GridColumn gc_roles_edit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit gc_roles_btn_edit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btn_roles_import;
        private DevExpress.XtraEditors.SimpleButton btn_roles_add;
        private DevExpress.XtraGrid.Columns.GridColumn gc_roles_auth;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit gc_roles_btn_auth;
    }
}