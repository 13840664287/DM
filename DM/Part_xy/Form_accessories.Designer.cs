namespace DM
{
    partial class Form_accessories
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gc_accessories = new DevExpress.XtraGrid.GridControl();
            this.t_accessories = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gc_accessories_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_accessories_accname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_accessories_starttime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_accessories_acctype = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_accessories_updatetime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_accessories_circletime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_accessories_circleunit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_accessories_edit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_accessories_edit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gc_accessories_delete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_accessories_delete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btn_accessories_add = new DevExpress.XtraEditors.SimpleButton();
            this.btn_accessories_import = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gc_accessories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_accessories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_accessories_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_accessories_delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gc_accessories
            // 
            this.gc_accessories.AccessibleName = "";
            this.gc_accessories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_accessories.Location = new System.Drawing.Point(0, 80);
            this.gc_accessories.MainView = this.t_accessories;
            this.gc_accessories.Margin = new System.Windows.Forms.Padding(0);
            this.gc_accessories.Name = "gc_accessories";
            this.gc_accessories.Padding = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.gc_accessories.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btn_accessories_edit,
            this.btn_accessories_delete});
            this.gc_accessories.Size = new System.Drawing.Size(1116, 644);
            this.gc_accessories.TabIndex = 2;
            this.gc_accessories.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.t_accessories,
            this.gridView1});
            // 
            // t_accessories
            // 
            this.t_accessories.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gc_accessories_id,
            this.gc_accessories_accname,
            this.gc_accessories_starttime,
            this.gc_accessories_acctype,
            this.gc_accessories_updatetime,
            this.gc_accessories_circletime,
            this.gc_accessories_circleunit,
            this.gc_accessories_delete,
            this.gc_accessories_edit});
            this.t_accessories.GridControl = this.gc_accessories;
            this.t_accessories.IndicatorWidth = 60;
            this.t_accessories.Name = "t_accessories";
            this.t_accessories.OptionsBehavior.ReadOnly = true;
            this.t_accessories.OptionsView.ShowGroupPanel = false;
            this.t_accessories.ViewCaption = "用户表";
            this.t_accessories.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.t_accessories_CustomDrawRowIndicator);
            // 
            // gc_accessories_id
            // 
            this.gc_accessories_id.Caption = "ID";
            this.gc_accessories_id.Name = "gc_accessories_id";
            // 
            // gc_accessories_accname
            // 
            this.gc_accessories_accname.Caption = "配件名称";
            this.gc_accessories_accname.Name = "gc_accessories_accname";
            this.gc_accessories_accname.Visible = true;
            this.gc_accessories_accname.VisibleIndex = 0;
            // 
            // gc_accessories_starttime
            // 
            this.gc_accessories_starttime.Caption = "启用时间";
            this.gc_accessories_starttime.Name = "gc_accessories_starttime";
            this.gc_accessories_starttime.Visible = true;
            this.gc_accessories_starttime.VisibleIndex = 1;
            // 
            // gc_accessories_acctype
            // 
            this.gc_accessories_acctype.Caption = "类型";
            this.gc_accessories_acctype.Name = "gc_accessories_acctype";
            this.gc_accessories_acctype.Visible = true;
            this.gc_accessories_acctype.VisibleIndex = 2;
            // 
            // gc_accessories_updatetime
            // 
            this.gc_accessories_updatetime.Caption = "更新时间";
            this.gc_accessories_updatetime.Name = "gc_accessories_updatetime";
            this.gc_accessories_updatetime.Visible = true;
            this.gc_accessories_updatetime.VisibleIndex = 3;
            // 
            // gc_accessories_circletime
            // 
            this.gc_accessories_circletime.Caption = "周期";
            this.gc_accessories_circletime.Name = "gc_accessories_circletime";
            this.gc_accessories_circletime.Visible = true;
            this.gc_accessories_circletime.VisibleIndex = 4;
            // 
            // gc_accessories_circleunit
            // 
            this.gc_accessories_circleunit.Caption = "周期单位";
            this.gc_accessories_circleunit.Name = "gc_accessories_circleunit";
            this.gc_accessories_circleunit.Visible = true;
            this.gc_accessories_circleunit.VisibleIndex = 5;
            // 
            // gc_accessories_edit
            // 
            this.gc_accessories_edit.Caption = "操作";
            this.gc_accessories_edit.ColumnEdit = this.btn_accessories_edit;
            this.gc_accessories_edit.Name = "gc_accessories_edit";
            this.gc_accessories_edit.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.gc_accessories_edit.Visible = true;
            this.gc_accessories_edit.VisibleIndex = 7;
            this.gc_accessories_edit.Width = 80;
            // 
            // btn_accessories_edit
            // 
            this.btn_accessories_edit.AutoHeight = false;
            this.btn_accessories_edit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "编辑", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject8, "", null, null, true)});
            this.btn_accessories_edit.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btn_accessories_edit.Name = "btn_accessories_edit";
            this.btn_accessories_edit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btn_accessories_edit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btn_accessories_edit_ButtonClick);
            // 
            // gc_accessories_delete
            // 
            this.gc_accessories_delete.Caption = "操作";
            this.gc_accessories_delete.ColumnEdit = this.btn_accessories_delete;
            this.gc_accessories_delete.Name = "gc_accessories_delete";
            this.gc_accessories_delete.Visible = true;
            this.gc_accessories_delete.VisibleIndex = 6;
            this.gc_accessories_delete.Width = 80;
            // 
            // btn_accessories_delete
            // 
            this.btn_accessories_delete.AutoHeight = false;
            this.btn_accessories_delete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "删除", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject7, "", null, null, true)});
            this.btn_accessories_delete.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btn_accessories_delete.Name = "btn_accessories_delete";
            this.btn_accessories_delete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btn_accessories_delete.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btn_accessories_delete_ButtonClick);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gc_accessories;
            this.gridView1.Name = "gridView1";
            // 
            // btn_accessories_add
            // 
            this.btn_accessories_add.Location = new System.Drawing.Point(849, 20);
            this.btn_accessories_add.Name = "btn_accessories_add";
            this.btn_accessories_add.Size = new System.Drawing.Size(100, 40);
            this.btn_accessories_add.TabIndex = 7;
            this.btn_accessories_add.Text = "增加";
            this.btn_accessories_add.Click += new System.EventHandler(this.btn_accessories_add_Click);
            // 
            // btn_accessories_import
            // 
            this.btn_accessories_import.Location = new System.Drawing.Point(978, 20);
            this.btn_accessories_import.Name = "btn_accessories_import";
            this.btn_accessories_import.Size = new System.Drawing.Size(100, 40);
            this.btn_accessories_import.TabIndex = 8;
            this.btn_accessories_import.Text = "导入";
            // 
            // Form_accessories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 724);
            this.Controls.Add(this.btn_accessories_import);
            this.Controls.Add(this.btn_accessories_add);
            this.Controls.Add(this.gc_accessories);
            this.Name = "Form_accessories";
            this.Padding = new System.Windows.Forms.Padding(0, 80, 0, 0);
            this.Text = "易损/点检配件表";
            this.Load += new System.EventHandler(this.Form_accessories_Load);
            this.Resize += new System.EventHandler(this.Form_accessories_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.gc_accessories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_accessories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_accessories_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_accessories_delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_accessories;
        private DevExpress.XtraGrid.Views.Grid.GridView t_accessories;
        private DevExpress.XtraGrid.Columns.GridColumn gc_accessories_id;
        private DevExpress.XtraGrid.Columns.GridColumn gc_accessories_accname;
        private DevExpress.XtraGrid.Columns.GridColumn gc_accessories_starttime;
        private DevExpress.XtraGrid.Columns.GridColumn gc_accessories_acctype;
        private DevExpress.XtraGrid.Columns.GridColumn gc_accessories_updatetime;
        private DevExpress.XtraGrid.Columns.GridColumn gc_accessories_circletime;
        private DevExpress.XtraGrid.Columns.GridColumn gc_accessories_delete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btn_accessories_delete;
        private DevExpress.XtraGrid.Columns.GridColumn gc_accessories_edit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btn_accessories_edit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gc_accessories_circleunit;
        private DevExpress.XtraEditors.SimpleButton btn_accessories_add;
        private DevExpress.XtraEditors.SimpleButton btn_accessories_import;
    }
}