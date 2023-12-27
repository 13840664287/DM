using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using DevExpress.XtraGrid.Views.Grid;
using DAL;

namespace DM
{
    public partial class Form_users : Form
    {
        public Form_users()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=" + Application.StartupPath + "\\m_sqlite.db;Version=3;";
            SQLite.CreateTable(connectionString);
            //SQLite.InsertData(connectionString);

            string tableName = "t_users";
            DataTable dataTable = SQLite.returnUsersData(connectionString, tableName);

            gc_users.DataSource = dataTable;
            gc_users_id.FieldName = "id";
            gc_users_username.FieldName = "username";
            gc_users_userpwd.FieldName = "userpwd";
            gc_users_realname.FieldName = "realname";
            gc_users_idt_role.FieldName = "idt_role";
           
            //调整button的相对位置
            btn_users_import.Location = new System.Drawing.Point(this.ClientSize.Width - 100, 10);
            btn_users_add.Location = new System.Drawing.Point(this.ClientSize.Width - 200, 10);
        }

        private void btn_users_edit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Form_AddOrEdit_users faor = new Form_AddOrEdit_users();
            faor.Show();
        }

        private void btn_users_delete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //获取当前有焦点的视图，转换成GridView类型
            GridView view = gc_users.FocusedView as GridView;

            if (view != null)
            {
                // 获取按钮所在行的数据
                int rowHandle = view.FocusedRowHandle;
                DataRow row = view.GetDataRow(rowHandle);

                if (row != null)
                {
                    // 获取选定id
                    object id = row["id"];

                    //删除数据库内容
                    string connectionString = "Data Source=" + Application.StartupPath + "\\m_sqlite.db;Version=3;";
                    string tablename = "t_users";
                    SQLite.deleteTableData(connectionString, tablename, id.ToString());

                    // 刷新 GridControl
                    gc_users.DataSource = SQLite.returnUsersData(connectionString, tablename);
                    view.RefreshData();
                }
            }
        }

        /// <summary>
        /// form尺寸改变时改变button的相对位置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_users_Resize(object sender, EventArgs e)
        {
            btn_users_import.Location = new System.Drawing.Point(this.ClientSize.Width - 100, 10);
            btn_users_add.Location = new System.Drawing.Point(this.ClientSize.Width - 200, 10);
        }

        private void btn_open_roles_Click(object sender, EventArgs e)
        {
            Form_roles fr = new Form_roles();
            fr.Show();
        }

        private void btn_open_modules_Click(object sender, EventArgs e)
        {
            Form_modules fm = new Form_modules();
            fm.Show();
        }

        private void btn_open_roleandmodule_Click(object sender, EventArgs e)
        {
            Form_roleandmodule fram = new Form_roleandmodule();
            fram.Show();
        }

        private void btn_users_add_Click(object sender, EventArgs e)
        {
            Form_AddOrEdit_users fau = new Form_AddOrEdit_users();
            fau.Show();
        }

        private void btn_open_accessories_Click(object sender, EventArgs e)
        {
            Form_accessories fa = new Form_accessories();
            fa.Show();
        }

        private void t_users_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if(e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        /// <summary>
        /// 用户表编辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gc_users_btn_edit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //获取当前有焦点的视图，转换成GridView类型
            GridView view = gc_users.FocusedView as GridView;
            string id = null;
            if (view != null)
            {
                // 获取按钮所在行的数据
                int rowHandle = view.FocusedRowHandle;
                DataRow row = view.GetDataRow(rowHandle);

                if (row != null)
                {
                    // 获取选定id
                    id = row["id"].ToString();
                }
            }
            if(id != null)
            {
                Form_AddOrEdit_users fau = new Form_AddOrEdit_users(id);
                fau.Show();
            }
        }

        private void gc_users_btn_delete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //获取当前有焦点的视图，转换成GridView类型
            GridView view = gc_users.FocusedView as GridView;

            if (view != null)
            {
                // 获取按钮所在行的数据
                int rowHandle = view.FocusedRowHandle;
                DataRow row = view.GetDataRow(rowHandle);

                if (row != null)
                {
                    // 获取选定id
                    object id = row["id"];

                    //删除数据库内容
                    string connectionString = "Data Source=" + Application.StartupPath + "\\m_sqlite.db;Version=3;";
                    string tablename = "t_users";
                    SQLite.deleteTableData(connectionString, tablename, id.ToString());

                    // 刷新 GridControl
                    gc_users.DataSource = SQLite.returnUsersData(connectionString, tablename);
                    view.RefreshData();
                }
            }
        }
    }
}
