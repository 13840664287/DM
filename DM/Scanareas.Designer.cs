namespace DM
{
    partial class Scanareas
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.repositoryItemButtonEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemButtonDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridAreano = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridOffsetx = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridOffsety = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridOffsetz = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridScanlen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridIndexlen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridScanres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridIndexres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridIdt_products = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnEdit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumnDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonLeadingin = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit2)).BeginInit();
            this.SuspendLayout();
            // 
            // repositoryItemButtonEdit
            // 
            this.repositoryItemButtonEdit.AutoHeight = false;
            this.repositoryItemButtonEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "编辑", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, "", null, null, true)});
            this.repositoryItemButtonEdit.Name = "repositoryItemButtonEdit";
            this.repositoryItemButtonEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // repositoryItemButtonDelete
            // 
            this.repositoryItemButtonDelete.AutoHeight = false;
            this.repositoryItemButtonDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "删除", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject6, "", null, null, true)});
            this.repositoryItemButtonDelete.Name = "repositoryItemButtonDelete";
            this.repositoryItemButtonDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 41);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1,
            this.repositoryItemButtonEdit2});
            this.gridControl1.Size = new System.Drawing.Size(838, 324);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridId,
            this.gridAreano,
            this.gridOffsetx,
            this.gridOffsety,
            this.gridOffsetz,
            this.gridScanlen,
            this.gridIndexlen,
            this.gridScanres,
            this.gridIndexres,
            this.gridIdt_products,
            this.gridColumnEdit,
            this.gridColumnDelete});
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
            // gridAreano
            // 
            this.gridAreano.Caption = "区域编号";
            this.gridAreano.Name = "gridAreano";
            this.gridAreano.OptionsColumn.ReadOnly = true;
            this.gridAreano.Visible = true;
            this.gridAreano.VisibleIndex = 1;
            // 
            // gridOffsetx
            // 
            this.gridOffsetx.Caption = "偏移x";
            this.gridOffsetx.Name = "gridOffsetx";
            this.gridOffsetx.OptionsColumn.ReadOnly = true;
            this.gridOffsetx.Visible = true;
            this.gridOffsetx.VisibleIndex = 2;
            // 
            // gridOffsety
            // 
            this.gridOffsety.Caption = "偏移y";
            this.gridOffsety.Name = "gridOffsety";
            this.gridOffsety.OptionsColumn.ReadOnly = true;
            this.gridOffsety.Visible = true;
            this.gridOffsety.VisibleIndex = 3;
            // 
            // gridOffsetz
            // 
            this.gridOffsetz.Caption = "偏移z";
            this.gridOffsetz.Name = "gridOffsetz";
            this.gridOffsetz.OptionsColumn.ReadOnly = true;
            this.gridOffsetz.Visible = true;
            this.gridOffsetz.VisibleIndex = 4;
            // 
            // gridScanlen
            // 
            this.gridScanlen.Caption = "扫查距离";
            this.gridScanlen.Name = "gridScanlen";
            this.gridScanlen.OptionsColumn.ReadOnly = true;
            this.gridScanlen.Visible = true;
            this.gridScanlen.VisibleIndex = 5;
            // 
            // gridIndexlen
            // 
            this.gridIndexlen.Caption = "步进距离";
            this.gridIndexlen.Name = "gridIndexlen";
            this.gridIndexlen.OptionsColumn.ReadOnly = true;
            this.gridIndexlen.Visible = true;
            this.gridIndexlen.VisibleIndex = 6;
            // 
            // gridScanres
            // 
            this.gridScanres.Caption = "扫查精度";
            this.gridScanres.Name = "gridScanres";
            this.gridScanres.OptionsColumn.ReadOnly = true;
            this.gridScanres.Visible = true;
            this.gridScanres.VisibleIndex = 7;
            // 
            // gridIndexres
            // 
            this.gridIndexres.Caption = "步进精度";
            this.gridIndexres.Name = "gridIndexres";
            this.gridIndexres.OptionsColumn.ReadOnly = true;
            this.gridIndexres.Visible = true;
            this.gridIndexres.VisibleIndex = 8;
            // 
            // gridIdt_products
            // 
            this.gridIdt_products.Caption = "所属产品";
            this.gridIdt_products.Name = "gridIdt_products";
            this.gridIdt_products.OptionsColumn.ReadOnly = true;
            this.gridIdt_products.Visible = true;
            this.gridIdt_products.VisibleIndex = 9;
            // 
            // gridColumnEdit
            // 
            this.gridColumnEdit.ColumnEdit = this.repositoryItemButtonEdit1;
            this.gridColumnEdit.Name = "gridColumnEdit";
            this.gridColumnEdit.Visible = true;
            this.gridColumnEdit.VisibleIndex = 10;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "编辑", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject7, "", null, null, true)});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEdit1.Click += new System.EventHandler(this.repositoryItemButtonEdit_Click);
            // 
            // gridColumnDelete
            // 
            this.gridColumnDelete.ColumnEdit = this.repositoryItemButtonEdit2;
            this.gridColumnDelete.Name = "gridColumnDelete";
            this.gridColumnDelete.Visible = true;
            this.gridColumnDelete.VisibleIndex = 11;
            // 
            // repositoryItemButtonEdit2
            // 
            this.repositoryItemButtonEdit2.AutoHeight = false;
            this.repositoryItemButtonEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "删除", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject8, "", null, null, true)});
            this.repositoryItemButtonEdit2.Name = "repositoryItemButtonEdit2";
            this.repositoryItemButtonEdit2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEdit2.Click += new System.EventHandler(this.repositoryItemButtonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 12);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "增加";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click_1);
            // 
            // buttonLeadingin
            // 
            this.buttonLeadingin.Location = new System.Drawing.Point(93, 12);
            this.buttonLeadingin.Name = "buttonLeadingin";
            this.buttonLeadingin.Size = new System.Drawing.Size(75, 23);
            this.buttonLeadingin.TabIndex = 7;
            this.buttonLeadingin.Text = "导入";
            this.buttonLeadingin.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Scanareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 393);
            this.Controls.Add(this.buttonLeadingin);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.gridControl1);
            this.Name = "Scanareas";
            this.Text = "扫查区域";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Scanareas_FormClosed);
            this.Load += new System.EventHandler(this.Scanareas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridId;
        private DevExpress.XtraGrid.Columns.GridColumn gridAreano;
        private DevExpress.XtraGrid.Columns.GridColumn gridOffsetx;
        private DevExpress.XtraGrid.Columns.GridColumn gridOffsety;
        private DevExpress.XtraGrid.Columns.GridColumn gridOffsetz;
        private DevExpress.XtraGrid.Columns.GridColumn gridScanlen;
        private DevExpress.XtraGrid.Columns.GridColumn gridIndexlen;
        private DevExpress.XtraGrid.Columns.GridColumn gridScanres;
        private DevExpress.XtraGrid.Columns.GridColumn gridIndexres;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonLeadingin;
        private DevExpress.XtraGrid.Columns.GridColumn gridIdt_products;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonDelete;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit2;
    }
}