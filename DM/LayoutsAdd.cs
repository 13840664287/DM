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
    public partial class LayoutsAdd : Form
    {
        public LayoutsAdd()
        {
            InitializeComponent();
        }
        string id = null;
        public LayoutsAdd(bool EOA)
        {
            InitializeComponent();
            Edit = EOA;
        }
        bool Edit = false;

        DataRow listForm = null;
        public LayoutsAdd(bool EOA, DataRow list)
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

                string insertQuery = "INSERT INTO t_layouts (layoutname, rows, cols) VALUES (@layoutname, @rows, @cols);";
                using (SQLiteCommand insertCommand = new SQLiteCommand(insertQuery, connection))
                {

                    insertCommand.Parameters.AddWithValue("@layoutname", textBoxLayoutname.Text);
                    insertCommand.Parameters.AddWithValue("@rows", textBoxRows.Text);
                    insertCommand.Parameters.AddWithValue("@cols", textBoxCols.Text);

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
                string updateQuery = "UPDATE t_layouts SET layoutname = @layoutname, rows = @rows, cols = @cols WHERE ID = @id;";

                using (SQLiteCommand updateCommand = new SQLiteCommand(updateQuery, connection))
                {

                    updateCommand.Parameters.AddWithValue("@id", id);
                    updateCommand.Parameters.AddWithValue("@layoutname", textBoxLayoutname.Text);
                    updateCommand.Parameters.AddWithValue("@rows", textBoxRows.Text);
                    updateCommand.Parameters.AddWithValue("@cols", textBoxCols.Text);


                    connection.Open();

                    // 执行更新操作
                    updateCommand.ExecuteNonQuery();

                    connection.Close();
                }
            }
        }

   
        private void LayoutsAdd_Load(object sender, EventArgs e)
        {
            Form1.layoutsRef = true;
            if (Edit)
            {
                textBoxLayoutname.Text = Convert.ToString(listForm["layoutname"]);
                textBoxRows.Text = Convert.ToString(listForm["rows"]);
                textBoxCols.Text = Convert.ToString(listForm["cols"]);

            }
        }

        private void LayoutsAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.layoutsRef = false;
        }
    }
}
