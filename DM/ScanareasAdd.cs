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
    public partial class ScanareasAdd : Form
    {
        public ScanareasAdd()
        {
            InitializeComponent();
        }
        string id = null;
        public ScanareasAdd(bool EOA)
        {
            InitializeComponent();
            Edit = EOA;
        }
        bool Edit = false;

        DataRow listForm = null;
        public ScanareasAdd(bool EOA, DataRow list)
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
        private void AddToSqlite(string connectionString)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {

                string insertQuery = "INSERT INTO t_scanareas (areano, offsetx, offsety, offsetz, scanlen, indexlen, scanres, indexres,idt_products) VALUES (@areano, @offsetx, @offsety, @offsetz, @scanlen, @indexlen, @scanres, @indexres,@idt_products);";
                using (SQLiteCommand insertCommand = new SQLiteCommand(insertQuery, connection))
                {

                    insertCommand.Parameters.AddWithValue("@areano", textBoxAreano.Text);
                    insertCommand.Parameters.AddWithValue("@offsetx", textBoxOffsetx.Text);
                    insertCommand.Parameters.AddWithValue("@offsety", textBoxOffsety.Text);
                    insertCommand.Parameters.AddWithValue("@offsetz", textBoxOffsetz.Text);
                    insertCommand.Parameters.AddWithValue("@scanlen", textBoxScanlen.Text);
                    insertCommand.Parameters.AddWithValue("@indexlen", textBoxIndexlen.Text);
                    insertCommand.Parameters.AddWithValue("@scanres", textBoxScanres.Text);
                    insertCommand.Parameters.AddWithValue("@indexres", textBoxIndexres.Text);
                    int index1 = options1.IndexOf(comboBoxIdt_products.Text)+1;
                    insertCommand.Parameters.AddWithValue("@idt_products", index1);
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
                string updateQuery = "UPDATE t_scanareas SET areano = @areano, offsetx = @offsetx, offsety = @offsety, offsetz = @offsetz, scanlen = @scanlen, indexlen = @indexlen, scanres = @scanres, indexres = @indexres, idt_products= @idt_products WHERE ID = @id;";

                using (SQLiteCommand updateCommand = new SQLiteCommand(updateQuery, connection))
                {

                    updateCommand.Parameters.AddWithValue("@id", id);
                    updateCommand.Parameters.AddWithValue("@areano", textBoxAreano.Text);
                    updateCommand.Parameters.AddWithValue("@offsetx", textBoxOffsetx.Text);
                    updateCommand.Parameters.AddWithValue("@offsety", textBoxOffsety.Text);
                    updateCommand.Parameters.AddWithValue("@offsetz", textBoxOffsetz.Text);
                    updateCommand.Parameters.AddWithValue("@scanlen", textBoxScanlen.Text);
                    updateCommand.Parameters.AddWithValue("@indexlen", textBoxIndexlen.Text);
                    updateCommand.Parameters.AddWithValue("@scanres", textBoxScanres.Text);
                    updateCommand.Parameters.AddWithValue("@indexres", textBoxIndexres.Text);
                    int index1 = options1.IndexOf(comboBoxIdt_products.Text)+1;
                    updateCommand.Parameters.AddWithValue("@idt_products", index1);
                    connection.Open();

                    // 执行更新操作
                    updateCommand.ExecuteNonQuery();

                    connection.Close();
                }
            }
        }

        private void ScanareasAdd_Load(object sender, EventArgs e)
        {
            Form1.ScanareasRef = true;
            string query1 = "SELECT productname FROM t_products";
            options1 = SQLite.returnColData1(SQLite.connectionString, query1);
            comboBoxIdt_products.Items.AddRange(options1.ToArray());
            if (Edit)
            {
                textBoxAreano.Text = Convert.ToString(listForm["areano"]);
                textBoxOffsetx.Text = Convert.ToString(listForm["offsetx"]);
                textBoxOffsety.Text = Convert.ToString(listForm["offsety"]);
                textBoxOffsetz.Text = Convert.ToString(listForm["offsetz"]);
                textBoxScanlen.Text = Convert.ToString(listForm["scanlen"]);
                textBoxIndexlen.Text = Convert.ToString(listForm["indexlen"]);
                textBoxScanres.Text = Convert.ToString(listForm["scanres"]);
                textBoxIndexres.Text = Convert.ToString(listForm["indexres"]);
                comboBoxIdt_products.Text = Convert.ToString(listForm["productname"]);
            }
        }

        private void ScanareasAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.ScanareasRef = false;
        }
    }
}
