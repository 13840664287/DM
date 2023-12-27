using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DAL;

namespace DM
{
    public partial class Form_roleandmodule : Form
    {
        public Form_roleandmodule()
        {
            InitializeComponent();
        }

        private void Form_roleandmodule_Load(object sender, EventArgs e)
        {
            //加载数据库内容
            string connectionString = "Data Source=" + Application.StartupPath + "\\m_sqlite.db;Version=3;";

            string tableName = "r_roleandmodule";
            gc_roleandmodule.DataSource = SQLite.returnUsersData(connectionString, tableName);
            gc_roleandmodule_id.FieldName = "id";
            gc_roleandmodule_idt_roles.FieldName = "idt_roles";
            gc_roleandmodule_idt_modules.FieldName = "idt_modules";

            //调整button的相对位置
            btn_roleandmodule_import.Location = new System.Drawing.Point(this.ClientSize.Width - 100, 10);
            btn_roleandmodule_add.Location = new System.Drawing.Point(this.ClientSize.Width - 200, 10);
        }

        /// <summary>
        /// form尺寸改变时改变button的相对位置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_roleandmodule_Resize(object sender, EventArgs e)
        {
            btn_roleandmodule_import.Location = new System.Drawing.Point(this.ClientSize.Width - 100, 10);
            btn_roleandmodule_add.Location = new System.Drawing.Point(this.ClientSize.Width - 200, 10);
        }

        private void btn_roleandmodule_delete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //获取当前有焦点的视图，转换成GridView类型
            GridView view = gc_roleandmodule.FocusedView as GridView;

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
                    string tablename = "r_roleandmodule";
                    SQLite.deleteTableData(connectionString, tablename, id.ToString());

                    // 刷新 GridControl
                    gc_roleandmodule.DataSource = SQLite.returnUsersData(connectionString, tablename);
                    view.RefreshData();
                }
            }
        }

        private void btn_roleandmodule_add_Click(object sender, EventArgs e)
        {
            Form_AddOrEdit_roleandmodule faram = new Form_AddOrEdit_roleandmodule();
            faram.Show();
        }

        private void btn_roleandmodule_edit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Form_AddOrEdit_roleandmodule faram = new Form_AddOrEdit_roleandmodule();
            faram.Show();
        }

        private void r_roleandmodule_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }
    }
}
