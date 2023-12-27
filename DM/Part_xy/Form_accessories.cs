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
    public partial class Form_accessories : Form
    {
        public Form_accessories()
        {
            InitializeComponent();
        }

        private void Form_accessories_Load(object sender, EventArgs e)
        {
            //加载数据
            string connectionString = "Data Source=" + Application.StartupPath + "\\m_sqlite.db;Version=3;";

            string tableName = "t_accessories";
            gc_accessories.DataSource = SQLite.returnUsersData(connectionString, tableName);
            gc_accessories_id.FieldName = "id";
            gc_accessories_accname.FieldName = "accname";
            gc_accessories_starttime.FieldName = "starttime";
            gc_accessories_acctype.FieldName = "acctype";
            gc_accessories_updatetime.FieldName = "updatetime";
            gc_accessories_circletime.FieldName = "circletime";
            gc_accessories_circleunit.FieldName = "circleunit";

            //调整button的相对位置
            btn_accessories_import.Location = new System.Drawing.Point(this.ClientSize.Width - 100, 10);
            btn_accessories_add.Location = new System.Drawing.Point(this.ClientSize.Width - 200, 10);
        }

        private void Form_accessories_Resize(object sender, EventArgs e)
        {
            //调整button的相对位置
            btn_accessories_import.Location = new System.Drawing.Point(this.ClientSize.Width - 100, 10);
            btn_accessories_add.Location = new System.Drawing.Point(this.ClientSize.Width - 200, 10);
        }

        private void btn_accessories_delete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //获取当前有焦点的视图，转换成GridView类型
            GridView view = gc_accessories.FocusedView as GridView;

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
                    string tablename = "t_accessories";
                    SQLite.deleteTableData(connectionString, tablename, id.ToString());

                    // 刷新 GridControl
                    gc_accessories.DataSource = SQLite.returnUsersData(connectionString, tablename);
                    view.RefreshData();
                }
            }
        }

        private void btn_accessories_add_Click(object sender, EventArgs e)
        {
            Form_AddOrEdit_accessories faa = new Form_AddOrEdit_accessories();
            faa.Show();
        }

        private void btn_accessories_edit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Form_AddOrEdit_accessories faa = new Form_AddOrEdit_accessories();
            faa.Show();
        }

        private void t_accessories_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }
    }
}
