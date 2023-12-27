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
    public partial class ProductlinesAdd : Form
    {
        public ProductlinesAdd()
        {
            InitializeComponent();
        }
        bool Edit = false;
        string id = null;
        DataRow listForm = null;
        public ProductlinesAdd(bool EOA)
        {
            InitializeComponent();
            Edit = EOA;
        }
        public ProductlinesAdd(bool EOA, DataRow list)
        {
            InitializeComponent();
            Edit = EOA;
            listForm = list;
            id = Convert.ToString(list["id"]);
        }
        List<string> options1 = new List<string>();
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
        private void AddToSqlite(string  connectionString)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {

                string insertQuery = "INSERT INTO t_productlines (linename, linekey, scanspeed, indexspeed, auxspeed, scanspeed_empty, indexspeed_empty, auxspeed_empty, idt_layouts) VALUES (@linename, @linekey, @scanspeed, @indexspeed, @auxspeed, @scanspeed_empty, @indexspeed_empty, @auxspeed_empty, @idt_layouts);";
                using (SQLiteCommand insertCommand = new SQLiteCommand(insertQuery, connection))
                {

                    insertCommand.Parameters.AddWithValue("@linename", textBoxLinename.Text);
                    insertCommand.Parameters.AddWithValue("@linekey", textBoxLinekey.Text);
                    insertCommand.Parameters.AddWithValue("@scanspeed", textBoxScanspeed.Text);
                    insertCommand.Parameters.AddWithValue("@indexspeed", textBoxIndexspeed.Text);
                    insertCommand.Parameters.AddWithValue("@auxspeed", textBoxAuxspeed.Text);
                    insertCommand.Parameters.AddWithValue("@scanspeed_empty", textBoxIndexspeed_empty.Text);
                    insertCommand.Parameters.AddWithValue("@indexspeed_empty", textBoxIndexspeed_empty.Text);
                    insertCommand.Parameters.AddWithValue("@auxspeed_empty", textBoxAuxspeed_empty.Text);
                    int index1 = options1.IndexOf(comboBoxIdt_layouts.Text)+1;
                    insertCommand.Parameters.AddWithValue("@idt_layouts", index1);

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
                string updateQuery = "UPDATE t_productlines SET linename = @linename, linekey = @linekey,scanspeed = @scanspeed, indexspeed = @indexspeed, auxspeed = @auxspeed, scanspeed_empty = @scanspeed_empty, indexspeed_empty = @indexspeed_empty, auxspeed_empty = @auxspeed_empty, idt_layouts = @idt_layouts WHERE ID = @id;";

                using (SQLiteCommand updateCommand = new SQLiteCommand(updateQuery, connection))
                {

                    updateCommand.Parameters.AddWithValue("@id", id);
                    updateCommand.Parameters.AddWithValue("@linename", textBoxLinename.Text);
                    updateCommand.Parameters.AddWithValue("@linekey", textBoxLinekey.Text);
                    updateCommand.Parameters.AddWithValue("@scanspeed", textBoxScanspeed.Text);
                    updateCommand.Parameters.AddWithValue("@indexspeed", textBoxIndexspeed.Text);
                    updateCommand.Parameters.AddWithValue("@auxspeed", textBoxAuxspeed.Text);
                    updateCommand.Parameters.AddWithValue("@scanspeed_empty", textBoxScanspeed_empty.Text);
                    updateCommand.Parameters.AddWithValue("@indexspeed_empty", textBoxIndexspeed_empty.Text);
                    updateCommand.Parameters.AddWithValue("@auxspeed_empty", textBoxAuxspeed_empty.Text);
                    int index1 = options1.IndexOf(comboBoxIdt_layouts.Text)+1;
                    updateCommand.Parameters.AddWithValue("@idt_layouts", index1);

                    connection.Open();

                    // 执行更新操作
                    updateCommand.ExecuteNonQuery();

                    connection.Close();
                }
            }
        }

        private void ProductlinesAdd_Load(object sender, EventArgs e)
        {
            Form1.productlinesRef=true;
            string query1 = "SELECT layoutname FROM t_layouts";
            options1 = SQLite.returnColData1(SQLite.connectionString, query1);
            comboBoxIdt_layouts.Items.AddRange(options1.ToArray());
            if (Edit)
            {
                textBoxLinename.Text= Convert.ToString(listForm["linename"]);
                textBoxLinekey.Text = Convert.ToString(listForm["linekey"]);
                textBoxScanspeed.Text = Convert.ToString(listForm["scanspeed"]);
                textBoxIndexspeed.Text = Convert.ToString(listForm["indexspeed"]);
                textBoxAuxspeed.Text = Convert.ToString(listForm["auxspeed"]);
                textBoxScanspeed_empty.Text = Convert.ToString(listForm["scanspeed_empty"]);
                textBoxIndexspeed_empty.Text = Convert.ToString(listForm["indexspeed_empty"]);
                textBoxAuxspeed_empty.Text = Convert.ToString(listForm["auxspeed_empty"]);
                comboBoxIdt_layouts.Text = Convert.ToString(listForm["layoutname"]);
            }
        }

        private void ProductlinesAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.productlinesRef = false;
        }
    }
}
