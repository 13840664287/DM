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
    public partial class Form_modules : Form
    {
        public Form_modules()
        {
            InitializeComponent();
        }

        private void Form_modules_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=" + Application.StartupPath + "\\m_sqlite.db;Version=3;";

            string tableName = "t_modules";
            gc_modules.DataSource = SQLite.returnUsersData(connectionString, tableName);
            gc_modules_id.FieldName = "id";
            gc_modules_modulename.FieldName = "modulename";
            gc_modules_modulekey.FieldName = "modulekey";

            //调整button的相对位置
            btn_modules_import.Location = new System.Drawing.Point(this.ClientSize.Width - 100, 10);
            btn_modules_add.Location = new System.Drawing.Point(this.ClientSize.Width - 200, 10);
        }

        /// <summary>
        /// form尺寸改变时改变button的相对位置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_modules_Resize(object sender, EventArgs e)
        {
            btn_modules_import.Location = new System.Drawing.Point(this.ClientSize.Width - 100, 10);
            btn_modules_add.Location = new System.Drawing.Point(this.ClientSize.Width - 200, 10);
        }

        private void btn_modules_delete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //获取当前有焦点的视图，转换成GridView类型
            GridView view = gc_modules.FocusedView as GridView;

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
                    string tablename = "t_modules";
                    SQLite.deleteTableData(connectionString, tablename, id.ToString());

                    // 刷新 GridControl
                    gc_modules.DataSource = SQLite.returnUsersData(connectionString, tablename);
                    view.RefreshData();
                }
            }
        }

        private void btn_modules_add_Click(object sender, EventArgs e)
        {
            Form_AddOrEdit_modules fam = new Form_AddOrEdit_modules();
            fam.Show();
        }

        private void btn_modules_edit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Form_AddOrEdit_modules fam = new Form_AddOrEdit_modules();
            fam.Show();
        }

        private void t_modules_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if(e.Info.IsRowIndicator && e.RowHandle >=0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void t_modules_CustomRowCellEdit(object sender, CustomRowCellEditEventArgs e)
        {

        }
    }
}
