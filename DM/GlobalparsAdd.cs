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
    public partial class GlobalparsAdd : Form
    {
        public GlobalparsAdd()
        {
            InitializeComponent();
        }
        string id = null;
        public GlobalparsAdd(bool EOA)
        {
            InitializeComponent();
            Edit = EOA;
        }
        bool Edit = false;

        DataRow listForm = null;
        public GlobalparsAdd(bool EOA, DataRow list)
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

                string insertQuery = "INSERT INTO t_globalpars (parname, parvalue, dispname) VALUES (@parname, @parvalue, @dispname);";
                using (SQLiteCommand insertCommand = new SQLiteCommand(insertQuery, connection))
                {

                    insertCommand.Parameters.AddWithValue("@parname", textBoxParname.Text);
                    insertCommand.Parameters.AddWithValue("@parvalue", textBoxParvalue.Text);
                    insertCommand.Parameters.AddWithValue("@dispname", textBoxDispname.Text);
    
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
                string updateQuery = "UPDATE t_globalpars SET parname = @parname, parvalue = @parvalue, dispname = @dispname WHERE ID = @id;";

                using (SQLiteCommand updateCommand = new SQLiteCommand(updateQuery, connection))
                {

                    updateCommand.Parameters.AddWithValue("@id", id);
                    updateCommand.Parameters.AddWithValue("@parname", textBoxParname.Text);
                    updateCommand.Parameters.AddWithValue("@parvalue", textBoxParvalue.Text);
                    updateCommand.Parameters.AddWithValue("@dispname", textBoxDispname.Text);
                    

                    connection.Open();

                    // 执行更新操作
                    updateCommand.ExecuteNonQuery();

                    connection.Close();
                }
            }
        }

        private void ProductlinesAdd_Load(object sender, EventArgs e)
        {
            Form1.globalparsRef = true;
            if (Edit)
            {
                textBoxParname.Text = Convert.ToString(listForm["parname"]);
                textBoxParvalue.Text = Convert.ToString(listForm["parvalue"]);
                textBoxDispname.Text = Convert.ToString(listForm["dispname"]);
                
            }
        }

        private void GlobalparsAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.globalparsRef = false;
        }
    }
}
