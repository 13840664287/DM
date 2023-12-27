namespace DM
{
    partial class Form_modules
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
            this.gc_modules = new DevExpress.XtraGrid.GridControl();
            this.t_modules = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gc_modules_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_modules_modulename = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_modules_modulekey = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_modules_btn_edit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gc_modules_btn_delete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btn_modules_import = new DevExpress.XtraEditors.SimpleButton();
            this.btn_modules_add = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gc_modules)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_modules)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_modules_btn_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_modules_btn_delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gc_modules
            // 
            this.gc_modules.AccessibleName = "";
            this.gc_modules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_modules.Location = new System.Drawing.Point(0, 80);
            this.gc_modules.MainView = this.t_modules;
            this.gc_modules.Margin = new System.Windows.Forms.Padding(0);
            this.gc_modules.Name = "gc_modules";
            this.gc_modules.Padding = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.gc_modules.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.gc_modules_btn_edit,
            this.gc_modules_btn_delete});
            this.gc_modules.Size = new System.Drawing.Size(976, 604);
            this.gc_modules.TabIndex = 2;
            this.gc_modules.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.t_modules,
            this.gridView1});
            // 
            // t_modules
            // 
            this.t_modules.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gc_modules_id,
            this.gc_modules_modulename,
            this.gc_modules_modulekey});
            this.t_modules.GridControl = this.gc_modules;
            this.t_modules.IndicatorWidth = 60;
            this.t_modules.Name = "t_modules";
            this.t_modules.OptionsBehavior.ReadOnly = true;
            this.t_modules.OptionsView.ShowGroupPanel = false;
            this.t_modules.ViewCaption = "用户表";
            this.t_modules.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.t_modules_CustomDrawRowIndicator);
            this.t_modules.CustomRowCellEdit += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this.t_modules_CustomRowCellEdit);
            // 
            // gc_modules_id
            // 
            this.gc_modules_id.Caption = "ID";
            this.gc_modules_id.Name = "gc_modules_id";
            // 
            // gc_modules_modulename
            // 
            this.gc_modules_modulename.Caption = "功能名";
            this.gc_modules_modulename.Name = "gc_modules_modulename";
            this.gc_modules_modulename.Visible = true;
            this.gc_modules_modulename.VisibleIndex = 0;
            // 
            // gc_modules_modulekey
            // 
            this.gc_modules_modulekey.Caption = "功能key";
            this.gc_modules_modulekey.Name = "gc_modules_modulekey";
            this.gc_modules_modulekey.Visible = true;
            this.gc_modules_modulekey.VisibleIndex = 1;
            // 
            // gc_modules_btn_edit
            // 
            this.gc_modules_btn_edit.AutoHeight = false;
            this.gc_modules_btn_edit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "编辑", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.gc_modules_btn_edit.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.gc_modules_btn_edit.Name = "gc_modules_btn_edit";
            this.gc_modules_btn_edit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.gc_modules_btn_edit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btn_modules_edit_ButtonClick);
            // 
            // gc_modules_btn_delete
            // 
            this.gc_modules_btn_delete.AutoHeight = false;
            this.gc_modules_btn_delete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "删除", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.gc_modules_btn_delete.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.gc_modules_btn_delete.Name = "gc_modules_btn_delete";
            this.gc_modules_btn_delete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.gc_modules_btn_delete.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btn_modules_delete_ButtonClick);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gc_modules;
            this.gridView1.Name = "gridView1";
            // 
            // btn_modules_import
            // 
            this.btn_modules_import.Location = new System.Drawing.Point(837, 21);
            this.btn_modules_import.Name = "btn_modules_import";
            this.btn_modules_import.Size = new System.Drawing.Size(100, 40);
            this.btn_modules_import.TabIndex = 5;
            this.btn_modules_import.Text = "导入";
            // 
            // btn_modules_add
            // 
            this.btn_modules_add.Location = new System.Drawing.Point(704, 21);
            this.btn_modules_add.Name = "btn_modules_add";
            this.btn_modules_add.Size = new System.Drawing.Size(100, 40);
            this.btn_modules_add.TabIndex = 6;
            this.btn_modules_add.Text = "增加";
            this.btn_modules_add.Click += new System.EventHandler(this.btn_modules_add_Click);
            // 
            // Form_modules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 684);
            this.Controls.Add(this.btn_modules_add);
            this.Controls.Add(this.btn_modules_import);
            this.Controls.Add(this.gc_modules);
            this.Name = "Form_modules";
            this.Padding = new System.Windows.Forms.Padding(0, 80, 0, 0);
            this.Text = "功能表";
            this.Load += new System.EventHandler(this.Form_modules_Load);
            this.Resize += new System.EventHandler(this.Form_modules_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.gc_modules)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_modules)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_modules_btn_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_modules_btn_delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_modules;
        private DevExpress.XtraGrid.Views.Grid.GridView t_modules;
        private DevExpress.XtraGrid.Columns.GridColumn gc_modules_id;
        private DevExpress.XtraGrid.Columns.GridColumn gc_modules_modulename;
        private DevExpress.XtraGrid.Columns.GridColumn gc_modules_modulekey;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit gc_modules_btn_delete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit gc_modules_btn_edit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btn_modules_import;
        private DevExpress.XtraEditors.SimpleButton btn_modules_add;
    }
}