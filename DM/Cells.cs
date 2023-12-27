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
using DAL;

namespace DM
{
    public partial class Cells : Form
    {
        public Cells()
        {
            InitializeComponent();
        }

        string tablename = "t_cells";


        private void Cells_Load(object sender, EventArgs e)
        {
            timer1.Start();
            gridControl1.DataSource = SQLite.returnDataCells(SQLite.connectionString);
            gridId.FieldName = "id";
            gridRowno.FieldName = "rowno";
            gridColno.FieldName = "colno";
            gridSafypointx.FieldName = "safypointx";
            gridZeropointx.FieldName = "zeropointx";
            gridSafypointy.FieldName = "safypointy";
            gridZeropointy.FieldName = "zeropointy";
            gridSafypointz.FieldName = "safypointz";
            gridZeropointz.FieldName = "zeropointz";
            gridIdt_layouts.FieldName = "layoutname";
            gridIdt_products.FieldName = "productname";

        }
        

        private void repositoryItemButtonEdit_Click(object sender, EventArgs e)
        {
           
            if (gridView1 != null)
            {
                int handle = gridView1.FocusedRowHandle;
                DataRow list = gridView1.GetDataRow(handle);
                if (list != null)
                {
                    CellsAdd cellsEdit = new CellsAdd(true, list);
                    cellsEdit.ShowDialog();
                }
            }

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
            gridControl1.DataSource = SQLite.returnDataCells(SQLite.connectionString);
            //gridView1.DeleteSelectedRows();
            gridView1.RefreshData();
            MessageBox.Show("删除成功！");
            
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            CellsAdd cellsAdd = new CellsAdd(false);
            cellsAdd.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Form1.cellsRef)
            {
                gridControl1.DataSource = SQLite.returnDataCells(SQLite.connectionString);
            }
  
        }

        private void Cells_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
        }
    }
}
