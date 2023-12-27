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

namespace DM
{
    public partial class Scanareas : Form
    {
        public Scanareas()
        {
            InitializeComponent();
        }
        string tablename = "t_scanareas";
        private void Scanareas_Load(object sender, EventArgs e)
        {
            timer1.Start();
            gridControl1.DataSource = returnData(SQLite.connectionString);
            gridId.FieldName = "id";
            gridAreano.FieldName = "areano";
            gridOffsetx.FieldName = "offsetx";
            gridOffsety.FieldName = "offsety";
            gridOffsetz.FieldName = "offsetz";
            gridScanlen.FieldName = "scanlen";
            gridIndexlen.FieldName = "indexlen";
            gridScanres.FieldName = "scanres";
            gridIndexres.FieldName = "indexres";
            gridIdt_products.FieldName = "productname";

        }

        private void repositoryItemButtonDelete_Click(object sender, EventArgs e)
        {
            if (gridView1 != null)
            {
                int handle = gridView1.FocusedRowHandle;
                DataRow list = gridView1.GetDataRow(handle);
                if (list != null)
                {
                    object id = list["id"];
                    SQLite.deleteTableData(SQLite.connectionString, tablename, Convert.ToString(id));
                }

            }
            gridControl1.DataSource = returnData(SQLite.connectionString);
            //gridView1.DeleteSelectedRows();
            gridView1.RefreshData();
            MessageBox.Show("删除成功！");
        }

        private void buttonAdd_Click_1(object sender, EventArgs e)
        {
            ScanareasAdd scanareasAdd = new ScanareasAdd(false);
            scanareasAdd.ShowDialog();
        }

        private void repositoryItemButtonEdit_Click(object sender, EventArgs e)
        {
            if (gridView1 != null)
            {
                int handle = gridView1.FocusedRowHandle;
                DataRow list = gridView1.GetDataRow(handle);
                if (list != null)
                {
                    ScanareasAdd ScanareasEdit = new ScanareasAdd(true, list);
                    ScanareasEdit.ShowDialog();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Form1.ScanareasRef)
            {
                gridControl1.DataSource = returnData(SQLite.connectionString);
            }
        }
        /// <summary>
        /// 返回数据库主表和外键表的数据
        /// </summary>
        /// <param name="connectionString">数据库路径</param>
        /// <returns>数据库表</returns>
        public static DataTable returnData(string connectionString)
        {
            DataTable dataTable = new DataTable();
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand("SELECT t_scanareas.*,t_products.productname FROM t_scanareas JOIN t_products ON t_scanareas.idt_products = t_products.id", connection))

                {
                    //SQLiteDataAdapter类可以将数据填充到DataTable里
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }

                connection.Close();
            }
            return dataTable;
        }

        private void Scanareas_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
        }
    }
}
