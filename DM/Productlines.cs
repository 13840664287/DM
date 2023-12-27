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
    public partial class Productlines : Form
    {
        public Productlines()
        {
            InitializeComponent();
        }
        string tablename = "t_productlines";
        private void Productlines_Load(object sender, EventArgs e)
        {
            timer1.Start();
            gridControl1.DataSource = returnData(SQLite.connectionString);
            gridId.FieldName = "id";
            gridLinename.FieldName = "linename";
            gridLinekey.FieldName = "linekey";
            gridScanspeed.FieldName = "scanspeed";
            gridIndexspeed.FieldName = "indexspeed";
            gridAuxspeed.FieldName = "auxspeed";
            gridScanspeed_empty.FieldName = "scanspeed_empty";
            gridIndexspeed_empty.FieldName = "indexspeed_empty";
            gridAuxspeed_empty.FieldName = "auxspeed_empty";
            gridIdt_layouts.FieldName = "layoutname";
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
     
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ProductlinesAdd productlinesAdd = new ProductlinesAdd(false);
            productlinesAdd.ShowDialog();
        }

        private void repositoryItemButtonEdit_Click(object sender, EventArgs e)
        {
            if (gridView1 != null)
            {
                int handle = gridView1.FocusedRowHandle;
                DataRow list = gridView1.GetDataRow(handle);
                if (list != null)
                {
                    ProductlinesAdd productlinesAdd = new ProductlinesAdd(true, list);
                    productlinesAdd.ShowDialog();
                }

            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Form1.productlinesRef)
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
                using (SQLiteCommand command = new SQLiteCommand("SELECT t_productlines.*,t_layouts.layoutname FROM t_productlines JOIN t_layouts ON t_productlines.idt_layouts = t_layouts.id ", connection))

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

        private void Productlines_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
        }
    }
}
