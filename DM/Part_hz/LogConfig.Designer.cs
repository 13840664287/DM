namespace DM
{
    partial class LogConfig
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.logname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.logkey = new DevExpress.XtraGrid.Columns.GridColumn();
            this.strtemplate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.edit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_edit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.delete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_deletelog = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.sbtn_insert = new DevExpress.XtraEditors.SimpleButton();
            this.sbtn_import = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_deletelog)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(8, 55);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btn_edit,
            this.btn_deletelog});
            this.gridControl1.Size = new System.Drawing.Size(1538, 574);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.id,
            this.logname,
            this.logkey,
            this.strtemplate,
            this.edit,
            this.delete});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // id
            // 
            this.id.Caption = "ID";
            this.id.Name = "id";
            // 
            // logname
            // 
            this.logname.Caption = "名称";
            this.logname.Name = "logname";
            this.logname.OptionsColumn.AllowEdit = false;
            this.logname.OptionsColumn.ReadOnly = true;
            this.logname.Visible = true;
            this.logname.VisibleIndex = 0;
            // 
            // logkey
            // 
            this.logkey.Caption = "key";
            this.logkey.Name = "logkey";
            this.logkey.OptionsColumn.AllowEdit = false;
            this.logkey.OptionsColumn.ReadOnly = true;
            this.logkey.Visible = true;
            this.logkey.VisibleIndex = 1;
            // 
            // strtemplate
            // 
            this.strtemplate.Caption = "日志模板";
            this.strtemplate.Name = "strtemplate";
            this.strtemplate.OptionsColumn.AllowEdit = false;
            this.strtemplate.OptionsColumn.ReadOnly = true;
            this.strtemplate.Visible = true;
            this.strtemplate.VisibleIndex = 2;
            // 
            // edit
            // 
            this.edit.Caption = "操作";
            this.edit.ColumnEdit = this.btn_edit;
            this.edit.Name = "edit";
            this.edit.Visible = true;
            this.edit.VisibleIndex = 3;
            // 
            // btn_edit
            // 
            this.btn_edit.AutoHeight = false;
            this.btn_edit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "编辑", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.btn_edit.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btn_edit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btn_edit_ButtonClick);
            // 
            // delete
            // 
            this.delete.Caption = "操作";
            this.delete.ColumnEdit = this.btn_deletelog;
            this.delete.Name = "delete";
            this.delete.Visible = true;
            this.delete.VisibleIndex = 4;
            // 
            // btn_deletelog
            // 
            this.btn_deletelog.AutoHeight = false;
            this.btn_deletelog.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "删除", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.btn_deletelog.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btn_deletelog.Name = "btn_deletelog";
            this.btn_deletelog.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btn_deletelog.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btn_deletelog_ButtonClick);
            // 
            // sbtn_insert
            // 
            this.sbtn_insert.Location = new System.Drawing.Point(1325, 18);
            this.sbtn_insert.Name = "sbtn_insert";
            this.sbtn_insert.Size = new System.Drawing.Size(75, 31);
            this.sbtn_insert.TabIndex = 4;
            this.sbtn_insert.Text = "增加";
            this.sbtn_insert.Click += new System.EventHandler(this.sbtn_insert_Click);
            // 
            // sbtn_import
            // 
            this.sbtn_import.Location = new System.Drawing.Point(1461, 18);
            this.sbtn_import.Name = "sbtn_import";
            this.sbtn_import.Size = new System.Drawing.Size(75, 31);
            this.sbtn_import.TabIndex = 5;
            this.sbtn_import.Text = "导入";
            // 
            // LogConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1548, 608);
            this.Controls.Add(this.sbtn_import);
            this.Controls.Add(this.sbtn_insert);
            this.Controls.Add(this.gridControl1);
            this.Name = "LogConfig";
            this.Text = "LogConfig";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_deletelog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn id;
        private DevExpress.XtraGrid.Columns.GridColumn logname;
        private DevExpress.XtraGrid.Columns.GridColumn logkey;
        private DevExpress.XtraGrid.Columns.GridColumn strtemplate;
        private DevExpress.XtraGrid.Columns.GridColumn edit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btn_edit;
        private DevExpress.XtraEditors.SimpleButton sbtn_insert;
        private DevExpress.XtraEditors.SimpleButton sbtn_import;
        private DevExpress.XtraGrid.Columns.GridColumn delete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btn_deletelog;
    }
}