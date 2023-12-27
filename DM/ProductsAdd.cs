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
    public partial class ProductsAdd : Form
    {
        public ProductsAdd()
        {
            InitializeComponent();
        }
        string id = null;
        public ProductsAdd(bool EOA)
        {
            InitializeComponent();
            Edit = EOA;
        }
        bool Edit = false;

        DataRow listForm = null;
        public ProductsAdd(bool EOA, DataRow list)
        {
            InitializeComponent();
            Edit = EOA;
            listForm = list;
            id = Convert.ToString(list["id"]);
        }

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

                string insertQuery = "INSERT INTO t_products (productname, scanorder, notes) VALUES (@productname, @scanorder, @notes);";
                using (SQLiteCommand insertCommand = new SQLiteCommand(insertQuery, connection))
                {

                    insertCommand.Parameters.AddWithValue("@productname", textBoxProductname.Text);
                    insertCommand.Parameters.AddWithValue("@scanorder", textBoxScanorder.Text);
                    insertCommand.Parameters.AddWithValue("@notes", textBoxNotes.Text);

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
                string updateQuery = "UPDATE t_products SET productname = @productname, scanorder = @scanorder, notes = @notes WHERE ID = @id;";

                using (SQLiteCommand updateCommand = new SQLiteCommand(updateQuery, connection))
                {

                    updateCommand.Parameters.AddWithValue("@id", id);
                    updateCommand.Parameters.AddWithValue("@productname", textBoxProductname.Text);
                    updateCommand.Parameters.AddWithValue("@scanorder", textBoxScanorder.Text);
                    updateCommand.Parameters.AddWithValue("@notes", textBoxNotes.Text);


                    connection.Open();

                    // 执行更新操作
                    updateCommand.ExecuteNonQuery();

                    connection.Close();
                }
            }
        }

        private void ProductlinesAdd_Load(object sender, EventArgs e)
        {
            Form1.ProductsRef = true;
            if (Edit)
            {
                textBoxProductname.Text = Convert.ToString(listForm["productname"]);
                textBoxScanorder.Text = Convert.ToString(listForm["scanorder"]);
                textBoxNotes.Text = Convert.ToString(listForm["notes"]);

            }
        }

        private void ProductsAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.ProductsRef = false;
        }
    }
}
