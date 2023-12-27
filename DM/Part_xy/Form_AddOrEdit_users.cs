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
    public partial class Form_AddOrEdit_users : Form
    {
        public Form_AddOrEdit_users()
        {
            InitializeComponent();
        }

        public Form_AddOrEdit_users(object id)
        {
            InitializeComponent();
            DataTable dataTable = new DataTable();
            using (SQLiteConnection connection = new SQLiteConnection(SQLite.connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand("SELECT * FROM t_users WHERE id = (SELECT @id FROM t_users)", connection))
                {
                    //填入占位参数
                    command.Parameters.AddWithValue("@id", id);
                    //SQLiteDataAdapter类可以将数据填充到DataTable里
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
                connection.Close();
            }
            textBox_users_username.DataBindings.Add("Text", dataTable, "username");
            textBox_users_userpwd.DataBindings.Add("Text", dataTable, "userpwd");
            textBox_users_realname.DataBindings.Add("Text", dataTable, "realname");
            comboBox_users_idt_role.DataBindings.Add("Text", dataTable, "idt_role");
        }

        private void Form_AddOrEdit_users_Load(object sender, EventArgs e)
        {
            // 计算居中的位置
            int x = (this.ClientSize.Width - panel1.Width) / 2;

            // 设置Panel的位置
            panel1.Location = new System.Drawing.Point(x, 30);
        }

        private void Form_AddOrEdit_users_Resize(object sender, EventArgs e)
        {
            // 计算居中的位置
            int x = (this.ClientSize.Width - panel1.Width) / 2;

            // 设置Panel的位置
            panel1.Location = new System.Drawing.Point(x, 30);
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "图片文件|*.png;*.jpg;*.jpeg;*.gif;*.bmp|所有文件|*.*";
            openFileDialog1.Title = "选择图片";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // 设置PictureBox的Image属性为选择的图片路径
                pictureBox_users_photo.ImageLocation = openFileDialog1.FileName;
            }
            
        }
    }
}
