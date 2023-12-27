namespace DM
{
    partial class Productlines
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
            this.components = new System.ComponentModel.Container();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridLinename = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridLinekey = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridScanspeed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridIndexspeed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridAuxspeed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridScanspeed_empty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridIndexspeed_empty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridAuxspeed_empty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridIdt_layouts = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridEdit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.buttonLeadingin = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(2, 50);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit,
            this.repositoryItemButtonDelete});
            this.gridControl1.Size = new System.Drawing.Size(734, 276);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridId,
            this.gridLinename,
            this.gridLinekey,
            this.gridScanspeed,
            this.gridIndexspeed,
            this.gridAuxspeed,
            this.gridScanspeed_empty,
            this.gridIndexspeed_empty,
            this.gridAuxspeed_empty,
            this.gridIdt_layouts,
            this.gridEdit,
            this.gridDelete});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridId
            // 
            this.gridId.Name = "gridId";
            this.gridId.OptionsColumn.ReadOnly = true;
            this.gridId.Visible = true;
            this.gridId.VisibleIndex = 0;
            this.gridId.Width = 30;
            // 
            // gridLinename
            // 
            this.gridLinename.Caption = "名称";
            this.gridLinename.Name = "gridLinename";
            this.gridLinename.OptionsColumn.ReadOnly = true;
            this.gridLinename.Visible = true;
            this.gridLinename.VisibleIndex = 1;
            this.gridLinename.Width = 61;
            // 
            // gridLinekey
            // 
            this.gridLinekey.Caption = "key";
            this.gridLinekey.Name = "gridLinekey";
            this.gridLinekey.OptionsColumn.ReadOnly = true;
            this.gridLinekey.Visible = true;
            this.gridLinekey.VisibleIndex = 2;
            this.gridLinekey.Width = 61;
            // 
            // gridScanspeed
            // 
            this.gridScanspeed.Caption = "扫查速度";
            this.gridScanspeed.Name = "gridScanspeed";
            this.gridScanspeed.OptionsColumn.ReadOnly = true;
            this.gridScanspeed.Visible = true;
            this.gridScanspeed.VisibleIndex = 3;
            this.gridScanspeed.Width = 61;
            // 
            // gridIndexspeed
            // 
            this.gridIndexspeed.Caption = "步进速度";
            this.gridIndexspeed.Name = "gridIndexspeed";
            this.gridIndexspeed.OptionsColumn.ReadOnly = true;
            this.gridIndexspeed.Visible = true;
            this.gridIndexspeed.VisibleIndex = 4;
            this.gridIndexspeed.Width = 61;
            // 
            // gridAuxspeed
            // 
            this.gridAuxspeed.Caption = "升降速度";
            this.gridAuxspeed.Name = "gridAuxspeed";
            this.gridAuxspeed.OptionsColumn.ReadOnly = true;
            this.gridAuxspeed.Visible = true;
            this.gridAuxspeed.VisibleIndex = 5;
            this.gridAuxspeed.Width = 61;
            // 
            // gridScanspeed_empty
            // 
            this.gridScanspeed_empty.Caption = "X空行速度";
            this.gridScanspeed_empty.Name = "gridScanspeed_empty";
            this.gridScanspeed_empty.OptionsColumn.ReadOnly = true;
            this.gridScanspeed_empty.Visible = true;
            this.gridScanspeed_empty.VisibleIndex = 6;
            this.gridScanspeed_empty.Width = 61;
            // 
            // gridIndexspeed_empty
            // 
            this.gridIndexspeed_empty.Caption = "Y空行速度";
            this.gridIndexspeed_empty.Name = "gridIndexspeed_empty";
            this.gridIndexspeed_empty.OptionsColumn.ReadOnly = true;
            this.gridIndexspeed_empty.Visible = true;
            this.gridIndexspeed_empty.VisibleIndex = 7;
            this.gridIndexspeed_empty.Width = 61;
            // 
            // gridAuxspeed_empty
            // 
            this.gridAuxspeed_empty.Caption = "Z空行速度";
            this.gridAuxspeed_empty.Name = "gridAuxspeed_empty";
            this.gridAuxspeed_empty.OptionsColumn.ReadOnly = true;
            this.gridAuxspeed_empty.Visible = true;
            this.gridAuxspeed_empty.VisibleIndex = 8;
            this.gridAuxspeed_empty.Width = 61;
            // 
            // gridIdt_layouts
            // 
            this.gridIdt_layouts.Caption = "采用布局";
            this.gridIdt_layouts.Name = "gridIdt_layouts";
            this.gridIdt_layouts.OptionsColumn.ReadOnly = true;
            this.gridIdt_layouts.Visible = true;
            this.gridIdt_layouts.VisibleIndex = 9;
            this.gridIdt_layouts.Width = 61;
            // 
            // gridEdit
            // 
            this.gridEdit.ColumnEdit = this.repositoryItemButtonEdit;
            this.gridEdit.Name = "gridEdit";
            this.gridEdit.Visible = true;
            this.gridEdit.VisibleIndex = 10;
            this.gridEdit.Width = 61;
            // 
            // repositoryItemButtonEdit
            // 
            this.repositoryItemButtonEdit.AutoHeight = false;
            this.repositoryItemButtonEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "编辑", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.repositoryItemButtonEdit.Name = "repositoryItemButtonEdit";
            this.repositoryItemButtonEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEdit.Click += new System.EventHandler(this.repositoryItemButtonEdit_Click);
            // 
            // gridDelete
            // 
            this.gridDelete.ColumnEdit = this.repositoryItemButtonDelete;
            this.gridDelete.Name = "gridDelete";
            this.gridDelete.Visible = true;
            this.gridDelete.VisibleIndex = 11;
            this.gridDelete.Width = 76;
            // 
            // repositoryItemButtonDelete
            // 
            this.repositoryItemButtonDelete.AutoHeight = false;
            this.repositoryItemButtonDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "删除", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.repositoryItemButtonDelete.Name = "repositoryItemButtonDelete";
            this.repositoryItemButtonDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonDelete.Click += new System.EventHandler(this.repositoryItemButtonDelete_Click);
            // 
            // buttonLeadingin
            // 
            this.buttonLeadingin.Location = new System.Drawing.Point(118, 21);
            this.buttonLeadingin.Name = "buttonLeadingin";
            this.buttonLeadingin.Size = new System.Drawing.Size(75, 23);
            this.buttonLeadingin.TabIndex = 9;
            this.buttonLeadingin.Text = "导入";
            this.buttonLeadingin.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(22, 21);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "增加";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Productlines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 569);
            this.Controls.Add(this.buttonLeadingin);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.gridControl1);
            this.Name = "Productlines";
            this.Text = "产线";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Productlines_FormClosed);
            this.Load += new System.EventHandler(this.Productlines_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridId;
        private DevExpress.XtraGrid.Columns.GridColumn gridLinename;
        private DevExpress.XtraGrid.Columns.GridColumn gridLinekey;
        private DevExpress.XtraGrid.Columns.GridColumn gridScanspeed;
        private DevExpress.XtraGrid.Columns.GridColumn gridIndexspeed;
        private DevExpress.XtraGrid.Columns.GridColumn gridAuxspeed;
        private DevExpress.XtraGrid.Columns.GridColumn gridScanspeed_empty;
        private DevExpress.XtraGrid.Columns.GridColumn gridIndexspeed_empty;
        private DevExpress.XtraGrid.Columns.GridColumn gridAuxspeed_empty;
        private DevExpress.XtraGrid.Columns.GridColumn gridIdt_layouts;
        private DevExpress.XtraGrid.Columns.GridColumn gridEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit;
        private DevExpress.XtraGrid.Columns.GridColumn gridDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonDelete;
        private System.Windows.Forms.Button buttonLeadingin;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Timer timer1;
    }
}