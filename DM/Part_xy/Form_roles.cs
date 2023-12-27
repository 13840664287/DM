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
using System.Data.SQLite;
using DAL;

namespace DM
{
    public partial class Form_roles : Form
    {
        public Form_roles()
        {
            InitializeComponent();
        }

        private void Form_roles_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=" + Application.StartupPath + "\\m_sqlite.db;Version=3;";

            string tableName = "t_roles";
            gc_roles.DataSource = SQLite.returnUsersData(connectionString, tableName);
            gc_roles_id.FieldName = "id";
            gc_roles_rolename.FieldName = "rolename";
            gc_roles_notes.FieldName = "notes";

            //调整button的相对位置
            btn_roles_import.Location = new System.Drawing.Point(this.ClientSize.Width - 100, 10);
            btn_roles_add.Location = new System.Drawing.Point(this.ClientSize.Width - 200, 10);
        }

        /// <summary>
        /// form尺寸改变时改变button的相对位置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_roles_Resize(object sender, EventArgs e)
        {
            btn_roles_import.Location = new System.Drawing.Point(this.ClientSize.Width - 100, 10);
            btn_roles_add.Location = new System.Drawing.Point(this.ClientSize.Width - 200, 10);
        }

        private void btn_roles_import_Click(object sender, EventArgs e)
        {

        }

        private void btn_roles_delete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //获取当前有焦点的视图，转换成GridView类型
            GridView view = gc_roles.FocusedView as GridView;

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
                    string tablename = "t_roles";
                    SQLite.deleteTableData(connectionString, tablename, id.ToString());

                    // 刷新 GridControl
                    gc_roles.DataSource = SQLite.returnUsersData(connectionString, tablename);
                    view.RefreshData();
                }
            }
        }

        private void btn_roles_add_Click(object sender, EventArgs e)
        {
            Form_AddOrEdit_roles far = new Form_AddOrEdit_roles();
            far.Show();
        }

        private void btn_roles_edit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Form_AddOrEdit_roles far = new Form_AddOrEdit_roles();
            far.Show();
        }

        private void gc_roles_btn_auth_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //存放符合条件的行的r_roleandmodule的id
            List<int> list_auth_id = new List<int>();

            //获取当前有焦点的视图，转换成GridView类型
            GridView view = gc_roles.FocusedView as GridView;

            if (view != null)
            {
                // 获取按钮所在行的数据
                int rowHandle = view.FocusedRowHandle;
                DataRow row = view.GetDataRow(rowHandle);
                if (row != null)
                {
                    // 获取选定id
                    object id = row["id"];
                    // 执行查询
                    string queryString = "SELECT id FROM r_roleandmodule WHERE idt_roles = ?;";

                    using (SQLiteConnection connection = new SQLiteConnection(SQLite.connectionString))
                    {
                        connection.Open();
                        using (SQLiteCommand command = new SQLiteCommand(queryString, connection))
                        {
                            //填入占位参数
                            command.Parameters.AddWithValue("?", id);

                            using (SQLiteDataReader reader = command.ExecuteReader())
                            {
                                //查询表中每一行
                                while (reader.Read())
                                {                                
                                    // 获取查询结果
                                    object r_roleandmodule_id = reader["id"];
                                    //将对应的角色id存入list
                                    if (r_roleandmodule_id != null)
                                    {
                                        try
                                        {
                                            int convertedId = Convert.ToInt32(r_roleandmodule_id);
                                            list_auth_id.Add(convertedId);
                                        }
                                        catch (InvalidCastException)
                                        {
                                            Console.WriteLine("id转换失败");
                                        }
                                    }
                                }
                            }
                        }

                        connection.Close();
                    }
                }             
            }
            if (list_auth_id.Count > 0)
            {
                Form_auth_roleandmodule faram = new Form_auth_roleandmodule(list_auth_id);
                faram.Show();
            }
            else
            {
                MessageBox.Show("Error！");
                return;
            }
        }

        private void t_roles_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }
    }
}
