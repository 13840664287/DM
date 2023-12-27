using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DM
{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }
        string tablename = "t_products";
        private void Products_Load(object sender, EventArgs e)
        {
            timer1.Start();
            gridControl1.DataSource = SQLite.returnUsersData(SQLite.connectionString, tablename);
            gridId.FieldName = "id";
            gridProductname.FieldName = "productname";
            gridScanorder.FieldName = "scanorder";
            gridNotes.FieldName = "notes";
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
            gridControl1.DataSource = SQLite.returnUsersData(SQLite.connectionString, tablename);
            //gridView1.DeleteSelectedRows();
            gridView1.RefreshData();
            MessageBox.Show("删除成功！");
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ProductsAdd productsAdd = new ProductsAdd(false);
            productsAdd.ShowDialog();
        }

        private void repositoryItemButtonEdit_Click(object sender, EventArgs e)
        {
            if (gridView1 != null)
            {
                int handle = gridView1.FocusedRowHandle;
                DataRow list = gridView1.GetDataRow(handle);
                if (list != null)
                {
                    ProductsAdd ProductsEdit = new ProductsAdd(true, list);
                    ProductsEdit.ShowDialog();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Form1.ProductsRef)
            {
                gridControl1.DataSource = SQLite.returnUsersData(SQLite.connectionString, tablename);
            }
        }

        private void Products_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
        }
    }
}
