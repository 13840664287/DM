using DAL;
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
    public partial class CellsAdd : Form
    {
        public CellsAdd()
        {
            InitializeComponent();
        }
        string id = null;
        public CellsAdd(bool EOA)
        {
            InitializeComponent();
            Edit = EOA;
        }
        bool Edit = false;
        
        DataRow listForm = null;
        public CellsAdd(bool EOA, DataRow list)
        {
            InitializeComponent();
            Edit = EOA;
            listForm = list;
            id = Convert.ToString(list["id"]);
        }
        List<string> options1 = new List<string>();
        List<string> options2 = new List<string>();

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (Edit)
            {
                EditToSqlite(SQLite.connectionString, id);
                MessageBox.Show("编辑成功");
            }
            else
            {
                AddToSqlite(SQLite.connectionString);
                MessageBox.Show("增加成功");
            }
        }
        private void AddToSqlite(string connectionString)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {

                string insertQuery = "INSERT INTO t_cells (rowno, colno, safypointx, zeropointx, safypointy, zeropointy, safypointz, zeropointz, idt_layouts,idt_products) VALUES (@rowno, @colno, @safypointx, @zeropointx, @safypointy, @zeropointy, @safypointz, @zeropointz, @idt_layouts, @idt_products);";
                using (SQLiteCommand insertCommand = new SQLiteCommand(insertQuery, connection))
                {

                    insertCommand.Parameters.AddWithValue("@rowno", textBoxRowno.Text);
                    insertCommand.Parameters.AddWithValue("@colno", textBoxColno.Text);
                    insertCommand.Parameters.AddWithValue("@safypointx", textBoxSafypointx.Text);
                    insertCommand.Parameters.AddWithValue("@zeropointx", textBoxZeropointx.Text);
                    insertCommand.Parameters.AddWithValue("@safypointy", textBoxSafypointy.Text);
                    insertCommand.Parameters.AddWithValue("@zeropointy", textBoxZeropointy.Text);
                    insertCommand.Parameters.AddWithValue("@safypointz", textBoxSafypointz.Text);
                    insertCommand.Parameters.AddWithValue("@zeropointz", textBoxZeropointz.Text);
                    int index1 = options1.IndexOf(comboBoxIdt_layouts.Text)+1;
                    int index2 = options2.IndexOf(comboBoxIdt_products.Text)+1;
                    insertCommand.Parameters.AddWithValue("@idt_layouts", index1);
                    insertCommand.Parameters.AddWithValue("@idt_products", index2);
                    connection.Open();

                    // 执行插入操作
                    insertCommand.ExecuteNonQuery();

                    connection.Close();

                }

            }
        }
        private void EditToSqlite(string connectionString, string id)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                string updateQuery = "UPDATE t_cells SET rowno = @rowno, colno = @colno, safypointx = @safypointx, zeropointx = @zeropointx, safypointy = @safypointy, zeropointy = @zeropointy, safypointz = @safypointz, zeropointz = @zeropointz, idt_layouts = @idt_layouts, idt_products = @idt_products WHERE ID = @id;";

                using (SQLiteCommand updateCommand = new SQLiteCommand(updateQuery, connection))
                {

                    updateCommand.Parameters.AddWithValue("@id", id);
                    updateCommand.Parameters.AddWithValue("@rowno", textBoxRowno.Text);
                    updateCommand.Parameters.AddWithValue("@colno", textBoxColno.Text);
                    updateCommand.Parameters.AddWithValue("@safypointx", textBoxSafypointx.Text);
                    updateCommand.Parameters.AddWithValue("@zeropointx", textBoxZeropointx.Text);
                    updateCommand.Parameters.AddWithValue("@safypointy", textBoxSafypointy.Text);
                    updateCommand.Parameters.AddWithValue("@zeropointy", textBoxZeropointy.Text);
                    updateCommand.Parameters.AddWithValue("@safypointz", textBoxSafypointz.Text);
                    updateCommand.Parameters.AddWithValue("@zeropointz", textBoxZeropointz.Text);
                    int index1 = options1.IndexOf(comboBoxIdt_layouts.Text)+1;
                    int index2 = options2.IndexOf(comboBoxIdt_products.Text)+1;
                    updateCommand.Parameters.AddWithValue("@idt_layouts", index1); 
                    updateCommand.Parameters.AddWithValue("@idt_products", index2);

                    connection.Open();

                    // 执行更新操作
                    updateCommand.ExecuteNonQuery();

                    connection.Close();
                }
            }
        }

        private void ProductlinesAdd_Load(object sender, EventArgs e)
        {
            Form1.cellsRef = true;
            string query1 = "SELECT layoutname FROM t_layouts";
            string query2 = "SELECT productname FROM t_products";

            options1 = SQLite.returnColData1(SQLite.connectionString, query1);
            comboBoxIdt_layouts.Items.AddRange(options1.ToArray());

            options2 = SQLite.returnColData1(SQLite.connectionString, query2);
            comboBoxIdt_products.Items.AddRange(options2.ToArray());

            if (Edit)
            {
                textBoxRowno.Text = Convert.ToString(listForm["rowno"]);
                textBoxColno.Text = Convert.ToString(listForm["colno"]);
                textBoxSafypointx.Text = Convert.ToString(listForm["safypointx"]);
                textBoxZeropointx.Text = Convert.ToString(listForm["zeropointx"]);
                textBoxSafypointy.Text = Convert.ToString(listForm["safypointy"]);
                textBoxZeropointy.Text = Convert.ToString(listForm["zeropointy"]);
                textBoxSafypointz.Text = Convert.ToString(listForm["safypointz"]);
                textBoxZeropointz.Text = Convert.ToString(listForm["zeropointz"]);
                comboBoxIdt_layouts.Text = Convert.ToString(listForm["layoutname"]);
                comboBoxIdt_products.Text = Convert.ToString(listForm["productname"]);
            }
        }

        private void CellsAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.cellsRef = false;
        }
    }
}
