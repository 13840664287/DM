namespace DM
{
    partial class Form_roleandmodule
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
            this.gc_roleandmodule = new DevExpress.XtraGrid.GridControl();
            this.r_roleandmodule = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gc_roleandmodule_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_roleandmodule_idt_roles = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_roleandmodule_idt_modules = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_roleandmodule_edit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_roleandmodule_btn_edit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gc_roleandmodule_delete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_roleandmodule_btn_delete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btn_roleandmodule_import = new DevExpress.XtraEditors.SimpleButton();
            this.btn_roleandmodule_add = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gc_roleandmodule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r_roleandmodule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_roleandmodule_btn_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_roleandmodule_btn_delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            this.gc_roleandmodule_btn_edit,
            this.gc_roleandmodule_btn_delete});
            this.gc_roleandmodule.Size = new System.Drawing.Size(847, 590);
            this.gc_roleandmodule.TabIndex = 3;
            this.gc_roleandmodule.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.r_roleandmodule,
            this.gridView1});
            // 
            // r_roleandmodule
            // 
            this.r_roleandmodule.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gc_roleandmodule_id,
            this.gc_roleandmodule_idt_roles,
            this.gc_roleandmodule_idt_modules,
            this.gc_roleandmodule_edit,
            this.gc_roleandmodule_delete});
            this.r_roleandmodule.GridControl = this.gc_roleandmodule;
            this.r_roleandmodule.IndicatorWidth = 60;
            this.r_roleandmodule.Name = "r_roleandmodule";
            this.r_roleandmodule.OptionsBehavior.ReadOnly = true;
            this.r_roleandmodule.OptionsView.ShowGroupPanel = false;
            this.r_roleandmodule.ViewCaption = "用户表";
            this.r_roleandmodule.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.r_roleandmodule_CustomDrawRowIndicator);
            // 
            // gc_roleandmodule_id
            // 
            this.gc_roleandmodule_id.Caption = "ID";
            this.gc_roleandmodule_id.Name = "gc_roleandmodule_id";
            // 
            // gc_roleandmodule_idt_roles
            // 
            this.gc_roleandmodule_idt_roles.Caption = "角色id";
            this.gc_roleandmodule_idt_roles.Name = "gc_roleandmodule_idt_roles";
            this.gc_roleandmodule_idt_roles.Visible = true;
            this.gc_roleandmodule_idt_roles.VisibleIndex = 0;
            // 
            // gc_roleandmodule_idt_modules
            // 
            this.gc_roleandmodule_idt_modules.Caption = "功能id";
            this.gc_roleandmodule_idt_modules.Name = "gc_roleandmodule_idt_modules";
            this.gc_roleandmodule_idt_modules.Visible = true;
            this.gc_roleandmodule_idt_modules.VisibleIndex = 1;
            // 
            // gc_roleandmodule_edit
            // 
            this.gc_roleandmodule_edit.Caption = "操作";
            this.gc_roleandmodule_edit.ColumnEdit = this.gc_roleandmodule_btn_edit;
            this.gc_roleandmodule_edit.Name = "gc_roleandmodule_edit";
            this.gc_roleandmodule_edit.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.gc_roleandmodule_edit.Visible = true;
            this.gc_roleandmodule_edit.VisibleIndex = 2;
            // 
            // gc_roleandmodule_btn_edit
            // 
            this.gc_roleandmodule_btn_edit.AutoHeight = false;
            this.gc_roleandmodule_btn_edit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "编辑", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.gc_roleandmodule_btn_edit.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.gc_roleandmodule_btn_edit.Name = "gc_roleandmodule_btn_edit";
            this.gc_roleandmodule_btn_edit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.gc_roleandmodule_btn_edit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btn_roleandmodule_edit_ButtonClick);
            // 
            // gc_roleandmodule_delete
            // 
            this.gc_roleandmodule_delete.Caption = "操作";
            this.gc_roleandmodule_delete.ColumnEdit = this.gc_roleandmodule_btn_delete;
            this.gc_roleandmodule_delete.Name = "gc_roleandmodule_delete";
            this.gc_roleandmodule_delete.Visible = true;
            this.gc_roleandmodule_delete.VisibleIndex = 3;
            // 
            // gc_roleandmodule_btn_delete
            // 
            this.gc_roleandmodule_btn_delete.AutoHeight = false;
            this.gc_roleandmodule_btn_delete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "删除", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.gc_roleandmodule_btn_delete.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.gc_roleandmodule_btn_delete.Name = "gc_roleandmodule_btn_delete";
            this.gc_roleandmodule_btn_delete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.gc_roleandmodule_btn_delete.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btn_roleandmodule_delete_ButtonClick);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gc_roleandmodule;
            this.gridView1.Name = "gridView1";
            // 
            // btn_roleandmodule_import
            // 
            this.btn_roleandmodule_import.Location = new System.Drawing.Point(706, 22);
            this.btn_roleandmodule_import.Name = "btn_roleandmodule_import";
            this.btn_roleandmodule_import.Size = new System.Drawing.Size(100, 40);
            this.btn_roleandmodule_import.TabIndex = 6;
            this.btn_roleandmodule_import.Text = "导入";
            // 
            // btn_roleandmodule_add
            // 
            this.btn_roleandmodule_add.Location = new System.Drawing.Point(579, 22);
            this.btn_roleandmodule_add.Name = "btn_roleandmodule_add";
            this.btn_roleandmodule_add.Size = new System.Drawing.Size(100, 40);
            this.btn_roleandmodule_add.TabIndex = 7;
            this.btn_roleandmodule_add.Text = "增加";
            this.btn_roleandmodule_add.Click += new System.EventHandler(this.btn_roleandmodule_add_Click);
            // 
            // Form_roleandmodule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 670);
            this.Controls.Add(this.btn_roleandmodule_add);
            this.Controls.Add(this.btn_roleandmodule_import);
            this.Controls.Add(this.gc_roleandmodule);
            this.Name = "Form_roleandmodule";
            this.Padding = new System.Windows.Forms.Padding(0, 80, 0, 0);
            this.Text = "角色-功能授权表";
            this.Load += new System.EventHandler(this.Form_roleandmodule_Load);
            this.Resize += new System.EventHandler(this.Form_roleandmodule_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.gc_roleandmodule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r_roleandmodule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_roleandmodule_btn_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_roleandmodule_btn_delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_roleandmodule;
        private DevExpress.XtraGrid.Views.Grid.GridView r_roleandmodule;
        private DevExpress.XtraGrid.Columns.GridColumn gc_roleandmodule_id;
        private DevExpress.XtraGrid.Columns.GridColumn gc_roleandmodule_idt_roles;
        private DevExpress.XtraGrid.Columns.GridColumn gc_roleandmodule_idt_modules;
        private DevExpress.XtraGrid.Columns.GridColumn gc_roleandmodule_delete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit gc_roleandmodule_btn_delete;
        private DevExpress.XtraGrid.Columns.GridColumn gc_roleandmodule_edit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit gc_roleandmodule_btn_edit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btn_roleandmodule_import;
        private DevExpress.XtraEditors.SimpleButton btn_roleandmodule_add;
    }
}