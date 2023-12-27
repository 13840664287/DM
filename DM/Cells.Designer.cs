namespace DM
{
    partial class Cells
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
            this.gridRowno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridSafypointx = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridZeropointx = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridSafypointy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridZeropointy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridSafypointz = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridZeropointz = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridIdt_layouts = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridIdt_products = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.gridControl1.Location = new System.Drawing.Point(12, 41);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit,
            this.repositoryItemButtonDelete});
            this.gridControl1.Size = new System.Drawing.Size(822, 279);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridId,
            this.gridRowno,
            this.gridColno,
            this.gridSafypointx,
            this.gridZeropointx,
            this.gridSafypointy,
            this.gridZeropointy,
            this.gridSafypointz,
            this.gridZeropointz,
            this.gridIdt_layouts,
            this.gridIdt_products,
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
            // gridRowno
            // 
            this.gridRowno.Caption = "行号";
            this.gridRowno.Name = "gridRowno";
            this.gridRowno.OptionsColumn.ReadOnly = true;
            this.gridRowno.Visible = true;
            this.gridRowno.VisibleIndex = 1;
            this.gridRowno.Width = 63;
            // 
            // gridColno
            // 
            this.gridColno.Caption = "列号";
            this.gridColno.Name = "gridColno";
            this.gridColno.OptionsColumn.ReadOnly = true;
            this.gridColno.Visible = true;
            this.gridColno.VisibleIndex = 2;
            this.gridColno.Width = 63;
            // 
            // gridSafypointx
            // 
            this.gridSafypointx.Caption = "安全点x";
            this.gridSafypointx.Name = "gridSafypointx";
            this.gridSafypointx.OptionsColumn.ReadOnly = true;
            this.gridSafypointx.Visible = true;
            this.gridSafypointx.VisibleIndex = 3;
            this.gridSafypointx.Width = 63;
            // 
            // gridZeropointx
            // 
            this.gridZeropointx.Caption = "零点x";
            this.gridZeropointx.Name = "gridZeropointx";
            this.gridZeropointx.OptionsColumn.ReadOnly = true;
            this.gridZeropointx.Visible = true;
            this.gridZeropointx.VisibleIndex = 4;
            this.gridZeropointx.Width = 63;
            // 
            // gridSafypointy
            // 
            this.gridSafypointy.Caption = "安全点y";
            this.gridSafypointy.Name = "gridSafypointy";
            this.gridSafypointy.OptionsColumn.ReadOnly = true;
            this.gridSafypointy.Visible = true;
            this.gridSafypointy.VisibleIndex = 5;
            this.gridSafypointy.Width = 63;
            // 
            // gridZeropointy
            // 
            this.gridZeropointy.Caption = "零点y";
            this.gridZeropointy.Name = "gridZeropointy";
            this.gridZeropointy.OptionsColumn.ReadOnly = true;
            this.gridZeropointy.Visible = true;
            this.gridZeropointy.VisibleIndex = 6;
            this.gridZeropointy.Width = 63;
            // 
            // gridSafypointz
            // 
            this.gridSafypointz.Caption = "安全点z";
            this.gridSafypointz.Name = "gridSafypointz";
            this.gridSafypointz.OptionsColumn.ReadOnly = true;
            this.gridSafypointz.Visible = true;
            this.gridSafypointz.VisibleIndex = 7;
            this.gridSafypointz.Width = 63;
            // 
            // gridZeropointz
            // 
            this.gridZeropointz.Caption = "零点z";
            this.gridZeropointz.Name = "gridZeropointz";
            this.gridZeropointz.OptionsColumn.ReadOnly = true;
            this.gridZeropointz.Visible = true;
            this.gridZeropointz.VisibleIndex = 8;
            this.gridZeropointz.Width = 63;
            // 
            // gridIdt_layouts
            // 
            this.gridIdt_layouts.Caption = "所属布局";
            this.gridIdt_layouts.Name = "gridIdt_layouts";
            this.gridIdt_layouts.OptionsColumn.ReadOnly = true;
            this.gridIdt_layouts.Visible = true;
            this.gridIdt_layouts.VisibleIndex = 9;
            this.gridIdt_layouts.Width = 63;
            // 
            // gridIdt_products
            // 
            this.gridIdt_products.Caption = "放置产品";
            this.gridIdt_products.Name = "gridIdt_products";
            this.gridIdt_products.OptionsColumn.ReadOnly = true;
            this.gridIdt_products.Visible = true;
            this.gridIdt_products.VisibleIndex = 10;
            this.gridIdt_products.Width = 63;
            // 
            // gridEdit
            // 
            this.gridEdit.ColumnEdit = this.repositoryItemButtonEdit;
            this.gridEdit.Name = "gridEdit";
            this.gridEdit.Visible = true;
            this.gridEdit.VisibleIndex = 11;
            this.gridEdit.Width = 63;
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
            this.gridDelete.VisibleIndex = 12;
            this.gridDelete.Width = 81;
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
            this.buttonLeadingin.Location = new System.Drawing.Point(108, 12);
            this.buttonLeadingin.Name = "buttonLeadingin";
            this.buttonLeadingin.Size = new System.Drawing.Size(75, 23);
            this.buttonLeadingin.TabIndex = 9;
            this.buttonLeadingin.Text = "导入";
            this.buttonLeadingin.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 12);
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
            // Cells
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 340);
            this.Controls.Add(this.buttonLeadingin);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.gridControl1);
            this.Name = "Cells";
            this.Text = "布局单元";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Cells_FormClosed);
            this.Load += new System.EventHandler(this.Cells_Load);
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
        private DevExpress.XtraGrid.Columns.GridColumn gridRowno;
        private DevExpress.XtraGrid.Columns.GridColumn gridColno;
        private DevExpress.XtraGrid.Columns.GridColumn gridSafypointx;
        private DevExpress.XtraGrid.Columns.GridColumn gridZeropointx;
        private DevExpress.XtraGrid.Columns.GridColumn gridSafypointy;
        private DevExpress.XtraGrid.Columns.GridColumn gridZeropointy;
        private DevExpress.XtraGrid.Columns.GridColumn gridSafypointz;
        private DevExpress.XtraGrid.Columns.GridColumn gridZeropointz;
        private DevExpress.XtraGrid.Columns.GridColumn gridIdt_layouts;
        private DevExpress.XtraGrid.Columns.GridColumn gridIdt_products;
        private System.Windows.Forms.Button buttonLeadingin;
        private System.Windows.Forms.Button buttonAdd;
        private DevExpress.XtraGrid.Columns.GridColumn gridEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit;
        private DevExpress.XtraGrid.Columns.GridColumn gridDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonDelete;
        private System.Windows.Forms.Timer timer1;
    }
}