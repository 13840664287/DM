namespace DM
{
    partial class Layouts
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
            this.gridLayoutname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridRows = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridCols = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.gridControl1.Location = new System.Drawing.Point(12, 40);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonDelete,
            this.repositoryItemButtonEdit});
            this.gridControl1.Size = new System.Drawing.Size(454, 200);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridId,
            this.gridLayoutname,
            this.gridRows,
            this.gridCols,
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
            // gridLayoutname
            // 
            this.gridLayoutname.Caption = "名称";
            this.gridLayoutname.Name = "gridLayoutname";
            this.gridLayoutname.OptionsColumn.ReadOnly = true;
            this.gridLayoutname.Visible = true;
            this.gridLayoutname.VisibleIndex = 1;
            this.gridLayoutname.Width = 80;
            // 
            // gridRows
            // 
            this.gridRows.Caption = "行数";
            this.gridRows.Name = "gridRows";
            this.gridRows.OptionsColumn.ReadOnly = true;
            this.gridRows.Visible = true;
            this.gridRows.VisibleIndex = 2;
            this.gridRows.Width = 80;
            // 
            // gridCols
            // 
            this.gridCols.Caption = "列数";
            this.gridCols.Name = "gridCols";
            this.gridCols.OptionsColumn.ReadOnly = true;
            this.gridCols.Visible = true;
            this.gridCols.VisibleIndex = 3;
            this.gridCols.Width = 80;
            // 
            // gridEdit
            // 
            this.gridEdit.ColumnEdit = this.repositoryItemButtonEdit;
            this.gridEdit.Name = "gridEdit";
            this.gridEdit.Visible = true;
            this.gridEdit.VisibleIndex = 4;
            this.gridEdit.Width = 80;
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
            this.gridDelete.VisibleIndex = 5;
            this.gridDelete.Width = 86;
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
            this.buttonLeadingin.Location = new System.Drawing.Point(108, 11);
            this.buttonLeadingin.Name = "buttonLeadingin";
            this.buttonLeadingin.Size = new System.Drawing.Size(75, 23);
            this.buttonLeadingin.TabIndex = 9;
            this.buttonLeadingin.Text = "导入";
            this.buttonLeadingin.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 11);
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
            // Layouts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 272);
            this.Controls.Add(this.buttonLeadingin);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.gridControl1);
            this.Name = "Layouts";
            this.Text = "工位布局";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Layouts_FormClosed);
            this.Load += new System.EventHandler(this.Layouts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridLayoutname;
        private DevExpress.XtraGrid.Columns.GridColumn gridRows;
        private DevExpress.XtraGrid.Columns.GridColumn gridCols;
        private System.Windows.Forms.Button buttonLeadingin;
        private System.Windows.Forms.Button buttonAdd;
        private DevExpress.XtraGrid.Columns.GridColumn gridEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit;
        private DevExpress.XtraGrid.Columns.GridColumn gridDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonDelete;
        private DevExpress.XtraGrid.Columns.GridColumn gridId;
        private System.Windows.Forms.Timer timer1;
    }
}