using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace DAL
{
    public class SQLite
    {
        public static string connectionString = "Data Source=@D:\\m_sqlite.db;Version=3;";

        /// <summary>
        /// 创建表
        /// </summary>
        /// <param name="connectionString"></param>
        public static void CreateTable(string connectionString)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                //用户表
                using (SQLiteCommand command_users = new SQLiteCommand(
                @"CREATE TABLE IF NOT EXISTS t_users (
                id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, 
                username VARCHAR(50) NOT NULL,
                userpwd VARCHAR(100) NOT NULL,
                realname VARCHAR(50) NOT NULL,
                photo VARCHAR(100), 
                idt_role INTEGER NOT NULL,
                FOREIGN KEY (idt_role) REFERENCES t_roles(id))"
                , connection))
                {
                    command_users.ExecuteNonQuery();
                }

                //角色表
                using (SQLiteCommand command_roles = new SQLiteCommand(
                @"CREATE TABLE IF NOT EXISTS t_roles (
                id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                rolename VARCHAR(50) NOT NULL,
                notes VARCHAR(255))"
                , connection))
                {
                    command_roles.ExecuteNonQuery();
                }

                //功能表
                using (SQLiteCommand command_modules = new SQLiteCommand(
                @"CREATE TABLE IF NOT EXISTS t_modules (
                id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, 
                modulename VARCHAR(50) NOT NULL,
                modulekey VARCHAR(255))"
                , connection))
                {
                    command_modules.ExecuteNonQuery();
                }

                //角色-功能授权表
                using (SQLiteCommand command_roleandmodule = new SQLiteCommand(
                @"CREATE TABLE IF NOT EXISTS r_roleandmodule (
                id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, 
                idt_roles INTEGER NOT NULL,
                idt_modules INTEGER NOT NULL,
                FOREIGN KEY (idt_roles) REFERENCES t_roles(id),
                FOREIGN KEY (idt_modules) REFERENCES t_modules(id))"
                , connection))
                {
                    command_roleandmodule.ExecuteNonQuery();
                }

                //易损/点检配件表
                using (SQLiteCommand command_accessories = new SQLiteCommand(
                @"CREATE TABLE IF NOT EXISTS t_accessories (
                id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, 
                accname VARCHAR(50) NOT NULL,
                starttime TEXT NOT NULL,
                acctype INTEGER,
                updatetime TEXT,
                circletime INTEGER,
                circleunit INTEGER)"
                , connection))
                {
                    command_accessories.ExecuteNonQuery();
                }

                //I/O信息表
                using (SQLiteCommand command_ios = new SQLiteCommand(
                @"CREATE TABLE IF NOT EXISTS t_ios (
                id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, 
                ioname VARCHAR(50) NOT NULL,
                truetext VARCHAR(50) DEFAULT 'close',
                falsetext VARCHAR(50) DEFAULT 'open',
                iotype INTEGER,
                control INTEGER,
                addr1 VARCHAR(50),
                addr2 VARCHAR(50))"
                , connection))
                {
                    command_ios.ExecuteNonQuery();
                }

                //监控参数
                using (SQLiteCommand command_keyparameters = new SQLiteCommand(
                @"CREATE TABLE IF NOT EXISTS t_keyparameters (
                id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, 
                ioname VARCHAR(50) NOT NULL,
                upthreshv REAL,
                upenableflg INTEGER DEFAULT 1,
                upcolor INTEGER,
                dwnthreshv DEAL,
                dwnenableflg INTEGER,
                dwncolor INTEGER,
                datatype VARCHAR(50),
                startaddr VARCHAR(50))"
                , connection))
                {
                    command_keyparameters.ExecuteNonQuery();
                }

                //日志配置
                using (SQLiteCommand command_logconfigure = new SQLiteCommand(
                @"CREATE TABLE IF NOT EXISTS t_logconfigure (
                id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, 
                logname VARCHAR(50),
                logkey VARCHAR(50) NOT NULL,
                strtemplate INTEGER NOT NULL)"
                , connection))
                {
                    command_logconfigure.ExecuteNonQuery();
                }

                //产线
                using (SQLiteCommand command_productlines = new SQLiteCommand(
                @"CREATE TABLE IF NOT EXISTS t_productlines (
                id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, 
                linename VARCHAR(50),
                linekey VARCHAR(50) NOT NULL,
                scanspeed REAL,
                indexspeed REAL,
                auxspeed REAL,
                scanspeed_empty REAL,
                indexspeed_empty REAL,
                auxspeed_empty REAL,
                idt_layouts INTEGER,
                FOREIGN KEY (idt_layouts) REFERENCES t_layouts(id))"
                , connection))
                {
                    command_productlines.ExecuteNonQuery();
                }

                //工位布局
                using (SQLiteCommand command_layouts = new SQLiteCommand(
                @"CREATE TABLE IF NOT EXISTS t_layouts (
                id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, 
                layoutname VARCHAR(50),
                rows INTEGER NOT NULL,
                cols INTEGER NOT NULL)"
                , connection))
                {
                    command_layouts.ExecuteNonQuery();
                }

                //布局单元
                using (SQLiteCommand command_cells = new SQLiteCommand(
                @"CREATE TABLE IF NOT EXISTS t_cells (
                id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, 
                rowno INTEGER NOT NULL,
                colno INTEGER NOT NULL,
                safypointx REAL NOT NULL,
                zeropointx REAL NOT NULL,
                safypointy REAL NOT NULL,
                zeropointy REAL NOT NULL,
                safypointz REAL,
                zeropointz REAL,
                idt_layouts INTEGER NOT NULL,
                idt_products INTEGER NOT NULL,
                FOREIGN KEY (idt_layouts) REFERENCES t_layouts(id),
                FOREIGN KEY (idt_products) REFERENCES t_products(id))"
                , connection))
                {
                    command_cells.ExecuteNonQuery();
                }

                //产品信息
                using (SQLiteCommand command_products = new SQLiteCommand(
                @"CREATE TABLE IF NOT EXISTS t_products (
                id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, 
                productname VARCHAR(50) NOT NULL,
                scanorder VARCHAR(50),
                notes VARCHAR(200))"
                , connection))
                {
                    command_products.ExecuteNonQuery();
                }

                //扫查区域
                using (SQLiteCommand command_scanareas = new SQLiteCommand(
                @"CREATE TABLE IF NOT EXISTS t_scanareas (
                id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, 
                areano INTEGER NOT NULL,
                offsetx REAL,
                offsety REAL,
                offsetz REAL,
                scanlen REAL,
                indexlen REAL,
                scanres REAL,
                indexres REAL,
                idt_products INTEGER NOT NULL,
                FOREIGN KEY (idt_products) REFERENCES t_products(id))"
                , connection))
                {
                    command_scanareas.ExecuteNonQuery();
                }

                //系统参数
                using (SQLiteCommand command_globalpars = new SQLiteCommand(
                @"CREATE TABLE IF NOT EXISTS t_globalpars (
                id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, 
                parname VARCHAR(50),
                parvalue VARCHAR(50),
                dispname VARCHAR(50))"
                , connection))
                {
                    command_globalpars.ExecuteNonQuery();
                }

                connection.Close();
            }

        }
        /// <summary>
        /// 返回数据库主表和外键表的数据cells
        /// </summary>
        /// <param name="connectionString">数据库路径</param>
        /// <returns>数据库表</returns>
        public static DataTable returnDataCells(string connectionString)
        {
            DataTable dataTable = new DataTable();
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand("SELECT t_cells.*,t_layouts.layoutname,t_products.productname FROM t_cells JOIN t_layouts ON t_cells.idt_layouts = t_layouts.id JOIN t_products ON t_cells.idt_products = t_products.id", connection))

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



        /// <summary>
        /// 检索数据
        /// </summary>
        /// <param name="connectionString"></param>
        public static void RetrieveData(string connectionString, string tablename, string delete_id)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand("SELECT * FROM "+tablename, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // 获取每一行的数据
                            int id = reader.GetInt32(0);  // 0 是 id 列的索引
                            string rolename = reader.GetString(1);  // 1 是 rolename 列的索引
                            string notes = reader.GetString(2);  // 2 是 notes 列的索引

                            // 输出或处理获取到的数据
                            Console.WriteLine($"ID: {id}, rolename: {rolename}, notes: {rolename}");
                        }
                    }
                }

                connection.Close();
            }
        }

        /// <summary>
        /// 返回数据库表的数据
        /// </summary>
        /// <param name="connectionString">数据库路径</param>
        /// <returns>数据库表</returns>
        public static DataTable returnUsersData(string connectionString, string tablename)
        {
            DataTable dataTable = new DataTable();
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand("SELECT * FROM " + tablename, connection))
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
        public static List<int> returnColData(string connectionString,string query)
        {
            List<int> options = new List<int>();
            using (SQLiteConnection connection = new SQLiteConnection(SQLite.connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                       
                        // 逐行读取数据
                        while (reader.Read())
                        {
                            int columnValue = reader.GetInt32(0);  // 0 是列索引，或者可以使用 reader["columnName"] 的方式获取指定列的值
                            options.Add(columnValue);

                        }
                    }
                }
            }
            return options;
        }
        public static List<string> returnColData1(string connectionString, string query)
        {
            List<string> options = new List<string>();
            using (SQLiteConnection connection = new SQLiteConnection(SQLite.connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {

                        // 逐行读取数据
                        while (reader.Read())
                        {
                            string columnValue = reader.GetString(0);  // 0 是列索引，或者可以使用 reader["columnName"] 的方式获取指定列的值
                            options.Add(columnValue);

                        }
                    }
                }
            }
            return options;
        }
      
        /// <summary>
        /// 删除选定行的数据库数据
        /// </summary>
        /// <param name="connectionString">数据库路径</param>
        /// <param name="delete_id">数据库选定id</param>
        public static void deleteTableData(string connectionString, string tablename, string delete_id)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand(
                "DELETE FROM " + tablename + " WHERE ID = " + delete_id + ";", connection))
                {
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }

        }
        

        
    }
}
