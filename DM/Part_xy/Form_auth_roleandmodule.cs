using DAL;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DM
{
    public partial class Form_auth_roleandmodule : Form
    {
        public Form_auth_roleandmodule()
        {
            InitializeComponent();
        }
        public Form_auth_roleandmodule(List<int> list_auth_id)
        {
            InitializeComponent();
            //存储关系表的idt_modules
            List<int> list_auth_idt_modules = new List<int>();
            DataTable dataTable = new DataTable();
            using (SQLiteConnection connection = new SQLiteConnection(SQLite.connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand("SELECT idt_modules FROM r_roleandmodule WHERE id = ?" , connection))
                {
                    foreach(int id in list_auth_id)
                    {
                        command.Parameters.AddWithValue("?", id);
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // 读取 idt_modules 值
                                list_auth_idt_modules.Add(Convert.ToInt32(reader["idt_modules"]));
                            }
                        }
                    }
                }

                //构建 SQL 查询语句
               StringBuilder queryBuilder = new StringBuilder("SELECT id, modulename, modulekey FROM t_modules WHERE id IN (");
                queryBuilder.Append(string.Join(", ", list_auth_idt_modules.Select(v => $"@param{v}")));
                queryBuilder.Append(")");

                using (SQLiteCommand command = new SQLiteCommand(queryBuilder.ToString(), connection))
                {
                    // 添加参数
                    foreach (int value in list_auth_idt_modules)
                    {
                        command.Parameters.AddWithValue($"@param{value}", value);
                    }

                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }

                foreach (DataRow row in dataTable.Rows)
                {
                    int id = Convert.ToInt32(row["id"]);
                    string moduleName = row["modulename"].ToString();
                    string moduleKey = row["modulekey"].ToString();

                    Console.WriteLine($"ID: {id}, ModuleName: {moduleName}, ModuleKey: {moduleKey}");
                }              
                connection.Close();
            }
            dataTable.Columns.Add("select", typeof(bool));
            foreach (DataRow row in dataTable.Rows)
            {
                row["select"] = true; // 设置默认值为 true，或者根据需要设置为其他值
            }
            gc_roleandmodule.DataSource = dataTable;
            gc_roleandmodule_modulename.FieldName = "modulename";
            gc_roleandmodule_modulekey.FieldName = "modulekey";
            gc_roleandmodule_select.FieldName = "select";
        }

        private void Form_auth_roleandmodule_Load(object sender, EventArgs e)
        {

        }

        private void r_roleandmodule_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        private void gc_roleandmodule_btn_check_Click(object sender, EventArgs e)
        {
            // 获取当前行
            int rowIndex = r_roleandmodule.FocusedRowHandle;

            // 获取当前行的 select 列的值
            bool currentValue = (bool)r_roleandmodule.GetRowCellValue(rowIndex, "select");

            // 更改 select 列的值
            r_roleandmodule.SetRowCellValue(rowIndex, "select", !currentValue);

            // 刷新当前行
            r_roleandmodule.RefreshRow(rowIndex);
        }
    }
}
