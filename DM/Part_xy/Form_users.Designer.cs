namespace DM
{
    partial class Form_users
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.gc_users = new DevExpress.XtraGrid.GridControl();
            this.t_users = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gc_users_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_users_username = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_users_userpwd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_users_realname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_users_photo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_users_idt_role = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_users_edit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_users_btn_edit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gc_users_delete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_users_btn_delete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btn_users_add = new DevExpress.XtraEditors.SimpleButton();
            this.btn_users_import = new DevExpress.XtraEditors.SimpleButton();
            this.btn_open_roles = new DevExpress.XtraEditors.SimpleButton();
            this.btn_open_modules = new DevExpress.XtraEditors.SimpleButton();
            this.btn_open_roleandmodule = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_open_accessories = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_users)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_users)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_users_btn_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_users_btn_delete)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gc_users
            // 
            this.gc_users.AccessibleName = "";
            this.gc_users.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_users.Location = new System.Drawing.Point(0, 80);
            this.gc_users.MainView = this.t_users;
            this.gc_users.Margin = new System.Windows.Forms.Padding(0);
            this.gc_users.Name = "gc_users";
            this.gc_users.Padding = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.gc_users.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.gc_users_btn_edit,
            this.gc_users_btn_delete});
            this.gc_users.Size = new System.Drawing.Size(1082, 526);
            this.gc_users.TabIndex = 1;
            this.gc_users.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.t_users});
            // 
            // t_users
            // 
            this.t_users.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gc_users_id,
            this.gc_users_username,
            this.gc_users_userpwd,
            this.gc_users_realname,
            this.gc_users_photo,
            this.gc_users_idt_role,
            this.gc_users_delete,
            this.gc_users_edit});
            this.t_users.GridControl = this.gc_users;
            this.t_users.IndicatorWidth = 60;
            this.t_users.Name = "t_users";
            this.t_users.OptionsBehavior.ReadOnly = true;
            this.t_users.OptionsView.ShowGroupPanel = false;
            this.t_users.ViewCaption = "用户表";
            this.t_users.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.t_users_CustomDrawRowIndicator);
            // 
            // gc_users_id
            // 
            this.gc_users_id.Caption = "ID";
            this.gc_users_id.Name = "gc_users_id";
            // 
            // gc_users_username
            // 
            this.gc_users_username.Caption = "用户名";
            this.gc_users_username.Name = "gc_users_username";
            this.gc_users_username.Visible = true;
            this.gc_users_username.VisibleIndex = 0;
            this.gc_users_username.Width = 145;
            // 
            // gc_users_userpwd
            // 
            this.gc_users_userpwd.Caption = "密码";
            this.gc_users_userpwd.Name = "gc_users_userpwd";
            this.gc_users_userpwd.Visible = true;
            this.gc_users_userpwd.VisibleIndex = 1;
            this.gc_users_userpwd.Width = 145;
            // 
            // gc_users_realname
            // 
            this.gc_users_realname.Caption = "真实姓名";
            this.gc_users_realname.Name = "gc_users_realname";
            this.gc_users_realname.Visible = true;
            this.gc_users_realname.VisibleIndex = 2;
            this.gc_users_realname.Width = 145;
            // 
            // gc_users_photo
            // 
            this.gc_users_photo.Caption = "头像";
            this.gc_users_photo.Name = "gc_users_photo";
            this.gc_users_photo.Visible = true;
            this.gc_users_photo.VisibleIndex = 3;
            this.gc_users_photo.Width = 145;
            // 
            // gc_users_idt_role
            // 
            this.gc_users_idt_role.Caption = "角色id";
            this.gc_users_idt_role.Name = "gc_users_idt_role";
            this.gc_users_idt_role.Visible = true;
            this.gc_users_idt_role.VisibleIndex = 4;
            this.gc_users_idt_role.Width = 145;
            // 
            // gc_users_edit
            // 
            this.gc_users_edit.Caption = "操作";
            this.gc_users_edit.ColumnEdit = this.gc_users_btn_edit;
            this.gc_users_edit.Name = "gc_users_edit";
            this.gc_users_edit.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.gc_users_edit.Visible = true;
            this.gc_users_edit.VisibleIndex = 6;
            this.gc_users_edit.Width = 80;
            // 
            // gc_users_btn_edit
            // 
            this.gc_users_btn_edit.AutoHeight = false;
            this.gc_users_btn_edit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "编辑", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject6, "", null, null, true)});
            this.gc_users_btn_edit.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.gc_users_btn_edit.Name = "gc_users_btn_edit";
            this.gc_users_btn_edit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.gc_users_btn_edit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.gc_users_btn_edit_ButtonClick);
            // 
            // gc_users_delete
            // 
            this.gc_users_delete.Caption = "操作";
            this.gc_users_delete.ColumnEdit = this.gc_users_btn_delete;
            this.gc_users_delete.Name = "gc_users_delete";
            this.gc_users_delete.Visible = true;
            this.gc_users_delete.VisibleIndex = 5;
            this.gc_users_delete.Width = 80;
            // 
            // gc_users_btn_delete
            // 
            this.gc_users_btn_delete.AutoHeight = false;
            this.gc_users_btn_delete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "删除", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, "", null, null, true)});
            this.gc_users_btn_delete.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.gc_users_btn_delete.Name = "gc_users_btn_delete";
            this.gc_users_btn_delete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.gc_users_btn_delete.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.gc_users_btn_delete_ButtonClick);
            // 
            // btn_users_add
            // 
            this.btn_users_add.Location = new System.Drawing.Point(820, 20);
            this.btn_users_add.Name = "btn_users_add";
            this.btn_users_add.Size = new System.Drawing.Size(100, 40);
            this.btn_users_add.TabIndex = 2;
            this.btn_users_add.Text = "增加";
            this.btn_users_add.Click += new System.EventHandler(this.btn_users_add_Click);
            // 
            // btn_users_import
            // 
            this.btn_users_import.Location = new System.Drawing.Point(945, 20);
            this.btn_users_import.Name = "btn_users_import";
            this.btn_users_import.Size = new System.Drawing.Size(100, 40);
            this.btn_users_import.TabIndex = 3;
            this.btn_users_import.Text = "导入";
            // 
            // btn_open_roles
            // 
            this.btn_open_roles.Location = new System.Drawing.Point(12, 15);
            this.btn_open_roles.Name = "btn_open_roles";
            this.btn_open_roles.Size = new System.Drawing.Size(100, 40);
            this.btn_open_roles.TabIndex = 4;
            this.btn_open_roles.Text = "角色表";
            this.btn_open_roles.Click += new System.EventHandler(this.btn_open_roles_Click);
            // 
            // btn_open_modules
            // 
            this.btn_open_modules.Location = new System.Drawing.Point(134, 15);
            this.btn_open_modules.Name = "btn_open_modules";
            this.btn_open_modules.Size = new System.Drawing.Size(100, 40);
            this.btn_open_modules.TabIndex = 5;
            this.btn_open_modules.Text = "功能表";
            this.btn_open_modules.Click += new System.EventHandler(this.btn_open_modules_Click);
            // 
            // btn_open_roleandmodule
            // 
            this.btn_open_roleandmodule.Location = new System.Drawing.Point(256, 15);
            this.btn_open_roleandmodule.Name = "btn_open_roleandmodule";
            this.btn_open_roleandmodule.Size = new System.Drawing.Size(100, 40);
            this.btn_open_roleandmodule.TabIndex = 6;
            this.btn_open_roleandmodule.Text = "角色-功能";
            this.btn_open_roleandmodule.Click += new System.EventHandler(this.btn_open_roleandmodule_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_open_accessories);
            this.panel1.Controls.Add(this.btn_open_roleandmodule);
            this.panel1.Controls.Add(this.btn_open_roles);
            this.panel1.Controls.Add(this.btn_open_modules);
            this.panel1.Location = new System.Drawing.Point(3, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 69);
            this.panel1.TabIndex = 7;
            // 
            // btn_open_accessories
            // 
            this.btn_open_accessories.Location = new System.Drawing.Point(378, 15);
            this.btn_open_accessories.Name = "btn_open_accessories";
            this.btn_open_accessories.Size = new System.Drawing.Size(100, 40);
            this.btn_open_accessories.TabIndex = 7;
            this.btn_open_accessories.Text = "易损/点检";
            this.btn_open_accessories.Click += new System.EventHandler(this.btn_open_accessories_Click);
            // 
            // Form_users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 606);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_users_import);
            this.Controls.Add(this.btn_users_add);
            this.Controls.Add(this.gc_users);
            this.Name = "Form_users";
            this.Padding = new System.Windows.Forms.Padding(0, 80, 0, 0);
            this.Text = "用户表";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form_users_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_users)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_users)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_users_btn_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_users_btn_delete)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraGrid.GridControl gc_users;
        private DevExpress.XtraGrid.Views.Grid.GridView t_users;
        private DevExpress.XtraGrid.Columns.GridColumn gc_users_id;
        private DevExpress.XtraGrid.Columns.GridColumn gc_users_username;
        private DevExpress.XtraGrid.Columns.GridColumn gc_users_userpwd;
        private DevExpress.XtraGrid.Columns.GridColumn gc_users_realname;
        private DevExpress.XtraGrid.Columns.GridColumn gc_users_photo;
        private DevExpress.XtraGrid.Columns.GridColumn gc_users_idt_role;
        private DevExpress.XtraGrid.Columns.GridColumn gc_users_delete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit gc_users_btn_delete;
        private DevExpress.XtraGrid.Columns.GridColumn gc_users_edit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit gc_users_btn_edit;
        private DevExpress.XtraEditors.SimpleButton btn_users_add;
        private DevExpress.XtraEditors.SimpleButton btn_users_import;
        private DevExpress.XtraEditors.SimpleButton btn_open_roles;
        private DevExpress.XtraEditors.SimpleButton btn_open_modules;
        private DevExpress.XtraEditors.SimpleButton btn_open_roleandmodule;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btn_open_accessories;
    }
}

